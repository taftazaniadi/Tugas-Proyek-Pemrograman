<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.amcc = New System.Windows.Forms.PictureBox()
        Me.Garis1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Garis2 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.btnExit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txtUser = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.logoAnimator = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPass = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.chkAdmin = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.btnLogin = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1.SuspendLayout()
        CType(Me.amcc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 10
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Aqua
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.amcc)
        Me.Panel1.Controls.Add(Me.Garis1)
        Me.Panel1.Controls.Add(Me.Garis2)
        Me.logoAnimator.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(325, 400)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.logoAnimator.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Location = New System.Drawing.Point(30, 239)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(271, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "AMIKOM COMPUTER CLUB"
        '
        'amcc
        '
        Me.logoAnimator.SetDecoration(Me.amcc, BunifuAnimatorNS.DecorationType.None)
        Me.amcc.Image = CType(resources.GetObject("amcc.Image"), System.Drawing.Image)
        Me.amcc.Location = New System.Drawing.Point(87, 65)
        Me.amcc.Name = "amcc"
        Me.amcc.Size = New System.Drawing.Size(153, 156)
        Me.amcc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.amcc.TabIndex = 0
        Me.amcc.TabStop = False
        '
        'Garis1
        '
        Me.Garis1.BackColor = System.Drawing.Color.Aqua
        Me.Garis1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.logoAnimator.SetDecoration(Me.Garis1, BunifuAnimatorNS.DecorationType.None)
        Me.Garis1.Enabled = False
        Me.Garis1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Garis1.ForeColor = System.Drawing.Color.Transparent
        Me.Garis1.HintForeColor = System.Drawing.Color.Empty
        Me.Garis1.HintText = ""
        Me.Garis1.isPassword = False
        Me.Garis1.LineFocusedColor = System.Drawing.Color.White
        Me.Garis1.LineIdleColor = System.Drawing.Color.White
        Me.Garis1.LineMouseHoverColor = System.Drawing.Color.White
        Me.Garis1.LineThickness = 3
        Me.Garis1.Location = New System.Drawing.Point(34, 254)
        Me.Garis1.Margin = New System.Windows.Forms.Padding(4)
        Me.Garis1.Name = "Garis1"
        Me.Garis1.Size = New System.Drawing.Size(262, 33)
        Me.Garis1.TabIndex = 2
        Me.Garis1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Garis2
        '
        Me.Garis2.BackColor = System.Drawing.Color.Aqua
        Me.Garis2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.logoAnimator.SetDecoration(Me.Garis2, BunifuAnimatorNS.DecorationType.None)
        Me.Garis2.Enabled = False
        Me.Garis2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Garis2.ForeColor = System.Drawing.Color.Transparent
        Me.Garis2.HintForeColor = System.Drawing.Color.Empty
        Me.Garis2.HintText = ""
        Me.Garis2.isPassword = False
        Me.Garis2.LineFocusedColor = System.Drawing.Color.White
        Me.Garis2.LineIdleColor = System.Drawing.Color.White
        Me.Garis2.LineMouseHoverColor = System.Drawing.Color.White
        Me.Garis2.LineThickness = 3
        Me.Garis2.Location = New System.Drawing.Point(51, 279)
        Me.Garis2.Margin = New System.Windows.Forms.Padding(4)
        Me.Garis2.Name = "Garis2"
        Me.Garis2.Size = New System.Drawing.Size(230, 33)
        Me.Garis2.TabIndex = 3
        Me.Garis2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel1
        Me.BunifuDragControl1.Vertical = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.logoAnimator.SetDecoration(Me.btnExit, BunifuAnimatorNS.DecorationType.None)
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageActive = Nothing
        Me.btnExit.Location = New System.Drawing.Point(620, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(25, 25)
        Me.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnExit.TabIndex = 3
        Me.btnExit.TabStop = False
        Me.btnExit.Zoom = 10
        '
        'txtUser
        '
        Me.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.logoAnimator.SetDecoration(Me.txtUser, BunifuAnimatorNS.DecorationType.None)
        Me.txtUser.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtUser.ForeColor = System.Drawing.Color.White
        Me.txtUser.HintForeColor = System.Drawing.Color.White
        Me.txtUser.HintText = "Username or NPM"
        Me.txtUser.isPassword = False
        Me.txtUser.LineFocusedColor = System.Drawing.Color.Teal
        Me.txtUser.LineIdleColor = System.Drawing.Color.Gray
        Me.txtUser.LineMouseHoverColor = System.Drawing.Color.Teal
        Me.txtUser.LineThickness = 3
        Me.txtUser.Location = New System.Drawing.Point(364, 148)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(260, 33)
        Me.txtUser.TabIndex = 10
        Me.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'logoAnimator
        '
        Me.logoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate
        Me.logoAnimator.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(30)
        Animation1.RotateCoeff = 0.5!
        Animation1.RotateLimit = 0.2!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.logoAnimator.DefaultAnimation = Animation1
        '
        'logo
        '
        Me.logoAnimator.SetDecoration(Me.logo, BunifuAnimatorNS.DecorationType.None)
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(390, 65)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(211, 50)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logo.TabIndex = 13
        Me.logo.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.logoAnimator.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(390, 280)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 18)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Login sebagai Admin"
        '
        'txtPass
        '
        Me.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.logoAnimator.SetDecoration(Me.txtPass, BunifuAnimatorNS.DecorationType.None)
        Me.txtPass.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtPass.ForeColor = System.Drawing.Color.White
        Me.txtPass.HintForeColor = System.Drawing.Color.White
        Me.txtPass.HintText = "Password"
        Me.txtPass.isPassword = True
        Me.txtPass.LineFocusedColor = System.Drawing.Color.Teal
        Me.txtPass.LineIdleColor = System.Drawing.Color.Gray
        Me.txtPass.LineMouseHoverColor = System.Drawing.Color.Teal
        Me.txtPass.LineThickness = 3
        Me.txtPass.Location = New System.Drawing.Point(364, 213)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(260, 33)
        Me.txtPass.TabIndex = 16
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'chkAdmin
        '
        Me.chkAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkAdmin.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkAdmin.Checked = False
        Me.chkAdmin.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.logoAnimator.SetDecoration(Me.chkAdmin, BunifuAnimatorNS.DecorationType.None)
        Me.chkAdmin.ForeColor = System.Drawing.Color.White
        Me.chkAdmin.Location = New System.Drawing.Point(364, 280)
        Me.chkAdmin.Name = "chkAdmin"
        Me.chkAdmin.Size = New System.Drawing.Size(20, 20)
        Me.chkAdmin.TabIndex = 17
        '
        'btnLogin
        '
        Me.btnLogin.ActiveBorderThickness = 1
        Me.btnLogin.ActiveCornerRadius = 20
        Me.btnLogin.ActiveFillColor = System.Drawing.Color.Aqua
        Me.btnLogin.ActiveForecolor = System.Drawing.Color.White
        Me.btnLogin.ActiveLineColor = System.Drawing.Color.Aqua
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnLogin.BackgroundImage = CType(resources.GetObject("btnLogin.BackgroundImage"), System.Drawing.Image)
        Me.btnLogin.ButtonText = "LOGIN"
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.logoAnimator.SetDecoration(Me.btnLogin, BunifuAnimatorNS.DecorationType.None)
        Me.btnLogin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.Transparent
        Me.btnLogin.IdleBorderThickness = 1
        Me.btnLogin.IdleCornerRadius = 20
        Me.btnLogin.IdleFillColor = System.Drawing.Color.Aqua
        Me.btnLogin.IdleForecolor = System.Drawing.Color.White
        Me.btnLogin.IdleLineColor = System.Drawing.Color.Aqua
        Me.btnLogin.Location = New System.Drawing.Point(416, 323)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(163, 37)
        Me.btnLogin.TabIndex = 18
        Me.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(650, 400)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.chkAdmin)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Panel1)
        Me.logoAnimator.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.amcc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents btnExit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txtUser As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents logoAnimator As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents logo As PictureBox
    Friend WithEvents txtPass As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogin As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents chkAdmin As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents Label2 As Label
    Friend WithEvents amcc As PictureBox
    Friend WithEvents Garis1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Garis2 As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class
