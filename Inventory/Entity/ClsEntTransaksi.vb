Public Class ClsEntTransaksi
    Private id_transaksi As String
    Private NIM As String
    Private id_barang As String
    Private tgl_pinjam As Date
    Private tgl_kembali As Date
    Private jumlah As Integer
    Private id_status_transaksi As Integer

    Public Property id_transaksiDetail() As String
        Get
            Return id_transaksi
        End Get
        Set(value As String)
            id_transaksi = value
        End Set
    End Property

    Public Property NIMDetail() As String
        Get
            Return NIM
        End Get
        Set(value As String)
            NIM = value
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

    Public Property id_status_transaksiDetail() As Integer
        Get
            Return id_status_transaksi
        End Get
        Set(value As Integer)
            id_status_transaksi = value
        End Set
    End Property

End Class
