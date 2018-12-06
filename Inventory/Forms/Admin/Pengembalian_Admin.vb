Public Class Pengembalian_Admin

    Private Sub Pengembalian_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        RefreshGrid()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        If Me.Width = 855 Then
            Panel1.Width = 540 + 150
            DGKembali.Width = 534 + 150
        Else
            Panel1.Width = 540
            DGKembali.Width = 534
        End If
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolPeminjaman.tampilData.ToTable
        DGKembali.DataSource = DTGrid
    End Sub

End Class