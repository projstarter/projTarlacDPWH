Public Class TestPrint
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p As New PrintManager
        p.Print(TextBox1.Text)
    End Sub

    Private Sub TestPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDB()
    End Sub
End Class