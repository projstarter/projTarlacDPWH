Public Class UserManager
    Public UserId As Integer = 0
    Public isFormLoaded As Boolean = False
    Private Sub UserManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
        RefreshList()
        isFormLoaded = True
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        SaveUpdateUser()
    End Sub

    Private Sub SaveUpdateUser()
        Dim d As New clsDataManipulation
        If (SaveOrUpdateConfirmation(ConvertBooleantoInt((UserId > 0) + 1))) Then
            If (UserId > 0) Then
                d.Exec($"UPDATE tbluser SET 
                        firstname = '{txtfirstname.Text}'
                        ,lastname = '{txtlastname.Text}'
                        ,username = '{txtusername.Text}'
                        ,password = '{TextEncode(FixApostrophe(txtpassword.Text))}'
                        ,role = '{cborole.Text}'
                        ,isactive = {ConvertBooleantoInt((chkactive.Checked))}
                        WHERE id IN ({UserId})"
                        )
            Else
                d.Exec($"INSERT INTO tbluser (firstname, lastname, username, password, role, isactive) 
                         VALUES ('{txtfirstname.Text}','{txtlastname.Text}', '{txtusername.Text}',  '{TextEncode(FixApostrophe(txtpassword.Text))}','{cborole.Text}',{ConvertBooleantoInt((chkactive.Checked))})"
                        )
            End If
            OperationCompleted()
            RefreshList()
            Clear()
        End If


    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Clear()
    End Sub
    Public Sub Clear()
        UserId = 0
        txtfirstname.Text = ""
        txtlastname.Text = ""
        txtusername.Text = ""
        txtpassword.Text = ""
        cborole.Text = ""
        chkactive.Checked = False


    End Sub
    Sub RefreshList()
        PopulateDataGridView_Default(dtg, $"SELECT * FROM tbluser WHERE (username LIKE '%{txtfind.Text}%' OR lastname LIKE '%{txtfind.Text}%' OR username LIKE '%{txtfind.Text}%' OR role LIKE '%{txtfind.Text}%') {IIf((Not chkactiveonly.Checked), "", "AND isactive = 1")}")
    End Sub

    Private Sub LoadUser()
        Dim d As New clsDataManipulation
        d.Fetch($"SELECT * FROM tbluser WHERE id IN ({UserId})")
        With d.DataReader
            If (d.DataReader.HasRows) Then
                Do While .Read()
                    txtfirstname.Text = .Item("firstname").ToString
                    txtlastname.Text = .Item("lastname").ToString
                    txtusername.Text = .Item("username").ToString
                    txtpassword.Text = .Item("password").ToString
                    cborole.Text = .Item("role").ToString
                    chkactive.Checked = ConvertIntToBoolean(.Item("isactive"))
                Loop
            End If
        End With
        d.DataReader.Close()
    End Sub

    Private Sub chkactiveonly_CheckedChanged(sender As Object, e As EventArgs) Handles chkactiveonly.CheckedChanged
        If Not (isFormLoaded) Then Exit Sub
        RefreshList()
    End Sub

    Private Sub txtfind_TextChanged(sender As Object, e As EventArgs) Handles txtfind.TextChanged
        RefreshList()
    End Sub

    Private Sub dtg_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg.CellDoubleClick
        UserId = dtg.Rows(e.RowIndex).Cells(0).Value
        LoadUser()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim d As New clsDataManipulation
        If (DeleteConfirmation()) Then
            d.Exec($"DELETE FROM tbluser WHERE id IN ({UserId})")
            OperationCompleted()
            RefreshList()
            Clear()
        End If

    End Sub
End Class