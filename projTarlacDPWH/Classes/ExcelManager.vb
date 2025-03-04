Imports ClosedXML.Excel

Public Class ExcelManager

    Private wb As XLWorkbook
    Private ws As IXLWorksheet

    Public Sub ExportToExcel(querySelection As String)
        Dim d As New clsDataManipulation, r As Integer = 1

        Dim workbook As New XLWorkbook()

        ' Open existing workbook
        wb = New XLWorkbook()
        ws = wb.Worksheets.Add("JAAM Reports")

        With d
            If (.Fetch(querySelection)) Then
                With .DataReader
                    If (r = 1) Then
                        For x As Integer = 0 To .FieldCount - 1
                            ws.Cell(r, x + 1).Value = .GetName(x).ToString.ToUpper
                        Next
                    End If
                    r += 1
                    Do While .Read
                        For c As Integer = 0 To .FieldCount - 1
                            ws.Cell(r, c + 1).Value = .Item(c).ToString()
                        Next
                        r += 1
                    Loop
                    .Close()
                End With
            End If
        End With
        SaveAs()
    End Sub

    Public Sub SaveAs()
        ' Create a SaveFileDialog
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Excel Files|*.xlsx"
        saveFileDialog.Title = "Save Excel File"
        saveFileDialog.FileName = $"JAAM Reports - (as of {DateTime.Now.ToString("yyyy-MM-dd")}).xlsx"

        ' Show the dialog and get the selected file path
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = saveFileDialog.FileName

            Try
                ' Create and save the Excel file
                wb.SaveAs(filePath)
                MessageBox.Show("Exported completed successfuly!", "Reports", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception

            End Try

            Console.WriteLine("Excel file created successfully at: " & filePath)
        Else
            Console.WriteLine("Operation canceled by the user.")
        End If
    End Sub

End Class
