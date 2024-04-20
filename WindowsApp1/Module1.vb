
Module Module1

    Public L As New Label
    Public B As New Button
    Public ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\SalonErp.mdb"
    Public takecompanyname As String, takeCompanyAdd1 As String, takeCompanyAdd2 As String, takeCompanyAdd3 As String, takeCompanyContact As String, takeCompanyMobile As String, takeCompanyEmail As String, TakeCompanyWebsite As String, CompanyGSTIN As String, TakeOfficeAccountID As Integer
    Public takecompanySecondname As String, takeCompanySecondAdd1 As String, takeCompanySecondAdd2 As String, takeCompanySecondAdd3 As String
    Public CompanyPDFPrinter As String, CompanyPrintFile As String = Application.StartupPath, TakeCompanyFssai As String
    Public TakeUserName As String, TakeUType As String
    Public Sub ExporttoListView(LV As ListView)
        Dim objExcel As New Microsoft.Office.Interop.Excel.Application
        Dim bkWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim shWorkSheet As Microsoft.Office.Interop.Excel.Worksheet

        Dim i As Integer
        Dim j As Integer


        'objExcel = Ne
        'w Microsoft.Office.Interop.Excel.ApplicationClass
        bkWorkBook = objExcel.Workbooks.Add
        shWorkSheet = bkWorkBook.ActiveSheet

        Dim style As Microsoft.Office.Interop.Excel.Style = shWorkSheet.Application.ActiveWorkbook.Styles.Add("NewStyle")
        style.Font.Bold = True
        style.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.SkyBlue)

        Dim Linecount As Integer
        Linecount = 1
        For i = 0 To LV.Columns.Count - 1
            'header
            shWorkSheet.Cells(Linecount, i + 1) = LV.Columns(i).Text
            shWorkSheet.Columns(i + 1).ColumnWidth = Val(LV.Columns(i).Width) / 7.2
            shWorkSheet.Columns(i + 1).Font.Bold = True
            shWorkSheet.Columns(i + 1).Font.ColorIndex = 3
            shWorkSheet.Cells(Linecount, i + 1).style = "NewStyle"
        Next
        Linecount = Linecount + 1

        For i = 0 To LV.Items.Count - 1
            'If Mid(LV.Items(i).Text, 1, 1) = "0" Then
            '    LV.Items(i).Text = "`" & LV.Items(i).Text
            'End If
            '1st column
            shWorkSheet.Cells(i + Linecount, "A") = LV.Items(i).Text
            shWorkSheet.Cells(i + Linecount, "A").font.bold = False
            shWorkSheet.Cells(i + Linecount, "A").font.ColorIndex = 0
            For j = 1 To LV.Columns.Count - 1
                'MsgBox(LV.Items(i).SubItems(j).Text)
                'MsgBox(Chr(64 + (j + 1)))
                Try
                    'If Mid(LV.Items(i).SubItems(j).Text, 1, 1) = "0" Then
                    '    LV.Items(i).SubItems(j).Text = "'" & LV.Items(i).SubItems(j).Text
                    'End If
                    'rest of column
                    shWorkSheet.Cells(i + Linecount, j + 1) = LV.Items(i).SubItems(j).Text
                    shWorkSheet.Cells(i + Linecount, j + 1).font.bold = False
                    shWorkSheet.Cells(i + Linecount, j + 1).font.ColorIndex = 0

                Catch ex As Exception

                End Try
            Next
        Next
        objExcel.Visible = True

    End Sub
    'Sub childform(ByVal panel As Form)
    '    With Main_Form
    '        .Temp_Panel.Controls.Clear()
    '        panel.TopLevel = False
    '        .Temp_Panel.Controls.Add(panel)
    '        panel.Show()
    '    End With

    'End Sub
    Public Sub FunListviewExportToExcelCSV(ByVal LV As ListView, ByVal Takecaption As String)
        Try
            Dim FILE_NAME As String = Application.StartupPath & "\Report.CSV" '"D:\Print.txt"
            If Trim(CompanyPrintFile) = "" Then
                FILE_NAME = Application.StartupPath & "\Report.CSV"
            End If
