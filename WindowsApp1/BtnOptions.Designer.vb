<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BtnOptions
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Start = New System.Windows.Forms.Button()
        Me.Btn_Stop = New System.Windows.Forms.Button()
        Me.Btn_Cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(107, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Choose"
        '
        'Btn_Start
        '
        Me.Btn_Start.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Btn_Start.FlatAppearance.BorderSize = 0
        Me.Btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Start.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Start.Location = New System.Drawing.Point(49, 45)
        Me.Btn_Start.Name = "Btn_Start"
        Me.Btn_Start.Size = New System.Drawing.Size(191, 53)
        Me.Btn_Start.TabIndex = 1
        Me.Btn_Start.Text = "Start a new work"
        Me.Btn_Start.UseVisualStyleBackColor = False
        '
        'Btn_Stop
        '
        Me.Btn_Stop.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Btn_Stop.FlatAppearance.BorderSize = 0
        Me.Btn_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Stop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Stop.Location = New System.Drawing.Point(49, 104)
        Me.Btn_Stop.Name = "Btn_Stop"
        Me.Btn_Stop.Size = New System.Drawing.Size(191, 53)
        Me.Btn_Stop.TabIndex = 2
        Me.Btn_Stop.Text = "Stop"
        Me.Btn_Stop.UseVisualStyleBackColor = False
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Btn_Cancel.FlatAppearance.BorderSize = 0
        Me.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancel.Location = New System.Drawing.Point(49, 163)
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.Size = New System.Drawing.Size(191, 53)
        Me.Btn_Cancel.TabIndex = 3
        Me.Btn_Cancel.Text = "Cancel"
        Me.Btn_Cancel.UseVisualStyleBackColor = False
        '
        'BtnOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 240)
        Me.Controls.Add(Me.Btn_Cancel)
        Me.Controls.Add(Me.Btn_Stop)
        Me.Controls.Add(Me.Btn_Start)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BtnOptions"
        Me.Text = "BtnOptions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Start As Button
    Friend WithEvents Btn_Stop As Button
    Friend WithEvents Btn_Cancel As Button
End Class
