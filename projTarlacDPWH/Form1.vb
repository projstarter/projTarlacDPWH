Imports System.IO.Ports
Imports System.Linq
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Public portManager As PortManager = New PortManager
    Public WithEvents serialPort As New SerialPort
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        serialPort = portManager.Connect("COM3")
        CheckForIllegalCrossThreadCalls = False
    End Sub

    Dim scaleReadings As List(Of Integer) = New List(Of Integer)
    Dim AxelCount As Integer = 1
    Dim AxelIsOn As Boolean = False

    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles serialPort.DataReceived
        Dim inputData As String = serialPort.ReadExisting()
        Invoke(New MethodInvoker(Sub()
                                     TextBox1.AppendText(inputData & Environment.NewLine)
                                 End Sub))
    End Sub

    'Private Sub PortData(sender As System.Object, e As System.IO.Ports.SerialDataReceivedEventArgs) Handles serialPort.DataReceived

    '    'If (AxelCount <= Val(txtNoofAxel.Text)) Then

    '    Dim str As String = serialPort.ReadLine()
    '    Dim reading As Integer = portManager.GetScaleReadingRemovingNonNumericValue(str)
    '    ListBox1.Items.Add(str)
    '    ListBox1.SelectedIndex = ListBox1.Items.Count - 1
    '    Label2.Text = reading
    '    'capture all the readings the readings to the 


    '    Try
    '        Dim maxReading As Integer = Val(portManager.GetMaxReading(scaleReadings.ToArray()))

    '        If (reading < 10) And maxReading <> 0 Then
    '            ListBox2.Items.Add(maxReading)
    '            scaleReadings.Clear()
    '        End If
    '    Catch ex As Exception

    '    End Try
    '    scaleReadings.Add(reading)

    'End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = (serialPort.IsOpen())
    End Sub
End Class
