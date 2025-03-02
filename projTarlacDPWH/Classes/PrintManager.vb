Imports System.IO
Imports ClosedXML.Excel
Imports Microsoft.Office.Interop.Excel
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
        Dim data As List(Of PrintData) = New List(Of PrintData)
        Dim d As New clsDataManipulation
        With d
            If (.Fetch($"SELECT * FROM tbltransaction WHERE sn = '{sn}'")) Then
                With .DataReader
                    Do While .Read
                        data.Add(New PrintData("Time", .Item("Date").ToString))
                        data.Add(New PrintData("Transaction Number", .Item("sn").ToString))
                        data.Add(New PrintData("Supervisor", .Item("operator").ToString))
                        data.Add(New PrintData("Serial Number", "<unknown>"))
                        data.Add(New PrintData("Calibration Number", "<unknown>"))

                        data.Add(New PrintData("", ""))

                        data.Add(New PrintData("Class ID", "<unknown>"))
                        data.Add(New PrintData("Class Name", "<unknown>"))
                        data.Add(New PrintData("Class Config", "<unknown>"))
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

        Return data
    End Function

    Private Sub Create(sn As String)
        'Begin writting
        Dim r As Integer = 1
        For Each data As PrintData In GetData(sn)
            ws.Cell(r, 1).Value = data.Particular
            ws.Cell(r, 2).Value = ":"
            ws.Cell(r, 3).Value = data.Values
            r += 1
        Next

        ' Save changes
        wb.Save()
    End Sub

    Public Sub Print(sn As String)
        Create(sn)
        SendToPrinter(print_Output)
        MessageBox.Show("Print Completed!", "Print", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub SendToPrinter(filePath As String)

        If IO.File.Exists(filePath) Then
            Dim printProcess As New Process()
            printProcess.StartInfo.FileName = filePath
            printProcess.StartInfo.Verb = "Print"
            printProcess.StartInfo.CreateNoWindow = True
            printProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            printProcess.Start()
        Else
            MessageBox.Show("File not found!")
        End If
    End Sub

End Class

