Public Class Inventaris_Admin
    Private Sub Inventaris_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        RefreshGrid()
    End Sub

    Private Sub BunifuCards1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        If Me.Width = 855 Then
            Panel1.Width = 540 + 150
        Else
            Panel1.Width = 540
        End If
    End Sub

    Private Sub BunifuCustomDataGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGBarang.CellContentClick

    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolPeminjaman.tampilData.ToTable
        DGBarang.DataSource = DTGrid
    End Sub

End Class