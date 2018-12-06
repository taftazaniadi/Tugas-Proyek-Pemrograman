Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Environment.Exit(1)
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        If Sidemenu.Width = 50 Then
            logoAnimator.Hide(logo_small)
            Sidemenu.Visible = True
            Sidemenu.Width = 200
            Dashboard_Admin.Width = 705
            Peminjaman_Admin.Width = 705
            Pengembalian_Admin.Width = 705
            Pengembalian_Admin.Width = 705
            Inventaris_Admin.Width = 705
            PanelAnimator.ShowSync(Sidemenu)
            logoAnimator.ShowSync(logo)
        Else
            logoAnimator.Hide(logo)
            Sidemenu.Width = 50
            Sidemenu.Visible = False
            Dashboard_Admin.Width = 705 + 150
            Peminjaman_Admin.Width = 705 + 150
            Pengembalian_Admin.Width = 705 + 150
            Inventaris_Admin.Width = 705 + 150
            PanelAnimator.ShowSync(Sidemenu)
            logoAnimator.ShowSync(logo_small)
        End If
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        logo.Hide()
        Dashboard_Admin.Show()
        logo_small.Hide()
        logoAnimator.Show(logo)
        Me.CenterToScreen()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btnDash_Click(sender As Object, e As EventArgs) Handles btnDash.Click
        Dashboard_Admin.Show()
        Dashboard_Admin.Location = New System.Drawing.Point(0, 0)
        Peminjaman_Admin.Hide()
        Pengembalian_Admin.Hide()
        Inventaris_Admin.Hide()
    End Sub

    Private Sub btnPinjam_Click(sender As Object, e As EventArgs) Handles btnPinjam.Click
        Peminjaman_Admin.Show()
        Peminjaman_Admin.Location = New System.Drawing.Point(0, 0)
        Dashboard_Admin.Hide()
        Pengembalian_Admin.Hide()
        Inventaris_Admin.Hide()
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Pengembalian_Admin.Show()
        Pengembalian_Admin.Location = New System.Drawing.Point(0, 0)
        Dashboard_Admin.Hide()
        Peminjaman_Admin.Hide()
        Inventaris_Admin.Hide()
    End Sub

    Private Sub btnInventaris_Click(sender As Object, e As EventArgs) Handles btnInventaris.Click
        Inventaris_Admin.Show()
        Inventaris_Admin.Location = New System.Drawing.Point(0, 0)
        Dashboard_Admin.Hide()
        Peminjaman_Admin.Hide()
        Pengembalian_Admin.Hide()
    End Sub
End Class
