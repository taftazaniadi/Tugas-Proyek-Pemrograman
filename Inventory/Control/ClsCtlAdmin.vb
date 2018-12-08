Imports System.Data.OleDb
Imports Inventory

Public Class ClsCtlAdmin : Implements InfProses

    Public Function LoginAdmin(username As String) As DataView
        Try
            DTA = New OleDbDataAdapter("SELECT * FROM admin WHERE username = '" & username & "'", BUKAKONEKSI)
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
        Throw New NotImplementedException()
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        Throw New NotImplementedException()
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("SELECT * FROM admin", BUKAKONEKSI)
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
