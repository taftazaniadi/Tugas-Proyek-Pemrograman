Public Class Transaksi_Admin
    Private Sub Peminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        RefreshGrid()
    End Sub

    Private Sub BunifuCards1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        If Me.Width = 855 Then
            Panel1.Width = 540 + 150
            DGTransaksi.Width = 534 + 150
        Else
            Panel1.Width = 540
            DGTransaksi.Width = 534
        End If
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolTransaksi.tampilData.ToTable
        DGTransaksi.DataSource = DTGrid
    End Sub

End Class