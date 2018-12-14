<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transaksi))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1 = New Bunifu.Framework.UI.BunifuCards()
        Me.DGPinjam = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_peminjaman = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NIM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tgl_pinjam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tgl_kembali = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DGPinjam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderRadius = 5
        Me.Panel1.BottomSahddow = True
        Me.Panel1.color = System.Drawing.Color.Tomato
        Me.Panel1.Controls.Add(Me.DGPinjam)
        Me.Panel1.LeftSahddow = False
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.RightSahddow = True
        Me.Panel1.ShadowDepth = 20
        Me.Panel1.Size = New System.Drawing.Size(540, 494)
        Me.Panel1.TabIndex = 0
        '
        'DGPinjam
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DGPinjam.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGPinjam.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DGPinjam.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGPinjam.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGPinjam.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGPinjam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPinjam.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.id_peminjaman, Me.NIM, Me.id_barang, Me.tgl_pinjam, Me.tgl_kembali, Me.jumlah, Me.id_status})
        Me.DGPinjam.DoubleBuffered = True
        Me.DGPinjam.EnableHeadersVisualStyles = False
        Me.DGPinjam.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.DGPinjam.HeaderForeColor = System.Drawing.Color.White
        Me.DGPinjam.Location = New System.Drawing.Point(3, 7)
        Me.DGPinjam.Name = "DGPinjam"
        Me.DGPinjam.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGPinjam.Size = New System.Drawing.Size(534, 484)
        Me.DGPinjam.TabIndex = 1
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Add Data"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(558, 12)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(135, 48)
        Me.BunifuFlatButton1.TabIndex = 1
        Me.BunifuFlatButton1.Text = "Add Data"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'no
        '
        Me.no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.no.HeaderText = "No."
        Me.no.Name = "no"
        Me.no.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.no.Width = 51
        '
        'id_peminjaman
        '
        Me.id_peminjaman.HeaderText = "ID Peminjaman"
        Me.id_peminjaman.Name = "id_peminjaman"
        '
        'NIM
        '
        Me.NIM.HeaderText = "NIM"
        Me.NIM.Name = "NIM"
        '
        'id_barang
        '
        Me.id_barang.HeaderText = "Nama Barang"
        Me.id_barang.Name = "id_barang"
        '
        'tgl_pinjam
        '
        Me.tgl_pinjam.HeaderText = "Tanggal Peminjaman"
        Me.tgl_pinjam.Name = "tgl_pinjam"
        '
        'tgl_kembali
        '
        Me.tgl_kembali.HeaderText = "Tanggal Kembali"
        Me.tgl_kembali.Name = "tgl_kembali"
        '
        'jumlah
        '
        Me.jumlah.HeaderText = "Jumlah"
        Me.jumlah.Name = "jumlah"
        '
        'id_status
        '
        Me.id_status.HeaderText = "Status"
        Me.id_status.Name = "id_status"
        '
        'Peminjaman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(705, 518)
        Me.Controls.Add(Me.BunifuFlatButton1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Peminjaman"
        Me.Text = "Peminjaman"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DGPinjam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents DGPinjam As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents id_peminjaman As DataGridViewTextBoxColumn
    Friend WithEvents NIM As DataGridViewTextBoxColumn
    Friend WithEvents id_barang As DataGridViewTextBoxColumn
    Friend WithEvents tgl_pinjam As DataGridViewTextBoxColumn
    Friend WithEvents tgl_kembali As DataGridViewTextBoxColumn
    Friend WithEvents jumlah As DataGridViewTextBoxColumn
    Friend WithEvents id_status As DataGridViewTextBoxColumn
End Class
