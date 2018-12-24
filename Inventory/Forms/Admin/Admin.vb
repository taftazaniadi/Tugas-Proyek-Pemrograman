Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MsgBox("Are you sure to Exit?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            Environment.Exit(1)
        End If
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        If Sidemenu.Width = 50 Then
            logoAnimator.Hide(logo_small)
            Sidemenu.Visible = True
            Sidemenu.Width = 200
            Dashboard_Admin.Width = 705
            Transaksi_Admin.Width = 705
            Inventaris_Admin.Width = 705
            Info_Member.Width = 705
            PanelAnimator.ShowSync(Sidemenu)
            logoAnimator.ShowSync(logo)
        Else
            logoAnimator.Hide(logo)
            Sidemenu.Width = 50
            Sidemenu.Visible = False
            Dashboard_Admin.Width = 705 + 150
            Transaksi_Admin.Width = 705 + 150
            Inventaris_Admin.Width = 705 + 150
            Info_Member.Width = 705 + 150
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
        Transaksi_Admin.Hide()
        Inventaris_Admin.Hide()
    End Sub

    Private Sub btnPinjam_Click(sender As Object, e As EventArgs) Handles btnPinjam.Click
        Transaksi_Admin.Show()
        Transaksi_Admin.Location = New System.Drawing.Point(0, 0)
        Dashboard_Admin.Hide()
        Inventaris_Admin.Hide()
    End Sub

    Private Sub btnInventaris_Click(sender As Object, e As EventArgs) Handles btnInventaris.Click
        Inventaris_Admin.Show()
        Inventaris_Admin.Location = New System.Drawing.Point(0, 0)
        Dashboard_Admin.Hide()
        Transaksi_Admin.Hide()
    End Sub

    Private Sub btnMember_Click(sender As Object, e As EventArgs) Handles btnMember.Click
        Info_Member.Show()
        Info_Member.Location = New System.Drawing.Point(0, 0)
        Dashboard_Admin.Hide()
        Transaksi_Admin.Hide()
        Inventaris_Admin.Hide()
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        System.Diagnostics.Process.Start("http://amcc-inventory.000webhostapp.com/")
    End Sub


End Class
