Imports MySql.Data.MySqlClient
Imports Inventory

Public Class ClsCtlAdmin : Implements InfProses

    Public Function LoginAdmin(username As String, password As String) As DataView
        Try
            da = New MySqlDataAdapter("SELECT users.id, users.username, users.password, users.email, users.active, users.first_name, users.last_name, users.company, 
                                        users.phone, users_groups.group_id FROM users JOIN users_groups ON users.id = users_groups.user_id 
                                        WHERE users.first_name = '" & username & "' AND users.password = '" & password & "'", conn)
            ds = New DataSet()
            da.Fill(ds, "cari_admin")
            Dim grid As New DataView(ds.Tables("cari_admin"))

            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function InsertData(Ob As Object) As MySqlCommand Implements InfProses.InsertData
        Throw New NotImplementedException()
    End Function

    Public Function updateData(Ob As Object) As MySqlCommand Implements InfProses.updateData
        'Dim data As New ClsEntAdmin
        'data = Ob
        'CMD = New MySqlCommand("exec UpdateData '" & data.namaAdmin & "', '" & data.EmailAdmin & "', '" & data.contactAdmin & "', '" & data.jurusanAdmin & "', 
        '                       '" & data.PasswordAdmin & "', '" & data.UsernameAdmin & "', 'null', 'A', '" & data.id_personalAdmin & "'", BUKAKONEKSI)
        'CMD.CommandType = CommandType.Text
        'CMD.ExecuteNonQuery()
        'CMD = New MySqlCommand("", TUTUPKONEKSI)
        'Return CMD
        Throw New NotImplementedException()
    End Function

    Public Function deleteData(kunci As String) As MySqlCommand Implements InfProses.deleteData
        Throw New NotImplementedException()
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        'Try
        '    DTA = New OleDbDataAdapter("SELECT p.nama, p.email, p.contact, a.username FROM personal p JOIN admin a ON 
        '                                p.id_personal = a.id_personal", BUKAKONEKSI)
        '    DTS = New DataSet()
        '    DTA.Fill(DTS, "data_admin")
        '    Dim data As New DataView(DTS.Tables("data_admin"))

        '    Return data
        'Catch ex As Exception
        '    Throw New Exception(ex.Message)
        'End Try
        Throw New NotImplementedException()
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Throw New NotImplementedException()
    End Function
End Class
