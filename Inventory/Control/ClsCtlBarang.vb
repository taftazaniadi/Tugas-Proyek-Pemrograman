Imports System.Data.OleDb
Imports Inventory

Public Class ClsCtlBarang : Implements InfProses

    Function kodeBaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("SELECT MAX(RIGHT(id_barang, 4)) FROM barang", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "B" & Strings.Right("000" & kodeakhir + 1, 4)

            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Function cekBarangDireferensi(kunci As String) As Boolean
        Dim cek As Boolean
        cek = False

        Try
            DTA = New OleDbDataAdapter("SELECT COUNT(id_barang) FROM transaksi WHERE id_barang = '" & kunci & "'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "cek")

            If DTS.Tables("cek").Rows(0)(0).ToString > 0 Then cek = True
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return cek
    End Function

    Function cekStock(kunci As String) As Integer
        Dim stock As Integer

        Try
            DTA = New OleDbDataAdapter("SELECT stock FROM barang WHERE id_barang = '" & kunci & "'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "stock")
            stock = Val(DTS.Tables("stock").Rows(0).Item(0))

            Return stock
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim data As New ClsEntBarang
        data = Ob
        CMD = New OleDbCommand("INSERT INTO barang VALUES('" & data.id_barangBarang & "', '1', '" & data.namaBarang & "', 
                               '" & data.jenisBarang & "', '" & data.stockBarang & "', '" & data.satuanBarang & "', 
                               '" & data.keteranganBarang & "', '" & data.tempatBarang & "', '" & data.statusBarang & "')",
                               BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Dim data As New ClsEntBarang
        data = Ob
        CMD = New OleDbCommand("UPDATE barang SET nama_barang = '" & data.namaBarang & "', jenis_barang ='" & data.jenisBarang & "', 
                                stock = '" & data.stockBarang & "', satuan = '" & data.satuanBarang & "', keterangan = 
                                '" & data.keteranganBarang & "', tempat = '" & data.tempatBarang & "', status_barang = 
                                '" & data.statusBarang & "' WHERE id_barang = '" & data.id_barangBarang & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        CMD = New OleDbCommand("DELETE FROM barang WHERE id_barang = '" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("SELECT id_barang as 'ID Barang', nama_barang as 'Nama Barang', jenis_barang as 'Jenis Barang', stock as 'Stock Barang', pinjam as 'Jumlah yang dipinjam', 
                                        satuan as 'Satuan', keterangan as 'Keterangan', tempat as 'Lokasi Barang', status_barang as 'Kondisi Barang' FROM barang", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Barang")
            Dim grid As New DataView(DTS.Tables("Tabel_Barang"))

            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Throw New NotImplementedException()
    End Function

End Class
