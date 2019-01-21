Imports System.Data.OleDb

Public Class Inventaris_Admin

    Dim modeProses As Integer
    Dim baris As Integer

    Private Sub Inventaris_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        RefreshGrid()
        txtKode.Enabled = False
    End Sub

    Private Sub BunifuCards1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        If Me.Width = 855 Then
            Panel1.Width = 540 + 150
            DGBarang.Width = 534 + 150
            GroupBox1.Width = 534 + 150
        Else
            Panel1.Width = 540
            DGBarang.Width = 534
            GroupBox1.Width = 534
        End If
    End Sub

    Private Sub AturButton(st As Boolean)
        cbJenis.Enabled = st
        txtNama.Enabled = st
        txtStock.Enabled = st
        cbStatus.Enabled = st
        cbSatuan.Enabled = st
        cbKet.Enabled = st
        cbTempat.Enabled = st
        btnAdd.Enabled = Not st
        btnEdit.Enabled = Not st
        btnCancel.Enabled = st
        btnDelete.Enabled = st
        btnSave.Enabled = st
    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGBarang.Rows(br)
                txtKode.Text = .Cells(0).Value.ToString
                txtNama.Text = .Cells(1).Value.ToString
                cbJenis.Text = .Cells(2).Value.ToString
                txtStock.Text = .Cells(3).Value.ToString
                cbSatuan.Text = .Cells(4).Value.ToString
                cbKet.Text = .Cells(5).Value.ToString
                cbTempat.Text = .Cells(6).Value.ToString
                cbStatus.Text = .Cells(7).Value.ToString
            End With
        End If
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolBarang.tampilData.ToTable
        DGBarang.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGBarang.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGBarang.CurrentCell = DGBarang.Item(1, baris)
            AturButton(False)
            IsiBox(baris)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim status_referensi As Boolean
        status_referensi = KontrolBarang.cekBarangDireferensi(txtKode.Text)

        If status_referensi Then
            MsgBox("Data masih digunakan, tidak boleh dihapus", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        If MsgBox("Apakah Anda yakin akan menghapus " & txtKode.Text & " - " & txtNama.Text & " ? ", MsgBoxStyle.Question +
                  MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            KontrolBarang.deleteData(txtKode.Text)
        End If
        RefreshGrid()
        modeProses = 0
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        AturButton(True)
        modeProses = 2
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AturButton(True)
        modeProses = 1
        txtKode.Text = KontrolBarang.kodeBaru()
        txtNama.Text = ""
        txtStock.Text = ""
        cbJenis.SelectedIndex = 0
        cbSatuan.SelectedIndex = 0
        cbKet.SelectedIndex = 0
        cbTempat.SelectedIndex = 0
        cbStatus.SelectedIndex = 0
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        AturButton(False)
        modeProses = 0
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        With EntitasBarang
            .id_barangBarang = txtKode.Text
            .id_PersonalAdmin = EntitasAdmin.id_personalAdmin.ToString
            .namaBarang = txtNama.Text
            .jenisBarang = cbJenis.SelectedItem
            .stockBarang = txtStock.Text
            .satuanBarang = cbSatuan.SelectedItem
            .keteranganBarang = cbKet.SelectedItem
            .tempatBarang = cbTempat.SelectedItem
            .statusBarang = cbStatus.SelectedItem
        End With

        If modeProses = 1 Then
            KontrolBarang.InsertData(EntitasBarang)
        ElseIf modeProses = 2 Then
            KontrolBarang.updateData(EntitasBarang)
        End If

        MsgBox("Data has been Saved..", MsgBoxStyle.Information, "Information")
        RefreshGrid()
        modeProses = 0
    End Sub

    Private Sub DGBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGBarang.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGBarang.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub

End Class