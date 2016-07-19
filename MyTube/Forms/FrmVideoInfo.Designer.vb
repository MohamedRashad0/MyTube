<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVideoInfo
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVideoInfo))
        Me.BWVideoInfo = New System.ComponentModel.BackgroundWorker()
        Me.LblProgress = New System.Windows.Forms.Label()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.BtnOpenLink = New System.Windows.Forms.Button()
        Me.TxtWebsiteURL = New System.Windows.Forms.TextBox()
        Me.LblWebsiteURL = New System.Windows.Forms.Label()
        Me.PicThumbnail = New System.Windows.Forms.PictureBox()
        Me.TxtDescription = New System.Windows.Forms.TextBox()
        Me.LblDescription = New System.Windows.Forms.Label()
        Me.TxtDuration = New System.Windows.Forms.TextBox()
        Me.LblDuration = New System.Windows.Forms.Label()
        Me.LblLinks = New System.Windows.Forms.Label()
        Me.TxtTitle = New System.Windows.Forms.TextBox()
        Me.LstLinks = New System.Windows.Forms.ListView()
        Me.ColURL = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColQuality = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColSize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.MnuLinks = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ItmCopyURL = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnAction = New System.Windows.Forms.Button()
        Me.PnlProgress = New System.Windows.Forms.Panel()
        Me.PBProgress = New NeroBar.NeroBar()
        Me.TmrProgress = New System.Windows.Forms.Timer(Me.components)
        Me.PnlMain.SuspendLayout()
        CType(Me.PicThumbnail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MnuLinks.SuspendLayout()
        Me.PnlProgress.SuspendLayout()
        Me.SuspendLayout()
        '
        'BWVideoInfo
        '
        Me.BWVideoInfo.WorkerSupportsCancellation = True
        '
        'LblProgress
        '
        Me.LblProgress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblProgress.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.LblProgress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblProgress.Location = New System.Drawing.Point(15, 20)
        Me.LblProgress.Name = "LblProgress"
        Me.LblProgress.Size = New System.Drawing.Size(310, 25)
        Me.LblProgress.TabIndex = 0
        Me.LblProgress.Text = "Getting Video Info..."
        Me.LblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlMain
        '
        Me.PnlMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlMain.BackColor = System.Drawing.Color.White
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlMain.Controls.Add(Me.BtnOpenLink)
        Me.PnlMain.Controls.Add(Me.TxtWebsiteURL)
        Me.PnlMain.Controls.Add(Me.LblWebsiteURL)
        Me.PnlMain.Controls.Add(Me.PicThumbnail)
        Me.PnlMain.Controls.Add(Me.TxtDescription)
        Me.PnlMain.Controls.Add(Me.LblDescription)
        Me.PnlMain.Controls.Add(Me.TxtDuration)
        Me.PnlMain.Controls.Add(Me.LblDuration)
        Me.PnlMain.Controls.Add(Me.LblLinks)
        Me.PnlMain.Controls.Add(Me.TxtTitle)
        Me.PnlMain.Controls.Add(Me.LstLinks)
        Me.PnlMain.Controls.Add(Me.LblTitle)
        Me.PnlMain.Location = New System.Drawing.Point(-3, -2)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(525, 480)
        Me.PnlMain.TabIndex = 1
        Me.PnlMain.Visible = False
        '
        'BtnOpenLink
        '
        Me.BtnOpenLink.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOpenLink.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnOpenLink.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnOpenLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOpenLink.Image = CType(resources.GetObject("BtnOpenLink.Image"), System.Drawing.Image)
        Me.BtnOpenLink.Location = New System.Drawing.Point(467, 285)
        Me.BtnOpenLink.Name = "BtnOpenLink"
        Me.BtnOpenLink.Size = New System.Drawing.Size(40, 23)
        Me.BtnOpenLink.TabIndex = 9
        Me.BtnOpenLink.UseVisualStyleBackColor = False
        '
        'TxtWebsiteURL
        '
        Me.TxtWebsiteURL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtWebsiteURL.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtWebsiteURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtWebsiteURL.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TxtWebsiteURL.Location = New System.Drawing.Point(17, 285)
        Me.TxtWebsiteURL.Name = "TxtWebsiteURL"
        Me.TxtWebsiteURL.ReadOnly = True
        Me.TxtWebsiteURL.Size = New System.Drawing.Size(444, 23)
        Me.TxtWebsiteURL.TabIndex = 8
        '
        'LblWebsiteURL
        '
        Me.LblWebsiteURL.AutoSize = True
        Me.LblWebsiteURL.Location = New System.Drawing.Point(16, 262)
        Me.LblWebsiteURL.Name = "LblWebsiteURL"
        Me.LblWebsiteURL.Size = New System.Drawing.Size(64, 15)
        Me.LblWebsiteURL.TabIndex = 7
        Me.LblWebsiteURL.Text = "&Video URL:"
        '
        'PicThumbnail
        '
        Me.PicThumbnail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicThumbnail.ErrorImage = Nothing
        Me.PicThumbnail.InitialImage = Nothing
        Me.PicThumbnail.Location = New System.Drawing.Point(362, 33)
        Me.PicThumbnail.Name = "PicThumbnail"
        Me.PicThumbnail.Size = New System.Drawing.Size(145, 128)
        Me.PicThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicThumbnail.TabIndex = 0
        Me.PicThumbnail.TabStop = False
        '
        'TxtDescription
        '
        Me.TxtDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDescription.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDescription.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TxtDescription.Location = New System.Drawing.Point(17, 190)
        Me.TxtDescription.Multiline = True
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.ReadOnly = True
        Me.TxtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDescription.Size = New System.Drawing.Size(490, 50)
        Me.TxtDescription.TabIndex = 6
        '
        'LblDescription
        '
        Me.LblDescription.AutoSize = True
        Me.LblDescription.Location = New System.Drawing.Point(16, 167)
        Me.LblDescription.Name = "LblDescription"
        Me.LblDescription.Size = New System.Drawing.Size(70, 15)
        Me.LblDescription.TabIndex = 5
        Me.LblDescription.Text = "&Description:"
        '
        'TxtDuration
        '
        Me.TxtDuration.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDuration.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDuration.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TxtDuration.Location = New System.Drawing.Point(17, 118)
        Me.TxtDuration.Name = "TxtDuration"
        Me.TxtDuration.ReadOnly = True
        Me.TxtDuration.Size = New System.Drawing.Size(325, 23)
        Me.TxtDuration.TabIndex = 4
        '
        'LblDuration
        '
        Me.LblDuration.AutoSize = True
        Me.LblDuration.Location = New System.Drawing.Point(16, 95)
        Me.LblDuration.Name = "LblDuration"
        Me.LblDuration.Size = New System.Drawing.Size(56, 15)
        Me.LblDuration.TabIndex = 3
        Me.LblDuration.Text = "D&uration:"
        '
        'LblLinks
        '
        Me.LblLinks.AutoSize = True
        Me.LblLinks.Location = New System.Drawing.Point(14, 334)
        Me.LblLinks.Name = "LblLinks"
        Me.LblLinks.Size = New System.Drawing.Size(94, 15)
        Me.LblLinks.TabIndex = 0
        Me.LblLinks.Text = "Download Links:"
        '
        'TxtTitle
        '
        Me.TxtTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTitle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTitle.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TxtTitle.Location = New System.Drawing.Point(17, 46)
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.ReadOnly = True
        Me.TxtTitle.Size = New System.Drawing.Size(325, 23)
        Me.TxtTitle.TabIndex = 2
        '
        'LstLinks
        '
        Me.LstLinks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LstLinks.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColURL, Me.ColQuality, Me.ColType, Me.ColSize})
        Me.LstLinks.FullRowSelect = True
        Me.LstLinks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LstLinks.HideSelection = False
        Me.LstLinks.LabelWrap = False
        Me.LstLinks.Location = New System.Drawing.Point(17, 357)
        Me.LstLinks.MultiSelect = False
        Me.LstLinks.Name = "LstLinks"
        Me.LstLinks.Size = New System.Drawing.Size(490, 100)
        Me.LstLinks.TabIndex = 10
        Me.LstLinks.UseCompatibleStateImageBehavior = False
        Me.LstLinks.View = System.Windows.Forms.View.Details
        '
        'ColURL
        '
        Me.ColURL.Text = "URL"
        Me.ColURL.Width = 150
        '
        'ColQuality
        '
        Me.ColQuality.Text = "Quality"
        Me.ColQuality.Width = 100
        '
        'ColType
        '
        Me.ColType.Text = "Type"
        Me.ColType.Width = 100
        '
        'ColSize
        '
        Me.ColSize.Text = "Size"
        Me.ColSize.Width = 100
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Location = New System.Drawing.Point(16, 23)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(33, 15)
        Me.LblTitle.TabIndex = 1
        Me.LblTitle.Text = "&Title:"
        '
        'MnuLinks
        '
        Me.MnuLinks.DropShadowEnabled = False
        Me.MnuLinks.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MnuLinks.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItmCopyURL})
        Me.MnuLinks.Name = "MnuLinks"
        Me.MnuLinks.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MnuLinks.ShowImageMargin = False
        Me.MnuLinks.Size = New System.Drawing.Size(135, 26)
        '
        'ItmCopyURL
        '
        Me.ItmCopyURL.Name = "ItmCopyURL"
        Me.ItmCopyURL.Size = New System.Drawing.Size(134, 22)
        Me.ItmCopyURL.Text = "Copy Video URL"
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.Location = New System.Drawing.Point(432, 487)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 3
        Me.BtnClose.Text = "&Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        Me.BtnClose.Visible = False
        '
        'BtnAction
        '
        Me.BtnAction.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAction.Location = New System.Drawing.Point(351, 487)
        Me.BtnAction.Name = "BtnAction"
        Me.BtnAction.Size = New System.Drawing.Size(75, 23)
        Me.BtnAction.TabIndex = 2
        Me.BtnAction.UseVisualStyleBackColor = True
        Me.BtnAction.Visible = False
        '
        'PnlProgress
        '
        Me.PnlProgress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PnlProgress.Controls.Add(Me.PBProgress)
        Me.PnlProgress.Controls.Add(Me.LblProgress)
        Me.PnlProgress.Location = New System.Drawing.Point(89, 200)
        Me.PnlProgress.Name = "PnlProgress"
        Me.PnlProgress.Size = New System.Drawing.Size(340, 85)
        Me.PnlProgress.TabIndex = 0
        '
        'PBProgress
        '
        Me.PBProgress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PBProgress.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PBProgress.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PBProgress.BackColor = System.Drawing.Color.Transparent
        Me.PBProgress.ForeColor = System.Drawing.Color.Black
        Me.PBProgress.GlowMode = NeroBar.NeroBar.NeroBarGlowModes.ProgressOnly
        Me.PBProgress.GlowPause = 2000
        Me.PBProgress.GlowSpeed = 10
        Me.PBProgress.Location = New System.Drawing.Point(20, 54)
        Me.PBProgress.Name = "PBProgress"
        Me.PBProgress.PercentageBasedOn = NeroBar.NeroBar.NeroBarPercentageCalculationModes.WholeControl
        Me.PBProgress.Segment1Color = System.Drawing.Color.PaleGreen
        Me.PBProgress.SegmentCount = NeroBar.NeroBar.NeroBarSegments.One
        Me.PBProgress.Size = New System.Drawing.Size(305, 10)
        Me.PBProgress.TabIndex = 0
        Me.PBProgress.TabStop = False
        Me.PBProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TmrProgress
        '
        Me.TmrProgress.Interval = 500
        '
        'FrmVideoInfo
        '
        Me.AcceptButton = Me.BtnAction
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(519, 522)
        Me.Controls.Add(Me.BtnAction)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.PnlMain)
        Me.Controls.Add(Me.PnlProgress)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(535, 560)
        Me.Name = "FrmVideoInfo"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Video Information"
        Me.PnlMain.ResumeLayout(False)
        Me.PnlMain.PerformLayout()
        CType(Me.PicThumbnail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MnuLinks.ResumeLayout(False)
        Me.PnlProgress.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BWVideoInfo As System.ComponentModel.BackgroundWorker
    Friend WithEvents LblProgress As System.Windows.Forms.Label
    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents LblLinks As System.Windows.Forms.Label
    Friend WithEvents TxtTitle As System.Windows.Forms.TextBox
    Friend WithEvents LstLinks As System.Windows.Forms.ListView
    Friend WithEvents ColURL As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColType As System.Windows.Forms.ColumnHeader
    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents LblDuration As System.Windows.Forms.Label
    Friend WithEvents TxtDuration As System.Windows.Forms.TextBox
    Friend WithEvents TxtDescription As System.Windows.Forms.TextBox
    Friend WithEvents LblDescription As System.Windows.Forms.Label
    Friend WithEvents ColQuality As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColSize As System.Windows.Forms.ColumnHeader
    Friend WithEvents TxtWebsiteURL As System.Windows.Forms.TextBox
    Friend WithEvents LblWebsiteURL As System.Windows.Forms.Label
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnAction As System.Windows.Forms.Button
    Friend WithEvents BtnOpenLink As System.Windows.Forms.Button
    Friend WithEvents PicThumbnail As System.Windows.Forms.PictureBox
    Friend WithEvents MnuLinks As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ItmCopyURL As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PnlProgress As System.Windows.Forms.Panel
    Friend WithEvents PBProgress As NeroBar.NeroBar
    Friend WithEvents TmrProgress As System.Windows.Forms.Timer
End Class