Public Class ClsEntBarang
    Private id_barang As String
    Private nama As String
    Private jenis As String
    Private jumlah As Integer
    Private status As String

    Public Property id_barangBarang() As String
        Get
            Return id_barang
        End Get
        Set(value As String)
            id_barang = value
        End Set
    End Property

    Public Property namaBarang() As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property

    Public Property jenisBarang() As String
        Get
            Return jenis
        End Get
        Set(value As String)
            jenis = value
        End Set
    End Property

    Public Property jumlahBarang() As Integer
        Get
            Return jumlah
        End Get
        Set(value As Integer)
            jumlah = value
        End Set
    End Property

    Public Property statusBarang() As String
        Get
            Return status
        End Get
        Set(value As String)
            status = value
        End Set
    End Property

End Class
