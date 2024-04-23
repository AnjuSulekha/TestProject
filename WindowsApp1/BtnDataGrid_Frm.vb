Imports System.Data.OleDb
Imports System.IO
Imports System.Net.Configuration

Public Class BtnDataGrid_Frm
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Private Sub BtnDataGrid_Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridAdd("")
        Id.Visible = True

    End Sub
    Private Sub DataGridAdd(SearchString As String)
        Try
            con.ConnectionString = ConString
            cmd = con.CreateCommand

            If con.State = ConnectionState.Closed Then con.Open()

            cmd.CommandText = "SELECT * FROM StaffMaster"
            If Trim(SearchString) <> "" Then
                cmd.CommandText &= " WHERE StaffID LIKE '%" & SearchString & "%'"
            End If
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            ' Create a DataTable
            Dim DT As New DataTable
            DT.Columns.Add("Image", GetType(Image)) ' Add a column for the image
            DT.Columns.Add("StaffID")
            DT.Columns.Add("StaffName")
            DT.Columns.Add("Status")
            While dr.Read()
                Dim imagePath As String = dr("Img").ToString()
                Dim workStatus As Integer = Convert.ToInt32(dr("Work_Status"))

                Dim statusText As String = If(workStatus = 0, "Tap to Assign Work", "Already in Work")
                If Not String.IsNullOrEmpty(imagePath) AndAlso File.Exists(imagePath) Then
                    ' Load image only if the file path is not empty and the file exists
                    Dim img As Image = Image.FromFile(imagePath)

                    ' Add the row to the DataTable
                    DT.Rows.Add(img, dr("StaffID"), dr("StaffName"), statusText)
                Else
                    ' Handle invalid or missing file path
                    DT.Rows.Add(Nothing, dr("StaffID"), dr("StaffName"), statusText)
                End If
            End While
            dr.Close()
            con.Close()
            Master_Form.RefreshStaffData()
            ' Assign the DataTable as the DataSource for DataGridView2
            DataGridView2.DataSource = DT
            DataGridView2.Columns("StaffID").Visible = False

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub DataGridView2_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DataGridView2.CellBeginEdit

    End Sub


    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick

        If e.RowIndex >= 0 Then
            If e.ColumnIndex = DataGridView2.Columns("Status").Index Then
                Dim staffID As String = DataGridView2.Rows(e.RowIndex).Cells("StaffID").Value.ToString()
                Dim staffname As String = DataGridView2.Rows(e.RowIndex).Cells("StaffName").Value.ToString()
                UpdateWorkStatus(staffID)
                '  Dim staffname As String = DataGridView2.Rows(e.RowIndex).Cells("StaffName").Value.ToString()
                cmd = con.CreateCommand
                If con.State = ConnectionState.Closed Then con.Open()
                ' Prepare the SQL query with parameter for staffname
                cmd.CommandText = "UPDATE Chair SET StaffName=@staffname, Status=1 WHERE ID=" & Id.Text & ""
                ' Add parameters and set their values
                cmd.Parameters.AddWithValue("@StaffName", staffname)
                cmd.Parameters.AddWithValue("@ID", Id.Text)
                ' Execute the query
                cmd.ExecuteNonQuery()
                con.Close()
                'Chairs_working.UpdateButtonColors()

                Master_Form.RefreshStaffData()
                Me.Close()
            End If

        End If

    End Sub
    Public Sub RefreshStaffData()
        ' Clear the DataGridView
        DataGridView2.DataSource = Nothing

        ' Re-fetch the data from the database and update the DataGridView
        DataGridAdd("")
    End Sub

    Private Sub UpdateWorkStatus(StaffID As String)
        Try
            con.ConnectionString = ConString
            cmd = con.CreateCommand()
            If con.State = ConnectionState.Closed Then con.Open()
            ' Update the Work_Status column value to 1 for the specified staffID
            cmd.CommandText = "UPDATE StaffMaster SET Work_Status = 1 WHERE StaffID = @StaffID"
            cmd.Parameters.AddWithValue("@StaffID", StaffID)
            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub DataGridView2_Click(sender As Object, e As EventArgs) Handles DataGridView2.Click

    End Sub


End Class