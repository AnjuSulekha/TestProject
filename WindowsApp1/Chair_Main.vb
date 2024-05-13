'mports Microsoft.Office.Interop.Excel
Imports System.Data.OleDb
Imports System.Reflection.Emit
Public Class Chair_Main
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim DT As New DataTable
    Private Sub Chair_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = ConString
        cmd = con.CreateCommand
        DataGridAdd("")
    End Sub
    Private Sub DataGridAdd(SearchString As String)
        Try
            If con.State = ConnectionState.Closed Then con.Open()
            cmd.CommandText = "SELECT ID,ChairName,ChairType,StaffName FROM Chair"
            If Trim(SearchString) <> "" Then
                cmd.CommandText &= " WHERE ID LIKE '%" & SearchString & "%'"
            End If
            Dim dr As OleDbDataReader = cmd.ExecuteReader
            ' Create a DataTable
            Dim DT As New DataTable
            DT.Columns.Add("ID")
            DT.Columns.Add("ChairName")
            DT.Columns.Add("ChairType")
            DT.Columns.Add("StaffName")
            DT.Columns.Add("Edit", GetType(Image))
            While dr.Read()
                ' Add rows to the DataTable
                DT.Rows.Add(dr("ID"), dr("ChairName"), dr("ChairType"), dr("StaffName"))
            End While

            ', Tax, Details
            dr.Close()
            DataGridView1.DataSource = DT
            DataGridView1.Columns("ID").Visible = False
            DataGridView1.Columns("StaffName").Visible = False
            'DataGridView1.Dock = DockStyle.Fill
            '    DataGridView1.Anchor = AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Top
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub
    Private Sub DataGridView1_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridView1.CellPainting
        ' Check if the cell being painted is in the "Edit" column
        If e.ColumnIndex = DataGridView1.Columns("Edit").Index AndAlso e.RowIndex >= 0 Then
            ' Get the edit icon image
            Dim editIcon As Image = My.Resources.Edit ' Assuming "EditIcon" is the name of your icon resource

            ' Calculate the position to draw the icon
            Dim iconX As Integer = e.CellBounds.Left + 2 ' Adjust the X position as needed
            Dim iconY As Integer = e.CellBounds.Top + (e.CellBounds.Height - editIcon.Height) / 2 ' Center vertically

            ' Draw the cell's background
            e.PaintBackground(e.CellBounds, False)

            ' Draw the icon to the left of the cell
            e.Graphics.DrawImage(editIcon, iconX, iconY)

            ' Suppress default painting of the cell content
            e.Handled = True
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            If e.ColumnIndex = DataGridView1.Columns("Edit").Index Then
                ' Check if the clicked cell is in the "Edit" column
                ' e.RowIndex >= 0 ensures that the click is not on the header row

                ' Retrieve data from the clicked cell
                Dim ID = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
                ' This line seems problematic, see below for correction
                Dim Chairid As String = DataGridView1.Rows(e.RowIndex).Cells("ID").Value.ToString() ' Assuming "StaffIDColumn" is the name of the column containing the staff ID
                '        ' .StaffID = staffid
                Chair_Add.lbl_ChairID.Text = Chairid
                Chair_Add.MdiParent = Home_frm
                Chair_Add.Show()
                Chair_Add.BringToFront()
                Chair_Add.lbl_Update.Visible = True
                Chair_Add.Label11.Visible = False
                Chair_Add.Button7.Visible = False
                Chair_Add.Edit_btn.Visible = True
                Chair_Add.Button7.Visible = False
                Chair_Add.Button12.Visible = True
                Chair_Add.Exit_btn.Location = New Point(395, 270)
                Chair_Add.LoadChairData()

            End If
        End If
    End Sub
    Public Sub RefreshData()
        ' Clear the DataGridView
        DataGridView1.DataSource = Nothing

        ' Re-fetch the data from the database and update the DataGridView
        DataGridAdd("")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Btn_Reg_Click(sender As Object, e As EventArgs) Handles Btn_Reg.Click
        Try
            If String.IsNullOrWhiteSpace(Txt_ChairName.Text) Then
                MsgBox("Please enter Chair Name.")
                Txt_ChairName.Focus()
                Return ' Exit the event handler if Chair Name is empty
            End If
            If Trim(Btn_Reg.Text) = "Save" Then

                If con.State = ConnectionState.Closed Then con.Open()
                cmd.CommandText = "Select ChairName,ChairType Chair where ChairName='" & UCase(Trim(Me.Txt_ChairName.Text)) & "'"
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows = True Then
                    dr.Close()
                    MsgBox("Chair Already exists")
                    Me.Txt_ChairName.Focus()
                Else
                    dr.Close()
                    cmd.CommandText = "insert into Chair (ChairName,ChairType,Status) values ('" & Txt_ChairName.Text & "','" & Txt_ChairType.Text & "',0)"
                    cmd.ExecuteNonQuery()
                    ChairClear()
                    con.Close()
                    DataGridAdd("")
                End If
            ElseIf Trim(Btn_Reg.Text) = "Update" Then
                If con.State = ConnectionState.Closed Then con.Open()
                cmd.CommandText = "Select ChairName,ChairType Chair where ID=" & Val(Me.lbl_ID.Text) & ""
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows = True Then
                    dr.Close()
                    cmd.CommandText = "Update Chair Set ChairName='" & Txt_ChairName.Text & "',ChairType='" & Txt_ChairType.Text & "' where ID=" & Val(Me.lbl_ID.Text) & ""
                    cmd.ExecuteNonQuery()
                    ChairClear()
                    con.Close()
                    DataGridAdd("")
                Else
                    dr.Close()
                    MsgBox("Chair Not Found")
                End If
                dr.Close()
            End If
        Catch ex As Exception
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub
    Private Sub ChairClear()
        Me.Txt_ChairName.Text = ""
        Me.Txt_ChairType.Text = ""
        Btn_Reg.Text = "Save"
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ChairClear()
        DataGridAdd("")
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        With DataGridView1
            If Trim(.Rows(e.RowIndex).Cells(0).Value) <> "" Then
                Me.lbl_ID.Text = Val(.Rows(e.RowIndex).Cells("ID").Value)
                If con.State = ConnectionState.Closed Then con.Open()
                cmd.CommandText = "Select ChairName,ChairType from Chair where ID=" & Val(Me.lbl_ID.Text) & ""
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows = True Then
                    Me.Txt_ChairName.Text = dr("ChairName").ToString
                    Me.Txt_ChairType.Text = dr("ChairType").ToString
                    Btn_Reg.Text = "Update"
                End If
                dr.Close()
            End If
        End With
    End Sub
End Class