FP:
            If System.IO.File.Exists(FILE_NAME) = False Then
                System.IO.File.Create(FILE_NAME).Dispose()
            Else
                System.IO.File.Delete(FILE_NAME)
                GoTo FP
            End If
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, True)

            Dim i As Integer
            Dim j As Integer
            Dim TakeWord As String
            TakeWord = " ," & takecompanyname
            objWriter.WriteLine(TakeWord)
            TakeWord = " ," & takeCompanyAdd1
            objWriter.WriteLine(TakeWord)
            TakeWord = " ," & takeCompanyAdd2
            objWriter.WriteLine(TakeWord)
            TakeWord = " ," & takeCompanyAdd3
            objWriter.WriteLine(TakeWord)
            TakeWord = " ," & takeCompanyContact
            objWriter.WriteLine(TakeWord)
            TakeWord = " "
            objWriter.WriteLine(TakeWord)
            TakeWord = " ," & Takecaption
            objWriter.WriteLine(TakeWord)
            TakeWord = ""
            For i = 0 To LV.Columns.Count - 1
                If Trim(TakeWord) <> "" Then
                    TakeWord = TakeWord & ","
                End If
                TakeWord = TakeWord & LV.Columns(i).Text
            Next
            objWriter.WriteLine(TakeWord)

            For i = 0 To LV.Items.Count - 1
                TakeWord = ""
                For j = 0 To LV.Columns.Count - 1
                    If j > 0 Then
                        TakeWord = TakeWord & ","
                    End If
                    TakeWord = TakeWord & Replace(LV.Items(i).SubItems(j).Text, ",", " ")
                Next
                objWriter.WriteLine(TakeWord)
            Next
            objWriter.Flush()
            objWriter.Close()

            Dim xlsWorkBook As Microsoft.Office.Interop.Excel.Workbook
            Dim xlsWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim xls As New Microsoft.Office.Interop.Excel.Application
            xlsWorkBook = xls.Workbooks.Open(FILE_NAME)
            xlsWorkSheet = xlsWorkBook.Sheets(1)


            'Dim objExcel As New Microsoft.Office.Interop.Excel.ApplicationClass
            'xlsWorkBook = xls.Workbooks.Open(resourcesFolder & fileName)
            'Dim bkWorkBook As Microsoft.Office.Interop.Excel.Workbook
            'Dim shWorkSheet As Microsoft.Office.Interop.Excel.Worksheet




            'objExcel = New Microsoft.Office.Interop.Excel.ApplicationClass
            'bkWorkBook = objExcel.Workbooks.Add
            'shWorkSheet = bkWorkBook.ActiveSheet

            Dim style As Microsoft.Office.Interop.Excel.Style = xlsWorkSheet.Application.ActiveWorkbook.Styles.Add("NewStyle")
            style.Font.Bold = True
            style.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.SkyBlue)

            Dim Linecount As Integer
            Linecount = 6
            For i = 0 To LV.Columns.Count - 1
                xlsWorkSheet.Columns(i + 1).ColumnWidth = Val(LV.Columns(i).Width) / 7.2
                '            xlsWorkSheet.Columns(i + 1).Font.Bold = True
                '           xlsWorkSheet.Columns(i + 1).Font.ColorIndex = 3
                xlsWorkSheet.Cells(Linecount, i + 1).style = "NewStyle"
            Next
            '      xlsWorkSheet.Columns(i + 1).Font.Bold = False
            '     xlsWorkSheet.Columns(i + 1).Font.ColorIndex = 0
            'Linecount = Linecount + 1
            'For i = 0 To LV.Items.Count - 1
            '    shWorkSheet.Cells(i + Linecount, "A") = LV.Items(i).Text
            '    shWorkSheet.Cells(i + Linecount, "A").font.bold = False
            '    shWorkSheet.Cells(i + Linecount, "A").font.ColorIndex = 0
            '    For j = 1 To LV.Columns.Count - 1
            '        'MsgBox(LV.Items(i).SubItems(j).Text)
            '        'MsgBox(Chr(64 + (j + 1)))
            '        shWorkSheet.Cells(i + Linecount, j + 1) = LV.Items(i).SubItems(j).Text
            '        shWorkSheet.Cells(i + Linecount, j + 1).font.bold = False
            '        shWorkSheet.Cells(i + Linecount, j + 1).font.ColorIndex = 0
            '    Next
            'Next
            xlsWorkBook.Save()
            xls.Visible = True
            'TimeSheetReports.Show()
            'TimeSheetReports.BringToFront()
            MsgBox("hello user this is the front page ")



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
