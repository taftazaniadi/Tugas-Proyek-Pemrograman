Imports System.Data.OleDb
Imports Inventory

Public Class ClsCtlMember : Implements InfProses

    Public Function LoginMember(NIM As String) As DataView
        Try
            DTA = New OleDbDataAdapter("SELECT * FROM member WHERE NIM = '" & NIM & "'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "cari_member")
            Dim grid As New DataView(DTS.Tables("cari_member"))

            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim data As New ClsEntMember
        data = Ob
        CMD = New OleDbCommand("INSERT INTO member VALUES('" & data.NIMMember & "', '" & data.NamaMember & "', '" & data.PasswordMember & "', '" & data.EmailMember & "', '" & data.ContactMember & "', '" & data.JurusanMember & "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Dim data As New ClsEntMember
        data = Ob
        CMD = New OleDbCommand("UPDATE member SET nama ='" & data.NamaMember & "', email = '" & data.EmailMember & "', contact = " & data.ContactMember & ", jurusan = '" & data.JurusanMember & "' WHERE NIM = '" & data.NIMMember & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        CMD = New OleDbCommand("DELETE FROM peminjaman WHERE id_peminjaman = '" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("SELECT * FROM member", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "data_member")
            Dim data As New DataView(DTS.Tables("data_member"))

            Return data
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Throw New NotImplementedException()
    End Function
End Class
