Imports Excel = Microsoft.Office.Interop.Excel

Module PrintManager1
    Public Sub PrepPrint(sn As String)
        thisTransanction = New Transaction
        Dim stock_condition As String = ""
        Dim d As New clsDataManipulation
        With d
            If (.Fetch($"SELECT * FROM tbltransaction WHERE sn = '{sn}")) Then
                With .DataReader
                    Do While .Read
                        thisTransanction.sn = .Item("sn").ToString
                        thisTransanction.id = .Item("id").ToString
                        thisTransanction.capturedate = .Item("date").ToString
                        thisTransanction.driver = .Item("drivername").ToString
                        thisTransanction.plateno = .Item("plateno").ToString
                    Loop
                    .Close()
                End With
            End If
            If (.Fetch($"SELECT * FROM tblreadings WHERE sn = '{sn}")) Then
                With .DataReader
                    Do While .Read
                        Dim Readings As CapturedWeigh = New CapturedWeigh
                        Readings.particular = .Item("reading").ToString
                        Readings.weight = .Item("weigh").ToString
                        thisTransanction.Readings.Add(Readings)
                    Loop
                    .Close()
                End With
            End If
        End With
    End Sub
    Public Sub Print(sn As String)

        PrepPrint(sn)

        Dim template As String = Environment.CurrentDirectory & "\_Print_Master.xlsx"
        Dim thisOne As String = ""
        thisOne = Environment.CurrentDirectory & "\_Print.xlsx"

        ' delete the file first
        Try
            Kill(thisOne)
        Catch ex As Exception

        End Try


        ' preparation of the transaction information
        Dim xlApp As Excel.Application = New Excel.Application
        xlApp.DisplayAlerts = False
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        xlWorkBook = xlApp.Workbooks.Open(template)
        xlWorkSheet = xlWorkBook.Worksheets(1)

        With thisTransanction
            xlWorkSheet.UsedRange.Replace("jaam_sn", .sn)
            xlWorkSheet.UsedRange.Replace("jaam_date", .capturedate)
            xlWorkSheet.UsedRange.Replace("jaam_driver", .driver)
            xlWorkSheet.UsedRange.Replace("jaam_plate", .plateno)
            xlWorkSheet.UsedRange.Replace("jaam_code", .code)
        End With

        xlWorkBook.SaveAs(thisOne)

        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)

        BeginPrint(thisOne)

    End Sub

    Private Sub BeginPrint(the_file As String)
        Dim monProcess As New Process()
        monProcess.StartInfo.FileName = the_file
        monProcess.StartInfo.Verb = "Print"
        monProcess.StartInfo.CreateNoWindow = True
        monProcess.Start()

        Process.Start("cmd", "/c taskkill /f /im excel.exe")

    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

End Module
