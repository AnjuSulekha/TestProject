Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices
Imports System.Data
Imports System.Data.OleDb

Public Class Login
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dt As New DataTable
    Dim dr As OleDbDataReader
    Dim da As New OleDbDataAdapter
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim gbrush As New LinearGradientBrush(Me.DisplayRectangle, Color.DarkBlue, Color.LightBlue, LinearGradientMode.BackwardDiagonal)
        Me.BackgroundImage = New Bitmap(Me.Width, Me.Height)
        Dim g As Graphics = Graphics.FromImage(Me.BackgroundImage)
        g.FillRectangle(gbrush, Me.DisplayRectangle)
        Dim pic As New Drawing2D.GraphicsPath
        pic.AddEllipse(1, 1, 100, 100)
        PictureBox1.Region = New Region(pic)
        SetPlaceholder(Txt_UserName, "Username")
        SetPlaceholder(Txt_Password, "Password")
        ' Set the placeholder text color
        Txt_UserName.ForeColor = Color.Gray
        Txt_Password.ForeColor = Color.Gray

        RoundPanel(Panel1, 32)
        'RoundPanel(Panel4, 32)
        SetRoundButton(Btn_Login)
        SetRoundButton(Button2)


        'Create And configure the shadow panel
        Dim shadowPanel As New Panel()
        shadowPanel.BackColor = Color.FromArgb(64, Color.White) ' Semi-transparent black color
        shadowPanel.Location = New Point(Panel1.Location.X + 0, Panel1.Location.Y + 0) ' Offset position
        shadowPanel.Size = Panel1.Size ' Same size as the original panel

        ' Add the shadow panel behind the original panel
        Me.Controls.Add(Panel1)
        Me.Controls.SetChildIndex(Panel1, 0)

        AddHandler Panel3.Paint, AddressOf Panel3_Paint
        AddHandler Panel4.Paint, AddressOf Panel4_Paint


    End Sub
    Private Sub Tabmovement(ByVal Keycode As Integer)
        If Keycode = 13 Then
            SendKeys.Send("{tab}")
        End If
    End Sub
    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)
        Dim pen As New Pen(Color.DarkGray) ' Set the color of the line
        e.Graphics.DrawLine(pen, New Point(10, Panel3.Height - 1), New Point(Panel3.Width, Panel3.Height - 1))
    End Sub
    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs)
        Dim pen As New Pen(Color.DarkGray) ' Set the color of the line
        e.Graphics.DrawLine(pen, New Point(10, Panel4.Height - 1), New Point(Panel4.Width, Panel4.Height - 1))
    End Sub


    Private Sub SetPlaceholder(textBox As TextBox, placeholderText As String)
        ' Set the placeholder text and color
        textBox.Text = placeholderText
        textBox.ForeColor = Color.Gray
    End Sub
    Private Sub SetRoundButton(button As Button)
        ' Set the button to be owner-drawn
        button.FlatStyle = FlatStyle.Flat
        button.FlatAppearance.BorderSize = 0

        ' Add event handlers
        AddHandler button.Paint, AddressOf RoundButton_Paint
    End Sub
    Private Sub RoundButton_Paint(sender As Object, e As PaintEventArgs)
        Dim button As Button = CType(sender, Button)
        Dim path As GraphicsPath = New GraphicsPath()
        Dim rectangle As Rectangle = button.ClientRectangle
        Dim cornerRadius As Integer = 20 ' Change this value to adjust the roundness of corners

        ' Create a rounded rectangle path
        path.StartFigure()
        path.AddArc(rectangle.X, rectangle.Y, cornerRadius * 2, cornerRadius * 2, 180, 90)
        path.AddLine(rectangle.X + cornerRadius, rectangle.Y, rectangle.Right - cornerRadius * 2, rectangle.Y)
        path.AddArc(rectangle.Right - cornerRadius * 2, rectangle.Y, cornerRadius * 2, cornerRadius * 2, 270, 90)
        path.AddLine(rectangle.Right, rectangle.Y + cornerRadius * 2, rectangle.Right, rectangle.Bottom - cornerRadius * 2)
        path.AddArc(rectangle.Right - cornerRadius * 2, rectangle.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90)
        path.AddLine(rectangle.Right - cornerRadius * 2, rectangle.Bottom, rectangle.X + cornerRadius * 2, rectangle.Bottom)
        path.AddArc(rectangle.X, rectangle.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90)
        path.CloseFigure()

        button.Region = New Region(path)
    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles Txt_UserName.GotFocus
        If Txt_UserName.Text = "Username" Then
            Txt_UserName.Text = ""
            Txt_UserName.ForeColor = Color.DarkGray
        End If

    End Sub

    Private Sub Txt_UserName_LostFocus(sender As Object, e As EventArgs) Handles Txt_UserName.LostFocus
        If Txt_UserName.Text = "" Then
            Txt_UserName.Text = "Username"
            Txt_UserName.ForeColor = Color.DarkGray
        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_GotFocus(sender As Object, e As EventArgs)

    End Sub



    Private Sub Txt_Password_LostFocus(sender As Object, e As EventArgs) Handles Txt_Password.LostFocus
        If Txt_Password.Text = "" Then
            Txt_Password.Text = "Password"
            Txt_Password.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub TextBox1_TextChanged_2(sender As Object, e As EventArgs) Handles Txt_Password.TextChanged

    End Sub

    Private Sub Txt_Password_GotFocus(sender As Object, e As EventArgs) Handles Txt_Password.GotFocus
        If Txt_Password.Text = "Password" Then
            Txt_Password.Text = ""
            Txt_Password.ForeColor = Color.DarkGray
        End If
    End Sub
    Private Sub RoundPanel(panel As Panel, cornerRadius As Integer)
        Dim path As New GraphicsPath()
        Dim bounds As Rectangle = panel.ClientRectangle
        bounds.Inflate(-1, -1) ' Adjust the size to avoid border cutting off

        ' Create a rounded rectangle path
        path.AddArc(bounds.X, bounds.Y, cornerRadius, cornerRadius, 180, 90)
        path.AddArc(bounds.X + bounds.Width - cornerRadius, bounds.Y, cornerRadius, cornerRadius, 270, 90)
        path.AddArc(bounds.X + bounds.Width - cornerRadius, bounds.Y + bounds.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90)
        path.AddArc(bounds.X, bounds.Y + bounds.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90)
        path.CloseFigure()

        ' Set the panel's region to the created path
        panel.Region = New Region(path)
    End Sub

    Private Sub Button1_Paint(sender As Object, e As PaintEventArgs) Handles Btn_Login.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel3_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub



    Private Sub Btn_Login_Click(sender As Object, e As EventArgs) Handles Btn_Login.Click
        Try
            con.ConnectionString = ConString
            con.Open()
            cmd = con.CreateCommand
            If Trim(Txt_UserName.Text) <> "" And Trim(Txt_Password.Text) <> "" Then
                If con.State = ConnectionState.Closed Then con.Open()
                cmd.CommandText = "Select UserType,Password from AdminUser where UserName='" & UCase(Trim(Me.Txt_UserName.Text)) & "'"
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows = True Then
                    If UCase(Trim(Me.Txt_Password.Text)) = UCase(Trim(dr("Password").ToString)) Then
                        TakeUType = dr("UserType").ToString
                        dr.Close()
                        TakeUserName = Txt_UserName.Text
                        ' MsgBox("login successful")
                        Me.Hide()
                        Form1.Visible = True
                    Else
                        dr.Close()
                        MsgBox("Invalid Password")
                        Txt_Password.Text = ""
                        Me.Txt_Password.Focus()
                        'MsgBox("invalid login")
                    End If
                Else
                    dr.Close()
                    MsgBox("Invalid User")
                    Me.Txt_UserName.Focus()
                End If
            Else
                If Trim(Me.Txt_UserName.Text) = "" Then
                    MsgBox("Enter UserName")
                    Me.Txt_UserName.Focus()
                    GoTo enarpart
                End If
                If Trim(Me.Txt_Password.Text) = "" Then
                    MsgBox("Enter Password")
                    Me.Txt_Password.Focus()
                    GoTo enarpart
                End If
            End If
        Catch ex As Exception
            ' Display error message box with exception details
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
enarpart:
    End Sub

    ' cmd.CommandText = "select UserType,Password FROM AdminUser where UserName='" & UCase(Trim(Txt_UserName.Text)) & "'"
    ' dr.Read()
    '                If dr.HasRows = True Then
    '                    If UCase(Trim(Me.Txt_Password.Text)) = UCase(Trim(dr("Pwd").ToString)) Then
    '                        TakeUType = dr("UserType").ToString
    '                        dr.Close()
    '                        TakeUserName = Txt_UserName.Text
    '                        Main_Form.Visible = False
    '                    Else
    '                        dr.Close()
    '                        MsgBox("Invalid Password")
    '                        Txt_Password.Text = ""
    '                        Me.Txt_Password.Focus()
    '                    End If
    '                Else
    '                    dr.Close()
    '                    MsgBox("Invalid User")
    '                    Me.Txt_UserName.Focus()
    '                End If
    '            Else
    '                If Trim(Me.Txt_UserName.Text) = "" Then
    '                    MsgBox("Select UserName")
    '                    Me.Txt_UserName.Focus()
    '                    GoTo enarpart
    '                End If
    '                If Trim(Me.Txt_Password.Text) = "" Then
    '                    MsgBox("Enter Password")
    '                    Me.Txt_Password.Focus()
    '                    GoTo enarpart
    '                End If






    Private Sub Login_Resize(sender As Object, e As EventArgs) Handles Me.Resize


    End Sub

    Private Sub Txt_UserName_TextChanged(sender As Object, e As EventArgs) Handles Txt_UserName.TextChanged

    End Sub

    Private Sub Txt_UserName_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_UserName.KeyDown
        Call Tabmovement(e.KeyCode)
    End Sub

    Private Sub Txt_Password_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Password.KeyDown
        Call Tabmovement(e.KeyCode)
    End Sub

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Txt_Password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Password.KeyPress
        Txt_Password.PasswordChar = "●"c
    End Sub
End Class