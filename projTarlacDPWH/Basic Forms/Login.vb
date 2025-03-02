Public Class Login
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        End
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If (LoginMe(txtUsername.Text, txtPassword.Text)) Then
            Me.Hide()
            Dim frm As New frmMain
            frm.Show()
        Else
            MsgBox("Unable to login. Username or Password is incorrect!", MsgBoxStyle.OkOnly & MsgBoxStyle.Critical, "Login Validation")
            ClearEntry()
        End If
    End Sub

    Sub ClearEntry()
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDB()
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Call btnlogin_Click(sender, e)
        End If
    End Sub
End Class