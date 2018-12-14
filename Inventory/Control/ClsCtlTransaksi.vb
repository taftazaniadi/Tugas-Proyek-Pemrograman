Imports System.Data.OleDb
Imports Inventory

Public Class ClsCtlTransaksi : Implements InfProses

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim data As New ClsEntTransaksi
        data = Ob
        CMD = New OleDbCommand("INSERT INTO transaksi VALUES('" & data.id_transaksiDetail & "', '" & data.NIMDetail & "', '" & data.id_barangDetail & "', '" & data.tgl_pinjamDetail & "', '" & data.tgl_kembaliDetail & "', '" & data.jumlahDetail & "', '" & data.id_status_transaksiDetail & "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Dim data As New ClsEntTransaksi
        data = Ob
        CMD = New OleDbCommand("UPDATE transaksi SET id_status_transaksi = '" & data.id_status_transaksiDetail & "' WHERE id_transaksi = '" & data.id_transaksiDetail & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        CMD = New OleDbCommand("DELETE FROM transaksi WHERE id_transaksi = '" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("SELECT * FROM Transaksi", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Transaksi")
            Dim grid As New DataView(DTS.Tables("Tabel_Transaksi"))

            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Throw New NotImplementedException()
    End Function
End Class
