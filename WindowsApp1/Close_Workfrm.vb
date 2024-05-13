Imports System.Data.OleDb
Imports System.Globalization
Imports System.Security.Cryptography
Public Class Close_Workfrm
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Private Sub Close_Workfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Width = 636
            Me.Height = 525
            DataGridView1.Rows.Add(10)
            Me.txt_Slno.Text = 1
            PlaceGrid(0)
            con.ConnectionString = ConString
            con.Open()
            cmd = con.CreateCommand
            If con.State = ConnectionState.Closed Then con.Open()
            cmd.CommandText = "SELECT ItemID,ItemName,Category,Rate,Tax,Details FROM Item_Master"
            dr = cmd.ExecuteReader
            While dr.Read
                Me.cmb_ItemName.Items.Add(dr("ItemName").ToString)
            End While
            dr.Close()
            If con.State = ConnectionState.Closed Then con.Open()
            cmd.CommandText = "Select max(BillNo) from Bill_inf"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                If IsDBNull(dr.GetValue(0)) = False Then
                    Me.txt_BillNo.Text = Val(dr.GetValue(0)) + 1
                    dr.Close()
                Else
                    dr.Close()
                    Me.txt_BillNo.Text = 1
                End If
                dr.Close()
            Else
                dr.Close()
                Me.txt_BillNo.Text = 1
            End If
            Me.DT_STime.Value = System.DateTime.Now
            Me.DT_ETime.Value = System.DateTime.Now
        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub FunGrandTotal()
        lbl_GrandTotal.Text = Format((Val(Me.txt_TotalProduct.Text) + Val(Me.txt_ServiceCharge.Text) + Val(Me.txt_Tax.Text)), "0.00")
    End Sub
    Private Sub DT_Date_ValueChanged(sender As Object, e As EventArgs) Handles DT_Date.ValueChanged

    End Sub

    Private Sub DT_Date_KeyDown(sender As Object, e As KeyEventArgs) Handles DT_Date.KeyDown
        Call TabMovement(e.KeyValue)
    End Sub

    Private Sub txt_StaffName_TextChanged(sender As Object, e As EventArgs) Handles txt_StaffName.TextChanged

    End Sub
    Public Sub PlaceGrid(ByVal rowindex As Integer)
        With DataGridView1
            Dim RowHeight1 As Integer = .Rows(rowindex).Height
            Dim CellRectangle1 As Rectangle = .GetCellDisplayRectangle(.Columns("Slno").Index, rowindex, False) 'GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, False)  '
            CellRectangle1.X += DataGridView1.Left
            CellRectangle1.Y += DataGridView1.Top
            txt_Slno.Width = CellRectangle1.Width
            txt_Slno.Height = CellRectangle1.Height
            txt_Slno.Left = CellRectangle1.X
            txt_Slno.Top = CellRectangle1.Y

            CellRectangle1 = DataGridView1.GetCellDisplayRectangle(.Columns("ItemName").Index, rowindex, False)
            CellRectangle1.X += DataGridView1.Left
            CellRectangle1.Y += DataGridView1.Top
            cmb_ItemName.Width = CellRectangle1.Width
            cmb_ItemName.Left = CellRectangle1.X
            cmb_ItemName.Top = CellRectangle1.Y
            cmb_ItemName.Height = CellRectangle1.Height
            If CellRectangle1.Width <= 5 Then
                cmb_ItemName.TabStop = False
            End If

            CellRectangle1 = DataGridView1.GetCellDisplayRectangle(.Columns("Qty").Index, rowindex, False)
            CellRectangle1.X += DataGridView1.Left
            CellRectangle1.Y += DataGridView1.Top
            txt_Qty.Width = CellRectangle1.Width
            txt_Qty.Left = CellRectangle1.X
            txt_Qty.Top = CellRectangle1.Y
            txt_Qty.Height = CellRectangle1.Height
            If CellRectangle1.Width <= 5 Then
                txt_Qty.TabStop = False
            End If
            CellRectangle1 = DataGridView1.GetCellDisplayRectangle(.Columns("Rate").Index, rowindex, False)
            CellRectangle1.X += DataGridView1.Left
            CellRectangle1.Y += DataGridView1.Top
            txt_Rate.Width = CellRectangle1.Width
            txt_Rate.Left = CellRectangle1.X
            txt_Rate.Top = CellRectangle1.Y
            txt_Rate.Height = CellRectangle1.Height
            If CellRectangle1.Width <= 5 Then
                txt_Rate.TabStop = False
            End If
            CellRectangle1 = DataGridView1.GetCellDisplayRectangle(.Columns("Amount").Index, rowindex, False)
            CellRectangle1.X += DataGridView1.Left
            CellRectangle1.Y += DataGridView1.Top
            txt_Amount.Width = CellRectangle1.Width
            txt_Amount.Left = CellRectangle1.X
            txt_Amount.Top = CellRectangle1.Y
            txt_Amount.Height = CellRectangle1.Height
            If CellRectangle1.Width <= 5 Then
                txt_Amount.TabStop = False
            End If
        End With
    End Sub
    Private Sub txt_StaffName_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_StaffName.KeyDown
        Call TabMovement(e.KeyValue)

    End Sub

    Private Sub txt_ChairName_TextChanged(sender As Object, e As EventArgs) Handles txt_ChairName.TextChanged

    End Sub

    Private Sub txt_ChairName_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_ChairName.KeyDown
        Call TabMovement(e.KeyValue)

    End Sub

    Private Sub cmb_ItemName_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txt_Qty_TextChanged(sender As Object, e As EventArgs) Handles txt_Qty.TextChanged
        FunTotal()
    End Sub
    Private Sub FunTotal()
        Me.txt_Amount.Text = Format(Val(Me.txt_Qty.Text) * Val(Me.txt_Rate.Text), "0.00")
    End Sub
    Private Sub txt_Qty_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Qty.KeyDown
        Call TabMovement(e.KeyValue)

    End Sub

    Private Sub txt_Rate_TextChanged(sender As Object, e As EventArgs) Handles txt_Rate.TextChanged
        FunTotal()
    End Sub

    Private Sub txt_Rate_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Rate.KeyDown
        Call TabMovement(e.KeyValue)

    End Sub

    Private Sub txt_ServiceCharge_TextChanged(sender As Object, e As EventArgs) Handles txt_ServiceCharge.TextChanged
        FunTax()
        FunGrandTotal()
    End Sub

    Private Sub txt_ServiceCharge_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_ServiceCharge.KeyDown
        Call TabMovement(e.KeyValue)

    End Sub
    Private Sub FunTax()
        Me.txt_Tax.Text = Format((Val(Me.txt_TotalProduct.Text) + Val(Me.txt_ServiceCharge.Text)) * Val(Me.txt_TaxPecent.Text), "0.00")

    End Sub
    Private Sub txt_TaxPecent_TextChanged(sender As Object, e As EventArgs) Handles txt_TaxPecent.TextChanged
        FunTax()
    End Sub

    Private Sub txt_TaxPecent_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_TaxPecent.KeyDown
        Call TabMovement(e.KeyValue)

    End Sub

    Private Sub txt_Tax_TextChanged(sender As Object, e As EventArgs) Handles txt_Tax.TextChanged
        FunGrandTotal()
    End Sub

    Private Sub txt_Tax_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Tax.KeyDown
        Call TabMovement(e.KeyValue)

    End Sub

    Private Sub txt_Cash_TextChanged(sender As Object, e As EventArgs) Handles txt_Cash.TextChanged
        FunBalance()
    End Sub

    Private Sub txt_Cash_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Cash.KeyDown
        Call TabMovement(e.KeyValue)

    End Sub

    Private Sub txt_Card_TextChanged(sender As Object, e As EventArgs) Handles txt_Card.TextChanged
        FunBalance()
    End Sub

    Private Sub txt_Card_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Card.KeyDown
        Call TabMovement(e.KeyValue)

    End Sub

    Private Sub txt_CustomerName_TextChanged(sender As Object, e As EventArgs) Handles txt_CustomerName.TextChanged

    End Sub

    Private Sub txt_CustomerName_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_CustomerName.KeyDown
        Call TabMovement(e.KeyValue)

    End Sub

    Private Sub txt_Place_TextChanged(sender As Object, e As EventArgs) Handles txt_Place.TextChanged

    End Sub

    Private Sub txt_Place_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Place.KeyDown
        Call TabMovement(e.KeyValue)

    End Sub

    Private Sub txt_Mobile_TextChanged(sender As Object, e As EventArgs) Handles txt_Mobile.TextChanged

    End Sub

    Private Sub txt_Mobile_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Mobile.KeyDown
        Call TabMovement(e.KeyValue)

    End Sub

    Private Sub cmb_ItemName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_ItemName.SelectedIndexChanged

    End Sub

    Private Sub cmb_ItemName_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_ItemName.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Trim(Me.cmb_ItemName.Text) <> "" Then
                Call TabMovement(e.KeyCode)
            Else
                txt_ServiceCharge.Focus()
            End If
        End If
    End Sub

    Private Sub cmb_ItemName_LostFocus(sender As Object, e As EventArgs) Handles cmb_ItemName.LostFocus
        Try
            If con.State = ConnectionState.Closed Then con.Open()
            cmd.CommandText = "Select Rate from Item_Master where ItemName='" & Trim(Me.cmb_ItemName.Text) & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                Me.txt_Rate.Text = Format(Val(dr("Rate").ToString), "0.00")
            End If
            dr.Close()
        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub txt_Amount_TextChanged(sender As Object, e As EventArgs) Handles txt_Amount.TextChanged

    End Sub

    Private Sub txt_Amount_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Amount.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If Trim(Me.cmb_ItemName.Text) = "" Then
                    MsgBox("Select ItemName")
                    Me.cmb_ItemName.Focus()
                    GoTo endpart
                End If


                If Trim(Me.cmb_ItemName.Text) <> "" Then
                    If DataGridView1.Rows.Count <= (Me.txt_Slno.Text) Then
                        DataGridView1.Rows.Add()
                    End If
                    With DataGridView1
                        .Rows(Val(txt_Slno.Text) - 1).Cells(.Columns("Slno").Index).Value = txt_Slno.Text
                        .Rows(Val(txt_Slno.Text) - 1).Cells(.Columns("ItemName").Index).Value = cmb_ItemName.Text
                        .Rows(Val(txt_Slno.Text) - 1).Cells(.Columns("Qty").Index).Value = txt_Qty.Text
                        .Rows(Val(txt_Slno.Text) - 1).Cells(.Columns("Rate").Index).Value = txt_Rate.Text
                        .Rows(Val(txt_Slno.Text) - 1).Cells(.Columns("Amount").Index).Value = txt_Amount.Text
                        Dim TakeCount1 As Integer
                        TakeCount1 = 0
                        Dim AmountTotal As Double
                        AmountTotal = 0
                        For c = 0 To .Rows.Count - 1
                            If Trim(.Rows(c).Cells(0).Value) <> "" Then
                                TakeCount1 = TakeCount1 + 1
                                AmountTotal = AmountTotal + Val(.Rows(c).Cells("Amount").Value)
                            End If
                        Next
                        Me.txt_TotalProduct.Text = Format(AmountTotal, "0.00")
                        Me.lbl_RowCount.Text = TakeCount1
                        Me.txt_Slno.Text = Val(Me.txt_Slno.Text) + 1
                        If Val(Me.txt_Slno.Text) > 12 Then
                            DataGridView1.FirstDisplayedScrollingRowIndex = Val(Me.txt_Slno.Text) - 12
                        End If
                        If Trim(.Rows(Val(Me.txt_Slno.Text) - 1).Cells(0).Value) <> "" Then
                            Call FunGridValuestoBox(Val(Me.txt_Slno.Text) - 1)
                            Call PlaceGrid(Val(txt_Slno.Text) - 1)
                            Me.cmb_ItemName.Focus()
                        Else
                            FunClear()
                            Me.cmb_ItemName.Focus()
                            Call PlaceGrid(Val(txt_Slno.Text) - 1)
                        End If
                    End With
                Else
                    MsgBox("Enter Details")
                    Me.cmb_ItemName.Focus()
                End If
            End If
