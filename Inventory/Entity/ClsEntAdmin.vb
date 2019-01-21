Public Class ClsEntAdmin
    Private id_personal As Integer
    Private tipe As Char
    Private nama As String
    Private email As String
    Private contact As String
    Private jurusan As String
    Private password As String
    Private username As String

    Public Property id_personalAdmin() As String
        Get
            Return id_personal
        End Get
        Set(value As String)
            id_personal = value
        End Set
    End Property

    Public Property tipeAdmin() As String
        Get
            Return tipe
        End Get
        Set(value As String)
            tipe = value
        End Set
    End Property

    Public Property namaAdmin() As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
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

    Public Property jurusanAdmin() As String
        Get
            Return jurusan
        End Get
        Set(value As String)
            jurusan = value
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

    Public Property usernameAdmin() As String
        Get
            Return username
        End Get
        Set(value As String)
            username = value
        End Set
    End Property
End Class
