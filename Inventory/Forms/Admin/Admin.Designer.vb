<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Sidemenu = New System.Windows.Forms.Panel()
        Me.btnMember = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnLog = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnInventaris = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnPinjam = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnDash = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.logo_small = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuImageButton3 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnExit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.logoAnimator = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.PanelAnimator = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Sidemenu.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo_small, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 10
        Me.BunifuElipse1.TargetControl = Me
        '
        'Sidemenu
        '
        Me.Sidemenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Sidemenu.Controls.Add(Me.btnMember)
        Me.Sidemenu.Controls.Add(Me.btnLog)
        Me.Sidemenu.Controls.Add(Me.btnInventaris)
        Me.Sidemenu.Controls.Add(Me.btnPinjam)
        Me.Sidemenu.Controls.Add(Me.btnDash)
        Me.Sidemenu.Controls.Add(Me.logo)
        Me.Sidemenu.Controls.Add(Me.BunifuCustomLabel1)
        Me.Sidemenu.Controls.Add(Me.BunifuImageButton1)
        Me.Sidemenu.Controls.Add(Me.logo_small)
        Me.PanelAnimator.SetDecoration(Me.Sidemenu, BunifuAnimatorNS.DecorationType.None)
        Me.logoAnimator.SetDecoration(Me.Sidemenu, BunifuAnimatorNS.DecorationType.None)
        Me.Sidemenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.Sidemenu.Location = New System.Drawing.Point(0, 0)
        Me.Sidemenu.Name = "Sidemenu"
        Me.Sidemenu.Size = New System.Drawing.Size(200, 562)
        Me.Sidemenu.TabIndex = 0
        '
        'btnMember
        '
        Me.btnMember.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnMember.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMember.BorderRadius = 0
        Me.btnMember.ButtonText = "     Member"
        Me.btnMember.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator.SetDecoration(Me.btnMember, BunifuAnimatorNS.DecorationType.None)
        Me.logoAnimator.SetDecoration(Me.btnMember, BunifuAnimatorNS.DecorationType.None)
        Me.btnMember.DisabledColor = System.Drawing.Color.Gray
        Me.btnMember.Iconcolor = System.Drawing.Color.Transparent
        Me.btnMember.Iconimage = CType(resources.GetObject("btnMember.Iconimage"), System.Drawing.Image)
        Me.btnMember.Iconimage_right = Nothing
        Me.btnMember.Iconimage_right_Selected = Nothing
        Me.btnMember.Iconimage_Selected = Nothing
        Me.btnMember.IconMarginLeft = 0
        Me.btnMember.IconMarginRight = 0
        Me.btnMember.IconRightVisible = True
        Me.btnMember.IconRightZoom = 0R
        Me.btnMember.IconVisible = True
        Me.btnMember.IconZoom = 60.0R
        Me.btnMember.IsTab = True
        Me.btnMember.Location = New System.Drawing.Point(0, 301)
        Me.btnMember.Name = "btnMember"
        Me.btnMember.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnMember.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnMember.OnHoverTextColor = System.Drawing.Color.White
        Me.btnMember.selected = False
        Me.btnMember.Size = New System.Drawing.Size(200, 48)
        Me.btnMember.TabIndex = 7
        Me.btnMember.Text = "     Member"
        Me.btnMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMember.Textcolor = System.Drawing.Color.White
        Me.btnMember.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnLog
        '
        Me.btnLog.Activecolor = System.Drawing.Color.Red
        Me.btnLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLog.BorderRadius = 0
        Me.btnLog.ButtonText = "     Log Out"
        Me.btnLog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator.SetDecoration(Me.btnLog, BunifuAnimatorNS.DecorationType.None)
        Me.logoAnimator.SetDecoration(Me.btnLog, BunifuAnimatorNS.DecorationType.None)
        Me.btnLog.DisabledColor = System.Drawing.Color.Gray
        Me.btnLog.Iconcolor = System.Drawing.Color.Transparent
        Me.btnLog.Iconimage = CType(resources.GetObject("btnLog.Iconimage"), System.Drawing.Image)
        Me.btnLog.Iconimage_right = Nothing
        Me.btnLog.Iconimage_right_Selected = Nothing
        Me.btnLog.Iconimage_Selected = Nothing
        Me.btnLog.IconMarginLeft = 0
        Me.btnLog.IconMarginRight = 0
        Me.btnLog.IconRightVisible = True
        Me.btnLog.IconRightZoom = 0R
        Me.btnLog.IconVisible = True
        Me.btnLog.IconZoom = 60.0R
        Me.btnLog.IsTab = True
        Me.btnLog.Location = New System.Drawing.Point(0, 502)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnLog.OnHovercolor = System.Drawing.Color.DarkRed
        Me.btnLog.OnHoverTextColor = System.Drawing.Color.White
        Me.btnLog.selected = False
        Me.btnLog.Size = New System.Drawing.Size(200, 48)
        Me.btnLog.TabIndex = 6
        Me.btnLog.Text = "     Log Out"
        Me.btnLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLog.Textcolor = System.Drawing.Color.White
        Me.btnLog.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnInventaris
        '
        Me.btnInventaris.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnInventaris.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnInventaris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInventaris.BorderRadius = 0
        Me.btnInventaris.ButtonText = "     Inventaris"
        Me.btnInventaris.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator.SetDecoration(Me.btnInventaris, BunifuAnimatorNS.DecorationType.None)
        Me.logoAnimator.SetDecoration(Me.btnInventaris, BunifuAnimatorNS.DecorationType.None)
        Me.btnInventaris.DisabledColor = System.Drawing.Color.Gray
        Me.btnInventaris.Iconcolor = System.Drawing.Color.Transparent
        Me.btnInventaris.Iconimage = CType(resources.GetObject("btnInventaris.Iconimage"), System.Drawing.Image)
        Me.btnInventaris.Iconimage_right = Nothing
        Me.btnInventaris.Iconimage_right_Selected = Nothing
        Me.btnInventaris.Iconimage_Selected = Nothing
        Me.btnInventaris.IconMarginLeft = 0
        Me.btnInventaris.IconMarginRight = 0
        Me.btnInventaris.IconRightVisible = True
        Me.btnInventaris.IconRightZoom = 0R
        Me.btnInventaris.IconVisible = True
        Me.btnInventaris.IconZoom = 60.0R
        Me.btnInventaris.IsTab = True
        Me.btnInventaris.Location = New System.Drawing.Point(0, 247)
        Me.btnInventaris.Name = "btnInventaris"
        Me.btnInventaris.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnInventaris.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnInventaris.OnHoverTextColor = System.Drawing.Color.White
        Me.btnInventaris.selected = False
        Me.btnInventaris.Size = New System.Drawing.Size(200, 48)
        Me.btnInventaris.TabIndex = 5
        Me.btnInventaris.Text = "     Inventaris"
        Me.btnInventaris.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventaris.Textcolor = System.Drawing.Color.White
        Me.btnInventaris.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnPinjam
        '
        Me.btnPinjam.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnPinjam.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnPinjam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPinjam.BorderRadius = 0
        Me.btnPinjam.ButtonText = "    Transaksi"
        Me.btnPinjam.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator.SetDecoration(Me.btnPinjam, BunifuAnimatorNS.DecorationType.None)
        Me.logoAnimator.SetDecoration(Me.btnPinjam, BunifuAnimatorNS.DecorationType.None)
        Me.btnPinjam.DisabledColor = System.Drawing.Color.Gray
        Me.btnPinjam.Iconcolor = System.Drawing.Color.Transparent
        Me.btnPinjam.Iconimage = CType(resources.GetObject("btnPinjam.Iconimage"), System.Drawing.Image)
        Me.btnPinjam.Iconimage_right = Nothing
        Me.btnPinjam.Iconimage_right_Selected = Nothing
        Me.btnPinjam.Iconimage_Selected = Nothing
        Me.btnPinjam.IconMarginLeft = 0
        Me.btnPinjam.IconMarginRight = 0
        Me.btnPinjam.IconRightVisible = True
        Me.btnPinjam.IconRightZoom = 0R
        Me.btnPinjam.IconVisible = True
        Me.btnPinjam.IconZoom = 70.0R
        Me.btnPinjam.IsTab = True
        Me.btnPinjam.Location = New System.Drawing.Point(0, 193)
        Me.btnPinjam.Name = "btnPinjam"
        Me.btnPinjam.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnPinjam.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnPinjam.OnHoverTextColor = System.Drawing.Color.White
        Me.btnPinjam.selected = False
        Me.btnPinjam.Size = New System.Drawing.Size(200, 48)
        Me.btnPinjam.TabIndex = 3
        Me.btnPinjam.Text = "    Transaksi"
        Me.btnPinjam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPinjam.Textcolor = System.Drawing.Color.White
        Me.btnPinjam.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnDash
        '
        Me.btnDash.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnDash.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnDash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDash.BorderRadius = 0
        Me.btnDash.ButtonText = "     Dashboard"
        Me.btnDash.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator.SetDecoration(Me.btnDash, BunifuAnimatorNS.DecorationType.None)
        Me.logoAnimator.SetDecoration(Me.btnDash, BunifuAnimatorNS.DecorationType.None)
        Me.btnDash.DisabledColor = System.Drawing.Color.Gray
        Me.btnDash.Iconcolor = System.Drawing.Color.Transparent
        Me.btnDash.Iconimage = CType(resources.GetObject("btnDash.Iconimage"), System.Drawing.Image)
        Me.btnDash.Iconimage_right = Nothing
        Me.btnDash.Iconimage_right_Selected = Nothing
        Me.btnDash.Iconimage_Selected = Nothing
        Me.btnDash.IconMarginLeft = 0
        Me.btnDash.IconMarginRight = 0
        Me.btnDash.IconRightVisible = True
        Me.btnDash.IconRightZoom = 0R
        Me.btnDash.IconVisible = True
        Me.btnDash.IconZoom = 50.0R
        Me.btnDash.IsTab = True
        Me.btnDash.Location = New System.Drawing.Point(0, 139)
        Me.btnDash.Name = "btnDash"
        Me.btnDash.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnDash.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnDash.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnDash.selected = True
        Me.btnDash.Size = New System.Drawing.Size(200, 48)
        Me.btnDash.TabIndex = 2
        Me.btnDash.Text = "     Dashboard"
        Me.btnDash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDash.Textcolor = System.Drawing.Color.White
        Me.btnDash.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'logo
        '
        Me.logoAnimator.SetDecoration(Me.logo, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.logo, BunifuAnimatorNS.DecorationType.None)
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(20, 49)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(164, 62)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logo.TabIndex = 2
        Me.logo.TabStop = False
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.logoAnimator.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(67, 6)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(78, 25)
        Me.BunifuCustomLabel1.TabIndex = 2
        Me.BunifuCustomLabel1.Text = "MENU"
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.PanelAnimator.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.logoAnimator.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(12, 6)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(25, 25)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 2
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'logo_small
        '
        Me.logoAnimator.SetDecoration(Me.logo_small, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.logo_small, BunifuAnimatorNS.DecorationType.None)
        Me.logo_small.Image = CType(resources.GetObject("logo_small.Image"), System.Drawing.Image)
        Me.logo_small.Location = New System.Drawing.Point(9, 64)
        Me.logo_small.Name = "logo_small"
        Me.logo_small.Size = New System.Drawing.Size(35, 35)
        Me.logo_small.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logo_small.TabIndex = 2
        Me.logo_small.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BunifuImageButton3)
        Me.Panel2.Controls.Add(Me.BunifuImageButton2)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.PanelAnimator.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.logoAnimator.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(200, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(709, 40)
        Me.Panel2.TabIndex = 1
        '
        'BunifuImageButton3
        '
        Me.BunifuImageButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuImageButton3.BackColor = System.Drawing.Color.Transparent
        Me.PanelAnimator.SetDecoration(Me.BunifuImageButton3, BunifuAnimatorNS.DecorationType.None)
        Me.logoAnimator.SetDecoration(Me.BunifuImageButton3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton3.Image = CType(resources.GetObject("BunifuImageButton3.Image"), System.Drawing.Image)
        Me.BunifuImageButton3.ImageActive = Nothing
        Me.BunifuImageButton3.Location = New System.Drawing.Point(625, 10)
        Me.BunifuImageButton3.Name = "BunifuImageButton3"
        Me.BunifuImageButton3.Size = New System.Drawing.Size(22, 22)
        Me.BunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton3.TabIndex = 10
        Me.BunifuImageButton3.TabStop = False
        Me.BunifuImageButton3.Zoom = 10
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.PanelAnimator.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.logoAnimator.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(651, 9)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(22, 22)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 9
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.logoAnimator.SetDecoration(Me.BunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.BunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(11, 7)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(119, 24)
        Me.BunifuCustomLabel2.TabIndex = 8
        Me.BunifuCustomLabel2.Text = "Administrator"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.PanelAnimator.SetDecoration(Me.btnExit, BunifuAnimatorNS.DecorationType.None)
        Me.logoAnimator.SetDecoration(Me.btnExit, BunifuAnimatorNS.DecorationType.None)
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageActive = Nothing
        Me.btnExit.Location = New System.Drawing.Point(676, 6)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(25, 25)
        Me.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnExit.TabIndex = 2
        Me.btnExit.TabStop = False
        Me.btnExit.Zoom = 10
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel2
        Me.BunifuDragControl1.Vertical = True
        '
        'logoAnimator
        '
        Me.logoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate
        Me.logoAnimator.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(30)
        Animation2.RotateCoeff = 0.5!
        Animation2.RotateLimit = 0.2!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.logoAnimator.DefaultAnimation = Animation2
        '
        'PanelAnimator
        '
        Me.PanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.PanelAnimator.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.PanelAnimator.DefaultAnimation = Animation1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(909, 562)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Sidemenu)
        Me.logoAnimator.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Sidemenu.ResumeLayout(False)
        Me.Sidemenu.PerformLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo_small, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Sidemenu As Panel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents btnExit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents logo As PictureBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnLog As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnInventaris As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnPinjam As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnDash As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents logoAnimator As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents PanelAnimator As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents logo_small As PictureBox
    Friend WithEvents btnMember As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuImageButton3 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
End Class
