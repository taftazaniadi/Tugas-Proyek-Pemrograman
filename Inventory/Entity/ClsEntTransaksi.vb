Public Class ClsEntTransaksi
    Private id_transaksi As String
    Private id_personal As Integer
    Private id_barang As String
    Private tgl_pinjam As Date
    Private tgl_kembali As Date
    Private jumlah As Integer
    Private deskripsi As String
    Private surat As String
    Private status_transaksi As String

    Public Property id_transaksiDetail() As String
        Get
            Return id_transaksi
        End Get
        Set(value As String)
            id_transaksi = value
        End Set
    End Property

    Public Property id_personalDetail() As Integer
        Get
            Return id_personal
        End Get
        Set(value As Integer)
            id_personal = value
        End Set
    End Property

    Public Property id_barangDetail() As String
        Get
            Return id_barang
        End Get
        Set(value As String)
            id_barang = value
        End Set
    End Property

    Public Property tgl_pinjamDetail() As Date
        Get
            Return tgl_pinjam
        End Get
        Set(value As Date)
            tgl_pinjam = value
        End Set
    End Property

    Public Property tgl_kembaliDetail() As Date
        Get
            Return tgl_kembali
        End Get
        Set(value As Date)
            tgl_kembali = value
        End Set
    End Property

    Public Property jumlahDetail() As Integer
        Get
            Return jumlah
        End Get
        Set(value As Integer)
            jumlah = value
        End Set
    End Property

    Public Property deskripsiDetail() As String
        Get
            Return deskripsi
        End Get
        Set(value As String)
            deskripsi = value
        End Set
    End Property

    Public Property suratDetail() As String
        Get
            Return surat
        End Get
        Set(value As String)
            surat = value
        End Set
    End Property

    Public Property status_transaksiDetail() As String
        Get
            Return status_transaksi
        End Get
        Set(value As String)
            status_transaksi = value
        End Set
    End Property

End Class
