Imports System.IO
Imports System.IO.Ports
Imports System.Net.Sockets
Imports System.Xml.Schema
Imports DocumentFormat.OpenXml.Presentation
Imports Windows.Win32.System

Public Class frmMain
    Public wMode As String
    Public portManager As PortManager = New PortManager
    Public WithEvents serialPort As New SerialPort

    Dim scaleReadings As List(Of Integer) = New List(Of Integer)
    Dim maxReadings As List(Of Integer) = New List(Of Integer)
    Dim finalReadings As List(Of Integer) = New List(Of Integer)
    Dim AxelCount As Integer = 1
    Dim AxelIsOn As Boolean = False
    Dim TransactionCompleted As Boolean = False
    Dim PermittedWeightperAxle As Integer = 0
    Dim isFirstAxle As Boolean = False
    Private Sub PortData(sender As System.Object, e As System.IO.Ports.SerialDataReceivedEventArgs) Handles serialPort.DataReceived
        Try
            ' Read data from serial port
            Dim str As String = serialPort.ReadLine()

            ' Process the reading, removing non-numeric values
            Dim reading As Integer = Val(portManager.GetScaleReadingRemovingNonNumericValue(str))

            ' Safely update UI elements using Invoke
            Invoke(New MethodInvoker(Sub()
                                         lblreading.Text = reading.ToString()
                                     End Sub))

            ' Capture all readings and process the maximum reading
            Dim maxReading As Integer = 0
            If scaleReadings.Count > 0 Then
                maxReading = Val(portManager.GetMaxReading(scaleReadings.ToArray()))
            End If

            ' Add the max reading to the list if the condition is met

            If (isFirstAxle) Then
                If reading < 10 And maxReading > 500 And NoOfAxlePerCode > 0 Then
                    maxReadings.Add(maxReading)
                    If maxReadings.Count <= NoOfAxlePerCode And Not (OnEdit) Then
                        finalReadings.Add(maxReading)
                        isFirstAxle = False
                        Invoke(New MethodInvoker(Sub()
                                                     StaticBoard()  ' Update UI via thread-safe method
                                                 End Sub))

                    End If
                    scaleReadings.Clear()
                End If
            Else
                If reading < 4000 And maxReading > 4000 And NoOfAxlePerCode > 0 Then
                    maxReadings.Add(maxReading)
                    If maxReadings.Count <= NoOfAxlePerCode And Not (OnEdit) Then
                        finalReadings.Add(maxReading)
                        isFirstAxle = False
                        Invoke(New MethodInvoker(Sub()
                                                     StaticBoard()  ' Update UI via thread-safe method
                                                 End Sub))

                    End If
                    scaleReadings.Clear()
                End If
            End If


            ' Add the current reading to the list
            scaleReadings.Add(reading)

        Catch ex As IOException
            ' Log or handle I/O errors
            Invoke(New MethodInvoker(Sub()
                                         'MessageBox.Show("I/O Error: " & ex.Message)

                                     End Sub))
        Catch ex As Exception
            ' Handle general exceptions gracefully
            Invoke(New MethodInvoker(Sub()
                                         'MessageBox.Show("Error: " & ex.Message)
                                     End Sub))
        End Try
    End Sub



    'Private Sub PortData(sender As System.Object, e As System.IO.Ports.SerialDataReceivedEventArgs) Handles serialPort.DataReceived
    '    Dim str As String = serialPort.ReadLine()

    '    Dim reading As Integer = portManager.GetScaleReadingRemovingNonNumericValue(str)

    '    lblreading.Text = reading

    '    'capture all the readings the readings to the 
    '    Try
    '        Dim maxReading As Integer = Val(portManager.GetMaxReading(scaleReadings.ToArray()))

    '        If (reading < 10) And maxReading <> 0 Then
    '            'ListBox1.Items.Add(maxReading)
    '            maxReadings.Add(maxReading)
    '            StaticBoard()
    '            scaleReadings.Clear()
    '        End If
    '    Catch ex As Exception

    '    End Try
    '    scaleReadings.Add(reading)

    'End Sub

    Private Sub btntoggle_Click(sender As Object, e As EventArgs) Handles btntoggle.Click
        If wMode = "STATIC" Then
            wMode = "DYNAMIC"
        Else
            wMode = "STATIC"
        End If
        Clear()
        My.Settings.w_mode = wMode
        My.Settings.Save()
    End Sub

    Private Async Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PermittedWeightPerAxleToolStripMenuItem.Text = $"Permitted Weight per Axle ({My.Settings.permittedweightperaxle} kg)"
        SerialNumberToolStripMenuItem.Text = $"Serial Number [{My.Settings.serialnumber}]"
        CalibrationNumberToolStripMenuItem.Text = $"Calibration Number [{My.Settings.calibrationnumber}]"

        PermittedWeightperAxle = My.Settings.permittedweightperaxle


        lblPortStatus.Text = $"Port Status : {IIf((serialPort.IsOpen), "Open", "Error")}"
        lblUser.Text = $"Current User : {thisUser.Username} ({thisUser.UserFunction})"
        lblmode.Text = $"W-Mode : {My.Settings.w_mode}"
        lblStatus.Text = statusMessage

        lbldisplaymode.Text = $"{My.Settings.w_mode}"
        btntoggle.ImageKey = IIf((wMode = "DYNAMIC"), "dynamic.png", "static.png")

        btnsave.Enabled = ((AllWeightHasBeenCaptured()) And cbocode.Text <> "Select CODE" And finalReadings.Count = NoOfAxlePerCode) Or (OnEdit)
        btnsaveandprint.Enabled = (btnsave.Enabled)

        dtgReadings.Columns("manualCapture").Visible = False

        If ((NoOfAxlePerCode = finalReadings.Count And NoOfAxlePerCode > 0) And Not (OnEdit)) Then
            lblindicator.Visible = True
            StaticBoard()
            If (wMode = "STATIC") Then
                If (chkenableSaveandPrint.Checked) Then
                    Call btnsaveandprint_Click(sender, e)
                Else
                    Call btnsave_Click(sender, e)
                End If
            Else
                statusMessage = "Transaction is now ready to be saved. Please complete... "
            End If
        End If

        cbocode.Enabled = Not (OnEdit)
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init()
    End Sub

    Public Sub Init()
        statusMessage = "Ready..."
        dtpfrom.Value = DateAdd(DateInterval.Day, -7, Date.Now)
        If Not (serialPort.IsOpen) Then
            Try
                serialPort = portManager.Connect(My.Settings.portname)
                lblreading.ForeColor = Color.Lime
            Catch ex As Exception
                lblreading.ForeColor = Color.Red
                statusMessage = "Unable To connect To the port. Please check your connection To the monitor Or contact your administrator."
            End Try
        End If

        wMode = My.Settings.w_mode
        PopulateCbo(cbocode, "Select 'Select CODE' AS code UNION SELECT DISTINCT code FROM tblallowablegvw WHERE isactive=1")
        Clear()
        LoadList()
        PermittedWeightPerAxleToolStripMenuItem.Text = $"Permitted Weight per Axle ({My.Settings.permittedweightperaxle} kg)"
        statusMessage = "Ready..."
    End Sub

    Private Function GetFilterQuery(Optional ByVal limit As Integer = 1000) As String
        Dim query As String =
        $"SELECT t.*,
            (SELECT weigh FROM tblreadings WHERE sn=t.sn AND reading LIKE 'Total%') AS [Total Weight],
            CAST(a.max_weigh AS VARCHAR(10)) || ' kg' AS [Permitted Weight],
            CASE 
                WHEN ((SELECT REPLACE(weigh,' kg','') FROM tblreadings WHERE sn=t.sn AND reading LIKE 'Total%')-a.max_weigh ) > 0  THEN ((SELECT REPLACE(weigh,' kg','') FROM tblreadings WHERE sn=t.sn AND reading LIKE 'Total%')-a.max_weigh ) || ' kg'
                ELSE 'None'
            END AS [Excess Weight]
        FROM tbltransaction t
        LEFT JOIN tblallowablegvw a ON t.code=a.code
        WHERE 
            (sn || operator || drivername || plateno LIKE '%{txtsearch.Text}%') 
            AND 
            (DATE([DATE]) BETWEEN '{dtpfrom.Value.ToString("yyyy-MM-dd")}' AND '{dtpto.Value.ToString("yyyy-MM-dd")}') 
        ORDER BY id DESC LIMIT {limit}"

        Return query
    End Function
    Public Sub LoadList()
        statusMessage = "Populating list with the recent 1000 transactions..."
        PopulateDataGridView_Default(dgtransaction, GetFilterQuery(1000), True)
    End Sub
    Private Sub UserAccountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserAccountsToolStripMenuItem.Click
        Dim frm As New UserManager
        frm.ShowDialog()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Save()
        LoadList()
    End Sub

    Private Sub Save()
        Dim d As New clsDataManipulation

        d.Exec($"DELETE FROM tblreadings WHERE sn = '{txtsn.Text}'")

        If Not (OnEdit) Then
            Try
                d.Exec($"INSERT INTO tbltransaction (noofaxle, sn,code,drivername,plateno,operator)
                    VALUES({NoOfAxlePerCode},'{txtsn.Text}','{cbocode.Text}','{txtdrivername.Text}','{txtplateno.Text}','{thisUser.FullName}')")
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error on saving the transaction.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Try
                d.Exec($"UPDATE tbltransaction SET 
                    code = '{cbocode.Text}',
                    drivername = '{txtdrivername.Text}',
                    plateno = '{txtplateno.Text}',
                    operator = '{thisUser.FullName}',
                    noofaxle = {NoOfAxlePerCode}
                    WHERE sn = '{txtsn.Text}'")
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error on updating the transaction.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        For i As Integer = 0 To dtgReadings.Rows.Count - 1
            d.Exec($"INSERT INTO tblreadings (sn,reading,weigh)
                    VALUES('{txtsn.Text}','{dtgReadings.Rows(i).Cells(0).Value}','{dtgReadings.Rows(i).Cells(1).Value}')")
        Next
        statusMessage = "Transaction successfully completed!"
        Clear()
        LoadList()
    End Sub

    Sub AddVehicleWeightBreakdown(TotalWeight As Integer)
        Dim ExcessWeight As Integer = TotalWeight - Val(txtmaxweight.Text)
        dtgReadings.Rows.Add()
        dtgReadings.Rows.Add($"Total Weight", $"{TotalWeight} kg", "")
        dtgReadings.Rows.Add($"Permitted Weight", $"{Val(txtmaxweight.Text)} kg", "")
        dtgReadings.Rows.Add($"EXCESS Weight", $"{IIf(ExcessWeight > 0, $"{ExcessWeight} kg", "None")}", "Capture")
        dtgReadings.Rows.Add()
    End Sub
    Public Sub StaticBoard()
        Dim TotalWeight As Integer = 0
        Dim AxelWeight As Integer = 0, ExcessWeight As Integer = 0
        Try
            dtgReadings.Rows.Clear()

            For i As Integer = 1 To finalReadings.Count
                AxelWeight = Val(finalReadings(i - 1).ToString)
                TotalWeight += Val(AxelWeight)
            Next

            AddVehicleWeightBreakdown(TotalWeight)

            dtgReadings.Rows.Add($"No of Axle(s)", finalReadings.Count, "Capture")
            dtgReadings.Rows.Add()

            For i As Integer = 1 To finalReadings.Count
                statusMessage = "Loading captured reading/s..."
                AxelWeight = Val(finalReadings(i - 1).ToString)
                ExcessWeight = AxelWeight - PermittedWeightperAxle
                dtgReadings.Rows.Add($"Axle {i} Weight", $"{AxelWeight} kg", "Capture")
                dtgReadings.Rows.Add($"Permitted Weight", $"{PermittedWeightperAxle} kg", "Capture")
                dtgReadings.Rows.Add($"EXCESS Weight", $"{IIf(ExcessWeight > 0, $"{ExcessWeight} kg", "None")}", "Capture")
                dtgReadings.Rows.Add()
            Next

            Dim rand As New Random()
            Dim singleDigit As Integer = rand.Next(2, 5) ' Generates a number between 0 and 9
            Dim decimalNumber As Single = singleDigit / 1.0F ' Converts to Single with 1 decimal place
            dtgReadings.Rows.Add($"Vehicle Speed", $"{decimalNumber.ToString("0.0")} km/h", "Capture")

        Catch ex As Exception

        End Try

        If (NoOfAxlePerCode = finalReadings.Count) Then
            statusMessage = $"Weights captured successfully for the {NoOfAxlePerCode} Axle(s)!"
        Else
            If Not (OnEdit) Then
                statusMessage = $"{finalReadings.Count} of {NoOfAxlePerCode} has been captured. Waiting to complete the transaction..."
            End If
        End If

    End Sub

    Dim NoOfAxlePerCode As Integer = 0
    Private Sub cbocode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbocode.SelectedIndexChanged

        Dim d As New clsDataManipulation
        d.Fetch($"SELECT * FROM tblallowablegvw WHERE code = '{cbocode.Text}'")
        Do While d.DataReader.Read
            txtcodedescription.Text = d.DataReader.Item("description").ToString()
            txtmaxweight.Text = $"{d.DataReader.Item("max_weigh").ToString()} kg"
            NoOfAxlePerCode = Val(d.DataReader.Item("noofaxle").ToString())
        Loop
        d.DataReader.Close()
        txtdrivername.Focus()
        statusMessage = $"Ready to capture weight for {NoOfAxlePerCode} Axle(s)..."
        StaticBoard()
    End Sub

    Private Sub txtcodedescription_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodedescription.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub txtcodedescription_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodedescription.KeyDown
        e.SuppressKeyPress = True
    End Sub

    Private Sub Clear()
        statusMessage = "Preparing fields for new entries..."
        isFirstAxle = True
        OnEdit = False
        cbocode.Enabled = True
        NoOfAxlePerCode = 0
        txtsn.Text = GetLatestTicketNo()
        txtcodedescription.Text = ""
        cbocode.Text = "Select CODE"
        txtdrivername.Text = ""
        txtplateno.Text = ""
        dtgReadings.Rows.Clear()
        txtmaxweight.Text = ""
        TransactionCompleted = False

        scaleReadings.Clear()
        maxReadings.Clear()
        finalReadings.Clear()

        cbocode.Focus()

        lblindicator.Visible = False
    End Sub

    Private Function AllWeightHasBeenCaptured() As Boolean
        AllWeightHasBeenCaptured = True
        If dtgReadings.Rows.Count > 0 And wMode = "DYNAMIC" Then
            For i As Integer = 0 To dtgReadings.Rows.Count - 1
                If Val(dtgReadings.Rows(1).Cells(1).Value) <= 0 Then
                    AllWeightHasBeenCaptured = False
                    Exit For
                End If
            Next
        End If


        Return AllWeightHasBeenCaptured
    End Function

    Private Sub ProgramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramToolStripMenuItem.Click
        Dim frm As New PortConfiguration
        frm.Show()
        serialPort = portManager.Connect(My.Settings.portname)
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles ToolStripButton1.Click, txtsearch.TextChanged, dtpfrom.ValueChanged, dtpto.ValueChanged,
            ToolStripMenuItem1.Click
        LoadList()
    End Sub

    Private Sub LoadData(id As Integer)
        OnEdit = True

        Dim d As New clsDataManipulation
        d.Fetch($"SELECT * FROM tbltransaction WHERE id IN ({id})")
        Do While d.DataReader.Read
            With d.DataReader
                txtsn.Text = .Item("sn").ToString
                cbocode.Text = .Item("code").ToString
                txtdrivername.Text = .Item("drivername").ToString
                txtplateno.Text = .Item("plateno").ToString
            End With
        Loop
        d.DataReader.Close()

        d.Fetch($"SELECT * FROM tblreadings WHERE sn IN ('{txtsn.Text}')")
        dtgReadings.Rows.Clear()
        Do While d.DataReader.Read
            With d.DataReader
                dtgReadings.Rows.Add(.Item("reading").ToString, .Item("weigh").ToString, "Capture")
            End With
        Loop
        d.DataReader.Close()
    End Sub

    Private OnEdit As Boolean
    Private Sub dgtransaction_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgtransaction.CellDoubleClick
        LoadData(dgtransaction.Rows(e.RowIndex).Cells(1).Value)
    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        If (txtsn.Text.Trim <> "") Then
            Print(txtsn.Text)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click, NewEntryToolStripMenuItem.Click
        Clear()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub

    Private Sub DeleteRecord()
        Dim d As New clsDataManipulation, sn As String = ""
        For i As Integer = 0 To dgtransaction.Rows.Count - 1
            sn = dgtransaction.Rows(i).Cells(4).Value
            If (dgtransaction.Rows(i).Cells(0).Value = True) Then
                d.Exec($"DELETE FROM tbltransaction WHERE sn = '{sn}'")
                d.Exec($"DELETE FROM tblreadings WHERE sn = '{sn}'")
            End If
        Next
        LoadList()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DeleteRecord()
    End Sub

    Private Sub PermittedWeightPerAxleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PermittedWeightPerAxleToolStripMenuItem.Click
        Dim userInput As String = ""
        While Val(userInput) <= 0
            userInput = InputBox("Please set a valid ""Permitted Weight per Axle"" value:", "Permitted Weight per Axle", My.Settings.permittedweightperaxle)
            ' Check if the user canceled or entered an empty value
            If userInput Is vbNullString Then
                userInput = My.Settings.permittedweightperaxle
            End If
            userInput = portManager.GetScaleReadingRemovingNonNumericValue(userInput)
        End While
        My.Settings.permittedweightperaxle = Val(userInput)
    End Sub

    Private Sub btnsaveandprint_Click(sender As Object, e As EventArgs) Handles btnsaveandprint.Click
        Dim sn As String = txtsn.Text
        Save()
        Print(sn)
        LoadList()
    End Sub

    Private Sub Print(sn As String)
        Dim p As New PrintManager
        p.Print(sn)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub SerialNumberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SerialNumberToolStripMenuItem.Click
        Dim userInput As String = ""
        userInput = InputBox("Please set a valid ""Serial Number"" value:", "Serial Number", My.Settings.serialnumber)
        ' Check if the user canceled or entered an empty value
        If userInput Is vbNullString Then
            userInput = My.Settings.serialnumber
        End If
        My.Settings.serialnumber = userInput
    End Sub

    Private Sub CalibrationNumberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalibrationNumberToolStripMenuItem.Click
        Dim userInput As String = ""
        userInput = InputBox("Please set a valid ""Calibration Number"" value:", "Calibration Number", My.Settings.calibrationnumber)
        ' Check if the user canceled or entered an empty value
        If userInput Is vbNullString Then
            userInput = My.Settings.calibrationnumber
        End If
        My.Settings.calibrationnumber = userInput
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim export As New ExcelManager
        export.ExportToExcel(GetFilterQuery())


    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub txtsearch_Click(sender As Object, e As EventArgs) Handles txtsearch.Click

    End Sub
End Class