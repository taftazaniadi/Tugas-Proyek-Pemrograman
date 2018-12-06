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
