Public Class Member
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Environment.Exit(1)
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        If Sidemenu.Width = 50 Then
            logoAnimator.Hide(logo_small)
            Sidemenu.Visible = True
            Sidemenu.Width = 200
            Dashboard.Width = 705
            Peminjaman.Width = 705
            Pengembalian.Width = 705
            PanelAnimator.ShowSync(Sidemenu)
            logoAnimator.ShowSync(logo)
        Else
            logoAnimator.Hide(logo)
            Sidemenu.Width = 50
            Sidemenu.Visible = False
            Dashboard.Width = 705 + 150
            Peminjaman.Width = 705 + 150
            Pengembalian.Width = 705 + 150
            PanelAnimator.ShowSync(Sidemenu)
            logoAnimator.ShowSync(logo_small)
        End If
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub Member_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        logo.Hide()
        logo_small.Hide()
        logoAnimator.Show(logo)
        Dashboard.Show()
        Me.CenterToScreen()
    End Sub

    Private Sub btnLog_Click_1(sender As Object, e As EventArgs) Handles btnLog.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub btnDash_Click(sender As Object, e As EventArgs) Handles btnDash.Click
        Dashboard.Show()
        Dashboard.Location = New System.Drawing.Point(0, 0)
        Peminjaman.Hide()
        Pengembalian.Hide()
    End Sub

    Private Sub btnPinjam_Click(sender As Object, e As EventArgs) Handles btnPinjam.Click
        Peminjaman.Show()
        Peminjaman.Location = New System.Drawing.Point(0, 0)
        Dashboard.Hide()
        Pengembalian.Hide()
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Pengembalian.Show()
        Pengembalian.Location = New System.Drawing.Point(0, 0)
        Dashboard.Hide()
        Peminjaman.Hide()
    End Sub
End Class