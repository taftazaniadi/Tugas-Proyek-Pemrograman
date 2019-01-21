Public Class ClsEntBarang
    Private id_barang As String
    Private id_personal As Integer
    Private nama As String
    Private jenis As String
    Private stock As Integer
    Private satuan As String
    Private keterangan As String
    Private tempat As String
    Private status As String

    Public Property id_barangBarang() As String
        Get
            Return id_barang
        End Get
        Set(value As String)
            id_barang = value
        End Set
    End Property

    Public Property id_PersonalAdmin() As Integer
        Get
            Return id_personal
        End Get
        Set(value As Integer)
            id_personal = value
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

    Public Property stockBarang() As Integer
        Get
            Return stock
        End Get
        Set(value As Integer)
            stock = value
        End Set
    End Property

    Public Property satuanBarang() As String
        Get
            Return satuan
        End Get
        Set(value As String)
            satuan = value
        End Set
    End Property

    Public Property keteranganBarang() As String
        Get
            Return keterangan
        End Get
        Set(value As String)
            keterangan = value
        End Set
    End Property

    Public Property tempatBarang() As String
        Get
            Return tempat
        End Get
        Set(value As String)
            tempat = value
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
