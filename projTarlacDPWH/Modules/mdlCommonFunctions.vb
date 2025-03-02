Imports System.Windows.Forms
Imports System.Security.Cryptography.RNGCryptoServiceProvider
Imports System.Diagnostics.Eventing
Imports System.Data.SqlClient
Imports System.Runtime.ConstrainedExecution
Imports System.CodeDom.Compiler


Module mdlCommonFunctions
    Public Function FixApostrophe(str As String)
        Return Replace(FixSpaces(str), "'", "''")
    End Function
    Public Function FixSpaces(str As String)
        If str = "" Then Return ""
        Return Replace(str, "  ", " ").Trim
    End Function
    Public Function TextEncode(str As String)
        Dim wrapper As New Simple3Des("dpcondes")
        Return wrapper.EncryptData(str)
    End Function
    Public Function TextDecode(str As String)
        Dim wrapper As New Simple3Des("dpcondes")
        Return wrapper.DecryptData(str)
    End Function

    Public Function TruncateDecimal(ByVal val As Decimal, len As Integer) As String
        If (val.ToString().Contains(".")) Then
            Try
                Return val.ToString.Substring(0, val.ToString.IndexOf(".")) & val.ToString.Substring(val.ToString.IndexOf("."), len + 1)
            Catch ex As Exception
                Try
                    Return val.ToString.Substring(0, val.ToString.IndexOf(".")) & val.ToString.Substring(val.ToString.IndexOf("."), len)
                Catch e As Exception
                    Return val
                End Try
            End Try
        Else
            Return val
        End If
    End Function
    Public Sub PopulateCbo(cbo As ComboBox, cmdText As String)
        cbo.Items.Clear()
        Dim d As New clsDataManipulation
        With d
            If (.Fetch(cmdText)) Then
                With .DataReader
                    Do While .Read
                        cbo.Items.Add(.Item(0).ToString())
                    Loop
                    .Close()
                End With

            End If
        End With
    End Sub

    Public Sub PopulateCbo(cbo As ComboBox, srcTable As String, srcField As String)
        cbo.Items.Clear()
        Dim d As New clsDataManipulation
        With d
            If (.Fetch("SELECT DISTINCT TRIM(" & srcField & ") FROM " & srcTable & " ORDER BY 1 ASC")) Then
                With .DataReader
                    Do While .Read
                        cbo.Items.Add(.Item(0).ToString())
                    Loop
                    .Close()
                End With

            End If
        End With
    End Sub

    Public Sub PopulateCbo(cbo As ComboBox, srcTable As String, srcField As String, whereClause As String)
        cbo.Items.Clear()
        Dim d As New clsDataManipulation
        With d
            If (.Fetch("SELECT DISTINCT TRIM(" & srcField & ") FROM " & srcTable & " WHERE " & whereClause & " ORDER BY 1 ASC")) Then
                With .DataReader
                    Do While .Read
                        cbo.Items.Add(.Item(0).ToString())
                    Loop
                    .Close()
                End With

            End If
        End With
    End Sub

    Public Sub PopulateDataGridView(dtg As DataGridView, querySelection As String, Optional withCheckbox As Boolean = False)

        If dtg.ColumnCount > 0 Then

            'clear DataGridView
            dtg.Rows.Clear()

            Dim d As New clsDataManipulation
            With d
                If (.Fetch(querySelection)) Then
                    With .DataReader
                        Do While .Read
                            Dim newRow_Index As Integer = dtg.Rows.Add() ' get the index of the newly added row
                            Dim newRow As DataGridViewRow = dtg.Rows(newRow_Index) ' get the newly added row

                            ' this will determine what index the populating will start
                            Dim startIndex As Integer = 0
                            If (withCheckbox) Then
                                startIndex = 1
                                newRow.Cells(0).Value = 0
                            End If

                            'begin the population of the DataGridViewRow
                            For col As Integer = 0 To .FieldCount - 1
                                newRow.Cells(IIf((withCheckbox), col + 1, col)).Value = .Item(col).ToString
                            Next
                        Loop
                        .Close()
                    End With

                End If
            End With


        End If

    End Sub

    Public Function ConvertIntToBoolean(i As Integer) As Boolean
        Return (i > 0)
    End Function

    Public Function ConvertBooleantoInt(val As Boolean) As Integer
        Return IIf((val), 1, 0)
    End Function

    Public Sub PopulateDataGridView_Default(dg As DataGridView, selection As String, Optional withCheckBoxColumn As Boolean = False)
        dg.Rows.Clear()
        dg.Columns.Clear()

        Dim ctr As Integer = 0
        Dim d As clsDataManipulation = New clsDataManipulation()
        d.Fetch(selection)

        'generate the datagrid view column
        Dim schemaTable As DataTable = d.DataReader.GetSchemaTable()
        Dim columnNames As List(Of String) = New List(Of String)

        For Each row As DataRow In schemaTable.Rows
            dg.Columns.Add($"col_{ctr}", row("ColumnName").ToString().ToUpper())
            dg.Columns($"col_{ctr}").ReadOnly = True
            ctr += 1

        Next

        Do While d.DataReader.Read
            Dim r = dg.Rows.Add()
            For i As Integer = 0 To d.DataReader.FieldCount - 1
                dg.Rows(r).Cells(i).Value = d.DataReader(i).ToString()
            Next
        Loop

        d.DataReader.Close()
        If (withCheckBoxColumn) Then
            Dim checkBoxColumn As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn()
            checkBoxColumn.Name = "checkBoxColumn"
            checkBoxColumn.HeaderText = ""
            checkBoxColumn.TrueValue = True
            checkBoxColumn.FalseValue = False
            checkBoxColumn.IndeterminateValue = False
            dg.Columns.Insert(0, checkBoxColumn)
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            dg.Columns("checkBoxColumn").ReadOnly = False
        End If

        'Using (SqlDataReader reader = d.ExecuteReader(selection))
        '    {


        '        While (reader.Read())
        '        {
        '         
        '        }
        '        Reader.Close();
        '        If (withCheckBoxColumn) Then
        '                        {
        '            DataGridViewCheckBoxColumn checkBoxColumn = New DataGridViewCheckBoxColumn();
        '            checkBoxColumn.Name = "checkBoxColumn";
        '            checkBoxColumn.HeaderText = "";
        '            checkBoxColumn.TrueValue = True;
        '            checkBoxColumn.FalseValue = False;
        '            checkBoxColumn.IndeterminateValue = False;
        '            dg.Columns.Insert(0, checkBoxColumn);
        '            //dg.Columns.Add(dataGridViewCheckBoxColumn);
        '            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        '        }
        '    }
    End Sub
    Public Function SaveOrUpdateConfirmation(op As Integer) As Boolean
        Return (MessageBox.Show($"Are you sure you want to {IIf(op = 1, "SAVE", "UPDATE")} the current information?", "Save / Update Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
    End Function

    Public Function DeleteConfirmation() As Boolean
        Return (MessageBox.Show($"Are you sure you want to DELETE this information in the system?", "Delete Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning))
    End Function

    Public Sub OperationCompleted()
        MessageBox.Show("Operation completed successfully!", "Operation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Function GetOrdinalValue(ByVal number As Integer) As String
        Dim suffix As String = "th"
        Dim ones As Integer = number Mod 10
        Dim tens As Integer = (number \ 10) Mod 10

        ' Handle special cases for 11, 12, 13
        If tens <> 1 Then
            Select Case ones
                Case 1
                    suffix = "st"
                Case 2
                    suffix = "nd"
                Case 3
                    suffix = "rd"
            End Select
        End If

        Return number.ToString() & suffix
    End Function
End Module
