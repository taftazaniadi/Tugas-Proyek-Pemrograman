Imports MySql.Data.MySqlClient

Public Interface InfProses
    Function InsertData(Ob As Object) As MySqlCommand
    Function updateData(Ob As Object) As MySqlCommand
    Function deleteData(kunci As String) As MySqlCommand
    Function tampilData() As DataView
    Function cariData(kunci As String) As DataView
End Interface
