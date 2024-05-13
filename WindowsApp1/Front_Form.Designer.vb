<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Front_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Front_Form))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel_Chairs = New System.Windows.Forms.Panel()
        Me.Panel_StartWork = New System.Windows.Forms.Panel()
        Me.Dt_STime = New System.Windows.Forms.DateTimePicker()
        Me.lbl_StaffName = New System.Windows.Forms.Label()
        Me.btnEndWork = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnStartWork = New System.Windows.Forms.Button()
        Me.Panel_Assign = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_Chair = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAssign = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_Staff = New System.Windows.Forms.ComboBox()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Panel_Card = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel_Expense = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel_Cash = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel_Total = New System.Windows.Forms.Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Slno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Staff = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_Chairs.SuspendLayout()
        Me.Panel_StartWork.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Assign.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel17.SuspendLayout()
        Me.Panel_Card.SuspendLayout()
        Me.Panel_Expense.SuspendLayout()
        Me.Panel_Cash.SuspendLayout()
        Me.Panel_Total.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Chairs
        '
        Me.Panel_Chairs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Chairs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel_Chairs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_Chairs.Controls.Add(Me.Panel_StartWork)
        Me.Panel_Chairs.Controls.Add(Me.Panel_Assign)
        Me.Panel_Chairs.Location = New System.Drawing.Point(17, 168)
        Me.Panel_Chairs.Name = "Panel_Chairs"
        Me.Panel_Chairs.Size = New System.Drawing.Size(670, 608)
        Me.Panel_Chairs.TabIndex = 12
        '
        'Panel_StartWork
        '
        Me.Panel_StartWork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel_StartWork.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_StartWork.Controls.Add(Me.Dt_STime)
        Me.Panel_StartWork.Controls.Add(Me.lbl_StaffName)
        Me.Panel_StartWork.Controls.Add(Me.btnEndWork)
        Me.Panel_StartWork.Controls.Add(Me.PictureBox2)
        Me.Panel_StartWork.Controls.Add(Me.Button1)
        Me.Panel_StartWork.Controls.Add(Me.btnStartWork)
        Me.Panel_StartWork.Location = New System.Drawing.Point(120, 153)
        Me.Panel_StartWork.Name = "Panel_StartWork"
        Me.Panel_StartWork.Size = New System.Drawing.Size(338, 227)
        Me.Panel_StartWork.TabIndex = 1
        Me.Panel_StartWork.Visible = False
        '
        'Dt_STime
        '
        Me.Dt_STime.Location = New System.Drawing.Point(12, 27)
        Me.Dt_STime.Name = "Dt_STime"
        Me.Dt_STime.Size = New System.Drawing.Size(115, 20)
        Me.Dt_STime.TabIndex = 8
        Me.Dt_STime.Visible = False
        '
        'lbl_StaffName
        '
        Me.lbl_StaffName.AutoSize = True
        Me.lbl_StaffName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_StaffName.Location = New System.Drawing.Point(133, 24)
        Me.lbl_StaffName.Name = "lbl_StaffName"
        Me.lbl_StaffName.Size = New System.Drawing.Size(82, 18)
        Me.lbl_StaffName.TabIndex = 7
        Me.lbl_StaffName.Text = "Staff Name"
        '
        'btnEndWork
        '
        Me.btnEndWork.Location = New System.Drawing.Point(56, 109)
        Me.btnEndWork.Name = "btnEndWork"
        Me.btnEndWork.Size = New System.Drawing.Size(231, 52)
        Me.btnEndWork.TabIndex = 6
        Me.btnEndWork.Text = "End Work"
        Me.btnEndWork.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(336, 21)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(56, 167)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(231, 52)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnStartWork
        '
        Me.btnStartWork.Location = New System.Drawing.Point(56, 51)
        Me.btnStartWork.Name = "btnStartWork"
        Me.btnStartWork.Size = New System.Drawing.Size(231, 52)
        Me.btnStartWork.TabIndex = 2
        Me.btnStartWork.Text = "Start Work"
        Me.btnStartWork.UseVisualStyleBackColor = True
        '
        'Panel_Assign
        '
        Me.Panel_Assign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel_Assign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_Assign.Controls.Add(Me.Label2)
        Me.Panel_Assign.Controls.Add(Me.PictureBox1)
        Me.Panel_Assign.Controls.Add(Me.lbl_Chair)
        Me.Panel_Assign.Controls.Add(Me.btnExit)
        Me.Panel_Assign.Controls.Add(Me.btnAssign)
        Me.Panel_Assign.Controls.Add(Me.Label1)
        Me.Panel_Assign.Controls.Add(Me.cmb_Staff)
        Me.Panel_Assign.Location = New System.Drawing.Point(121, 101)
        Me.Panel_Assign.Name = "Panel_Assign"
        Me.Panel_Assign.Size = New System.Drawing.Size(460, 169)
        Me.Panel_Assign.TabIndex = 0
        Me.Panel_Assign.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Chair"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(458, 21)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'lbl_Chair
        '
        Me.lbl_Chair.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_Chair.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Chair.Location = New System.Drawing.Point(107, 72)
        Me.lbl_Chair.Name = "lbl_Chair"
        Me.lbl_Chair.Size = New System.Drawing.Size(339, 25)
        Me.lbl_Chair.TabIndex = 4
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(371, 107)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 52)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnAssign
        '
        Me.btnAssign.Location = New System.Drawing.Point(290, 107)
        Me.btnAssign.Name = "btnAssign"
        Me.btnAssign.Size = New System.Drawing.Size(75, 52)
        Me.btnAssign.TabIndex = 2
        Me.btnAssign.Text = "Assign"
        Me.btnAssign.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Staff Name"
        '
        'cmb_Staff
        '
        Me.cmb_Staff.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Staff.FormattingEnabled = True
        Me.cmb_Staff.Location = New System.Drawing.Point(107, 40)
        Me.cmb_Staff.Name = "cmb_Staff"
        Me.cmb_Staff.Size = New System.Drawing.Size(339, 26)
        Me.cmb_Staff.TabIndex = 0
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.White
        Me.Panel17.Controls.Add(Me.Panel_Card)
        Me.Panel17.Controls.Add(Me.Panel_Expense)
        Me.Panel17.Controls.Add(Me.Panel_Cash)
        Me.Panel17.Controls.Add(Me.Panel_Total)
        Me.Panel17.Location = New System.Drawing.Point(17, 12)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(1018, 128)
        Me.Panel17.TabIndex = 8
        '
        'Panel_Card
        '
        Me.Panel_Card.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Panel_Card.Controls.Add(Me.Label19)
        Me.Panel_Card.ForeColor = System.Drawing.Color.White
        Me.Panel_Card.Location = New System.Drawing.Point(542, 14)
        Me.Panel_Card.Name = "Panel_Card"
        Me.Panel_Card.Size = New System.Drawing.Size(170, 100)
        Me.Panel_Card.TabIndex = 2
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Label19.Location = New System.Drawing.Point(21, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Label19.Size = New System.Drawing.Size(45, 20)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Card"
        '
        'Panel_Expense
        '
        Me.Panel_Expense.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Panel_Expense.Controls.Add(Me.Label20)
        Me.Panel_Expense.ForeColor = System.Drawing.Color.White
        Me.Panel_Expense.Location = New System.Drawing.Point(190, 14)
        Me.Panel_Expense.Name = "Panel_Expense"
        Me.Panel_Expense.Size = New System.Drawing.Size(170, 100)
        Me.Panel_Expense.TabIndex = 1
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Label20.Location = New System.Drawing.Point(36, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Label20.Size = New System.Drawing.Size(68, 20)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Expense"
        '
        'Panel_Cash
        '
        Me.Panel_Cash.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Panel_Cash.Controls.Add(Me.Label21)
        Me.Panel_Cash.ForeColor = System.Drawing.Color.White
        Me.Panel_Cash.Location = New System.Drawing.Point(366, 14)
        Me.Panel_Cash.Name = "Panel_Cash"
        Me.Panel_Cash.Size = New System.Drawing.Size(170, 100)
        Me.Panel_Cash.TabIndex = 1
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Label21.Location = New System.Drawing.Point(20, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Label21.Size = New System.Drawing.Size(45, 20)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "Cash"
        '
        'Panel_Total
        '
        Me.Panel_Total.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Panel_Total.Controls.Add(Me.Label22)
        Me.Panel_Total.ForeColor = System.Drawing.Color.White
        Me.Panel_Total.Location = New System.Drawing.Point(13, 14)
        Me.Panel_Total.Name = "Panel_Total"
        Me.Panel_Total.Size = New System.Drawing.Size(170, 100)
        Me.Panel_Total.TabIndex = 0
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(19, 16)
        Me.Label22.Name = "Label22"
        Me.Label22.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Label22.Size = New System.Drawing.Size(47, 20)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Total"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 40
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Slno, Me.Staff, Me.Amount})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(737, 168)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 40
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(439, 367)
        Me.DataGridView1.TabIndex = 13
        '
        'Slno
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Slno.DefaultCellStyle = DataGridViewCellStyle2
        Me.Slno.HeaderText = "Slno"
        Me.Slno.Name = "Slno"
        Me.Slno.Width = 50
        '
        'Staff
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Staff.DefaultCellStyle = DataGridViewCellStyle3
        Me.Staff.HeaderText = "Staff"
        Me.Staff.Name = "Staff"
        Me.Staff.Width = 250
        '
        'Amount
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Amount.DefaultCellStyle = DataGridViewCellStyle4
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(17, 142)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 14
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Front_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1151, 788)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel_Chairs)
        Me.Controls.Add(Me.Panel17)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Front_Form"
        Me.Text = "Front_Form"
        Me.Panel_Chairs.ResumeLayout(False)
        Me.Panel_StartWork.ResumeLayout(False)
        Me.Panel_StartWork.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Assign.ResumeLayout(False)
        Me.Panel_Assign.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel17.ResumeLayout(False)
        Me.Panel_Card.ResumeLayout(False)
        Me.Panel_Card.PerformLayout()
        Me.Panel_Expense.ResumeLayout(False)
        Me.Panel_Expense.PerformLayout()
        Me.Panel_Cash.ResumeLayout(False)
        Me.Panel_Cash.PerformLayout()
        Me.Panel_Total.ResumeLayout(False)
        Me.Panel_Total.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Panel_Card As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents Panel_Expense As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents Panel_Cash As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents Panel_Total As Panel
    Friend WithEvents Label22 As Label
    Friend WithEvents Panel_Chairs As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Slno As DataGridViewTextBoxColumn
    Friend WithEvents Staff As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents Panel_Assign As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnAssign As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_Staff As ComboBox
    Friend WithEvents lbl_Chair As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel_StartWork As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnStartWork As Button
    Friend WithEvents btnEndWork As Button
    Friend WithEvents lbl_StaffName As Label
    Friend WithEvents Dt_STime As DateTimePicker
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Timer1 As Timer
End Class
