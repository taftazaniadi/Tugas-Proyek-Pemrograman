Imports System.Data.OleDb
Imports Inventory

Public Class ClsCtlBarang : Implements InfProses

    Function kodeBaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("SELECT MAX(RIGHT(id_barang, 4)) FROM Barang", BUKAKONEKSI)
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
            DTA = New OleDbDataAdapter("SELECT COUNT(id_barang) FROM Transaksi WHERE id_barang = '" & kunci & "'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "cek")

            If DTS.Tables("cek").Rows(0)(0).ToString > 0 Then cek = True
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return cek
    End Function

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim data As New ClsEntBarang
        data = Ob
        CMD = New OleDbCommand("INSERT INTO Barang VALUES('" & data.id_barangBarang & "', '" & data.jenisBarang & "', '" & data.namaBarang & "', '" & data.jumlahBarang & "', '" & data.statusBarang & "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Dim data As New ClsEntBarang
        data = Ob
        CMD = New OleDbCommand("UPDATE Barang SET id_jenis ='" & data.jenisBarang & "', nama_barang = '" & data.namaBarang & "', jumlah_barang = " & data.jumlahBarang & ", id_status = '" & data.statusBarang & "' WHERE id_barang = '" & data.id_barangBarang & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        CMD = New OleDbCommand("DELETE FROM Barang WHERE id_barang = '" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("SELECT b.id_barang, b.nama, j.nama, b.stock, s.nama FROM barang AS b JOIN jenis_barang AS j ON b.id_jenis = j.id_jenis JOIN status_barang AS s ON b.id_status = s.id_status", BUKAKONEKSI)
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
