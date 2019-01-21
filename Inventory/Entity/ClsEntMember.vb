Public Class ClsEntMember
    Private id_personal As Integer
    Private tipe As Char
    Private nama As String
    Private email As String
    Private contact As String
    Private jurusan As String
    Private password As String
    Private NIM As String

    Public Property id_personalMember() As String
        Get
            Return id_personal
        End Get
        Set(value As String)
            id_personal = value
        End Set
    End Property

    Public Property tipeMember() As String
        Get
            Return tipe
        End Get
        Set(value As String)
            tipe = value
        End Set
    End Property

    Public Property namaMember() As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property

    Public Property emailMember() As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property

    Public Property contactMember() As String
        Get
            Return contact
        End Get
        Set(value As String)
            contact = value
        End Set
    End Property

    Public Property jurusanMember() As String
        Get
            Return jurusan
        End Get
        Set(value As String)
            jurusan = value
        End Set
    End Property

    Public Property passwordMember() As String
        Get
            Return password
        End Get
        Set(value As String)
            password = value
        End Set
    End Property

    Public Property NIMMember() As String
        Get
            Return NIM
        End Get
        Set(value As String)
            NIM = value
        End Set
    End Property

End Class
