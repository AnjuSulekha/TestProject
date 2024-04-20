Imports System.Data.OleDb
'Imports Microsoft.Office.Interop.Excel
Public Class Product_Add
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim DT As New DataTable
    Private Sub Product_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Btn_product.BackColor = Color.DodgerBlue
        Btn_product.ForeColor = Color.White
        Button8.BackColor = Color.DodgerBlue
        Button8.ForeColor = Color.White
        Button10.BackColor = Color.DodgerBlue
        Button10.ForeColor = Color.White
        DeleteProduct.BackColor = Color.DodgerBlue
        DeleteProduct.ForeColor = Color.White
        lbl_id.Visible = False
    End Sub
    Private Sub Tabmovement(ByVal Keycode As Integer)
        If Keycode = 13 Then
            SendKeys.Send("{tab}")
        End If
    End Sub
    Private Sub Txt_Product_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Product.KeyDown
        Call Tabmovement(e.KeyValue)
    End Sub


    Private Sub Txt_ProCat_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_ProCat.KeyDown
        Call Tabmovement(e.KeyValue)
    End Sub

    Private Sub Txt_Rate_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Rate.KeyDown
        Call Tabmovement(e.KeyValue)
    End Sub


    Private Sub Txt_Tax_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Tax.KeyDown
        Call Tabmovement(e.KeyValue)
    End Sub

    Private Sub Txt_Type_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Type.KeyDown
        Call Tabmovement(e.KeyValue)
    End Sub

    Private Sub Txt_Details_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Details.KeyDown
        Call Tabmovement(e.KeyValue)
    End Sub

    Private Sub Btn_product_Click(sender As Object, e As EventArgs) Handles Btn_product.Click
        Try
            If String.IsNullOrWhiteSpace(Txt_Product.Text) Then
                MsgBox("Required Field.")
                Txt_Product.Focus()
                Return ' Exit the event handler if Chair Name is empty
            End If

            If String.IsNullOrWhiteSpace(Txt_ProCat.Text) Then
                MsgBox("Required Field.")
                Txt_ProCat.Focus()
                Return ' Exit the event handler if Chair Type is empty
            End If
            If String.IsNullOrWhiteSpace(Txt_Rate.Text) Then
                MsgBox("Required Field.")
                Txt_Rate.Focus()
                Return ' Exit the event handler if Chair Type is empty
            End If
            If String.IsNullOrWhiteSpace(Txt_Tax.Text) Then
                MsgBox("Required Field.")
                Txt_Tax.Focus()
                Return ' Exit the event handler if Chair Type is empty
            End If
            con.ConnectionString = ConString
            cmd = con.CreateCommand
            If con.State = ConnectionState.Closed Then con.Open()
            cmd.CommandText = "insert into Item_Master(ItemName,Category,Rate,Tax,Details) values('" & Txt_Product.Text & "','" & Txt_ProCat.Text & "','" & Txt_Rate.Text & "','" & Txt_Tax.Text & "','" & Txt_Details.Text & "')"
            cmd.ExecuteNonQuery()
            MsgBox("Data inserted successfully.")
            Prodcutclear()
            con.Close()
            Product_Main.RefreshProdutData()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub Prodcutclear()
        Txt_Product.Text = ""
        Txt_ProCat.Text = ""
        Txt_Details.Text = ""
        Txt_Rate.Text = ""
        Txt_Tax.Text = ""
        Txt_Type.Text = ""
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Hide()
        Prodcutclear()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Try
            con.ConnectionString = ConString
            cmd = con.CreateCommand
            If con.State = ConnectionState.Closed Then con.Open()
            cmd.CommandText = "update Item_Master set ItemName='" & Txt_Product.Text & "',Category	='" & Txt_ProCat.Text & "',Rate	='" & Txt_Rate.Text & "',Tax='" & Txt_Tax.Text & "',Details='" & Txt_Details.Text & "'  where ItemID	=" & lbl_id.Text & ""
            cmd.ExecuteNonQuery()
            MsgBox("Data updated successfully")
            Prodcutclear()
            con.Close()
            Product_Main.RefreshProdutData()
            Me.Hide()
        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub DeleteProduct_Click(sender As Object, e As EventArgs) Handles DeleteProduct.Click
        Try
            Dim result As DialogResult = MessageBox.Show("Do you want to Delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            ' Check the user's response
            If result = DialogResult.Yes Then


                ' Establish connection
                con.ConnectionString = ConString
                cmd = con.CreateCommand

                ' Check if connection is closed, then open it
                If con.State = ConnectionState.Closed Then con.Open()

                ' Prepare SQL command for deletion
                cmd.CommandText = "DELETE FROM Item_Master WHERE ItemID = @ItemID"

                ' Add parameters to the command (to prevent SQL injection)
                cmd.Parameters.AddWithValue("@ItemID", lbl_id.Text)

                ' Execute the deletion command
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                ' Check if any rows were affected
                If rowsAffected > 0 Then
                    MsgBox("Data deleted successfully")
                    ' Clear input fields after deletion
                    Prodcutclear()
                Else
                    MsgBox("No data deleted. ItemID not found.")
                End If
            End If
            con.Close()
            Product_Main.RefreshProdutData()
            Me.Hide()
        Catch ex As Exception
            ' Handle exceptions, if any
            MsgBox("An error occurred: " & ex.Message)
        Finally
            ' Close connection
            con.Close()
        End Try
    End Sub
    Public Sub LoadProductData()
        Try
            con.ConnectionString = ConString
            cmd = con.CreateCommand
            If con.State = ConnectionState.Closed Then con.Open()
            If lbl_id.Text <> "" Then
                cmd.CommandText = "select * from Item_Master where ItemID=" & lbl_id.Text & ""
                dr = cmd.ExecuteReader()
                dr.Read()
                If dr.HasRows = True Then
                    Me.Txt_Product.Text = dr("ItemName").ToString()
                    Me.Txt_ProCat.Text = dr("Category").ToString()
                    Me.Txt_Rate.Text = dr("Rate").ToString()
                    Me.Txt_Tax.Text = dr("Tax").ToString()
                    Me.Txt_Details.Text = dr("Details").ToString()
                    dr.Close()
                Else
                    MsgBox("hi")
                End If
            End If
        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Product_Add_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim maxTextBoxPanelWidth As Integer = 700 ' Adjust this value as needed
        Dim RatemaxPanelWidth As Integer = 300 ' Adjust this value as needed
        Dim taxmaxPanelWidth As Integer = 321 ' 
        Dim minpanelwidth As Integer = 461
        Dim minwidth As Integer = 195
        ' Store original locations
        If Me.WindowState = FormWindowState.Maximized Then
            Panel16.Width = Math.Min(maxTextBoxPanelWidth, Me.Width)
            Panel15.Width = Math.Min(maxTextBoxPanelWidth, Me.Width)
            Panel13.Width = Math.Min(RatemaxPanelWidth, Me.Width)
            Panel12.Width = Math.Min(taxmaxPanelWidth, Me.Width)
            Panel14.Width = Math.Min(maxTextBoxPanelWidth, Me.Width)
            Panel1.Width = Math.Min(maxTextBoxPanelWidth, Me.Width)
            ' Adjust the width of the textboxes based on the panel's width
            ' Txt_Product.Width = Panel16.Width - (2 * Txt_Product.Left) ' Adjust this calculation as needed
            Txt_ProCat.Width = Panel15.Width - (2 * Txt_ProCat.Left)
            Txt_Rate.Width = Panel13.Width - (2 * Txt_Rate.Left)
            Txt_Tax.Width = Panel12.Width - (2 * Txt_Tax.Left)
            Txt_Type.Width = Panel14.Width - (2 * Txt_Type.Left)
            Txt_Details.Width = Panel1.Width - (2 * Txt_Details.Left)
            Dim Label14X As Integer = Panel13.Right + 10
            Dim label14Y As Integer = Label14.Top + (Label14.Height / 2) - (Label14.Height / 2)
            Dim Nlocation As Point = New Point(Label14X, label14Y)
            Label14.Location = Nlocation
            Dim Panel12X As Integer = Label14.Right + 20
            Dim panel12Y As Integer = Panel12.Top
            Dim Plocation As Point = New Point(Panel12X, panel12Y)
            Panel12.Location = Plocation
        Else
            Panel12.Location = New Point(442, 216)
            Label14.Location = New Point(393, 225)
            Panel16.Width = Math.Min(minpanelwidth, Me.Width)
            Panel15.Width = Math.Min(minpanelwidth, Me.Width)
            Panel13.Width = Math.Min(minwidth, Me.Width)
            Panel12.Width = Math.Min(minwidth, Me.Width)
            Panel14.Width = Math.Min(minpanelwidth, Me.Width)
            Panel1.Width = Math.Min(minpanelwidth, Me.Width)
        End If
    End Sub
End Class