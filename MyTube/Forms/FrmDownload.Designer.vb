<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDownload
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDownload))
        Me.HdrMain = New ComponentFactory.Krypton.Toolkit.KryptonHeader()
        Me.BtnNewDownload = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.BtnSprtr1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.BtnView = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.MnuView = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ItmViewTitle = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmViewDescription = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmViewSize = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmViewDuration = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmViewStatus = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmViewProgress = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmViewTransferRate = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmViewDate = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmViewLastTry = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmViewURL = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmViewReferer = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnSprtr2 = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.BtnSort = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.MnuSort = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ItmSortTitle = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmSortDescription = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmSortSize = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmSortDuration = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmSortStatus = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmSortProgress = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmSortTransferRate = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmSortDate = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmSortLastTry = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmSortSprtr1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ItmSortAsc = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmSortDesc = New System.Windows.Forms.ToolStripMenuItem()
        Me.BoxMain = New ComponentFactory.Krypton.Toolkit.KryptonGroup()
        Me.LstDownloads = New MyTube.FFListView()
        Me.ColTitle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColDescription = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColSize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColDuration = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColProgress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColTransferRate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColLastTry = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColURL = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColReferer = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MnuDownload = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ItmOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmOpenWith = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmLocation = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmSprtr1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ItmConvert = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmCon_WMV = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmCon_AVI = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmCon_MOV = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmCon_MP3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmSprtr4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ItmStartDownload = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmStopDownload = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmSprtr2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ItmRemoveDownload = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmSprtr3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ItmCopyDescription = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmCopyRefererURL = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmCopyDownloadURL = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImgLst = New System.Windows.Forms.ImageList(Me.components)
        Me.HdrDownload = New ComponentFactory.Krypton.Toolkit.KryptonHeader()
        Me.BtnConvert = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.BtnDownloadSprtr3 = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.BtnCopyDownloadURL = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.BtnDownloadSprtr2 = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.BtnRemove = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.BtnStopDownload = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.BtnStartDownload = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.BtnDownloadSprtr1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.BtnAddDownload = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.MnuDownloadOption = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ItmSingleVideo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ItmPlayList = New System.Windows.Forms.ToolStripMenuItem()
        Me.BWThread1 = New System.ComponentModel.BackgroundWorker()
        Me.BWThread2 = New System.ComponentModel.BackgroundWorker()
        Me.BWThread3 = New System.ComponentModel.BackgroundWorker()
        Me.BWThread4 = New System.ComponentModel.BackgroundWorker()
        Me.BWThread5 = New System.ComponentModel.BackgroundWorker()
        Me.MnuView.SuspendLayout()
        Me.MnuSort.SuspendLayout()
        CType(Me.BoxMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxMain.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BoxMain.Panel.SuspendLayout()
        Me.BoxMain.SuspendLayout()
        Me.MnuDownload.SuspendLayout()
        Me.MnuDownloadOption.SuspendLayout()
        Me.SuspendLayout()
        '
        'HdrMain
        '
        Me.HdrMain.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.BtnNewDownload, Me.BtnSprtr1, Me.BtnView, Me.BtnSprtr2, Me.BtnSort})
        Me.HdrMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.HdrMain.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HdrMain.Location = New System.Drawing.Point(0, 0)
        Me.HdrMain.Name = "HdrMain"
        Me.HdrMain.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.HdrMain.Size = New System.Drawing.Size(724, 34)
        Me.HdrMain.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.HdrMain.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HdrMain.TabIndex = 0
        Me.HdrMain.TabStop = False
        Me.HdrMain.Values.Description = ""
        Me.HdrMain.Values.Heading = " Downloads"
        Me.HdrMain.Values.Image = Nothing
        '
        'BtnNewDownload
        '
        Me.BtnNewDownload.ContextMenuStrip = Me.MnuDownloadOption
        Me.BtnNewDownload.Image = CType(resources.GetObject("BtnNewDownload.Image"), System.Drawing.Image)
        Me.BtnNewDownload.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.NavigatorOverflow
        Me.BtnNewDownload.Text = " New Download"
        Me.BtnNewDownload.UniqueName = ""
        '
        'BtnSprtr1
        '
        Me.BtnSprtr1.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.[False]
        Me.BtnSprtr1.Text = "|"
        Me.BtnSprtr1.UniqueName = ""
        '
        'BtnView
        '
        Me.BtnView.ContextMenuStrip = Me.MnuView
        Me.BtnView.Image = CType(resources.GetObject("BtnView.Image"), System.Drawing.Image)
        Me.BtnView.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.NavigatorOverflow
        Me.BtnView.Text = " View"
        Me.BtnView.UniqueName = ""
        '
        'MnuView
        '
        Me.MnuView.BackColor = System.Drawing.Color.White
        Me.MnuView.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MnuView.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItmViewTitle, Me.ItmViewDescription, Me.ItmViewSize, Me.ItmViewDuration, Me.ItmViewStatus, Me.ItmViewProgress, Me.ItmViewTransferRate, Me.ItmViewDate, Me.ItmViewLastTry, Me.ItmViewURL, Me.ItmViewReferer})
        Me.MnuView.Name = "MnuView"
        Me.MnuView.Size = New System.Drawing.Size(153, 246)
        '
        'ItmViewTitle
        '
        Me.ItmViewTitle.Checked = True
        Me.ItmViewTitle.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ItmViewTitle.Name = "ItmViewTitle"
        Me.ItmViewTitle.Size = New System.Drawing.Size(152, 22)
        Me.ItmViewTitle.Text = "Title"
        '
        'ItmViewDescription
        '
        Me.ItmViewDescription.Name = "ItmViewDescription"
        Me.ItmViewDescription.Size = New System.Drawing.Size(152, 22)
        Me.ItmViewDescription.Text = "Description"
        '
        'ItmViewSize
        '
        Me.ItmViewSize.Checked = True
        Me.ItmViewSize.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ItmViewSize.Name = "ItmViewSize"
        Me.ItmViewSize.Size = New System.Drawing.Size(152, 22)
        Me.ItmViewSize.Text = "Size"
        '
        'ItmViewDuration
        '
        Me.ItmViewDuration.Name = "ItmViewDuration"
        Me.ItmViewDuration.Size = New System.Drawing.Size(152, 22)
        Me.ItmViewDuration.Text = "Duration"
        '
        'ItmViewStatus
        '
        Me.ItmViewStatus.Checked = True
        Me.ItmViewStatus.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ItmViewStatus.Name = "ItmViewStatus"
        Me.ItmViewStatus.Size = New System.Drawing.Size(152, 22)
        Me.ItmViewStatus.Text = "Status"
        '
        'ItmViewProgress
        '
        Me.ItmViewProgress.Checked = True
        Me.ItmViewProgress.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ItmViewProgress.Name = "ItmViewProgress"
        Me.ItmViewProgress.Size = New System.Drawing.Size(152, 22)
        Me.ItmViewProgress.Text = "Progress"
        '
        'ItmViewTransferRate
        '
        Me.ItmViewTransferRate.Checked = True
        Me.ItmViewTransferRate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ItmViewTransferRate.Name = "ItmViewTransferRate"
        Me.ItmViewTransferRate.Size = New System.Drawing.Size(152, 22)
        Me.ItmViewTransferRate.Text = "Transfer Rate"
        '
        'ItmViewDate
        '
        Me.ItmViewDate.Checked = True
        Me.ItmViewDate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ItmViewDate.Name = "ItmViewDate"
        Me.ItmViewDate.Size = New System.Drawing.Size(152, 22)
        Me.ItmViewDate.Text = "Date Added"
        '
        'ItmViewLastTry
        '
        Me.ItmViewLastTry.Name = "ItmViewLastTry"
        Me.ItmViewLastTry.Size = New System.Drawing.Size(152, 22)
        Me.ItmViewLastTry.Text = "Last Try Date"
        '
        'ItmViewURL
        '
        Me.ItmViewURL.Name = "ItmViewURL"
        Me.ItmViewURL.Size = New System.Drawing.Size(152, 22)
        Me.ItmViewURL.Text = "Download URL"
        '
        'ItmViewReferer
        '
        Me.ItmViewReferer.Name = "ItmViewReferer"
        Me.ItmViewReferer.Size = New System.Drawing.Size(152, 22)
        Me.ItmViewReferer.Text = "Referer URL"
        '
        'BtnSprtr2
        '
        Me.BtnSprtr2.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.[False]
        Me.BtnSprtr2.Text = "|"
        Me.BtnSprtr2.UniqueName = ""
        '
        'BtnSort
        '
        Me.BtnSort.ContextMenuStrip = Me.MnuSort
        Me.BtnSort.Image = CType(resources.GetObject("BtnSort.Image"), System.Drawing.Image)
        Me.BtnSort.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.NavigatorOverflow
        Me.BtnSort.Text = " Sort"
        Me.BtnSort.UniqueName = ""
        '
        'MnuSort
        '
        Me.MnuSort.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MnuSort.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItmSortTitle, Me.ItmSortDescription, Me.ItmSortSize, Me.ItmSortDuration, Me.ItmSortStatus, Me.ItmSortProgress, Me.ItmSortTransferRate, Me.ItmSortDate, Me.ItmSortLastTry, Me.ItmSortSprtr1, Me.ItmSortAsc, Me.ItmSortDesc})
        Me.MnuSort.Name = "MnuSort"
        Me.MnuSort.Size = New System.Drawing.Size(161, 252)
        '
        'ItmSortTitle
        '
        Me.ItmSortTitle.Checked = True
        Me.ItmSortTitle.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ItmSortTitle.Name = "ItmSortTitle"
        Me.ItmSortTitle.Size = New System.Drawing.Size(160, 22)
        Me.ItmSortTitle.Text = "By Title"
        '
        'ItmSortDescription
        '
        Me.ItmSortDescription.Name = "ItmSortDescription"
        Me.ItmSortDescription.Size = New System.Drawing.Size(160, 22)
        Me.ItmSortDescription.Text = "By Description"
        '
        'ItmSortSize
        '
        Me.ItmSortSize.Name = "ItmSortSize"
        Me.ItmSortSize.Size = New System.Drawing.Size(160, 22)
        Me.ItmSortSize.Text = "By Size"
        '
        'ItmSortDuration
        '
        Me.ItmSortDuration.Name = "ItmSortDuration"
        Me.ItmSortDuration.Size = New System.Drawing.Size(160, 22)
        Me.ItmSortDuration.Text = "By Duration"
        '
        'ItmSortStatus
        '
        Me.ItmSortStatus.Name = "ItmSortStatus"
        Me.ItmSortStatus.Size = New System.Drawing.Size(160, 22)
        Me.ItmSortStatus.Text = "By Status"
        '
        'ItmSortProgress
        '
        Me.ItmSortProgress.Name = "ItmSortProgress"
        Me.ItmSortProgress.Size = New System.Drawing.Size(160, 22)
        Me.ItmSortProgress.Text = "By Progress"
        '
        'ItmSortTransferRate
        '
        Me.ItmSortTransferRate.Name = "ItmSortTransferRate"
        Me.ItmSortTransferRate.Size = New System.Drawing.Size(160, 22)
        Me.ItmSortTransferRate.Text = "By Transfer Rate"
        '
        'ItmSortDate
        '
        Me.ItmSortDate.Name = "ItmSortDate"
        Me.ItmSortDate.Size = New System.Drawing.Size(160, 22)
        Me.ItmSortDate.Text = "By Date Added"
        '
        'ItmSortLastTry
        '
        Me.ItmSortLastTry.Name = "ItmSortLastTry"
        Me.ItmSortLastTry.Size = New System.Drawing.Size(160, 22)
        Me.ItmSortLastTry.Text = "By Last Try Date"
        '
        'ItmSortSprtr1
        '
        Me.ItmSortSprtr1.Name = "ItmSortSprtr1"
        Me.ItmSortSprtr1.Size = New System.Drawing.Size(157, 6)
        '
        'ItmSortAsc
        '
        Me.ItmSortAsc.Checked = True
        Me.ItmSortAsc.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ItmSortAsc.Name = "ItmSortAsc"
        Me.ItmSortAsc.Size = New System.Drawing.Size(160, 22)
        Me.ItmSortAsc.Text = "A > Z Sort Order"
        '
        'ItmSortDesc
        '
        Me.ItmSortDesc.Name = "ItmSortDesc"
        Me.ItmSortDesc.Size = New System.Drawing.Size(160, 22)
        Me.ItmSortDesc.Text = "Z > A Sort Order"
        '
        'BoxMain
        '
        Me.BoxMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BoxMain.Location = New System.Drawing.Point(17, 58)
        Me.BoxMain.Name = "BoxMain"
        Me.BoxMain.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        '
        'BoxMain.Panel
        '
        Me.BoxMain.Panel.Controls.Add(Me.LstDownloads)
        Me.BoxMain.Panel.Controls.Add(Me.HdrDownload)
        Me.BoxMain.Size = New System.Drawing.Size(690, 418)
        Me.BoxMain.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.BoxMain.StateNormal.Border.Rounding = 2
        Me.BoxMain.TabIndex = 1
        '
        'LstDownloads
        '
        Me.LstDownloads.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LstDownloads.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColTitle, Me.ColDescription, Me.ColSize, Me.ColDuration, Me.ColStatus, Me.ColProgress, Me.ColTransferRate, Me.ColDate, Me.ColLastTry, Me.ColURL, Me.ColReferer})
        Me.LstDownloads.ContextMenuStrip = Me.MnuDownload
        Me.LstDownloads.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LstDownloads.FullRowSelect = True
        Me.LstDownloads.GridLines = True
        Me.LstDownloads.Location = New System.Drawing.Point(0, 34)
        Me.LstDownloads.Name = "LstDownloads"
        Me.LstDownloads.Size = New System.Drawing.Size(686, 380)
        Me.LstDownloads.SmallImageList = Me.ImgLst
        Me.LstDownloads.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.LstDownloads.TabIndex = 1
        Me.LstDownloads.UseCompatibleStateImageBehavior = False
        Me.LstDownloads.View = System.Windows.Forms.View.Details
        '
        'ColTitle
        '
        Me.ColTitle.Text = "Title"
        Me.ColTitle.Width = 180
        '
        'ColDescription
        '
        Me.ColDescription.Text = "Description"
        Me.ColDescription.Width = 0
        '
        'ColSize
        '
        Me.ColSize.Text = "Size"
        Me.ColSize.Width = 90
        '
        'ColDuration
        '
        Me.ColDuration.Text = "Duration"
        Me.ColDuration.Width = 0
        '
        'ColStatus
        '
        Me.ColStatus.Text = "Status"
        Me.ColStatus.Width = 110
        '
        'ColProgress
        '
        Me.ColProgress.Text = "Progress"
        Me.ColProgress.Width = 95
        '
        'ColTransferRate
        '
        Me.ColTransferRate.Text = "Transfer Rate"
        Me.ColTransferRate.Width = 90
        '
        'ColDate
        '
        Me.ColDate.Text = "Date Added"
        Me.ColDate.Width = 110
        '
        'ColLastTry
        '
        Me.ColLastTry.Text = "Last Try Date"
        Me.ColLastTry.Width = 0
        '
        'ColURL
        '
        Me.ColURL.Text = "Download URL"
        Me.ColURL.Width = 0
        '
        'ColReferer
        '
        Me.ColReferer.Text = "Referer URL"
        Me.ColReferer.Width = 0
        '
        'MnuDownload
        '
        Me.MnuDownload.BackColor = System.Drawing.Color.White
        Me.MnuDownload.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MnuDownload.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItmOpen, Me.ItmOpenWith, Me.ItmLocation, Me.ItmSprtr1, Me.ItmConvert, Me.ItmSprtr4, Me.ItmStartDownload, Me.ItmStopDownload, Me.ItmSprtr2, Me.ItmRemoveDownload, Me.ItmSprtr3, Me.ItmCopyDescription, Me.ItmCopyRefererURL, Me.ItmCopyDownloadURL})
        Me.MnuDownload.Name = "MnuDownload"
        Me.MnuDownload.Size = New System.Drawing.Size(184, 248)
        '
        'ItmOpen
        '
        Me.ItmOpen.Name = "ItmOpen"
        Me.ItmOpen.Size = New System.Drawing.Size(183, 22)
        Me.ItmOpen.Text = "Open"
        '
        'ItmOpenWith
        '
        Me.ItmOpenWith.Name = "ItmOpenWith"
        Me.ItmOpenWith.Size = New System.Drawing.Size(183, 22)
        Me.ItmOpenWith.Text = "Open with..."
        '
        'ItmLocation
        '
        Me.ItmLocation.Name = "ItmLocation"
        Me.ItmLocation.Size = New System.Drawing.Size(183, 22)
        Me.ItmLocation.Text = "Open Location"
        '
        'ItmSprtr1
        '
        Me.ItmSprtr1.Name = "ItmSprtr1"
        Me.ItmSprtr1.Size = New System.Drawing.Size(180, 6)
        '
        'ItmConvert
        '
        Me.ItmConvert.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItmCon_WMV, Me.ItmCon_AVI, Me.ItmCon_MOV, Me.ItmCon_MP3})
        Me.ItmConvert.Name = "ItmConvert"
        Me.ItmConvert.Size = New System.Drawing.Size(183, 22)
        Me.ItmConvert.Text = "Convert To ..."
        '
        'ItmCon_WMV
        '
        Me.ItmCon_WMV.Name = "ItmCon_WMV"
        Me.ItmCon_WMV.Size = New System.Drawing.Size(264, 22)
        Me.ItmCon_WMV.Text = "Windows Media Video (V.7 WMV)"
        '
        'ItmCon_AVI
        '
        Me.ItmCon_AVI.Name = "ItmCon_AVI"
        Me.ItmCon_AVI.Size = New System.Drawing.Size(264, 22)
        Me.ItmCon_AVI.Text = "Xvid MPEG-4 Codec (AVI)"
        '
        'ItmCon_MOV
        '
        Me.ItmCon_MOV.Name = "ItmCon_MOV"
        Me.ItmCon_MOV.Size = New System.Drawing.Size(264, 22)
        Me.ItmCon_MOV.Text = "iPod Video (Apple QuickTime MOV)"
        '
        'ItmCon_MP3
        '
        Me.ItmCon_MP3.Name = "ItmCon_MP3"
        Me.ItmCon_MP3.Size = New System.Drawing.Size(264, 22)
        Me.ItmCon_MP3.Text = "MPEG Audio Layer 3 (MP3)"
        '
        'ItmSprtr4
        '
        Me.ItmSprtr4.Name = "ItmSprtr4"
        Me.ItmSprtr4.Size = New System.Drawing.Size(180, 6)
        '
        'ItmStartDownload
        '
        Me.ItmStartDownload.Name = "ItmStartDownload"
        Me.ItmStartDownload.Size = New System.Drawing.Size(183, 22)
        Me.ItmStartDownload.Text = "Resume Download"
        '
        'ItmStopDownload
        '
        Me.ItmStopDownload.Name = "ItmStopDownload"
        Me.ItmStopDownload.Size = New System.Drawing.Size(183, 22)
        Me.ItmStopDownload.Text = "Stop Download"
        '
        'ItmSprtr2
        '
        Me.ItmSprtr2.Name = "ItmSprtr2"
        Me.ItmSprtr2.Size = New System.Drawing.Size(180, 6)
        '
        'ItmRemoveDownload
        '
        Me.ItmRemoveDownload.Name = "ItmRemoveDownload"
        Me.ItmRemoveDownload.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.ItmRemoveDownload.Size = New System.Drawing.Size(183, 22)
        Me.ItmRemoveDownload.Text = "Remove"
        '
        'ItmSprtr3
        '
        Me.ItmSprtr3.Name = "ItmSprtr3"
        Me.ItmSprtr3.Size = New System.Drawing.Size(180, 6)
        '
        'ItmCopyDescription
        '
        Me.ItmCopyDescription.Name = "ItmCopyDescription"
        Me.ItmCopyDescription.Size = New System.Drawing.Size(183, 22)
        Me.ItmCopyDescription.Text = "Copy Description"
        '
        'ItmCopyRefererURL
        '
        Me.ItmCopyRefererURL.Name = "ItmCopyRefererURL"
        Me.ItmCopyRefererURL.Size = New System.Drawing.Size(183, 22)
        Me.ItmCopyRefererURL.Text = "Copy Referer URL"
        '
        'ItmCopyDownloadURL
        '
        Me.ItmCopyDownloadURL.Name = "ItmCopyDownloadURL"
        Me.ItmCopyDownloadURL.Size = New System.Drawing.Size(183, 22)
        Me.ItmCopyDownloadURL.Text = "Copy Download URL"
        '
        'ImgLst
        '
        Me.ImgLst.ImageStream = CType(resources.GetObject("ImgLst.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgLst.TransparentColor = System.Drawing.Color.White
        Me.ImgLst.Images.SetKeyName(0, "videofile")
        '
        'HdrDownload
        '
        Me.HdrDownload.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.BtnConvert, Me.BtnDownloadSprtr3, Me.BtnCopyDownloadURL, Me.BtnDownloadSprtr2, Me.BtnRemove, Me.BtnStopDownload, Me.BtnStartDownload, Me.BtnDownloadSprtr1, Me.BtnAddDownload})
        Me.HdrDownload.Dock = System.Windows.Forms.DockStyle.Top
        Me.HdrDownload.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HdrDownload.Location = New System.Drawing.Point(0, 0)
        Me.HdrDownload.Name = "HdrDownload"
        Me.HdrDownload.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.HdrDownload.Size = New System.Drawing.Size(686, 34)
        Me.HdrDownload.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear50
        Me.HdrDownload.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.HdrDownload.TabIndex = 0
        Me.HdrDownload.TabStop = False
        Me.HdrDownload.Values.Description = ""
        Me.HdrDownload.Values.Heading = ""
        Me.HdrDownload.Values.Image = Nothing
        '
        'BtnConvert
        '
        Me.BtnConvert.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
        Me.BtnConvert.Image = CType(resources.GetObject("BtnConvert.Image"), System.Drawing.Image)
        Me.BtnConvert.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Form
        Me.BtnConvert.Text = "Convert"
        Me.BtnConvert.UniqueName = "2881404DF81941FF0787AD27023609AA"
        '
        'BtnDownloadSprtr3
        '
        Me.BtnDownloadSprtr3.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
        Me.BtnDownloadSprtr3.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.[False]
        Me.BtnDownloadSprtr3.Text = "|"
        Me.BtnDownloadSprtr3.UniqueName = "5A2D8FA4E0E6487F4C94CCA6935A054B"
        '
        'BtnCopyDownloadURL
        '
        Me.BtnCopyDownloadURL.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
        Me.BtnCopyDownloadURL.Image = CType(resources.GetObject("BtnCopyDownloadURL.Image"), System.Drawing.Image)
        Me.BtnCopyDownloadURL.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Form
        Me.BtnCopyDownloadURL.Text = " Copy URL"
        Me.BtnCopyDownloadURL.UniqueName = ""
        '
        'BtnDownloadSprtr2
        '
        Me.BtnDownloadSprtr2.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
        Me.BtnDownloadSprtr2.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.[False]
        Me.BtnDownloadSprtr2.Text = "|"
        Me.BtnDownloadSprtr2.UniqueName = ""
        '
        'BtnRemove
        '
        Me.BtnRemove.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
        Me.BtnRemove.Image = CType(resources.GetObject("BtnRemove.Image"), System.Drawing.Image)
        Me.BtnRemove.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Form
        Me.BtnRemove.Text = " Remove"
        Me.BtnRemove.UniqueName = ""
        '
        'BtnStopDownload
        '
        Me.BtnStopDownload.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
        Me.BtnStopDownload.Image = CType(resources.GetObject("BtnStopDownload.Image"), System.Drawing.Image)
        Me.BtnStopDownload.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Form
        Me.BtnStopDownload.Text = " Stop"
        Me.BtnStopDownload.UniqueName = ""
        '
        'BtnStartDownload
        '
        Me.BtnStartDownload.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
        Me.BtnStartDownload.Image = CType(resources.GetObject("BtnStartDownload.Image"), System.Drawing.Image)
        Me.BtnStartDownload.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Form
        Me.BtnStartDownload.Text = " Resume"
        Me.BtnStartDownload.UniqueName = ""
        '
        'BtnDownloadSprtr1
        '
        Me.BtnDownloadSprtr1.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
        Me.BtnDownloadSprtr1.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.[False]
        Me.BtnDownloadSprtr1.Text = "|"
        Me.BtnDownloadSprtr1.UniqueName = ""
        '
        'BtnAddDownload
        '
        Me.BtnAddDownload.ContextMenuStrip = Me.MnuDownloadOption
        Me.BtnAddDownload.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
        Me.BtnAddDownload.Image = CType(resources.GetObject("BtnAddDownload.Image"), System.Drawing.Image)
        Me.BtnAddDownload.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Form
        Me.BtnAddDownload.Text = " Add Download"
        Me.BtnAddDownload.UniqueName = ""
        '
        'MnuDownloadOption
        '
        Me.MnuDownloadOption.BackColor = System.Drawing.Color.White
        Me.MnuDownloadOption.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MnuDownloadOption.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItmSingleVideo, Me.ToolStripSeparator1, Me.ItmPlayList})
        Me.MnuDownloadOption.Name = "MnuDownload"
        Me.MnuDownloadOption.Size = New System.Drawing.Size(153, 76)
        '
        'ItmSingleVideo
        '
        Me.ItmSingleVideo.Name = "ItmSingleVideo"
        Me.ItmSingleVideo.Size = New System.Drawing.Size(152, 22)
        Me.ItmSingleVideo.Text = "Single Video"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'ItmPlayList
        '
        Me.ItmPlayList.Name = "ItmPlayList"
        Me.ItmPlayList.Size = New System.Drawing.Size(152, 22)
        Me.ItmPlayList.Text = "Play List"
        '
        'BWThread1
        '
        Me.BWThread1.WorkerReportsProgress = True
        Me.BWThread1.WorkerSupportsCancellation = True
        '
        'BWThread2
        '
        Me.BWThread2.WorkerReportsProgress = True
        Me.BWThread2.WorkerSupportsCancellation = True
        '
        'BWThread3
        '
        Me.BWThread3.WorkerReportsProgress = True
        Me.BWThread3.WorkerSupportsCancellation = True
        '
        'BWThread4
        '
        Me.BWThread4.WorkerReportsProgress = True
        Me.BWThread4.WorkerSupportsCancellation = True
        '
        'BWThread5
        '
        Me.BWThread5.WorkerReportsProgress = True
        Me.BWThread5.WorkerSupportsCancellation = True
        '
        'FrmDownload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(724, 504)
        Me.Controls.Add(Me.BoxMain)
        Me.Controls.Add(Me.HdrMain)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "FrmDownload"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Download"
        Me.MnuView.ResumeLayout(False)
        Me.MnuSort.ResumeLayout(False)
        CType(Me.BoxMain.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BoxMain.Panel.ResumeLayout(False)
        Me.BoxMain.Panel.PerformLayout()
        CType(Me.BoxMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BoxMain.ResumeLayout(False)
        Me.MnuDownload.ResumeLayout(False)
        Me.MnuDownloadOption.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HdrMain As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents BtnNewDownload As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents BtnSprtr1 As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents BtnView As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents BtnSprtr2 As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents BtnSort As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents MnuSort As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ItmSortTitle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmSortDescription As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmSortSize As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmSortDate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmSortSprtr1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ItmSortAsc As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmSortDesc As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmSortDuration As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmSortStatus As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmSortTransferRate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuView As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ItmViewTitle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmViewDescription As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmViewSize As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmViewDuration As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmViewStatus As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmViewTransferRate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmViewDate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmViewReferer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BoxMain As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents HdrDownload As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents BtnStartDownload As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents LstDownloads As FFListView
    Friend WithEvents ColTitle As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColDescription As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColSize As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColDuration As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColStatus As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColTransferRate As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColReferer As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColURL As System.Windows.Forms.ColumnHeader
    Friend WithEvents ItmViewURL As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmViewLastTry As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmSortLastTry As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuDownload As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ImgLst As System.Windows.Forms.ImageList
    Friend WithEvents ColLastTry As System.Windows.Forms.ColumnHeader
    Friend WithEvents ItmOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmOpenWith As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmLocation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmSprtr2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ItmStartDownload As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmStopDownload As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmRemoveDownload As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmSprtr1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ItmSprtr3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ItmCopyDescription As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmCopyRefererURL As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmCopyDownloadURL As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnCopyDownloadURL As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents BtnRemove As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents BtnStopDownload As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents BtnAddDownload As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents BtnDownloadSprtr2 As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents BtnDownloadSprtr1 As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents ColProgress As System.Windows.Forms.ColumnHeader
    Friend WithEvents ItmViewProgress As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmSortProgress As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BWThread1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BWThread2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BWThread3 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BWThread4 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BWThread5 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ItmConvert As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmSprtr4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnConvert As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents BtnDownloadSprtr3 As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents ItmCon_WMV As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmCon_AVI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmCon_MOV As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmCon_MP3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuDownloadOption As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ItmSingleVideo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ItmPlayList As System.Windows.Forms.ToolStripMenuItem
End Class