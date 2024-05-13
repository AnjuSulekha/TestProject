<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffMaster
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lbl_staff = New System.Windows.Forms.Label()
        Me.Txt_Salary = New System.Windows.Forms.TextBox()
        Me.Txt_Mobile = New System.Windows.Forms.TextBox()
        Me.Txt_Email = New System.Windows.Forms.TextBox()
        Me.Txt_Addrs = New System.Windows.Forms.TextBox()
        Me.Txt_StaffName = New System.Windows.Forms.TextBox()
        Me.Lbl_Reg = New System.Windows.Forms.Label()
        Me.Lbl_Edit = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btn_Exit = New System.Windows.Forms.Button()
        Me.DT_DOB = New System.Windows.Forms.DateTimePicker()
        Me.DT_DOJ = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Btn_Reg = New System.Windows.Forms.Button()
        Me.Btn_Edit = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Slno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mobile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.X = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txt_Search = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_staff
        '
        Me.lbl_staff.AutoSize = True
        Me.lbl_staff.Location = New System.Drawing.Point(341, 9)
        Me.lbl_staff.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_staff.Name = "lbl_staff"
        Me.lbl_staff.Size = New System.Drawing.Size(39, 13)
        Me.lbl_staff.TabIndex = 77
        Me.lbl_staff.Text = "Label1"
        Me.lbl_staff.Visible = False
        '
        'Txt_Salary
        '
        Me.Txt_Salary.BackColor = System.Drawing.Color.White
        Me.Txt_Salary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Salary.Location = New System.Drawing.Point(113, 204)
        Me.Txt_Salary.Name = "Txt_Salary"
        Me.Txt_Salary.Size = New System.Drawing.Size(296, 20)
        Me.Txt_Salary.TabIndex = 4
        '
        'Txt_Mobile
        '
        Me.Txt_Mobile.BackColor = System.Drawing.Color.White
        Me.Txt_Mobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Mobile.Location = New System.Drawing.Point(113, 182)
        Me.Txt_Mobile.Name = "Txt_Mobile"
        Me.Txt_Mobile.Size = New System.Drawing.Size(296, 20)
        Me.Txt_Mobile.TabIndex = 3
        '
        'Txt_Email
        '
        Me.Txt_Email.BackColor = System.Drawing.Color.White
        Me.Txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Email.Location = New System.Drawing.Point(113, 160)
        Me.Txt_Email.Name = "Txt_Email"
        Me.Txt_Email.Size = New System.Drawing.Size(296, 20)
        Me.Txt_Email.TabIndex = 2
        '
        'Txt_Addrs
        '
        Me.Txt_Addrs.BackColor = System.Drawing.Color.White
        Me.Txt_Addrs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Addrs.Location = New System.Drawing.Point(113, 136)
        Me.Txt_Addrs.Name = "Txt_Addrs"
        Me.Txt_Addrs.Size = New System.Drawing.Size(296, 20)
        Me.Txt_Addrs.TabIndex = 1
        '
        'Txt_StaffName
        '
        Me.Txt_StaffName.BackColor = System.Drawing.Color.White
        Me.Txt_StaffName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_StaffName.Location = New System.Drawing.Point(113, 114)
        Me.Txt_StaffName.MaxLength = 100
        Me.Txt_StaffName.Name = "Txt_StaffName"
        Me.Txt_StaffName.Size = New System.Drawing.Size(296, 20)
        Me.Txt_StaffName.TabIndex = 0
        '
        'Lbl_Reg
        '
        Me.Lbl_Reg.AutoSize = True
        Me.Lbl_Reg.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Reg.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_Reg.Name = "Lbl_Reg"
        Me.Lbl_Reg.Size = New System.Drawing.Size(173, 24)
        Me.Lbl_Reg.TabIndex = 100
        Me.Lbl_Reg.Text = "Staff Registration"
        '
        'Lbl_Edit
        '
        Me.Lbl_Edit.AutoSize = True
        Me.Lbl_Edit.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Edit.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_Edit.Name = "Lbl_Edit"
        Me.Lbl_Edit.Size = New System.Drawing.Size(167, 24)
        Me.Lbl_Edit.TabIndex = 101
        Me.Lbl_Edit.Text = "Edit Staff Details"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(244, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(12, 13)
        Me.Label9.TabIndex = 97
        Me.Label9.Text = "/"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(243, 60)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 99
        Me.Button3.Text = "Update"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Red
        Me.Button4.Location = New System.Drawing.Point(184, 60)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 98
        Me.Button4.Text = "Delete"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.insert_picture_icon
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(140, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 43)
        Me.PictureBox1.TabIndex = 96
        Me.PictureBox1.TabStop = False
        '
        'Btn_Exit
        '
        Me.Btn_Exit.BackColor = System.Drawing.Color.White
        Me.Btn_Exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Exit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Exit.Location = New System.Drawing.Point(306, 265)
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.Size = New System.Drawing.Size(67, 34)
        Me.Btn_Exit.TabIndex = 11
        Me.Btn_Exit.Text = "Exit"
        Me.Btn_Exit.UseVisualStyleBackColor = False
        '
        'DT_DOB
        '
        Me.DT_DOB.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DT_DOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_DOB.Location = New System.Drawing.Point(302, 229)
        Me.DT_DOB.Name = "DT_DOB"
        Me.DT_DOB.Size = New System.Drawing.Size(107, 22)
        Me.DT_DOB.TabIndex = 6
        '
        'DT_DOJ
        '
        Me.DT_DOJ.CalendarTitleBackColor = System.Drawing.Color.Transparent
        Me.DT_DOJ.CalendarTrailingForeColor = System.Drawing.Color.Transparent
        Me.DT_DOJ.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DT_DOJ.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_DOJ.Location = New System.Drawing.Point(112, 230)
        Me.DT_DOJ.Name = "DT_DOJ"
        Me.DT_DOJ.Size = New System.Drawing.Size(100, 22)
        Me.DT_DOJ.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(219, 234)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 16)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "Date of birth"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 234)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "Date of join"
        '
        'Btn_Reg
        '
        Me.Btn_Reg.BackColor = System.Drawing.Color.White
        Me.Btn_Reg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Btn_Reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Reg.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Reg.Location = New System.Drawing.Point(14, 265)
        Me.Btn_Reg.Name = "Btn_Reg"
        Me.Btn_Reg.Size = New System.Drawing.Size(67, 34)
        Me.Btn_Reg.TabIndex = 7
        Me.Btn_Reg.Text = "Register"
        Me.Btn_Reg.UseVisualStyleBackColor = False
        '
        'Btn_Edit
        '
        Me.Btn_Edit.BackColor = System.Drawing.Color.White
        Me.Btn_Edit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Edit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Edit.Location = New System.Drawing.Point(160, 265)
        Me.Btn_Edit.Name = "Btn_Edit"
        Me.Btn_Edit.Size = New System.Drawing.Size(67, 34)
        Me.Btn_Edit.TabIndex = 9
        Me.Btn_Edit.Text = "Edit"
        Me.Btn_Edit.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 16)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "Salary"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 16)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "Mobile"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Name"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.White
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDelete.Location = New System.Drawing.Point(233, 265)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(67, 34)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Slno, Me.StaffName, Me.Mobile, Me.X, Me.ID})
        Me.DataGridView1.Location = New System.Drawing.Point(415, 33)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.Size = New System.Drawing.Size(451, 423)
        Me.DataGridView1.TabIndex = 103
        Me.DataGridView1.TabStop = False
        '
        'Slno
        '
        Me.Slno.HeaderText = "Slno"
        Me.Slno.Name = "Slno"
        Me.Slno.Width = 40
        '
        'StaffName
        '
        Me.StaffName.HeaderText = "Staff Name"
        Me.StaffName.Name = "StaffName"
        Me.StaffName.Width = 200
        '
        'Mobile
        '
        Me.Mobile.HeaderText = "Mobile"
        Me.Mobile.Name = "Mobile"
        Me.Mobile.Width = 150
        '
        'X
        '
        Me.X.HeaderText = "X"
        Me.X.Name = "X"
        Me.X.Width = 30
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Visible = False
        Me.ID.Width = 5
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'txt_Search
        '
        Me.txt_Search.BackColor = System.Drawing.Color.White
        Me.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Search.Location = New System.Drawing.Point(415, 12)
        Me.txt_Search.MaxLength = 100
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.Size = New System.Drawing.Size(393, 20)
        Me.txt_Search.TabIndex = 104
        Me.txt_Search.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(809, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 23)
        Me.Button1.TabIndex = 105
        Me.Button1.TabStop = False
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.White
        Me.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(87, 265)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(67, 34)
        Me.btnNew.TabIndex = 8
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'StaffMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(878, 465)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_Search)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lbl_staff)
        Me.Controls.Add(Me.Txt_Salary)
        Me.Controls.Add(Me.Txt_Mobile)
        Me.Controls.Add(Me.Txt_Email)
        Me.Controls.Add(Me.Txt_Addrs)
        Me.Controls.Add(Me.Txt_StaffName)
        Me.Controls.Add(Me.Lbl_Reg)
        Me.Controls.Add(Me.Lbl_Edit)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Btn_Exit)
        Me.Controls.Add(Me.DT_DOB)
        Me.Controls.Add(Me.DT_DOJ)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Btn_Reg)
        Me.Controls.Add(Me.Btn_Edit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnDelete)
        Me.Name = "StaffMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StaffMaster"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_staff As Label
    Friend WithEvents Txt_Salary As TextBox
    Friend WithEvents Txt_Mobile As TextBox
    Friend WithEvents Txt_Email As TextBox
    Friend WithEvents Txt_Addrs As TextBox
    Friend WithEvents Txt_StaffName As TextBox
    Friend WithEvents Lbl_Reg As Label
    Friend WithEvents Lbl_Edit As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btn_Exit As Button
    Friend WithEvents DT_DOB As DateTimePicker
    Friend WithEvents DT_DOJ As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Btn_Reg As Button
    Friend WithEvents Btn_Edit As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Slno As DataGridViewTextBoxColumn
    Friend WithEvents StaffName As DataGridViewTextBoxColumn
    Friend WithEvents Mobile As DataGridViewTextBoxColumn
    Friend WithEvents X As DataGridViewImageColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txt_Search As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnNew As Button
End Class
