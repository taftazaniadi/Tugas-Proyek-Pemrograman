Public Class Member
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
            Dashboard.Width = 705
            Transaksi.Width = 705
            PanelAnimator.ShowSync(Sidemenu)
            logoAnimator.ShowSync(logo)
        Else
            logoAnimator.Hide(logo)
            Sidemenu.Width = 50
            Sidemenu.Visible = False
            Dashboard.Width = 705 + 150
            Transaksi.Width = 705 + 150
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
        Transaksi.Hide()
    End Sub

    Private Sub btnPinjam_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        Transaksi.Show()
        Transaksi.Location = New System.Drawing.Point(0, 0)
        Dashboard.Hide()
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://new-learn.000webhostapp.com/")
    End Sub
End Class