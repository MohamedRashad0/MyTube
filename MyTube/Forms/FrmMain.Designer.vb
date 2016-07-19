<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.MDICntrl = New SmartPCUtilities.Components.MdiClientController()
        Me.HdrMain = New ComponentFactory.Krypton.Toolkit.KryptonHeader()
        Me.BtnSettings = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.BtnHelp = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.MnuHelp = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ItmDoc = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmSupport = New System.Windows.Forms.ToolStripMenuItem()
        Me.Sprtr1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ItmUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.KMngr = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.StsMain = New System.Windows.Forms.StatusStrip()
        Me.LblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LblFacebook = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LblSprtr1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LblTwitter = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LblSprtr2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LblYoutube = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BoxSide = New ComponentFactory.Krypton.Toolkit.KryptonGroup()
        Me.BtnBookmark = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.BtnDownload = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.BtnWatch = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.BtnSearch = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.TmrFade = New System.Windows.Forms.Timer(Me.components)
        Me.NIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.MnuTray = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ItmRestore = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuTraySprtr1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ItmExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.PnlSearch = New System.Windows.Forms.Panel()
        Me.BtnSearchYoutube = New System.Windows.Forms.Button()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.PicYoutube = New System.Windows.Forms.PictureBox()
        Me.LstDate = New System.Windows.Forms.ListBox()
        Me.LblDate = New System.Windows.Forms.Label()
        Me.LstSort = New System.Windows.Forms.ListBox()
        Me.LblDuration = New System.Windows.Forms.Label()
        Me.LstDuration = New System.Windows.Forms.ListBox()
        Me.LblSort = New System.Windows.Forms.Label()
        Me.LblSearch = New System.Windows.Forms.Label()
        Me.TmrCatch = New System.Windows.Forms.Timer(Me.components)
        Me.BwCatch = New System.ComponentModel.BackgroundWorker()
        Me.MnuHelp.SuspendLayout()
        Me.StsMain.SuspendLayout()
        CType(Me.BoxSide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxSide.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BoxSide.Panel.SuspendLayout()
        Me.BoxSide.SuspendLayout()
        Me.MnuTray.SuspendLayout()
        Me.PnlSearch.SuspendLayout()
        CType(Me.PicYoutube, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MDICntrl
        '
        Me.MDICntrl.AutoScroll = False
        Me.MDICntrl.BackColor = System.Drawing.Color.White
        Me.MDICntrl.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MDICntrl.ParentForm = Me
        '
        'HdrMain
        '
        Me.HdrMain.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.BtnSettings, Me.BtnHelp})
        Me.HdrMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.HdrMain.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HdrMain.Location = New System.Drawing.Point(0, 0)
        Me.HdrMain.Name = "HdrMain"
        Me.HdrMain.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.HdrMain.Size = New System.Drawing.Size(907, 56)
        Me.HdrMain.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Switch50
        Me.HdrMain.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.HdrMain.StateNormal.Content.LongText.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HdrMain.StateNormal.Content.Padding = New System.Windows.Forms.Padding(10, 5, 81, 5)
        Me.HdrMain.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HdrMain.TabIndex = 0
        Me.HdrMain.TabStop = False
        Me.HdrMain.Values.Description = ""
        Me.HdrMain.Values.Heading = " MyTube"
        Me.HdrMain.Values.Image = CType(resources.GetObject("HdrMain.Values.Image"), System.Drawing.Image)
        '
        'BtnSettings
        '
        Me.BtnSettings.Image = CType(resources.GetObject("BtnSettings.Image"), System.Drawing.Image)
        Me.BtnSettings.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Form
        Me.BtnSettings.Text = " Settings"
        Me.BtnSettings.UniqueName = ""
        '
        'BtnHelp
        '
        Me.BtnHelp.ContextMenuStrip = Me.MnuHelp
        Me.BtnHelp.Image = CType(resources.GetObject("BtnHelp.Image"), System.Drawing.Image)
        Me.BtnHelp.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Form
        Me.BtnHelp.Text = " Help"
        Me.BtnHelp.UniqueName = ""
        '
        'MnuHelp
        '
        Me.MnuHelp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MnuHelp.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItmDoc, Me.ItmSupport, Me.Sprtr1, Me.ItmUpdate, Me.ItmAbout})
        Me.MnuHelp.Name = "MnuHelp"
        Me.MnuHelp.Size = New System.Drawing.Size(174, 98)
        '
        'ItmDoc
        '
        Me.ItmDoc.Name = "ItmDoc"
        Me.ItmDoc.Size = New System.Drawing.Size(173, 22)
        Me.ItmDoc.Text = "Documentation"
        '
        'ItmSupport
        '
        Me.ItmSupport.Name = "ItmSupport"
        Me.ItmSupport.Size = New System.Drawing.Size(173, 22)
        Me.ItmSupport.Text = "Online Support"
        '
        'Sprtr1
        '
        Me.Sprtr1.Name = "Sprtr1"
        Me.Sprtr1.Size = New System.Drawing.Size(170, 6)
        '
        'ItmUpdate
        '
        Me.ItmUpdate.Name = "ItmUpdate"
        Me.ItmUpdate.Size = New System.Drawing.Size(173, 22)
        Me.ItmUpdate.Text = "Check For Updates"
        '
        'ItmAbout
        '
        Me.ItmAbout.Name = "ItmAbout"
        Me.ItmAbout.Size = New System.Drawing.Size(173, 22)
        Me.ItmAbout.Text = "About"
        '
        'KMngr
        '
        Me.KMngr.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Silver
        '
        'StsMain
        '
        Me.StsMain.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.StsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LblStatus, Me.LblFacebook, Me.LblSprtr1, Me.LblTwitter, Me.LblSprtr2, Me.LblYoutube})
        Me.StsMain.Location = New System.Drawing.Point(0, 559)
        Me.StsMain.Name = "StsMain"
        Me.StsMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StsMain.Size = New System.Drawing.Size(907, 22)
        Me.StsMain.SizingGrip = False
        Me.StsMain.TabIndex = 0
        '
        'LblStatus
        '
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(646, 17)
        Me.LblStatus.Spring = True
        Me.LblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblFacebook
        '
        Me.LblFacebook.Image = CType(resources.GetObject("LblFacebook.Image"), System.Drawing.Image)
        Me.LblFacebook.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LblFacebook.IsLink = True
        Me.LblFacebook.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LblFacebook.Name = "LblFacebook"
        Me.LblFacebook.Size = New System.Drawing.Size(74, 17)
        Me.LblFacebook.Text = "Facebook"
        '
        'LblSprtr1
        '
        Me.LblSprtr1.Name = "LblSprtr1"
        Me.LblSprtr1.Size = New System.Drawing.Size(13, 17)
        Me.LblSprtr1.Text = "| "
        '
        'LblTwitter
        '
        Me.LblTwitter.Image = CType(resources.GetObject("LblTwitter.Image"), System.Drawing.Image)
        Me.LblTwitter.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LblTwitter.IsLink = True
        Me.LblTwitter.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LblTwitter.Name = "LblTwitter"
        Me.LblTwitter.Size = New System.Drawing.Size(60, 17)
        Me.LblTwitter.Text = "Twitter"
        '
        'LblSprtr2
        '
        Me.LblSprtr2.Name = "LblSprtr2"
        Me.LblSprtr2.Size = New System.Drawing.Size(13, 17)
        Me.LblSprtr2.Text = "| "
        '
        'LblYoutube
        '
        Me.LblYoutube.Image = CType(resources.GetObject("LblYoutube.Image"), System.Drawing.Image)
        Me.LblYoutube.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LblYoutube.IsLink = True
        Me.LblYoutube.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LblYoutube.Name = "LblYoutube"
        Me.LblYoutube.Size = New System.Drawing.Size(86, 17)
        Me.LblYoutube.Text = "Google Plus"
        '
        'BoxSide
        '
        Me.BoxSide.Dock = System.Windows.Forms.DockStyle.Left
        Me.BoxSide.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlToolTip
        Me.BoxSide.Location = New System.Drawing.Point(0, 56)
        Me.BoxSide.Name = "BoxSide"
        '
        'BoxSide.Panel
        '
        Me.BoxSide.Panel.Controls.Add(Me.BtnBookmark)
        Me.BoxSide.Panel.Controls.Add(Me.BtnDownload)
        Me.BoxSide.Panel.Controls.Add(Me.BtnWatch)
        Me.BoxSide.Panel.Controls.Add(Me.BtnSearch)
        Me.BoxSide.Size = New System.Drawing.Size(130, 503)
        Me.BoxSide.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right
        Me.BoxSide.TabIndex = 0
        '
        'BtnBookmark
        '
        Me.BtnBookmark.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form
        Me.BtnBookmark.Location = New System.Drawing.Point(14, 387)
        Me.BtnBookmark.Name = "BtnBookmark"
        Me.BtnBookmark.OverrideDefault.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
        Me.BtnBookmark.OverrideDefault.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
        Me.BtnBookmark.OverrideDefault.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.BtnBookmark.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.SteelBlue
        Me.BtnBookmark.OverrideDefault.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBookmark.OverrideDefault.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.BtnBookmark.Size = New System.Drawing.Size(100, 100)
        Me.BtnBookmark.StateNormal.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
        Me.BtnBookmark.StateNormal.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
        Me.BtnBookmark.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.BtnBookmark.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.SteelBlue
        Me.BtnBookmark.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBookmark.StateNormal.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.BtnBookmark.StatePressed.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
        Me.BtnBookmark.StatePressed.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
        Me.BtnBookmark.StatePressed.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.BtnBookmark.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.SteelBlue
        Me.BtnBookmark.StatePressed.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBookmark.StatePressed.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.BtnBookmark.StateTracking.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Light
        Me.BtnBookmark.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.SteelBlue
        Me.BtnBookmark.StateTracking.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBookmark.StateTracking.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.BtnBookmark.TabIndex = 0
        Me.BtnBookmark.TabStop = False
        Me.BtnBookmark.Values.Image = CType(resources.GetObject("BtnBookmark.Values.Image"), System.Drawing.Image)
        Me.BtnBookmark.Values.Text = "Bookmarks"
        '
        'BtnDownload
        '
        Me.BtnDownload.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form
        Me.BtnDownload.Location = New System.Drawing.Point(14, 263)
        Me.BtnDownload.Name = "BtnDownload"
        Me.BtnDownload.OverrideDefault.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
        Me.BtnDownload.OverrideDefault.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
        Me.BtnDownload.OverrideDefault.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.BtnDownload.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.SteelBlue
        Me.BtnDownload.OverrideDefault.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDownload.OverrideDefault.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.BtnDownload.Size = New System.Drawing.Size(100, 100)
        Me.BtnDownload.StateNormal.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
        Me.BtnDownload.StateNormal.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
        Me.BtnDownload.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.BtnDownload.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.SteelBlue
        Me.BtnDownload.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDownload.StateNormal.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.BtnDownload.StatePressed.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
        Me.BtnDownload.StatePressed.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
        Me.BtnDownload.StatePressed.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.BtnDownload.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.SteelBlue
        Me.BtnDownload.StatePressed.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDownload.StatePressed.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.BtnDownload.StateTracking.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Light
        Me.BtnDownload.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.SteelBlue
        Me.BtnDownload.StateTracking.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDownload.StateTracking.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.BtnDownload.TabIndex = 0
        Me.BtnDownload.TabStop = False
        Me.BtnDownload.Values.Image = CType(resources.GetObject("BtnDownload.Values.Image"), System.Drawing.Image)
        Me.BtnDownload.Values.Text = "Download"
        '
        'BtnWatch
        '
        Me.BtnWatch.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form
        Me.BtnWatch.Location = New System.Drawing.Point(14, 140)
        Me.BtnWatch.Name = "BtnWatch"
        Me.BtnWatch.OverrideDefault.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
        Me.BtnWatch.OverrideDefault.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
        Me.BtnWatch.OverrideDefault.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.BtnWatch.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.SteelBlue
        Me.BtnWatch.OverrideDefault.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnWatch.OverrideDefault.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.BtnWatch.Size = New System.Drawing.Size(100, 100)
        Me.BtnWatch.StateNormal.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
        Me.BtnWatch.StateNormal.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
        Me.BtnWatch.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.BtnWatch.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.SteelBlue
        Me.BtnWatch.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnWatch.StateNormal.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.BtnWatch.StatePressed.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
        Me.BtnWatch.StatePressed.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
        Me.BtnWatch.StatePressed.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.BtnWatch.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.SteelBlue
        Me.BtnWatch.StatePressed.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnWatch.StatePressed.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.BtnWatch.StateTracking.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Light
        Me.BtnWatch.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.SteelBlue
        Me.BtnWatch.StateTracking.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnWatch.StateTracking.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.BtnWatch.TabIndex = 0
        Me.BtnWatch.TabStop = False
        Me.BtnWatch.Values.Image = CType(resources.GetObject("BtnWatch.Values.Image"), System.Drawing.Image)
        Me.BtnWatch.Values.Text = "Watch"
        '
        'BtnSearch
        '
        Me.BtnSearch.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form
        Me.BtnSearch.Location = New System.Drawing.Point(14, 17)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.OverrideDefault.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
        Me.BtnSearch.OverrideDefault.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
        Me.BtnSearch.OverrideDefault.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.BtnSearch.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.SteelBlue
        Me.BtnSearch.OverrideDefault.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.OverrideDefault.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.BtnSearch.Size = New System.Drawing.Size(100, 100)
        Me.BtnSearch.StateNormal.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
        Me.BtnSearch.StateNormal.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
        Me.BtnSearch.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.BtnSearch.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.SteelBlue
        Me.BtnSearch.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.StateNormal.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.BtnSearch.StatePressed.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
        Me.BtnSearch.StatePressed.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
        Me.BtnSearch.StatePressed.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.BtnSearch.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.SteelBlue
        Me.BtnSearch.StatePressed.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.StatePressed.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.BtnSearch.StateTracking.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Light
        Me.BtnSearch.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.SteelBlue
        Me.BtnSearch.StateTracking.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.StateTracking.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.BtnSearch.TabIndex = 0
        Me.BtnSearch.TabStop = False
        Me.BtnSearch.Values.Image = CType(resources.GetObject("BtnSearch.Values.Image"), System.Drawing.Image)
        Me.BtnSearch.Values.Text = "Search"
        '
        'TmrFade
        '
        Me.TmrFade.Enabled = True
        Me.TmrFade.Interval = 50
        '
        'NIcon
        '
        Me.NIcon.ContextMenuStrip = Me.MnuTray
        Me.NIcon.Icon = CType(resources.GetObject("NIcon.Icon"), System.Drawing.Icon)
        Me.NIcon.Text = "MyTube"
        '
        'MnuTray
        '
        Me.MnuTray.BackColor = System.Drawing.Color.White
        Me.MnuTray.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MnuTray.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItmRestore, Me.MnuTraySprtr1, Me.ItmExit})
        Me.MnuTray.Name = "MnuTray"
        Me.MnuTray.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MnuTray.ShowImageMargin = False
        Me.MnuTray.Size = New System.Drawing.Size(89, 54)
        '
        'ItmRestore
        '
        Me.ItmRestore.Name = "ItmRestore"
        Me.ItmRestore.Size = New System.Drawing.Size(88, 22)
        Me.ItmRestore.Text = "Restore"
        '
        'MnuTraySprtr1
        '
        Me.MnuTraySprtr1.Name = "MnuTraySprtr1"
        Me.MnuTraySprtr1.Size = New System.Drawing.Size(85, 6)
        '
        'ItmExit
        '
        Me.ItmExit.Name = "ItmExit"
        Me.ItmExit.Size = New System.Drawing.Size(88, 22)
        Me.ItmExit.Text = "Exit"
        '
        'PnlSearch
        '
        Me.PnlSearch.Controls.Add(Me.BtnSearchYoutube)
        Me.PnlSearch.Controls.Add(Me.TxtSearch)
        Me.PnlSearch.Controls.Add(Me.PicYoutube)
        Me.PnlSearch.Controls.Add(Me.LstDate)
        Me.PnlSearch.Controls.Add(Me.LblDate)
        Me.PnlSearch.Controls.Add(Me.LstSort)
        Me.PnlSearch.Controls.Add(Me.LblDuration)
        Me.PnlSearch.Controls.Add(Me.LstDuration)
        Me.PnlSearch.Controls.Add(Me.LblSort)
        Me.PnlSearch.Controls.Add(Me.LblSearch)
        Me.PnlSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlSearch.Location = New System.Drawing.Point(130, 56)
        Me.PnlSearch.Name = "PnlSearch"
        Me.PnlSearch.Size = New System.Drawing.Size(777, 503)
        Me.PnlSearch.TabIndex = 1
        '
        'BtnSearchYoutube
        '
        Me.BtnSearchYoutube.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSearchYoutube.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnSearchYoutube.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnSearchYoutube.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearchYoutube.Location = New System.Drawing.Point(607, 173)
        Me.BtnSearchYoutube.Name = "BtnSearchYoutube"
        Me.BtnSearchYoutube.Size = New System.Drawing.Size(87, 27)
        Me.BtnSearchYoutube.TabIndex = 2
        Me.BtnSearchYoutube.Text = "Search"
        Me.BtnSearchYoutube.UseVisualStyleBackColor = False
        '
        'TxtSearch
        '
        Me.TxtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSearch.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearch.Location = New System.Drawing.Point(228, 173)
        Me.TxtSearch.MaxLength = 100
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(373, 27)
        Me.TxtSearch.TabIndex = 1
        Me.TxtSearch.WordWrap = False
        '
        'PicYoutube
        '
        Me.PicYoutube.ErrorImage = Nothing
        Me.PicYoutube.Image = CType(resources.GetObject("PicYoutube.Image"), System.Drawing.Image)
        Me.PicYoutube.InitialImage = Nothing
        Me.PicYoutube.Location = New System.Drawing.Point(84, 100)
        Me.PicYoutube.Name = "PicYoutube"
        Me.PicYoutube.Size = New System.Drawing.Size(128, 128)
        Me.PicYoutube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicYoutube.TabIndex = 0
        Me.PicYoutube.TabStop = False
        '
        'LstDate
        '
        Me.LstDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LstDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LstDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LstDate.FormattingEnabled = True
        Me.LstDate.ItemHeight = 15
        Me.LstDate.Items.AddRange(New Object() {"Today", "This week", "This month", "Any Date"})
        Me.LstDate.Location = New System.Drawing.Point(249, 290)
        Me.LstDate.Name = "LstDate"
        Me.LstDate.Size = New System.Drawing.Size(110, 105)
        Me.LstDate.TabIndex = 3
        '
        'LblDate
        '
        Me.LblDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblDate.AutoSize = True
        Me.LblDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDate.Location = New System.Drawing.Point(246, 257)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(76, 15)
        Me.LblDate.TabIndex = 0
        Me.LblDate.Text = "Upload Date"
        '
        'LstSort
        '
        Me.LstSort.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LstSort.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LstSort.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LstSort.FormattingEnabled = True
        Me.LstSort.ItemHeight = 15
        Me.LstSort.Items.AddRange(New Object() {"Title", "Relevance", "Upload date", "View count", "Video count", "Rating"})
        Me.LstSort.Location = New System.Drawing.Point(517, 290)
        Me.LstSort.Name = "LstSort"
        Me.LstSort.Size = New System.Drawing.Size(110, 105)
        Me.LstSort.TabIndex = 6
        '
        'LblDuration
        '
        Me.LblDuration.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblDuration.AutoSize = True
        Me.LblDuration.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDuration.Location = New System.Drawing.Point(372, 257)
        Me.LblDuration.Name = "LblDuration"
        Me.LblDuration.Size = New System.Drawing.Size(56, 15)
        Me.LblDuration.TabIndex = 0
        Me.LblDuration.Text = "Duration"
        '
        'LstDuration
        '
        Me.LstDuration.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LstDuration.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LstDuration.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LstDuration.FormattingEnabled = True
        Me.LstDuration.ItemHeight = 15
        Me.LstDuration.Items.AddRange(New Object() {"Short (~4 minutes)", "Medium (4~20 minutes)", "Long (20~ minutes)", "Any Duration"})
        Me.LstDuration.Location = New System.Drawing.Point(375, 290)
        Me.LstDuration.Name = "LstDuration"
        Me.LstDuration.Size = New System.Drawing.Size(110, 105)
        Me.LstDuration.TabIndex = 5
        '
        'LblSort
        '
        Me.LblSort.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblSort.AutoSize = True
        Me.LblSort.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSort.Location = New System.Drawing.Point(514, 257)
        Me.LblSort.Name = "LblSort"
        Me.LblSort.Size = New System.Drawing.Size(48, 15)
        Me.LblSort.TabIndex = 0
        Me.LblSort.Text = "Sort By"
        '
        'LblSearch
        '
        Me.LblSearch.AutoSize = True
        Me.LblSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSearch.Location = New System.Drawing.Point(226, 137)
        Me.LblSearch.Name = "LblSearch"
        Me.LblSearch.Size = New System.Drawing.Size(327, 21)
        Me.LblSearch.TabIndex = 0
        Me.LblSearch.Text = "Search YouTube for videos, movies and music"
        '
        'TmrCatch
        '
        Me.TmrCatch.Interval = 500
        '
        'BwCatch
        '
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(907, 581)
        Me.Controls.Add(Me.PnlSearch)
        Me.Controls.Add(Me.BoxSide)
        Me.Controls.Add(Me.StsMain)
        Me.Controls.Add(Me.HdrMain)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(880, 620)
        Me.Name = "FrmMain"
        Me.Opacity = 0.0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MyTube"
        Me.MnuHelp.ResumeLayout(False)
        Me.StsMain.ResumeLayout(False)
        Me.StsMain.PerformLayout()
        CType(Me.BoxSide.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BoxSide.Panel.ResumeLayout(False)
        CType(Me.BoxSide, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BoxSide.ResumeLayout(False)
        Me.MnuTray.ResumeLayout(False)
        Me.PnlSearch.ResumeLayout(False)
        Me.PnlSearch.PerformLayout()
        CType(Me.PicYoutube, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MDICntrl As SmartPCUtilities.Components.MdiClientController
    Friend WithEvents HdrMain As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents KMngr As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents BtnSettings As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents BtnHelp As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents BoxSide As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents BtnSearch As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents StsMain As System.Windows.Forms.StatusStrip
    Friend WithEvents MnuHelp As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BtnBookmark As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents BtnDownload As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents BtnWatch As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents ItmDoc As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmSupport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Sprtr1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ItmUpdate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TmrFade As System.Windows.Forms.Timer
    Friend WithEvents NIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents MnuTray As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ItmRestore As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuTraySprtr1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ItmExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LblTwitter As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LblFacebook As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LblSprtr1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LblSprtr2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LblYoutube As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PnlSearch As System.Windows.Forms.Panel
    Friend WithEvents BtnSearchYoutube As System.Windows.Forms.Button
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents PicYoutube As System.Windows.Forms.PictureBox
    Friend WithEvents LstDate As System.Windows.Forms.ListBox
    Friend WithEvents LblDate As System.Windows.Forms.Label
    Friend WithEvents LstSort As System.Windows.Forms.ListBox
    Friend WithEvents LblDuration As System.Windows.Forms.Label
    Friend WithEvents LstDuration As System.Windows.Forms.ListBox
    Friend WithEvents LblSort As System.Windows.Forms.Label
    Friend WithEvents LblSearch As System.Windows.Forms.Label
    Friend WithEvents TmrCatch As System.Windows.Forms.Timer
    Friend WithEvents BwCatch As System.ComponentModel.BackgroundWorker

End Class