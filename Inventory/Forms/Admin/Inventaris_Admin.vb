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
        DTGrid = KontrolBarang.tampilData.ToTable
        DGBarang.DataSource = DTGrid
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim status_referensi As Boolean
        status_referensi = KontrolBarang.cekBarangDireferensi(txtKode.Text)

        If status_referensi Then
            MsgBox("Data masih digunakan, tidak boleh dihapus", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        If MsgBox("Apakah Anda yakin akan menghapus " & txtKode.Text & " - " & txtNama.Text & " ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            KontrolBarang.deleteData(txtKode.Text)
        End If
        RefreshGrid()
    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGBarang.Rows(br)
                txtKode.Text = .Cells(0).Value.ToString
                cbJenis.Text = .Cells(1).Value.ToString
                txtNama.Text = .Cells(2).Value.ToString
                txtStock.Text = .Cells(3).Value.ToString
                cbStatus.Text = .Cells(4).Value.ToString
            End With
        End If
    End Sub
End Class