Public Class ClsEntAdmin

    Private id As Integer
    Private username As String
    Private password As String
    Private email As String
    Private active As Integer
    Private first_name As String
    Private last_name As String
    Private company As String
    Private phone As String

    Public Property IdAdmin() As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property UsernameAdmin() As String
        Get
            Return username
        End Get
        Set(value As String)
            username = value
        End Set
    End Property

    Public Property PasswordAdmin() As String
        Get
            Return password
        End Get
        Set(value As String)
            password = value
        End Set
    End Property

    Public Property EmailAdmin() As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property

    Public Property ActiveAdmin() As Integer
        Get
            Return active
        End Get
        Set(value As Integer)
            active = value
        End Set
    End Property

    Public Property First_nameAdmin() As String
        Get
            Return first_name
        End Get
        Set(value As String)
            first_name = value
        End Set
    End Property

    Public Property Last_nameAdmin() As String
        Get
            Return last_name
        End Get
        Set(value As String)
            last_name = value
        End Set
    End Property

    Public Property CompanyAdmin() As String
        Get
            Return company
        End Get
        Set(value As String)
            company = value
        End Set
    End Property

    Public Property PhoneAdmin() As String
        Get
            Return phone
        End Get
        Set(value As String)
            phone = value
        End Set
    End Property

End Class
