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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Front_Panel = New System.Windows.Forms.Panel()
        Me.Panel_Chairs = New System.Windows.Forms.Panel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Panel_Card = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel_Expense = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel_Cash = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel_Total = New System.Windows.Forms.Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Front_Panel.SuspendLayout()
        Me.Panel_Chairs.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel17.SuspendLayout()
        Me.Panel_Card.SuspendLayout()
        Me.Panel_Expense.SuspendLayout()
        Me.Panel_Cash.SuspendLayout()
        Me.Panel_Total.SuspendLayout()
        Me.SuspendLayout()
        '
        'Front_Panel
        '
        Me.Front_Panel.Controls.Add(Me.Panel_Chairs)
        Me.Front_Panel.Controls.Add(Me.Label2)
        Me.Front_Panel.Controls.Add(Me.Label1)
        Me.Front_Panel.Controls.Add(Me.Panel17)
        Me.Front_Panel.Controls.Add(Me.Label23)
        Me.Front_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Front_Panel.Location = New System.Drawing.Point(0, 0)
        Me.Front_Panel.Name = "Front_Panel"
        Me.Front_Panel.Size = New System.Drawing.Size(800, 450)
        Me.Front_Panel.TabIndex = 11
        '
        'Panel_Chairs
        '
        Me.Panel_Chairs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Chairs.Controls.Add(Me.DataGridView2)
        Me.Panel_Chairs.Location = New System.Drawing.Point(23, 203)
        Me.Panel_Chairs.Name = "Panel_Chairs"
        Me.Panel_Chairs.Size = New System.Drawing.Size(721, 225)
        Me.Panel_Chairs.TabIndex = 12
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(227, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(227, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(227, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView2.ColumnHeadersHeight = 40
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.Location = New System.Drawing.Point(429, -1)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowTemplate.Height = 50
        Me.DataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(284, 197)
        Me.DataGridView2.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(443, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 25)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "STAFF"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(19, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "CHAIRS"
        '
        'Panel17
        '
        Me.Panel17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel17.BackColor = System.Drawing.Color.White
        Me.Panel17.Controls.Add(Me.Panel_Card)
        Me.Panel17.Controls.Add(Me.Panel_Expense)
        Me.Panel17.Controls.Add(Me.Panel_Cash)
        Me.Panel17.Controls.Add(Me.Panel_Total)
        Me.Panel17.Location = New System.Drawing.Point(17, 42)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(722, 128)
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
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.White
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(12, 9)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(121, 25)
        Me.Label23.TabIndex = 7
        Me.Label23.Text = "DASHBOARD"
        '
        'Front_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Front_Panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Front_Form"
        Me.Text = "Front_Form"
        Me.Front_Panel.ResumeLayout(False)
        Me.Front_Panel.PerformLayout()
        Me.Panel_Chairs.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel17.ResumeLayout(False)
        Me.Panel_Card.ResumeLayout(False)
        Me.Panel_Card.PerformLayout()
        Me.Panel_Expense.ResumeLayout(False)
        Me.Panel_Expense.PerformLayout()
        Me.Panel_Cash.ResumeLayout(False)
        Me.Panel_Cash.PerformLayout()
        Me.Panel_Total.ResumeLayout(False)
        Me.Panel_Total.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Front_Panel As Panel
    Friend WithEvents Label23 As Label
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Panel_Card As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents Panel_Expense As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents Panel_Cash As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents Panel_Total As Panel
    Friend WithEvents Label22 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel_Chairs As Panel
    Friend WithEvents DataGridView2 As DataGridView
End Class
