Imports System.Data.OleDb
Imports Inventory

Public Class ClsCtlMember : Implements InfProses
    Public Function LoginMember(NIM As String, password As String) As DataView
        Try
            DTA = New OleDbDataAdapter("SELECT p.*, m.NIM FROM personal p JOIN member m ON p.id_personal = m.id_personal WHERE 
                                        m.NIM = '" & NIM & "' AND p.password = '" & password & "'", BUKAKONEKSI)
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
        CMD = New OleDbCommand("EXEC InsertPersonal 'M', '" & data.namaMember & "', '" & data.emailMember & "', 
                               '" & data.contactMember & "', '" & data.jurusanMember & "', '" & data.passwordMember & "', '', 
                               '" & data.NIMMember & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Dim data As New ClsEntMember
        data = Ob
        CMD = New OleDbCommand("EXEC UpdatePersonal 'M', '" & data.namaMember & "', '" & data.emailMember & "', 
                               '" & data.contactMember & "', '" & data.jurusanMember & "', '" & data.passwordMember & "', '', 
                               WHERE NIM = '" & data.NIMMember & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        CMD = New OleDbCommand("DELETE FROM member WHERE NIM = '" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("SELECT m.NIM, p.nama, p.password, p.email, p.contact, p.jurusan FROM personal p JOIN member m 
                                        ON p.id_personal = m.id_personal", BUKAKONEKSI)
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
