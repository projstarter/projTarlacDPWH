Imports System.IO.Ports
Imports System.Text.RegularExpressions

Public Class PortManager

    Public Function Connect(COM As String) As SerialPort
        Dim serialPort As New SerialPort
        With serialPort
            .PortName = COM
            .BaudRate = 9600
            .Parity = Parity.None
            .DataBits = 8
            .StopBits = StopBits.One
            .ReadTimeout = 1000
            .Encoding = System.Text.Encoding.ASCII
        End With

        Try
            statusMessage = $"Please wait while the program is trying to connect to port {My.Settings.portname}"
            serialPort.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return serialPort
    End Function

    Public Function GetScaleReadingRemovingNonNumericValue(ByVal strText As String) As String
        Return Regex.Replace(strText, "[^\d]", "")
    End Function

    Public Function GetMaxReading(readings() As Integer) As Integer
        Dim maxValue As Integer = 0
        If readings.Length > 0 Then
            maxValue = readings.Max()
        End If

        Return maxValue
    End Function


End Class
