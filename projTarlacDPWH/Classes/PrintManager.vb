Imports System.IO
Imports System.Threading
Imports ClosedXML.Excel
Imports System.Diagnostics
Imports Excel = Microsoft.Office.Interop.Excel
Public Class PrintManager

    Private wb As XLWorkbook
    Private ws As IXLWorksheet

    Private print_Template As String = $"{ Environment.CurrentDirectory }\Print_Template.xlsx"
    Private print_Output As String = $"{ Environment.CurrentDirectory }\Print_Output.xlsx"

    Public Sub New()

        ' Delete the destination file (if file exists)
        If File.Exists(print_Output) Then
            File.Delete(print_Output)
            Console.WriteLine("File deleted successfully.")
        Else
            Console.WriteLine("File does not exist.")
        End If

        ' Copy file (if file exists)
        If File.Exists(print_Template) Then
            File.Copy(print_Template, print_Output, True) ' Overwrite if exists
            Console.WriteLine("File copied successfully!")
        Else
            Console.WriteLine("Source file does not exist.")
        End If
        ' Open existing workbook
        wb = New XLWorkbook(print_Output)
        ws = wb.Worksheet(1)


    End Sub

    Private Function GetData(sn) As List(Of PrintData)
        Dim data As List(Of PrintData) = New List(Of PrintData), code As String = ""
        Dim d As New clsDataManipulation
        With d
            If (.Fetch($"SELECT * FROM tbltransaction WHERE sn = '{sn}'")) Then
                With .DataReader
                    Do While .Read

                        data.Add(New PrintData("Time", .Item("Date").ToString))
                        data.Add(New PrintData("Transaction Number", .Item("sn").ToString))
                        data.Add(New PrintData("Supervisor", .Item("operator").ToString))
                        data.Add(New PrintData("Serial Number", My.Settings.serialnumber))
                        data.Add(New PrintData("Calibration Number", My.Settings.calibrationnumber))

                        data.Add(New PrintData("", ""))

                        data.Add(New PrintData("Class ID", .Item("plateno").ToString))
                        data.Add(New PrintData("Class Name", .Item("code").ToString))
                        code = .Item("code").ToString
                    Loop
                    .Close()
                End With
            End If

            If (.Fetch($"SELECT * FROM tblallowablegvw WHERE code = '{code}'")) Then
                With .DataReader
                    Do While .Read
                        data.Add(New PrintData("Class Config", .Item("config").ToString))
                    Loop
                    .Close()
                End With
            End If

            If (.Fetch($"Select * FROM tblreadings WHERE sn = '{sn}'")) Then
                With .DataReader
                    Do While .Read
                        data.Add(New PrintData(.Item("reading").ToString, .Item("weigh").ToString))
                    Loop
                    .Close()
                End With
            End If
        End With
        data.Add(New PrintData("", ""))
        data.Add(New PrintData("", ""))

        Return data
    End Function

    Private Sub Create(sn As String)
        'Begin writting
        Dim r As Integer = 1
        Dim colon As String = ""

        For Each data As PrintData In GetData(sn)
            colon = IIf(data.Particular = "", "", ":")
            ws.Cell(r, 1).Value = data.Particular
            ws.Cell(r, 2).Value = colon
            ws.Cell(r, 3).Value = data.Values
            r += 1
        Next

        ' Save changes
        wb.Save()

        Process.Start("cmd", "/c taskkill /f /im excel.exe")

    End Sub

    Public Sub Print(sn As String)
        Create(sn)

        SendToPrinter(print_Output)
        'SendToPrinter_viaExcel(print_Output)

        statusMessage = "Print Completed"
        'MessageBox.Show("Print Completed!", "Print", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub SendToPrinter(filePath As String)

        If IO.File.Exists(filePath) Then
            Try
                statusMessage = "Printing.... "

                Dim powerShellCommand As String = "Start-Process -FilePath '" & filePath & "' -Verb Print"
                Process.Start("powershell", $"-Command ""{powerShellCommand}""")

                'Dim printProcess As New ProcessStartInfo()
                'printProcess.FileName = filePath
                'printProcess.Verb = "print"
                'printProcess.UseShellExecute = True
                'Process.Start(printProcess)

                'Process.Start("cmd", "/c taskkill /f /im excel.exe")

            Catch ex As Exception
                MessageBox.Show($"System encountered a printer related issue. Please fix the printer configuration.{vbCrLf & vbCrLf & ex.Message }", "Print", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("File not found!")
        End If
    End Sub

    Sub SendToPrinter_viaExcel(filePath As String)
        Dim excelApp As Excel.Application = Nothing
        Dim workbook As Excel.Workbook = Nothing

        Try
            ' Create Excel application instance
            excelApp = New Excel.Application()
            excelApp.Visible = False ' Keep Excel hidden

            ' Open the Excel file
            workbook = excelApp.Workbooks.Open(filePath)

            ' Print the workbook
            workbook.PrintOut()

            ' Close the workbook without saving
            workbook.Close(False)

        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)

        Finally
            ' Quit Excel and release resources
            If workbook IsNot Nothing Then workbook = Nothing
            If excelApp IsNot Nothing Then
                excelApp.Quit()
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp)
            End If

            ' Force garbage collection
            GC.Collect()
            GC.WaitForPendingFinalizers()
        End Try

        Console.WriteLine("Printing complete.")
    End Sub

End Class

