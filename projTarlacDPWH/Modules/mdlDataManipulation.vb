Imports System.Data.SQLite
Module mdlDataManipulation
    Public conn As New SQLiteConnection

    Public statusMessage As String
    Public Sub ConnectDB()
        conn.ConnectionString = $"Data Source={ Environment.CurrentDirectory }\projstarter.db"
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox("Database connection failed!" & vbNewLine & vbNewLine & "ERROR: " & ex.Message,
                   MessageBoxIcon.Exclamation & MessageBoxButtons.OK, "ConnectDB()")
        End Try
    End Sub


    Public Function LoginMe(uname As String, pw As String) As Boolean

        'If Not (AppIsLicensed()) Then
        '    MessageBox.Show("You have reach the allowed usage of this app. Contact your administrator for the activation of this application. Thank you!", "License Validation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    End
        'End If

        'My.Settings.Use_Counter += 1
        My.Settings.Save()

        Dim found As Boolean = False
        If (FixSpaces(uname) = "" Or FixSpaces(pw) = "") Then Return False

        Dim unameConverted As String = FixApostrophe(uname)
        Dim pwConverted As String = TextEncode(FixApostrophe(pw))
        Dim strSelect As String = "SELECT * FROM tbluser WHERE (username='" & unameConverted & "' AND password='" & pwConverted & "') AND isactive>0"

        Dim d As New clsDataManipulation
        With d
            If (.Fetch(strSelect)) Then
                With .DataReader
                    Do While .Read
                        found = True
                        thisUser.Lastname = .Item("lastname").ToString()
                        thisUser.Firstname = .Item("firstname").ToString()
                        thisUser.Username = .Item("username").ToString()
                        thisUser.UserFunction = .Item("role").ToString()
                        thisUser.IsAdmin = (.Item("role").ToString() = "Administrator" Or .Item("role").ToString() = "Super Administrator")
                        thisUser.IsSuperAdmin = (.Item("role").ToString() = "Super Administrator")
                        thisUser.FullName = String.Format("{0}, {1}", .Item("lastname").ToString(), .Item("firstname").ToString())
                    Loop
                    .Close()
                End With
            End If
        End With

        Return found
    End Function

    Public Function GetLatestTicketNo() As String
        GetLatestTicketNo = 0
        Dim d As New clsDataManipulation
        With d
            If (.Fetch("SELECT MAX(id) FROM tbltransaction")) Then
                With .DataReader
                    Do While .Read
                        GetLatestTicketNo = Val(.Item(0).ToString)
                    Loop
                    .Close()
                End With
            Else
                GetLatestTicketNo = 0
            End If
        End With

        Return FormatTicketNo(GetLatestTicketNo)

    End Function


    Public Function FormatTicketNo(tval As String) As String
        tval = Val(tval) + 1
        FormatTicketNo = ""
        For i As Integer = Len(tval) + 1 To 8
            FormatTicketNo &= "0"
        Next
        FormatTicketNo = FormatTicketNo & tval
        Return FormatTicketNo
    End Function

End Module
