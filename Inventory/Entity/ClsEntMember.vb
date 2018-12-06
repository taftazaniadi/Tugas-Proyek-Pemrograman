Public Class ClsEntMember
    Private NIM As String
    Private Nama As String
    Private Password As String
    Private Jurusan As String
    Private Contact As Integer
    Private Email As String

    Public Property NIMMember() As String
        Get
            Return NIM
        End Get
        Set(value As String)
            NIM = value
        End Set
    End Property

    Public Property NamaMember() As String
        Get
            Return Nama
        End Get
        Set(value As String)
            Nama = value
        End Set
    End Property

    Public Property PasswordMember() As String
        Get
            Return Password
        End Get
        Set(value As String)
            Password = value
        End Set
    End Property

    Public Property JurusanMember() As String
        Get
            Return Jurusan
        End Get
        Set(value As String)
            Jurusan = value
        End Set
    End Property

    Public Property ContactMember() As Integer
        Get
            Return Contact
        End Get
        Set(value As Integer)
            Contact = value
        End Set
    End Property

    Public Property EmailMember() As String
        Get
            Return Email
        End Get
        Set(value As String)
            Email = value
        End Set
    End Property

End Class
