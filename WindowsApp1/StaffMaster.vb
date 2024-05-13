Imports System.Data.OleDb
Imports System.IO

Public Class StaffMaster
    Public Property StaffID As String
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim destinationFilePath As String
    Dim DT As New DataTable
    Private Sub StaffMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 894
        Me.Height = 504
        lbl_staff.Visible = False
        Timer1.Enabled = True
        Btn_Reg.Enabled = True
        Btn_Edit.Enabled = False
        btnDelete.Enabled = False
        con.ConnectionString = ConString
    End Sub
    Dim filePath As String
    Private Sub FunShowData(SearchString As String)
        Try
            If con.State = ConnectionState.Closed Then con.Open()
            cmd = con.CreateCommand
            cmd.CommandText = "SELECT Img,StaffName,Mobile,StaffID FROM StaffMaster"
            If Trim(SearchString) <> "" Then
                cmd.CommandText &= " WHERE StaffName LIKE '%" & SearchString & "%' and Mobile like '%" & SearchString & "%'"
            End If
            cmd.CommandText = cmd.CommandText & " Order By(StaffName)"
            Dim dr As OleDbDataReader = cmd.ExecuteReader
            With DataGridView1
                .Rows.Clear()
                Dim Sl As Integer
                Sl = 0
                While dr.Read
                    .Rows.Add()
                    .Rows(Sl).Cells("Slno").Value = Sl + 1
                    .Rows(Sl).Cells("StaffName").Value = dr("StaffName").ToString
                    .Rows(Sl).Cells("Mobile").Value = dr("Mobile").ToString
                    .Rows(Sl).Cells("ID").Value = dr("StaffID").ToString
                    Sl = Sl + 1
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
    Private Function ValidateEmailAddress(ByVal emailAddress As String) As Boolean
        ' Define a regular expression pattern for validating email addresses
        Dim pattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"

        ' Check if the email address matches the pattern
        Return System.Text.RegularExpressions.Regex.IsMatch(emailAddress, pattern)
    End Function
    Private Function ValidateMobileNumber(ByVal mobileNumber As String) As Boolean
        ' Define a regular expression pattern for validating mobile numbers
        Dim pattern As String = "^\d{10}$" ' This pattern validates a 10-digit number

        ' Check if the mobile number matches the pattern
        Return System.Text.RegularExpressions.Regex.IsMatch(mobileNumber, pattern)
    End Function
    Private Sub CLEAR()
        Txt_StaffName.Text = ""
        Txt_Addrs.Text = ""
        Txt_Email.Text = ""
        Txt_Mobile.Text = ""
        Txt_Salary.Text = ""
        DT_DOJ.Value = Date.Today
        DT_DOB.Value = Date.Today
        PictureBox1.Image = Nothing
        FunShowData("")
        Btn_Reg.Enabled = True
        Btn_Edit.Enabled = False
        btnDelete.Enabled = False

    End Sub
    Private Sub Tabmovement(ByVal Keycode As Integer)
        If Keycode = 13 Then
            SendKeys.Send("{tab}")
        End If
    End Sub
    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs)
        CLEAR()
        Me.Hide()
    End Sub
    Private previewPictureBox As PictureBox
    Dim open As New OpenFileDialog()
    Private Sub ClosePreview(sender As Object, e As EventArgs)
        ' Close the preview PictureBox
        previewPictureBox.Visible = False
    End Sub
    Public Sub LoadFormData()
        Try
            If lbl_staff.Text <> "" Then
                con.ConnectionString = ConString
                cmd = con.CreateCommand
                If con.State = ConnectionState.Closed Then con.Open()
                If lbl_staff.Text <> "" Then
                    cmd.CommandText = "select * from StaffMaster where StaffID=" & Val(Me.lbl_staff.Text) & ""
                    dr = cmd.ExecuteReader
                    dr.Read()
                    If dr.HasRows = True Then
                        Me.Txt_StaffName.Text = dr("StaffName").ToString()
                        Me.Txt_Addrs.Text = dr("Address").ToString()
                        Me.Txt_Email.Text = dr("Email").ToString()
                        Me.Txt_Mobile.Text = dr("Mobile").ToString()
                        Me.Txt_Salary.Text = dr("Salary").ToString()
                        Me.DT_DOJ.Value = dr("DOJ")
                        Me.DT_DOB.Value = dr("DOB")
                        Dim imagePath As String = dr("Img").ToString()
                        Btn_Reg.Enabled = False
                        Btn_Edit.Enabled = True
                        btnDelete.Enabled = True
                        If Not String.IsNullOrEmpty(imagePath) AndAlso File.Exists(imagePath) Then
                            ' Load image only if the file path is not empty and the file exists
                            Me.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                            Me.PictureBox1.Image = Image.FromFile(imagePath)
                        End If
                        dr.Close()

                    End If
                Else

                End If
            End If
        Catch ex As Exception
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub StaffMaster_RegionChanged(sender As Object, e As EventArgs) Handles Me.RegionChanged

    End Sub

    Private Sub Btn_Exit_Click_1(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        Me.Close()
    End Sub

    Private Sub Txt_StaffName_TextChanged(sender As Object, e As EventArgs) Handles Txt_StaffName.TextChanged

    End Sub

    Private Sub Txt_StaffName_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_StaffName.KeyDown
        Call Tabmovement(e.KeyValue)
    End Sub

    Private Sub Btn_Reg_Click_1(sender As Object, e As EventArgs) Handles Btn_Reg.Click
        Try
            Dim location As String = Path.Combine(Application.StartupPath, "Image")
            If Not Directory.Exists(location) Then
                Directory.CreateDirectory(location)
            End If

            If PictureBox1.Image Is Nothing Then
                MsgBox("Profile Image Required.")
                Return
            ElseIf String.IsNullOrWhiteSpace(Txt_StaffName.Text) Then
                MsgBox("Staff Name is a required field.")
                Txt_StaffName.Focus()
                Return
            ElseIf String.IsNullOrWhiteSpace(Txt_Mobile.Text) Then
                MsgBox("Mobile Number is a required field.")
                Txt_Mobile.Focus()
                Return
            ElseIf Not ValidateEmailAddress(Txt_Email.Text) Then
                MsgBox("Invalid Email Format.")
                Txt_Email.Focus()
                Return
            ElseIf Not ValidateMobileNumber(Txt_Mobile.Text) Then
                MsgBox("Invalid Mobile Number Format.")
                Txt_Mobile.Focus()
                Return

            End If
            con.ConnectionString = ConString
            'con.Open()'
            cmd = con.CreateCommand
            If con.State = ConnectionState.Closed Then con.Open()
            cmd.CommandText = "SELECT * FROM StaffMaster WHERE Mobile='" & Me.Txt_Mobile.Text & "'"
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                con.Close()
                MsgBox("Duplicate Data: Staff with the same mobile number already exist.")
            Else
                dr.Close()

                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                Dim fileName As String = ".jpg"
                filePath = Path.Combine(location, Txt_StaffName.Text & fileName)

                If PictureBox1.Image IsNot Nothing Then

                    PictureBox1.Image.Save(filePath)
                End If
                cmd.CommandText = "INSERT INTO StaffMaster (StaffName, Address, Email, Mobile, Salary, DOB, DOJ, Img) VALUES ('" & Me.Txt_StaffName.Text & "','" & Me.Txt_Addrs.Text & "','" & Me.Txt_Email.Text & "','" & Me.Txt_Mobile.Text & "'," & Val(Me.Txt_Salary.Text) & ",#" & Format(Me.DT_DOJ.Value, "dd-MM-yyyy") & "#,#" & Format(Me.DT_DOB.Value, "dd-MM-yyyy") & "#,'" & filePath & "')"
                cmd.ExecuteNonQuery()

                MsgBox("New Staff " + UCase(Me.Txt_StaffName.Text) + " Added")
                CLEAR()
                con.Close()
                Master_Form.RefreshStaffData()
            End If
        Catch ex As Exception
            MsgBox("Database error: " & ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub Txt_Addrs_TextChanged(sender As Object, e As EventArgs) Handles Txt_Addrs.TextChanged

    End Sub

    Private Sub Txt_Addrs_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Addrs.KeyDown
        Call Tabmovement(e.KeyValue)

    End Sub

    Private Sub Txt_Email_TextChanged(sender As Object, e As EventArgs) Handles Txt_Email.TextChanged

    End Sub

    Private Sub Txt_Email_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Email.KeyDown
        Call Tabmovement(e.KeyValue)

    End Sub

    Private Sub Txt_Mobile_TextChanged(sender As Object, e As EventArgs) Handles Txt_Mobile.TextChanged

    End Sub

    Private Sub Txt_Mobile_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Mobile.KeyDown
        Call Tabmovement(e.KeyValue)

    End Sub

    Private Sub Txt_Salary_TextChanged(sender As Object, e As EventArgs) Handles Txt_Salary.TextChanged

    End Sub

    Private Sub Txt_Salary_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Salary.KeyDown
        Call Tabmovement(e.KeyValue)

    End Sub

    Private Sub DT_DOJ_ValueChanged(sender As Object, e As EventArgs) Handles DT_DOJ.ValueChanged

    End Sub

    Private Sub DT_DOJ_KeyDown(sender As Object, e As KeyEventArgs) Handles DT_DOJ.KeyDown
        Call Tabmovement(e.KeyValue)

    End Sub

    Private Sub DT_DOB_ValueChanged(sender As Object, e As EventArgs) Handles DT_DOB.ValueChanged

    End Sub

    Private Sub DT_DOB_KeyDown(sender As Object, e As KeyEventArgs) Handles DT_DOB.KeyDown
        Call Tabmovement(e.KeyValue)
    End Sub

    Private Sub Btn_Edit_Click_1(sender As Object, e As EventArgs) Handles Btn_Edit.Click
        Try
            Dim result As DialogResult = MessageBox.Show("Do you want to Edit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            ' Check the user's response
            If result = DialogResult.Yes Then
                con.ConnectionString = ConString
                cmd = con.CreateCommand
                If con.State = ConnectionState.Closed Then con.Open()
                cmd.CommandText = "update StaffMaster set StaffName='" & Txt_StaffName.Text & "',Address	='" & Txt_Addrs.Text & "',Mobile	='" & Txt_Mobile.Text & "',Email='" & Txt_Email.Text & "',Salary='" & Txt_Salary.Text & "'  where StaffID	=" & lbl_staff.Text & ""
                cmd.ExecuteNonQuery()
                MsgBox("Staff details updated successfully")
                CLEAR()
                con.Close()
                Master_Form.RefreshStaffData()
                Me.Hide()
            End If
            'Panel9.Visible = True
            'Panel9.BringToFront()
            'Panel9.Show()
        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Sub


    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim location As String = Path.Combine(Application.StartupPath, "Image")
            ' Check if a new image is selected
            If open.ShowDialog() = DialogResult.OK Then
                Dim newImagePath As String = open.FileName

                ' Update the image path in the database
                con.ConnectionString = ConString
                cmd = con.CreateCommand
                If con.State = ConnectionState.Closed Then con.Open()
                cmd.CommandText = "UPDATE StaffMaster SET Img = @Img WHERE StaffID = @StaffID"
                cmd.Parameters.AddWithValue("@Img", newImagePath)
                cmd.Parameters.AddWithValue("@StaffID", lbl_staff.Text)
                cmd.ExecuteNonQuery()

                ' Change the image in the PictureBox
                Dim newImage As Image = Image.FromFile(newImagePath)
                PictureBox1.Image = newImage
                ' Update the image in the preview PictureBox
                If previewPictureBox IsNot Nothing Then
                    previewPictureBox.Image = newImage
                End If

                MsgBox("Image updated successfully")
                Master_Form.RefreshStaffData()
            End If
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ' Check if PictureBox1 contains an image
        If PictureBox1.Image IsNot Nothing Then
            ' Toggle visibility of the preview PictureBox
            If previewPictureBox Is Nothing Then
                ' Create the preview PictureBox if it doesn't exist
                previewPictureBox = New PictureBox()
                previewPictureBox.Size = New Size(200, 150)
                previewPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
                previewPictureBox.Location = New Point((Me.ClientSize.Width - previewPictureBox.Width) \ 2, (Me.ClientSize.Height - previewPictureBox.Height) \ 2)
                previewPictureBox.Image = PictureBox1.Image
                ' Add click event handler to close the preview
                AddHandler previewPictureBox.Click, AddressOf ClosePreview
                Me.Controls.Add(previewPictureBox) ' Add the preview PictureBox to the main form
                previewPictureBox.BringToFront() ' Ensure the preview PictureBox is in front of other controls
            End If
            ' Toggle visibility of the preview PictureBox
            previewPictureBox.Visible = Not previewPictureBox.Visible
        Else

            Dim p As PictureBox = TryCast(sender, PictureBox)
            If p IsNot Nothing Then
                open.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG"
                If open.ShowDialog() = DialogResult.OK Then
                    p.Image = Image.FromFile(open.FileName)
                    PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                End If
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            ' Check if PictureBox2 contains an image
            If PictureBox1.Image IsNot Nothing Then
                ' Ask the user if they want to delete the image
                Dim result As DialogResult = MessageBox.Show("Do you want to delete the image?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                ' If user confirms deletion
                If result = DialogResult.Yes Then
                    ' Proceed with image deletion
                    con.ConnectionString = ConString
                    cmd = con.CreateCommand

                    If con.State = ConnectionState.Closed Then con.Open()

                    cmd.CommandText = "UPDATE StaffMaster SET Img = NULL WHERE StaffID = @StaffID"
                    cmd.Parameters.AddWithValue("@StaffID", lbl_staff.Text)
                    cmd.ExecuteNonQuery()

                    MsgBox("Image deleted successfully")
                    PictureBox1.Image = Nothing
                End If
            Else
                MsgBox("There is no image to delete.", MessageBoxIcon.Information)
            End If
            Master_Form.RefreshStaffData()
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        FunShowData("")
    End Sub

    Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged
        FunShowData(Me.txt_Search.Text)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        With DataGridView1
            If Trim(.Rows(e.RowIndex).Cells(0).Value) <> "" Then
                Me.lbl_staff.Text = Val(.Rows(e.RowIndex).Cells("ID").Value)
                LoadFormData()
            End If
        End With
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim result As DialogResult = MessageBox.Show("Do you want to Delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            ' Check the user's response
            If result = DialogResult.Yes Then
                ' Establish connection
                con.ConnectionString = ConString
                cmd = con.CreateCommand
                If con.State = ConnectionState.Closed Then con.Open()
                cmd.CommandText = "DELETE FROM StaffMaster WHERE StaffID = @StaffID"
                cmd.Parameters.AddWithValue("@StaffID", lbl_staff.Text)
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MsgBox("Data deleted successfully")
                    CLEAR()
                Else
                    MsgBox("No data deleted. StaffID not found.")
                End If
            End If
            con.Close()
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        Finally
            ' Close connection
            con.Close()
        End Try
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        CLEAR()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.txt_Search.Text = ""
        FunShowData("")
    End Sub
End Class