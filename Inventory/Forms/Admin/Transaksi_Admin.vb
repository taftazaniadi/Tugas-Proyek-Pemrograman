Public Class Transaksi_Admin

    Dim modeProses As Integer
    Dim baris As Integer

    Private Sub Peminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        RefreshGrid()
        txtID_Transaksi.Enabled = False
    End Sub

    Private Sub AturButton(st As Boolean)
        cbStatus.Enabled = st
        btnEdit.Enabled = Not st
        btnCancel.Enabled = st
        btnDelete.Enabled = st
        btnSave.Enabled = st
    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGTransaksi.Rows(br)
                txtID_Transaksi.Text = .Cells(0).Value.ToString
                cbStatus.SelectedItem = .Cells(7).Value.ToString
            End With
        End If
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolTransaksi.tampilData.ToTable
        DGTransaksi.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGTransaksi.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGTransaksi.CurrentCell = DGTransaksi.Item(1, baris)
            AturButton(False)
            IsiBox(baris)
        End If
    End Sub

    Private Sub BunifuCards1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        If Me.Width = 855 Then
            Panel1.Width = 540 + 150
            DGTransaksi.Width = 534 + 150
            GroupBox1.Width = 534 + 150
        Else
            Panel1.Width = 540
            DGTransaksi.Width = 534
            GroupBox1.Width = 534
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        AturButton(True)
        modeProses = 2
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        With EntitasTransaksi
            .id_transaksiDetail = txtID_Transaksi.Text
            .status_transaksiDetail = cbStatus.SelectedItem
        End With



        If modeProses = 1 Then
            KontrolTransaksi.InsertData(EntitasTransaksi)
        ElseIf modeProses = 2 Then
            KontrolTransaksi.updateData(EntitasTransaksi)
        End If

        MsgBox("Data has been Saved..", MsgBoxStyle.Information, "Information")
        RefreshGrid()
        modeProses = 0
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim status_referensi As Boolean
        status_referensi = KontrolBarang.cekBarangDireferensi(txtID_Transaksi.Text)

        If status_referensi Then
            MsgBox("Barang masih Digunakan/Belum Dikembalikan, tidak boleh dihapus.", MsgBoxStyle.Exclamation, "Warning!")
            Exit Sub
        End If

        If MsgBox("Apakah Anda yakin akan menghapus " & txtID_Transaksi.Text & " ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo,
                  "Konfirmasi") = MsgBoxResult.Yes Then
            KontrolTransaksi.deleteData(txtID_Transaksi.Text)
        End If
        RefreshGrid()
        modeProses = 0
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        AturButton(False)
        modeProses = 0
    End Sub

    Private Sub DGTransaksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGTransaksi.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGTransaksi.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub
End Class