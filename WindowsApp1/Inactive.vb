Imports System.Data.OleDb

Public Class Inactive
    Dim DT As New DataTable
    Dim con As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim IsCreated(99) As Boolean
    Dim ButtonWidh As Integer
    Dim ButtonHeight As Integer
    Dim ButtonPadding As Integer
    Private Sub Inactive_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        Try
            'MakePictureBoxRound(PictureBox1)

            ' Clear any existing data from the DataTable
            DT.Clear()

            ' Fetch data from the Access database and populate the DataTable
            FetchDataFromDatabase()

            ButtonWidh = 100
            ButtonHeight = 60
            ButtonPadding = 15
            FunlistChairs()
            ' DataGridAdd("")
        Catch ex As Exception
            ' Handle any exceptions that may occur during the loading process
            MessageBox.Show("An error occurred while loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Perform any cleanup or finalization tasks if necessary
        End Try

    End Sub

    Private Sub FetchDataFromDatabase()
        Try
            con.ConnectionString = ConString
            cmd = con.CreateCommand
            If con.State = ConnectionState.Closed Then con.Open()

            cmd.CommandText = "SELECT ChairName, ChairType, StaffName, Status FROM  Chair where Status=0"


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
        Finally
            con.Close()
        End Try


    End Sub

    'Old code
    'Private Sub Chairs_working_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    'MakePictureBoxRound(PictureBox1)
    '    DT.Columns.Add("Name")
    '    DT.Columns.Add("Status")
    '    DT.Columns.Add("EmpName")
    '    DT.Rows.Add("Chair1", "0", "")
    '    DT.Rows.Add("Chair2", "1", "")
    '    DT.Rows.Add("Chair3", "0", "")
    '    DT.Rows.Add("Chair4", "3", "")
    '    DT.Rows.Add("Chair5", "0", "")
    '    DT.Rows.Add("Chair6", "0", "")
    '    DT.Rows.Add("Chair7", "0", "")
    '    DT.Rows.Add("Chair8", "0", "")
    '    DT.Rows.Add("Chair9", "2", "")
    '    ButtonWidh = 150
    '    ButtonHeight = 120
    '    ButtonPadding = 10
    '    FunlistChairs()
    'End Sub
    Private Sub FunlistChairs()
        Dim Ls As New List(Of Label)
        For i As Integer = 0 To DT.Rows.Count - 1
            Dim B As New Button
            Dim L As New Label
            Dim L1 As New Label
            Panel__Chair.Controls.Add(B)
            Panel__Chair.Controls.Add(L)
            Panel__Chair.Controls.Add(L1)
            B.Height = ButtonHeight
            B.Width = ButtonWidh
            B.Left = (i Mod 4) * (ButtonWidh + ButtonPadding)
            B.Top = (i \ 4) * (ButtonHeight + ButtonPadding)
            B.Text = DT.Rows(i).Item("ChairName").ToString
            ' B.Text = DT.Rows(i).Item("Status").ToString

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
            L1.Text = DT.Rows(i).Item("StaffName").ToString
            L1.Font = New Font("Arial", 8, FontStyle.Bold)
            L1.AutoSize = True
            L1.TextAlign = ContentAlignment.MiddleCenter
            L1.BackColor = Color.Red
            L1.ForeColor = Color.White
            L1.BringToFront()
            'Dim chairImage As Image = My.Resources.NewChair ' Replace "NewChair" with the name of your image resource
            'B.Image = chairImage
            'B.ImageAlign = ContentAlignment.MiddleCenter ' Set image alignment to center
            'B.TextImageRelation = TextImageRelation.ImageAboveText ' Display image above the text
            'B.BackColor = Color.Transparent ' Set the background color of the button as transparent
            'B.FlatStyle = FlatStyle.Flat ' Set flat style to prevent any default button borders
            'B.FlatAppearance.BorderSize = 0 ' Set the border size to 0 to remove any border

            If DT.Rows(i).Item("Status") = 1 Then
                B.BackColor = Color.Honeydew
                L.Text = "Active"
            ElseIf DT.Rows(i).Item("Status") = 2 Then
                B.BackColor = Color.Green
                L.Text = "Working"
            Else
                L.Text = "InActive"
                B.BackColor = Color.Gray
            End If
            ' Set tag property of the button to hold the index of the current row
            B.Tag = i
            ' Add label to the list
            Ls.Add(L)
            Dim path As New System.Drawing.Drawing2D.GraphicsPath()
            Dim cornerRadius As Integer = 5 ' Adjust the radius to control the roundness of the corners
            Dim rect As New Rectangle(0, 0, B.Width, B.Height)

            ' Top-left corner
            path.AddArc(rect.Left, rect.Top, cornerRadius * 2, cornerRadius * 2, 180, 90)
            ' Top-right corner
            path.AddArc(rect.Right - cornerRadius * 2, rect.Top, cornerRadius * 2, cornerRadius * 2, 270, 90)
            ' Bottom-right corner
            path.AddArc(rect.Right - cornerRadius * 2, rect.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90)
            ' Bottom-left corner
            path.AddArc(rect.Left, rect.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90)
            path.CloseFigure()

            B.Region = New Region(path)


            AddHandler B.Click, AddressOf Button_Click
        Next
    End Sub


    '' Constructor to accept reference to chri_staff form
    'Public Sub New(chairStaffForm As Chair_Staff)
    '    InitializeComponent()
    '    Me.chairStaffForm = Chair_Staff
    'End Sub
    Private Sub Button_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        'Dim B As Button = DirectCast(sender, Button)
        'Dim index As Integer = CInt(B.Tag)

        '' Retrieve the label associated with the clicked button from the list
        'Dim Ls As List(Of Label) = Panel__Chair.Controls.OfType(Of Label)().ToList()
        'Dim statusLabel As Label = Ls(index)
        'If DT.Rows(index).Item("Status").ToString() = "0" Then
        '    ' Check if the form is not already open
        '    If Not IsFormOpen(GetType(Chair_Staff)) Then
        '        ' Load another form
        '        Dim chairStaffForm As New Chair_Staff()
        '        chairStaffForm.TopLevel = False
        '        Panel__Chair.Controls.Add(chairStaffForm)
        '        Dim centerX As Integer = Panel__Chair.Width \ 2 - chairStaffForm.Width \ 2
        '        Dim centerY As Integer = Panel__Chair.Height \ 2 - chairStaffForm.Height \ 2
        '        chairStaffForm.Location = New Point(centerX, centerY)
        '        chairStaffForm.BringToFront()
        '        chairStaffForm.Show()
        '    End If
        'End If
    End Sub
    Private Function IsFormOpen(formType As Type) As Boolean
        For Each form As Form In Application.OpenForms
            If form.GetType() = formType Then
                Return True
            End If
        Next
        Return False
    End Function

End Class