endpart:
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FunClear()
        Me.cmb_ItemName.Text = ""
        Me.txt_Qty.Text = ""
        Me.txt_Rate.Text = ""
        Me.txt_Amount.Text = ""
    End Sub
    Private Sub FunGridValuestoBox(RowNum As Integer)
        Try
            With DataGridView1
                If Trim(.Rows(RowNum).Cells(0).Value) <> "" Then
                    Me.txt_Slno.Text = .Rows(RowNum).Cells(.Columns("Slno").Index).Value
                    Me.cmb_ItemName.Text = .Rows(RowNum).Cells(.Columns("ItemName").Index).Value
                    Me.txt_Qty.Text = .Rows(RowNum).Cells(.Columns("Qty").Index).Value
                    Me.txt_Rate.Text = .Rows(RowNum).Cells(.Columns("Rate").Index).Value
                    Me.txt_Amount.Text = .Rows(RowNum).Cells(.Columns("Amount").Index).Value
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        With DataGridView1
            If Trim(.Rows(e.RowIndex).Cells(0).Value) <> "" Then
                If e.ColumnIndex = .Columns("X").Index Then
                    Dim a As String
                    a = MsgBox("Sure Do you want to Remove", MsgBoxStyle.YesNo)
                    If a = vbYes Then
                        DataGridView1.Rows.RemoveAt(e.RowIndex)
                        FunClear()
                        Dim sll As Double
                        sll = 0
                        For c = 0 To DataGridView1.Rows.Count - 1
                            If Trim(DataGridView1.Rows(c).Cells(0).Value) <> "" Then
                                sll = sll + 1
                                DataGridView1.Rows(c).Cells(0).Value = sll
                            End If
                        Next
                        Me.lbl_RowCount.Text = sll
                        txt_Slno.Text = sll + 1
                        If Val(Me.txt_Slno.Text) > 12 Then
                            DataGridView1.FirstDisplayedScrollingRowIndex = Val(Me.txt_Slno.Text) - 12
                        End If
                        Call PlaceGrid(sll)
                        Me.cmb_ItemName.Focus()
                    End If
                Else
                    Call FunGridValuestoBox(e.RowIndex)
                    Call PlaceGrid(e.RowIndex)
                    cmb_ItemName.Focus()
                End If
            End If
        End With
    End Sub

    Private Sub txt_TotalProduct_TextChanged(sender As Object, e As EventArgs) Handles txt_TotalProduct.TextChanged
        FunTax()
        FunGrandTotal()
    End Sub

    Private Sub lbl_GrandTotal_Click(sender As Object, e As EventArgs) Handles lbl_GrandTotal.Click

    End Sub
    Private Sub FunBalance()
        Me.txt_Balance.Text = Format(Val(Me.lbl_GrandTotal.Text) - (Val(Me.txt_Cash.Text) + Val(Me.txt_Card.Text)), "0.00")
    End Sub

    Private Sub lbl_GrandTotal_TextChanged(sender As Object, e As EventArgs) Handles lbl_GrandTotal.TextChanged
        FunBalance()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Try
            FunClear()
            Me.txt_Tax.Text = ""
            Me.txt_TaxPecent.Text = ""
            Me.txt_TotalProduct.Text = ""
            Me.lbl_GrandTotal.Text = ""
            Me.txt_Card.Text = ""
            Me.txt_Cash.Text = ""
            Me.txt_Balance.Text = ""
            Me.txt_ChairName.Text = ""
            Me.txt_CustomerName.Text = ""
            Me.txt_Place.Text = ""
            Me.txt_Mobile.Text = ""
            Me.txt_StaffName.Text = ""

            If con.State = ConnectionState.Closed Then con.Open()
            cmd.CommandText = "Select max(BillNo) from Bill_inf"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                If IsDBNull(dr.GetValue(0)) = False Then
                    Me.txt_BillNo.Text = Val(dr.GetValue(0)) + 1
                    dr.Close()
                Else
                    dr.Close()
                    Me.txt_BillNo.Text = 1
                End If
                dr.Close()
            Else
                dr.Close()
                Me.txt_BillNo.Text = 1
            End If
            Me.DT_Date.Value = Today
            Me.DT_Date.Focus()
        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If Trim(Me.txt_ChairName.Text) <> "" Then
                If con.State = ConnectionState.Closed Then con.Open()
                Dim TakeStaffID As Integer, TakeChairID As Integer
                cmd.CommandText = "Select StaffID from StaffMaster where StaffName='" & UCase(Trim(Me.txt_StaffName.Text)) & "'"
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows = True Then
                    TakeStaffID = Val(dr("StaffID").ToString)
                End If
                dr.Close()
                cmd.CommandText = "Select ID from Chair where ChairName='" & UCase(Trim(Me.txt_ChairName.Text)) & "'"
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows = True Then
                    TakeChairID = Val(dr("ID").ToString)
                End If
                dr.Close()
                cmd.CommandText = "Insert into Bill_inf(ChairID,StaffID,EntryDate,STime,ETime,Product,Service,TaxPercent,Tax,GrandTotal,Cash,Card,Customer,Mobile,Place)
                                values(" & TakeChairID & "," & TakeStaffID & ",'" & Format(Me.DT_Date.Value, "MM-dd-yyyy") & "','" & Format(Me.DT_STime.Value, "hh:mm:ss tt") & "','" & Format(Me.DT_ETime.Value, "hh:mm:ss tt") & "'," & Val(Me.txt_TotalProduct.Text) & "," & Val(Me.txt_ServiceCharge.Text) & "," & Val(Me.txt_TaxPecent.Text) & "," & Val(Me.txt_Tax.Text) & "," & Val(Me.lbl_GrandTotal.Text) & "," & Val(Me.txt_Cash.Text) & "," & Val(Me.txt_Card.Text) & ",'" & Trim(Me.txt_CustomerName.Text) & "','" & Trim(Me.txt_Mobile.Text) & "','" & Trim(Me.txt_Place.Text) & "')"
                cmd.ExecuteNonQuery()
                Dim takeBID As Integer
                If con.State = ConnectionState.Closed Then con.Open()
                cmd.CommandText = "Select max(BID) from Bill_inf"
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows = True Then
                    If IsDBNull(dr.GetValue(0)) = False Then
                        takeBID = Val(dr.GetValue(0))
                        dr.Close()
                    Else
                        dr.Close()
                    End If
                    dr.Close()
                Else
                    dr.Close()
                End If
                If con.State = ConnectionState.Closed Then con.Open()
                cmd.CommandText = "Select max(BillNo) from Bill_inf"
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows = True Then
                    If IsDBNull(dr.GetValue(0)) = False Then
                        Me.txt_BillNo.Text = Val(dr.GetValue(0)) + 1
                        dr.Close()
                    Else
                        dr.Close()
                        Me.txt_BillNo.Text = 1
                    End If
                    dr.Close()
                Else
                    dr.Close()
                    Me.txt_BillNo.Text = 1
                End If
                cmd.CommandText = "Update Bill_inf Set BillNo=" & Val(Me.txt_BillNo.Text) & " where BID=" & takeBID & ""
                cmd.ExecuteNonQuery()
                With DataGridView1
                    For c = 0 To .Rows.Count - 1
                        If Trim(.Rows(c).Cells(0).Value) <> "" Then
                            Dim TakeiTemName As String = Trim(.Rows(c).Cells("ItemName").Value)
                            Dim TakeQty As String = Trim(.Rows(c).Cells("Rate").Value)
                            Dim TakeRate As String = Trim(.Rows(c).Cells("Qty").Value)
                            Dim TakeAmount As String = Trim(.Rows(c).Cells("Amount").Value)
                            cmd.CommandText = "Insert into Bill_Details(BID,BillNo,EntryDate,ItemName,Qty,Rate,Amount,Type) values(" & takeBID & "," & Val(Me.txt_BillNo.Text) & ",#" & Format(Me.DT_Date.Value, "MM-dd-yyyy") & "#,'" & TakeiTemName & "'," & TakeQty & "," & TakeRate & "," & TakeAmount & ",1)"
                            cmd.ExecuteNonQuery()
                        End If
                    Next
                End With
                cmd.CommandText = "Insert into ChairStatus(EntryDate,EntryTime,ChairID,StaffID,Status,BillNo) values(#" & Format(Today, "MM-dd-yyyy") & "#,#" & Format(System.DateTime.Now, "hh:mm:ss tt") & "#," & TakeChairID & "," & TakeStaffID & ",3," & takeBID & ")"
                cmd.ExecuteNonQuery()

                cmd.CommandText = "Insert into ChairStatus(EntryDate,EntryTime,ChairID,StaffID,Status,BillNo) values(#" & Format(Today, "MM-dd-yyyy") & "#,#" & Format(System.DateTime.Now, "hh:mm:ss tt") & "#," & TakeChairID & "," & TakeStaffID & ",1,0)"
                cmd.ExecuteNonQuery()
                Call Front_Form.FunlistChairs()
                MsgBox("Saved")
                Front_Form.Timer1.Enabled = False
                Call btnClear_Click(sender, e)
            Else
                MsgBox("Please Select Chairname")
            End If
        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub cmb_ItemName_GotFocus(sender As Object, e As EventArgs) Handles cmb_ItemName.GotFocus

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

    End Sub
End Class