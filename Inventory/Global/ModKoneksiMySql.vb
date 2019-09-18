Imports MySql.Data.MySqlClient

Module ModuleKoneksiMySQL

    Public conn As MySqlConnection
    Public cmd As New MySqlCommand
    Public rd As MySqlDataReader
    Public da As New MySqlDataAdapter
    Public ds As New DataSet
    Public dtt As New DataTable
    Public dtg As New DataTable
    Public str As String

    Sub koneksi()
        Try
            Dim str As String = "Server=localhost;user id=root;database=krt"

            conn = New MySqlConnection(str)

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module