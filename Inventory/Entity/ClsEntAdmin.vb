Public Class ClsEntAdmin
    Private id_admin As String
    Private username As String
    Private password As String
    Private fullname As String
    Private email As String
    Private contact As String

    Public Property id_adminAdmin() As String
        Get
            Return id_admin
        End Get
        Set(value As String)
            id_admin = value
        End Set
    End Property

    Public Property usernameAdmin() As String
        Get
            Return username
        End Get
        Set(value As String)
            username = value
        End Set
    End Property

    Public Property passwordAdmin() As String
        Get
            Return password
        End Get
        Set(value As String)
            password = value
        End Set
    End Property

    Public Property fullnameAdmin() As String
        Get
            Return fullname
        End Get
        Set(value As String)
            fullname = value
        End Set
    End Property

    Public Property emailAdmin() As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property

    Public Property contactAdmin() As String
        Get
            Return contact
        End Get
        Set(value As String)
            contact = value
        End Set
    End Property

End Class
