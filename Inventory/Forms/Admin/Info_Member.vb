Public Class Info_Member
    Private Sub Info_Member_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        RefreshGrid()
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolMember.tampilData.ToTable
    End Sub
End Class