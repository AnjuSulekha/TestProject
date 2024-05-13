'Imports Microsoft.Office.Interop.Excel
Imports System.Data.OleDb
Public Class Front_Form
    Dim DT As New DataTable
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim IsCreated(99) As Boolean
    Dim ButtonWidh As Integer
    Dim ButtonHeight As Integer
    Dim ButtonPadding As Integer
    Private Sub Front_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Fetch data from the Access database and populate the DataTable
            con.ConnectionString = ConString
            'FetchDataFromDatabase()

            ButtonWidh = 150
            ButtonHeight = 100
            ButtonPadding = 5
            FunlistChairs()
            DataGridAdd("")

        Catch ex As Exception
            MessageBox.Show("An error occurred while loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
    Private Sub FetchDataFromDatabase()
        Try

            cmd = con.CreateCommand
            If con.State = ConnectionState.Closed Then con.Open()

            cmd.CommandText = "SELECT ChairName, ChairType, StaffName FROM  Chair"


            Using reader As OleDbDataReader = cmd.ExecuteReader()
                ' Check if the reader has rows
                If reader.HasRows Then
                    ' If DataTable columns are not yet added, add them dynamically based on the query
                    If DT.Columns.Count = 0 Then
                        For i As Integer = 0 To reader.FieldCount - 1
                            DT.Columns.Add(reader.GetName(i))
                        Next
                    End If

                    ' Loop through each row in the result set
                    While reader.Read()
                        ' Add a new row to the DataTable and populate it with data from the database
                        Dim newRow As DataRow = DT.NewRow()
                        For i As Integer = 0 To reader.FieldCount - 1
                            newRow(i) = reader(i)
                        Next
                        DT.Rows.Add(newRow)
                    End While
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            con.Close()
        End Try
    End Sub
    Public Sub FunlistChairs()
        DT.Rows.Clear()
        DT.Columns.Clear()
        For Each ctrl As Control In Panel_Chairs.Controls
            If TypeOf ctrl Is Button Then
                ctrl.Dispose()
            End If
        Next
        If con.State = ConnectionState.Closed Then con.Open()
        cmd = con.CreateCommand
        cmd.CommandText = "Select ChairName, ChairType,iD from Chair"
        dr = cmd.ExecuteReader
        DT.Rows.Clear()
        DT.Columns.Clear()
        DT.Load(dr)
        dr.Close()
        Dim maxIndex As Integer = 0
        For Each ctrl As Control In Panel_Chairs.Controls
            If TypeOf ctrl Is Button Then
                Dim index As Integer
                If Integer.TryParse(ctrl.Name.Replace("Button", ""), index) Then
                    If index > maxIndex Then
                        maxIndex = index
                    End If
                End If
            End If
        Next
        For i As Integer = 0 To DT.Rows.Count - 1
            Dim TakeStatus As Integer
            Dim TakeStaffName As String
            TakeStaffName = ""
            TakeStatus = 0
            cmd.CommandText = "Select Top 1 a.Status,a.StaffID,b.StaffName from ChairStatus a left join StaffMaster b on a.StaffID=b.StaffID where a.ChairID=" & Val(DT.Rows(i).Item("ID")) & " Order by(a.UID) Desc"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                TakeStatus = Val(dr("Status").ToString)
                If IsDBNull(dr("StaffName")) = False Then
                    TakeStaffName = dr("StaffName").ToString
                End If
            End If
            dr.Close()
            Dim B As New Button
            Dim L As New Label
            Dim L1 As New Label
            Panel_Chairs.Controls.Add(B)
            Panel_Chairs.Controls.Add(L)
            Panel_Chairs.Controls.Add(L1)
            B.Height = ButtonHeight
            B.Width = ButtonWidh
            B.Left = (i Mod 4) * (ButtonWidh + ButtonPadding)
            B.Top = (i \ 4) * (ButtonHeight + ButtonPadding)
            B.Text = DT.Rows(i).Item("ChairName").ToString
            If TakeStatus = 0 Then
                B.BackColor = Color.Gray
            ElseIf TakeStatus = 1 Then
                B.BackColor = Color.LightGreen
            End If
            L.Width = B.Width
            L.Height = 15
            L.Left = B.Left + 5
            L.Top = B.Top + 5
            L.Text = ""
            L.Font = New Font("Arial", 8, FontStyle.Bold)
            L.AutoSize = True
            L.TextAlign = ContentAlignment.MiddleCenter
            L.BackColor = Color.Blue
            L.ForeColor = Color.White
            L.BringToFront()
            L1.AutoSize = True ' 120
            L1.Height = 15
            L1.Left = B.Left
            L1.Top = (B.Top + (B.Height - L1.Height)) - 5
            L1.Text = TakeStaffName
            L1.Font = New Font("Arial", 8, FontStyle.Bold)
            L1.AutoSize = True
            L1.TextAlign = ContentAlignment.MiddleCenter
            L1.BackColor = Color.Red
            L1.ForeColor = Color.White
            L1.BringToFront()
            Dim chairImage As Image = My.Resources.NewChair ' Replace "ChairImage" with the name of your image resource
            B.Image = chairImage
            B.ImageAlign = ContentAlignment.TopCenter
            B.TextImageRelation = TextImageRelation.ImageAboveText
            If TakeStatus = 1 Then
                B.BackColor = Color.GreenYellow
                B.Font = New Font("Arial", 9, FontStyle.Italic)
                L.Text = "Active"
            ElseIf TakeStatus = 2 Then
                B.BackColor = Color.Orange
                L.Text = "Working"
            Else
                L.Text = ""
            End If
            AddHandler B.Click, AddressOf Button_Click
            ' Add button to the panel
            Panel_Chairs.Controls.Add(B)

            ' Increment maxIndex
            maxIndex += 1
        Next
    End Sub
    Private Sub Button_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Try

            Dim B As Button = sender
            IsCreated(B.Tag) = True
            ' B.BackColor = Color.Red
            Dim TakeEntryNo As String
            TakeEntryNo = Val(B.Text)
            If B.BackColor = Color.Gray Then
                lbl_Chair.Text = B.Text
                Panel_Assign.Visible = True
                Me.cmb_Staff.Items.Clear()
                If con.State = ConnectionState.Closed Then con.Open()
                cmd.CommandText = "Select StaffName from StaffMaster where StaffID Not in (Select StaffID from ChairStatus where EntryDate=#" & Format(Today, "MM-dd-yyyy") & "#)"
                dr = cmd.ExecuteReader
                While dr.Read
                    Me.cmb_Staff.Items.Add(dr("StaffName").ToString)
                End While
                dr.Close()
                Me.cmb_Staff.Focus()
            ElseIf B.BackColor = Color.GreenYellow Then
                btnStartWork.Enabled = True
                btnEndWork.Enabled = False

                lbl_Chair.Text = B.Text
                Panel_Assign.Visible = False
                Panel_StartWork.Visible = True
                Dim TakeChairID As Integer
                If con.State = ConnectionState.Closed Then con.Open()
                cmd.CommandText = "Select ID from Chair where ChairName='" & UCase(Trim(Me.lbl_Chair.Text)) & "'"
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows = True Then
                    TakeChairID = Val(dr("ID").ToString)
                End If
                dr.Close()
                Dim TakeStaffName As String
                TakeStaffName = ""
                cmd.CommandText = "Select Top 1 a.Status,a.StaffID,b.StaffName from ChairStatus a left join StaffMaster b on a.StaffID=b.StaffID where a.ChairID=" & TakeChairID & " Order by(a.UID) Desc"
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows = True Then
                    If IsDBNull(dr("StaffName")) = False Then
                        TakeStaffName = dr("StaffName").ToString
                    End If
                End If
                dr.Close()
                lbl_StaffName.Text = TakeStaffName
                btnStartWork.Focus()
            ElseIf B.BackColor = Color.Orange Then
                btnStartWork.Enabled = False
                btnEndWork.Enabled = True
                lbl_Chair.Text = B.Text
                Panel_Assign.Visible = False
                Panel_StartWork.Visible = True
                Dim TakeChairID As Integer
                If con.State = ConnectionState.Closed Then con.Open()
                cmd.CommandText = "Select ID from Chair where ChairName='" & UCase(Trim(Me.lbl_Chair.Text)) & "'"
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows = True Then
                    TakeChairID = Val(dr("ID").ToString)
                End If
                dr.Close()
                Dim TakeStaffName As String
                TakeStaffName = ""
                cmd.CommandText = "Select Top 1 a.Status,a.StaffID,b.StaffName,a.EntryTime from ChairStatus a left join StaffMaster b on a.StaffID=b.StaffID where a.ChairID=" & TakeChairID & " Order by(a.UID) Desc"
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows = True Then
                    If IsDBNull(dr("StaffName")) = False Then
                        TakeStaffName = dr("StaffName").ToString
                        Me.Dt_STime.Value = dr("EntryTime")
                    End If
                End If
                dr.Close()
                lbl_StaffName.Text = TakeStaffName
                btnEndWork.Focus()
            End If
endpart:
        Catch ex As Exception
        Finally
            con.Close()
        End Try

    End Sub
    Public Sub RefreshChair()
        DT.Clear()
        ' Fetch data from the Access database and populate the DataTable
        FetchDataFromDatabase()

        ButtonWidh = 100
        ButtonHeight = 60
        ButtonPadding = 5
        'FunlistChairs()
    End Sub
    Private Sub Front_Form_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim maxPanelWidth As Integer = (Me.ClientSize.Width - 20 * 4) / 4 ' Initial calculation for non-maximized state

        ' Check if the window is maximized
        If Me.WindowState = FormWindowState.Maximized Then
            ' Calculate new maxPanelWidth for maximized state
            maxPanelWidth = (Me.ClientSize.Width - 20 * 4) / 4 ' Adjust as needed for margins or spacing
        End If
        ' Set the size for each panel
        ' Assuming the height of all panels is 100
        Panel17.Width = Me.Width
        Dim panelHeight As Integer = 100
        Panel_Total.Size = New Size(maxPanelWidth, panelHeight)
        Panel_Expense.Size = New Size(maxPanelWidth, panelHeight)
        Panel_Cash.Size = New Size(maxPanelWidth, panelHeight)
        Panel_Card.Size = New Size(maxPanelWidth, panelHeight)
        ' Set the location for each panel
        Dim panelSpacing As Integer = 5 ' Adjust as needed
        Panel_Total.Location = New Point((maxPanelWidth + panelSpacing) * 0, Panel_Total.Location.Y)
        Panel_Expense.Location = New Point((maxPanelWidth + panelSpacing) * 1, Panel_Expense.Location.Y)
        Panel_Cash.Location = New Point((maxPanelWidth + panelSpacing) * 2, Panel_Cash.Location.Y)
        Panel_Card.Location = New Point((maxPanelWidth + panelSpacing) * 3, Panel_Card.Location.Y)
        DataGridView1.Left = Me.Width - (DataGridView1.Width + 20)
        Panel_Chairs.Left = Panel17.Left
        Panel_Chairs.Top = Panel17.Top + Panel17.Height + 30
        Panel_Chairs.Height = Me.Height - (Panel_Chairs.Top + 50)
    End Sub
    Private Sub DataGridAdd(SearchString As String)
        Try
            If con.State = ConnectionState.Closed Then con.Open()
            cmd = con.CreateCommand
            cmd.CommandText = "Select a.StaffName,(Select Sum(GrandTotal) from Bill_inf where StaffID=a.StaffID and EntryDate>=#" & Format(Today, "MM-dd-yyyy") & "#) as Amount from  StaffMaster a order by(a.StaffName)"
            Dim dr As OleDbDataReader = cmd.ExecuteReader
            Dim No As Integer = 0
            With DataGridView1
                .Rows.Clear()
                While dr.Read()
                    .Rows.Add()
                    .Rows(No).Cells("Slno").Value = No + 1
                    .Rows(No).Cells("Staff").Value = dr("StaffName").ToString
                    If IsDBNull(dr("Amount")) = False Then
                        .Rows(No).Cells("Amount").Value = Format(Val(dr("Amount").ToString), "0.00")
                    Else
                        .Rows(No).Cells("Amount").Value = "0.00"
                    End If
                    No = No + 1
                End While
            End With
            dr.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Panel_Assign.Visible = False
    End Sub

    Private Sub btnAssign_Click(sender As Object, e As EventArgs) Handles btnAssign.Click
        Try
            If con.State = ConnectionState.Closed Then con.Open()
            cmd = con.CreateCommand
            Dim TakeStaffID As Integer, TakeChairID As Integer
            TakeChairID = 0
            TakeStaffID = 0
            cmd.CommandText = "Select StaffID from StaffMaster where StaffName='" & UCase(Trim(Me.cmb_Staff.Text)) & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                TakeStaffID = Val(dr("StaffID").ToString)
            End If
            dr.Close()
            cmd.CommandText = "Select ID from Chair where ChairName='" & UCase(Trim(Me.lbl_Chair.Text)) & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                TakeChairID = Val(dr("ID").ToString)
            End If
            dr.Close()
            cmd.CommandText = "Insert into ChairStatus(EntryDate,EntryTime,ChairID,StaffID,Status,BillNo) values(#" & Format(Today, "MM-dd-yyyy") & "#,#" & Format(System.DateTime.Now, "hh:mm:ss tt") & "#," & TakeChairID & "," & TakeStaffID & ",1,0)"
            cmd.ExecuteNonQuery()
            Panel_Assign.Visible = False
            cmb_Staff.Text = ""
            Me.lbl_Chair.Text = ""
            FunlistChairs()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel_StartWork.Visible = False
    End Sub

    Private Sub btnStartWork_Click(sender As Object, e As EventArgs) Handles btnStartWork.Click
        Try
            If con.State = ConnectionState.Closed Then con.Open()
            cmd = con.CreateCommand
            Dim TakeStaffID As Integer, TakeChairID As Integer
            TakeChairID = 0
            TakeStaffID = 0
            cmd.CommandText = "Select StaffID from StaffMaster where StaffName='" & UCase(Trim(Me.lbl_StaffName.Text)) & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                TakeStaffID = Val(dr("StaffID").ToString)
            End If
            dr.Close()
            cmd.CommandText = "Select ID from Chair where ChairName='" & UCase(Trim(Me.lbl_Chair.Text)) & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                TakeChairID = Val(dr("ID").ToString)
            End If
            dr.Close()
            cmd.CommandText = "Insert into ChairStatus(EntryDate,EntryTime,ChairID,StaffID,Status,BillNo) values(#" & Format(Today, "MM-dd-yyyy") & "#,#" & Format(System.DateTime.Now, "hh:mm:ss tt") & "#," & TakeChairID & "," & TakeStaffID & ",2,0)"
            cmd.ExecuteNonQuery()
            Panel_StartWork.Visible = False
            FunlistChairs()
        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Panel_Chairs_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Chairs.Paint

    End Sub

    Private Sub btnEndWork_Click(sender As Object, e As EventArgs) Handles btnEndWork.Click
        Try
            Panel_StartWork.Visible = False
            Close_Workfrm.MdiParent = Home_frm
            Close_Workfrm.Show()
            Close_Workfrm.BringToFront()
            Close_Workfrm.DT_STime.Value = Dt_STime.Value
            Close_Workfrm.txt_StaffName.Text = lbl_StaffName.Text
            Close_Workfrm.txt_ChairName.Text = lbl_Chair.Text
        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        FunlistChairs()

    End Sub

    Private Sub Panel_StartWork_Paint(sender As Object, e As PaintEventArgs) Handles Panel_StartWork.Paint

    End Sub
End Class