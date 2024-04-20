'mports Microsoft.Office.Interop.Excel
Imports System.Data.OleDb

Public Class Chair_Main
    Dim con As New OLEDBConnection
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim DT As New DataTable
    Private Sub Chair_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridAdd("")
    End Sub
    Private Sub DataGridAdd(SearchString As String)
        Try
            con.ConnectionString = ConString
            cmd = con.CreateCommand
            If con.State = ConnectionState.Closed Then con.Open()
            cmd.CommandText = "SELECT ID,ChairName,ChairType,StaffName FROM Chair"
            If Trim(SearchString) <> "" Then
                cmd.CommandText &= " WHERE ID LIKE '%" & SearchString & "%'"
            End If
            Dim dr As OleDbDataReader = cmd.ExecuteReader
            ' Create a DataTable
            Dim DT As New DataTable
            DT.Columns.Add("ID")
            DT.Columns.Add("ChairName")
            DT.Columns.Add("ChairType")
            DT.Columns.Add("StaffName")
            DT.Columns.Add("Edit", GetType(Image))
            While dr.Read()
                ' Add rows to the DataTable
                DT.Rows.Add(dr("ID"), dr("ChairName"), dr("ChairType"), dr("StaffName"))
            End While

            ', Tax, Details
            dr.Close()
            DataGridView1.DataSource = DT
            DataGridView1.Columns("ID").Visible = False
            DataGridView1.Columns("StaffName").Visible = False
            'DataGridView1.Dock = DockStyle.Fill
            '    DataGridView1.Anchor = AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Top
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub
End Class