Public Class Peminjaman_Admin
    Private Sub Peminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        RefreshGrid()
    End Sub

    Private Sub BunifuCards1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        If Me.Width = 855 Then
            Panel1.Width = 540 + 150
            DGPinjam.Width = 534 + 150
        Else
            Panel1.Width = 540
            DGPinjam.Width = 534
        End If
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolPeminjaman.tampilData.ToTable
    End Sub

End Class