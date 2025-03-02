Imports System.IO.Ports

Public Class PortConfiguration
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        With My.Settings
            .baudrate = txtbaudrate.Text
            .stopbits = txtstopbits.Text
            .databits = txtdatabits.Text
            .readtimeout = txtreadtimeout.Text
            .portname = cboportname.Text
            .Save()
        End With
    End Sub

    Public Sub LoadSettings()
        With My.Settings
            cboportname.Text = .portname
            txtreadtimeout.Text = .readtimeout
            txtbaudrate.Text = .baudrate
            txtdatabits.Text = .databits
            txtstopbits.Text = .stopbits
        End With
    End Sub
    Private Sub PortConfiguration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboportname.Items.Clear()
        For Each port As String In SerialPort.GetPortNames
            cboportname.Items.Add(port)
        Next
        LoadSettings()
    End Sub
End Class