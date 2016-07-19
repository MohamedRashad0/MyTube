<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAbout
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAbout))
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblSoftwareLicense = New System.Windows.Forms.Label()
        Me.TxtLicense = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.LinAbout = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge()
        Me.LblLicense = New System.Windows.Forms.Label()
        Me.LblCRight = New System.Windows.Forms.Label()
        Me.LblHdr = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.LnkSoftwareLicense = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.LnkInternet = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.LblInternet = New System.Windows.Forms.Label()
        Me.LblVersion = New System.Windows.Forms.Label()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.PnlMain.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlMain.BackColor = System.Drawing.Color.White
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlMain.Controls.Add(Me.KryptonLabel1)
        Me.PnlMain.Controls.Add(Me.PictureBox1)
        Me.PnlMain.Controls.Add(Me.LblSoftwareLicense)
        Me.PnlMain.Controls.Add(Me.TxtLicense)
        Me.PnlMain.Controls.Add(Me.LinAbout)
        Me.PnlMain.Controls.Add(Me.LblLicense)
        Me.PnlMain.Controls.Add(Me.LblCRight)
        Me.PnlMain.Controls.Add(Me.LblHdr)
        Me.PnlMain.Controls.Add(Me.LnkSoftwareLicense)
        Me.PnlMain.Controls.Add(Me.LnkInternet)
        Me.PnlMain.Controls.Add(Me.LblInternet)
        Me.PnlMain.Controls.Add(Me.LblVersion)
        Me.PnlMain.Location = New System.Drawing.Point(-3, -2)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(445, 320)
        Me.PnlMain.TabIndex = 0
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(194, 16)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.KryptonLabel1.Size = New System.Drawing.Size(203, 33)
        Me.KryptonLabel1.StateNormal.ShortText.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 3
        Me.KryptonLabel1.Values.Text = "Download , Watch , Convert and Share" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Direct Download Links From YouTube!"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(61, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'LblSoftwareLicense
        '
        Me.LblSoftwareLicense.AutoSize = True
        Me.LblSoftwareLicense.Location = New System.Drawing.Point(23, 172)
        Me.LblSoftwareLicense.Name = "LblSoftwareLicense"
        Me.LblSoftwareLicense.Size = New System.Drawing.Size(49, 15)
        Me.LblSoftwareLicense.TabIndex = 0
        Me.LblSoftwareLicense.Text = "License:"
        '
        'TxtLicense
        '
        Me.TxtLicense.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtLicense.Location = New System.Drawing.Point(18, 203)
        Me.TxtLicense.Multiline = True
        Me.TxtLicense.Name = "TxtLicense"
        Me.TxtLicense.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.TxtLicense.ReadOnly = True
        Me.TxtLicense.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtLicense.Size = New System.Drawing.Size(410, 98)
        Me.TxtLicense.StateActive.Back.Color1 = System.Drawing.Color.WhiteSmoke
        Me.TxtLicense.StateActive.Border.DrawBorders = CType((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.TxtLicense.StateNormal.Back.Color1 = System.Drawing.Color.WhiteSmoke
        Me.TxtLicense.StateNormal.Border.DrawBorders = CType((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.TxtLicense.TabIndex = 0
        Me.TxtLicense.TabStop = False
        Me.TxtLicense.Text = resources.GetString("TxtLicense.Text")
        '
        'LinAbout
        '
        Me.LinAbout.Location = New System.Drawing.Point(18, 134)
        Me.LinAbout.Name = "LinAbout"
        Me.LinAbout.Size = New System.Drawing.Size(405, 1)
        Me.LinAbout.StateNormal.Color1 = System.Drawing.Color.LightSteelBlue
        '
        'LblLicense
        '
        Me.LblLicense.AutoSize = True
        Me.LblLicense.Location = New System.Drawing.Point(85, 82)
        Me.LblLicense.Name = "LblLicense"
        Me.LblLicense.Size = New System.Drawing.Size(0, 15)
        Me.LblLicense.TabIndex = 0
        '
        'LblCRight
        '
        Me.LblCRight.AutoSize = True
        Me.LblCRight.Location = New System.Drawing.Point(85, 105)
        Me.LblCRight.Name = "LblCRight"
        Me.LblCRight.Size = New System.Drawing.Size(0, 15)
        Me.LblCRight.TabIndex = 0
        '
        'LblHdr
        '
        Me.LblHdr.Location = New System.Drawing.Point(85, 12)
        Me.LblHdr.Name = "LblHdr"
        Me.LblHdr.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.LblHdr.Size = New System.Drawing.Size(103, 37)
        Me.LblHdr.StateNormal.ShortText.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHdr.TabIndex = 0
        Me.LblHdr.Values.Text = "MyTube"
        '
        'LnkSoftwareLicense
        '
        Me.LnkSoftwareLicense.LinkBehavior = ComponentFactory.Krypton.Toolkit.KryptonLinkBehavior.HoverUnderline
        Me.LnkSoftwareLicense.Location = New System.Drawing.Point(85, 171)
        Me.LnkSoftwareLicense.Name = "LnkSoftwareLicense"
        Me.LnkSoftwareLicense.OverrideFocus.DrawFocus = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
        Me.LnkSoftwareLicense.OverrideNotVisited.ShortText.Color1 = System.Drawing.Color.MediumBlue
        Me.LnkSoftwareLicense.OverridePressed.ShortText.Color1 = System.Drawing.Color.RoyalBlue
        Me.LnkSoftwareLicense.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.LnkSoftwareLicense.Size = New System.Drawing.Size(177, 20)
        Me.LnkSoftwareLicense.StateNormal.ShortText.Color1 = System.Drawing.Color.MediumBlue
        Me.LnkSoftwareLicense.TabIndex = 0
        Me.LnkSoftwareLicense.TabStop = False
        Me.LnkSoftwareLicense.Values.Text = "GNU General Public License v3"
        '
        'LnkInternet
        '
        Me.LnkInternet.LinkBehavior = ComponentFactory.Krypton.Toolkit.KryptonLinkBehavior.HoverUnderline
        Me.LnkInternet.Location = New System.Drawing.Point(85, 147)
        Me.LnkInternet.Name = "LnkInternet"
        Me.LnkInternet.OverrideFocus.DrawFocus = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
        Me.LnkInternet.OverrideNotVisited.ShortText.Color1 = System.Drawing.Color.MediumBlue
        Me.LnkInternet.OverridePressed.ShortText.Color1 = System.Drawing.Color.RoyalBlue
        Me.LnkInternet.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.LnkInternet.Size = New System.Drawing.Size(211, 20)
        Me.LnkInternet.StateNormal.ShortText.Color1 = System.Drawing.Color.MediumBlue
        Me.LnkInternet.TabIndex = 0
        Me.LnkInternet.TabStop = False
        Me.LnkInternet.Values.Text = "http://smartpcsoft.com/support.html"
        '
        'LblInternet
        '
        Me.LblInternet.AutoSize = True
        Me.LblInternet.Location = New System.Drawing.Point(23, 149)
        Me.LblInternet.Name = "LblInternet"
        Me.LblInternet.Size = New System.Drawing.Size(52, 15)
        Me.LblInternet.TabIndex = 0
        Me.LblInternet.Text = "Support:"
        '
        'LblVersion
        '
        Me.LblVersion.AutoSize = True
        Me.LblVersion.Location = New System.Drawing.Point(85, 59)
        Me.LblVersion.Name = "LblVersion"
        Me.LblVersion.Size = New System.Drawing.Size(0, 15)
        Me.LblVersion.TabIndex = 0
        '
        'BtnOK
        '
        Me.BtnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BtnOK.Location = New System.Drawing.Point(347, 330)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(80, 25)
        Me.BtnOK.TabIndex = 1
        Me.BtnOK.Text = "&OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'FrmAbout
        '
        Me.AcceptButton = Me.BtnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(439, 367)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.PnlMain)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAbout"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About MyTube"
        Me.PnlMain.ResumeLayout(False)
        Me.PnlMain.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents LblSoftwareLicense As System.Windows.Forms.Label
    Friend WithEvents TxtLicense As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LinAbout As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents LblLicense As System.Windows.Forms.Label
    Friend WithEvents LblCRight As System.Windows.Forms.Label
    Friend WithEvents LblHdr As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents LnkSoftwareLicense As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents LnkInternet As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents LblInternet As System.Windows.Forms.Label
    Friend WithEvents LblVersion As System.Windows.Forms.Label
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class