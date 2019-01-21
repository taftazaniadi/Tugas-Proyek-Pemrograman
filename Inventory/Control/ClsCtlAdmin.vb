Imports System.Data.OleDb
Imports Inventory

Public Class ClsCtlAdmin : Implements InfProses

    Public Function LoginAdmin(username As String, password As String) As DataView
        Try
            DTA = New OleDbDataAdapter("SELECT p.*,a.username FROM personal p JOIN admin a ON p.id_personal = a.id_personal
                                        WHERE a.username = '" & username & "' AND p.password = '" & password & "'",
                                        BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "cari_admin")
            Dim grid As New DataView(DTS.Tables("cari_admin"))

            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Throw New NotImplementedException()
    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Dim data As New ClsEntAdmin
        data = Ob
        CMD = New OleDbCommand("UPDATE admin a SET a.username ='" & data.usernameAdmin & "', p.nama = '" & data.namaAdmin &
                               "', p.email = '" & data.emailAdmin & "', p.contact = '" & data.contactAdmin & "' JOIN 
                               personal p ON a.id_personal = p.id_personal WHERE a.id_personal = '" & data.id_personalAdmin & "'",
                               BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        Throw New NotImplementedException()
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("SELECT p.nama, p.email, p.contact, a.username FROM personal p JOIN admin a ON 
                                        p.id_personal = a.id_personal", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "data_admin")
            Dim data As New DataView(DTS.Tables("data_admin"))

            Return data
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Throw New NotImplementedException()
    End Function
End Class
