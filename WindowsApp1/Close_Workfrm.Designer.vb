<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Close_Workfrm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Close_Workfrm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_ServiceCharge = New System.Windows.Forms.TextBox()
        Me.txt_TotalProduct = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_CustomerName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_Place = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_Mobile = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Slno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.X = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DT_STime = New System.Windows.Forms.DateTimePicker()
        Me.DT_ETime = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DT_Date = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_StaffName = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_ChairName = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_BillNo = New System.Windows.Forms.TextBox()
        Me.txt_Slno = New System.Windows.Forms.TextBox()
        Me.txt_Qty = New System.Windows.Forms.TextBox()
        Me.txt_Rate = New System.Windows.Forms.TextBox()
        Me.txt_Amount = New System.Windows.Forms.TextBox()
        Me.lbl_GrandTotal = New System.Windows.Forms.Label()
        Me.txt_Cash = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Card = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Tax = New System.Windows.Forms.TextBox()
        Me.txt_TaxPecent = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.cmb_ItemName = New System.Windows.Forms.ComboBox()
        Me.lbl_RowCount = New System.Windows.Forms.Label()
        Me.txt_Balance = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(343, 308)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Service Charge"
        '
        'txt_ServiceCharge
        '
        Me.txt_ServiceCharge.BackColor = System.Drawing.Color.White
        Me.txt_ServiceCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ServiceCharge.Location = New System.Drawing.Point(463, 305)
        Me.txt_ServiceCharge.Name = "txt_ServiceCharge"
        Me.txt_ServiceCharge.Size = New System.Drawing.Size(91, 20)
        Me.txt_ServiceCharge.TabIndex = 8
        Me.txt_ServiceCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_TotalProduct
        '
        Me.txt_TotalProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_TotalProduct.Location = New System.Drawing.Point(463, 282)
        Me.txt_TotalProduct.Name = "txt_TotalProduct"
        Me.txt_TotalProduct.Size = New System.Drawing.Size(91, 20)
        Me.txt_TotalProduct.TabIndex = 10
        Me.txt_TotalProduct.TabStop = False
        Me.txt_TotalProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(343, 284)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Product Charge"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(429, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "End Time "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(429, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Start Time "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(343, 334)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Tax Amount"
        '
        'txt_CustomerName
        '
        Me.txt_CustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_CustomerName.Location = New System.Drawing.Point(70, 286)
        Me.txt_CustomerName.Name = "txt_CustomerName"
        Me.txt_CustomerName.Size = New System.Drawing.Size(236, 20)
        Me.txt_CustomerName.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 289)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Name"
        '
        'txt_Place
        '
        Me.txt_Place.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Place.Location = New System.Drawing.Point(70, 309)
        Me.txt_Place.Name = "txt_Place"
        Me.txt_Place.Size = New System.Drawing.Size(236, 20)
        Me.txt_Place.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 309)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Place"
        '
        'txt_Mobile
        '
        Me.txt_Mobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Mobile.Location = New System.Drawing.Point(70, 333)
        Me.txt_Mobile.Name = "txt_Mobile"
        Me.txt_Mobile.Size = New System.Drawing.Size(236, 20)
        Me.txt_Mobile.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 333)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Number"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 457)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 28)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Save Bill"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Slno, Me.ItemName, Me.Qty, Me.Rate, Me.Amount, Me.X})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 83)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(598, 197)
        Me.DataGridView1.TabIndex = 30
        '
        'Slno
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Slno.DefaultCellStyle = DataGridViewCellStyle1
        Me.Slno.HeaderText = "Slno"
        Me.Slno.Name = "Slno"
        Me.Slno.Width = 40
        '
        'ItemName
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.ItemName.DefaultCellStyle = DataGridViewCellStyle2
        Me.ItemName.HeaderText = "ItemName"
        Me.ItemName.Name = "ItemName"
        Me.ItemName.Width = 300
        '
        'Qty
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Qty.DefaultCellStyle = DataGridViewCellStyle3
        Me.Qty.HeaderText = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.Width = 40
        '
        'Rate
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Rate.DefaultCellStyle = DataGridViewCellStyle4
        Me.Rate.HeaderText = "Rate"
        Me.Rate.Name = "Rate"
        Me.Rate.Width = 70
        '
        'Amount
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Amount.DefaultCellStyle = DataGridViewCellStyle5
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.Width = 90
        '
        'X
        '
        Me.X.HeaderText = "X"
        Me.X.Image = CType(resources.GetObject("X.Image"), System.Drawing.Image)
        Me.X.Name = "X"
        Me.X.Width = 30
        '
        'DT_STime
        '
        Me.DT_STime.CustomFormat = "hh:mm:ss tt"
        Me.DT_STime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DT_STime.Location = New System.Drawing.Point(493, 9)
        Me.DT_STime.Name = "DT_STime"
        Me.DT_STime.Size = New System.Drawing.Size(117, 20)
        Me.DT_STime.TabIndex = 31
        Me.DT_STime.TabStop = False
        '
        'DT_ETime
        '
        Me.DT_ETime.CustomFormat = "hh:mm:ss tt"
        Me.DT_ETime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DT_ETime.Location = New System.Drawing.Point(493, 35)
        Me.DT_ETime.Name = "DT_ETime"
        Me.DT_ETime.Size = New System.Drawing.Size(117, 20)
        Me.DT_ETime.TabIndex = 32
        Me.DT_ETime.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(212, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Date"
        '
        'DT_Date
        '
        Me.DT_Date.CustomFormat = "dd/MM/yyyy"
        Me.DT_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DT_Date.Location = New System.Drawing.Point(261, 8)
        Me.DT_Date.Name = "DT_Date"
        Me.DT_Date.Size = New System.Drawing.Size(117, 20)
        Me.DT_Date.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Staff"
        '
        'txt_StaffName
        '
        Me.txt_StaffName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_StaffName.Location = New System.Drawing.Point(76, 57)
        Me.txt_StaffName.Name = "txt_StaffName"
        Me.txt_StaffName.ReadOnly = True
        Me.txt_StaffName.Size = New System.Drawing.Size(230, 20)
        Me.txt_StaffName.TabIndex = 2
        Me.txt_StaffName.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(312, 59)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 13)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "Chair Name"
        '
        'txt_ChairName
        '
        Me.txt_ChairName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ChairName.Location = New System.Drawing.Point(380, 57)
        Me.txt_ChairName.Name = "txt_ChairName"
        Me.txt_ChairName.ReadOnly = True
        Me.txt_ChairName.Size = New System.Drawing.Size(230, 20)
        Me.txt_ChairName.TabIndex = 3
        Me.txt_ChairName.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(37, 13)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "Bill No"
        '
        'txt_BillNo
        '
        Me.txt_BillNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_BillNo.Location = New System.Drawing.Point(76, 8)
        Me.txt_BillNo.Name = "txt_BillNo"
        Me.txt_BillNo.Size = New System.Drawing.Size(104, 20)
        Me.txt_BillNo.TabIndex = 0
        Me.txt_BillNo.TabStop = False
        '
        'txt_Slno
        '
        Me.txt_Slno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Slno.Location = New System.Drawing.Point(15, 150)
        Me.txt_Slno.Name = "txt_Slno"
        Me.txt_Slno.Size = New System.Drawing.Size(30, 20)
        Me.txt_Slno.TabIndex = 41
        Me.txt_Slno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_Qty
        '
        Me.txt_Qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Qty.Location = New System.Drawing.Point(380, 151)
        Me.txt_Qty.Name = "txt_Qty"
        Me.txt_Qty.Size = New System.Drawing.Size(30, 20)
        Me.txt_Qty.TabIndex = 5
        Me.txt_Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_Rate
        '
        Me.txt_Rate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Rate.Location = New System.Drawing.Point(416, 151)
        Me.txt_Rate.Name = "txt_Rate"
        Me.txt_Rate.Size = New System.Drawing.Size(30, 20)
        Me.txt_Rate.TabIndex = 6
        Me.txt_Rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_Amount
        '
        Me.txt_Amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Amount.Location = New System.Drawing.Point(457, 151)
        Me.txt_Amount.Name = "txt_Amount"
        Me.txt_Amount.Size = New System.Drawing.Size(30, 20)
        Me.txt_Amount.TabIndex = 7
        Me.txt_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_GrandTotal
        '
        Me.lbl_GrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_GrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GrandTotal.Location = New System.Drawing.Point(346, 355)
        Me.lbl_GrandTotal.Name = "lbl_GrandTotal"
        Me.lbl_GrandTotal.Size = New System.Drawing.Size(208, 30)
        Me.lbl_GrandTotal.TabIndex = 46
        Me.lbl_GrandTotal.Text = "0.00"
        Me.lbl_GrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Cash
        '
        Me.txt_Cash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Cash.Location = New System.Drawing.Point(463, 388)
        Me.txt_Cash.Name = "txt_Cash"
        Me.txt_Cash.Size = New System.Drawing.Size(91, 20)
        Me.txt_Cash.TabIndex = 11
        Me.txt_Cash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(365, 389)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Cash"
        '
        'txt_Card
        '
        Me.txt_Card.BackColor = System.Drawing.Color.White
        Me.txt_Card.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Card.Location = New System.Drawing.Point(463, 410)
        Me.txt_Card.Name = "txt_Card"
        Me.txt_Card.Size = New System.Drawing.Size(91, 20)
        Me.txt_Card.TabIndex = 12
        Me.txt_Card.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(365, 412)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Bank/Card"
        '
        'txt_Tax
        '
        Me.txt_Tax.BackColor = System.Drawing.Color.White
        Me.txt_Tax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Tax.Location = New System.Drawing.Point(463, 331)
        Me.txt_Tax.Name = "txt_Tax"
        Me.txt_Tax.Size = New System.Drawing.Size(91, 20)
        Me.txt_Tax.TabIndex = 10
        Me.txt_Tax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_TaxPecent
        '
        Me.txt_TaxPecent.BackColor = System.Drawing.Color.White
        Me.txt_TaxPecent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_TaxPecent.Location = New System.Drawing.Point(416, 331)
        Me.txt_TaxPecent.Name = "txt_TaxPecent"
        Me.txt_TaxPecent.Size = New System.Drawing.Size(41, 20)
        Me.txt_TaxPecent.TabIndex = 9
        Me.txt_TaxPecent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(110, 457)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(92, 28)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(306, 456)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(92, 28)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(208, 457)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(92, 28)
        Me.btnRemove.TabIndex = 18
        Me.btnRemove.Text = "Delete"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'cmb_ItemName
        '
        Me.cmb_ItemName.FormattingEnabled = True
        Me.cmb_ItemName.Location = New System.Drawing.Point(70, 150)
        Me.cmb_ItemName.Name = "cmb_ItemName"
        Me.cmb_ItemName.Size = New System.Drawing.Size(294, 21)
        Me.cmb_ItemName.TabIndex = 4
        '
        'lbl_RowCount
        '
        Me.lbl_RowCount.AutoSize = True
        Me.lbl_RowCount.Location = New System.Drawing.Point(293, 377)
        Me.lbl_RowCount.Name = "lbl_RowCount"
        Me.lbl_RowCount.Size = New System.Drawing.Size(0, 13)
        Me.lbl_RowCount.TabIndex = 50
        Me.lbl_RowCount.Visible = False
        '
        'txt_Balance
        '
        Me.txt_Balance.BackColor = System.Drawing.Color.White
        Me.txt_Balance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Balance.Location = New System.Drawing.Point(463, 433)
        Me.txt_Balance.Name = "txt_Balance"
        Me.txt_Balance.Size = New System.Drawing.Size(91, 20)
        Me.txt_Balance.TabIndex = 51
        Me.txt_Balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(365, 435)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Balance"
        '
        'Close_Workfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(620, 486)
        Me.Controls.Add(Me.txt_Balance)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_RowCount)
        Me.Controls.Add(Me.cmb_ItemName)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txt_TaxPecent)
        Me.Controls.Add(Me.txt_Tax)
        Me.Controls.Add(Me.txt_Cash)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_Card)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_GrandTotal)
        Me.Controls.Add(Me.txt_TotalProduct)
        Me.Controls.Add(Me.txt_Amount)
        Me.Controls.Add(Me.txt_Rate)
        Me.Controls.Add(Me.txt_Qty)
        Me.Controls.Add(Me.txt_Slno)
        Me.Controls.Add(Me.txt_BillNo)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txt_ChairName)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txt_StaffName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DT_Date)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DT_ETime)
        Me.Controls.Add(Me.DT_STime)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txt_Mobile)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_Place)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_CustomerName)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_ServiceCharge)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Close_Workfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Billing"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_ServiceCharge As TextBox
    Friend WithEvents txt_TotalProduct As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_CustomerName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_Place As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_Mobile As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DT_STime As DateTimePicker
    Friend WithEvents DT_ETime As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents DT_Date As DateTimePicker
    Friend WithEvents Slno As DataGridViewTextBoxColumn
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents Qty As DataGridViewTextBoxColumn
    Friend WithEvents Rate As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents X As DataGridViewImageColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_StaffName As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_ChairName As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_BillNo As TextBox
    Friend WithEvents txt_Slno As TextBox
    Friend WithEvents txt_Qty As TextBox
    Friend WithEvents txt_Rate As TextBox
    Friend WithEvents txt_Amount As TextBox
    Friend WithEvents lbl_GrandTotal As Label
    Friend WithEvents txt_Cash As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_Card As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Tax As TextBox
    Friend WithEvents txt_TaxPecent As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents cmb_ItemName As ComboBox
    Friend WithEvents lbl_RowCount As Label
    Friend WithEvents txt_Balance As TextBox
    Friend WithEvents Label4 As Label
End Class
