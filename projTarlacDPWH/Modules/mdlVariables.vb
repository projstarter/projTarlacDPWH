Imports System.Windows.Forms
Module mdlVariables
    Public thisUser As New CurrentUser
    Public thisTransanction As Transaction
    Public Enum MessageBoxType
        _Error = MessageBoxIcon.Error
        _Info = MessageBoxIcon.Information
    End Enum
    Public Structure CurrentUser
        Public FullName
        Public Username
        Public Firstname
        Public Lastname
        Public Nickname
        Public UserFunction
        Public IsAdmin As Boolean
        Public IsSuperAdmin As Boolean
    End Structure

    Public Structure PrintData
        Public Particular As String
        Public Values As String

        Public Sub New(p As String, v As String)
            Particular = p
            Values = v
        End Sub
    End Structure

    Public Structure Transaction
        Public id
        Public sn
        Public capturedate
        Public code
        Public description
        Public driver
        Public plateno
        Public Customer
        Public Readings As List(Of CapturedWeigh)
    End Structure
    Public Structure CapturedWeigh
        Public particular
        Public weight
    End Structure

    Public Structure InsertParameters
        Public FieldName
        Public Value
    End Structure

End Module
