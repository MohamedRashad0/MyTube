<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBookmarks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBookmarks))
        Me.HdrMain = New ComponentFactory.Krypton.Toolkit.KryptonHeader()
        Me.BtnNewBookmark = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.BtnSprtr1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.BtnView = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.MnuView = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ItmViewIcons = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmViewSprtr1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ItmViewDetails = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmViewSprtr2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ItmViewTiles = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnSprtr2 = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.BtnSort = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.MnuSort = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ItmSortTitle = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmSortDescription = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmSortDuration = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmSortDate = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmSortSprtr1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ItmSortAsc = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmSortDesc = New System.Windows.Forms.ToolStripMenuItem()
        Me.LstBookmarks = New FFListView
        Me.ColTitle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColDescription = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColDuration = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColURL = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MnuBookmark = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ItmSprtr1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ItmWatch = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmDownload = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmSprtr2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ItmCopyURL = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmCopyDescription = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImgLst = New System.Windows.Forms.ImageList(Me.components)
        Me.MnuView.SuspendLayout()
        Me.MnuSort.SuspendLayout()
        Me.MnuBookmark.SuspendLayout()
        Me.SuspendLayout()
        '
        'HdrMain
        '
        Me.HdrMain.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.BtnNewBookmark, Me.BtnSprtr1, Me.BtnView, Me.BtnSprtr2, Me.BtnSort})
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
        Me.HdrMain.Values.Heading = " Bookmarks"
        Me.HdrMain.Values.Image = Nothing
        '
        'BtnNewBookmark
        '
        Me.BtnNewBookmark.Image = CType(resources.GetObject("BtnNewBookmark.Image"), System.Drawing.Image)
        Me.BtnNewBookmark.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.NavigatorOverflow
        Me.BtnNewBookmark.Text = " New Bookmark"
        Me.BtnNewBookmark.UniqueName = ""
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
        Me.MnuView.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItmViewIcons, Me.ItmViewSprtr1, Me.ItmViewDetails, Me.ItmViewSprtr2, Me.ItmViewTiles})
        Me.MnuView.Name = "MnuView"
        Me.MnuView.Size = New System.Drawing.Size(135, 82)
        '
        'ItmViewIcons
        '
        Me.ItmViewIcons.Name = "ItmViewIcons"
        Me.ItmViewIcons.Size = New System.Drawing.Size(134, 22)
        Me.ItmViewIcons.Text = "Large Icons"
        '
        'ItmViewSprtr1
        '
        Me.ItmViewSprtr1.Name = "ItmViewSprtr1"
        Me.ItmViewSprtr1.Size = New System.Drawing.Size(131, 6)
        '
        'ItmViewDetails
        '
        Me.ItmViewDetails.Name = "ItmViewDetails"
        Me.ItmViewDetails.Size = New System.Drawing.Size(134, 22)
        Me.ItmViewDetails.Text = "Details"
        '
        'ItmViewSprtr2
        '
        Me.ItmViewSprtr2.Name = "ItmViewSprtr2"
        Me.ItmViewSprtr2.Size = New System.Drawing.Size(131, 6)
        '
        'ItmViewTiles
        '
        Me.ItmViewTiles.Checked = True
        Me.ItmViewTiles.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ItmViewTiles.Name = "ItmViewTiles"
        Me.ItmViewTiles.Size = New System.Drawing.Size(134, 22)
        Me.ItmViewTiles.Text = "Tiles"
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
        Me.MnuSort.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItmSortTitle, Me.ItmSortDescription, Me.ItmSortDuration, Me.ItmSortDate, Me.ItmSortSprtr1, Me.ItmSortAsc, Me.ItmSortDesc})
        Me.MnuSort.Name = "MnuSort"
        Me.MnuSort.Size = New System.Drawing.Size(161, 142)
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
        Me.ItmSortDescription.Name = "ItmSortDecription"
        Me.ItmSortDescription.Size = New System.Drawing.Size(160, 22)
        Me.ItmSortDescription.Text = "By Description"
        '
        'ItmSortDuration
        '
        Me.ItmSortDuration.Name = "ItmSortDuration"
        Me.ItmSortDuration.Size = New System.Drawing.Size(160, 22)
        Me.ItmSortDuration.Text = "By Duration"
        '
        'ItmSortDate
        '
        Me.ItmSortDate.Name = "ItmSortDate"
        Me.ItmSortDate.Size = New System.Drawing.Size(160, 22)
        Me.ItmSortDate.Text = "By Date Added"
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
        'LstBookmarks
        '
        Me.LstBookmarks.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.LstBookmarks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LstBookmarks.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LstBookmarks.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColTitle, Me.ColDescription, Me.ColDuration, Me.ColURL, Me.ColDate})
        Me.LstBookmarks.ContextMenuStrip = Me.MnuBookmark
        Me.LstBookmarks.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstBookmarks.LargeImageList = Me.ImgLst
        Me.LstBookmarks.Location = New System.Drawing.Point(24, 34)
        Me.LstBookmarks.Name = "LstBookmarks"
        Me.LstBookmarks.Size = New System.Drawing.Size(700, 470)
        Me.LstBookmarks.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.LstBookmarks.TabIndex = 1
        Me.LstBookmarks.TileSize = New System.Drawing.Size(650, 170)
        Me.LstBookmarks.UseCompatibleStateImageBehavior = False
        Me.LstBookmarks.View = System.Windows.Forms.View.Tile
        '
        'ColTitle
        '
        Me.ColTitle.Text = "Title"
        Me.ColTitle.Width = 160
        '
        'ColDescription
        '
        Me.ColDescription.Text = "Description"
        Me.ColDescription.Width = 150
        '
        'ColDuration
        '
        Me.ColDuration.Text = "Duration"
        Me.ColDuration.Width = 130
        '
        'ColURL
        '
        Me.ColURL.Text = "Video URL"
        Me.ColURL.Width = 110
        '
        'ColDate
        '
        Me.ColDate.Text = "Date Added"
        Me.ColDate.Width = 140
        '
        'MnuBookmark
        '
        Me.MnuBookmark.BackColor = System.Drawing.Color.White
        Me.MnuBookmark.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MnuBookmark.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItmWatch, Me.ItmDownload, Me.ItmOpen, Me.ItmSprtr1, Me.ItmCopyURL, Me.ItmCopyDescription, Me.ItmSprtr2, Me.ItmDelete, Me.ItmRefresh})
        Me.MnuBookmark.Name = "MnuTasks"
        Me.MnuBookmark.Size = New System.Drawing.Size(189, 198)
        '
        'ItmSprtr1
        '
        Me.ItmSprtr1.Name = "ItmSprtr1"
        Me.ItmSprtr1.Size = New System.Drawing.Size(185, 6)
        '
        'ItmWatch
        '
        Me.ItmWatch.Name = "ItmWatch"
        Me.ItmWatch.Size = New System.Drawing.Size(188, 22)
        Me.ItmWatch.Text = "Watch Video"
        '
        'ItmDownload
        '
        Me.ItmDownload.Name = "ItmDownload"
        Me.ItmDownload.Size = New System.Drawing.Size(188, 22)
        Me.ItmDownload.Text = "Download Video"
        '
        'ItmOpen
        '
        Me.ItmOpen.Name = "ItmOpen"
        Me.ItmOpen.Size = New System.Drawing.Size(188, 22)
        Me.ItmOpen.Text = "Open in Web Browser"
        '
        'ItmSprtr2
        '
        Me.ItmSprtr2.Name = "ItmSprtr2"
        Me.ItmSprtr2.Size = New System.Drawing.Size(185, 6)
        '
        'ItmCopyURL
        '
        Me.ItmCopyURL.Name = "ItmCopyURL"
        Me.ItmCopyURL.Size = New System.Drawing.Size(188, 22)
        Me.ItmCopyURL.Text = "Copy Video URL"
        '
        'ItmCopyDescription
        '
        Me.ItmCopyDescription.Name = "ItmCopyDescription"
        Me.ItmCopyDescription.Size = New System.Drawing.Size(188, 22)
        Me.ItmCopyDescription.Text = "Copy Description"
        '
        'ItmDelete
        '
        Me.ItmDelete.Name = "ItmDelete"
        Me.ItmDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.ItmDelete.Size = New System.Drawing.Size(188, 22)
        Me.ItmDelete.Text = "Delete"
        '
        'ItmRefresh
        '
        Me.ItmRefresh.Name = "ItmRefresh"
        Me.ItmRefresh.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.ItmRefresh.Size = New System.Drawing.Size(188, 22)
        Me.ItmRefresh.Text = "Refresh"
        '
        'ImgLst
        '
        Me.ImgLst.ImageStream = CType(resources.GetObject("ImgLst.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgLst.TransparentColor = System.Drawing.Color.White
        Me.ImgLst.Images.SetKeyName(0, "nopreview")
        '
        'FrmBookmarks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(724, 504)
        Me.Controls.Add(Me.LstBookmarks)
        Me.Controls.Add(Me.HdrMain)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "FrmBookmarks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bookmarks"
        Me.MnuView.ResumeLayout(False)
        Me.MnuSort.ResumeLayout(False)
        Me.MnuBookmark.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HdrMain As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents LstBookmarks As FFListView
    Friend WithEvents ColTitle As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColDescription As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColDuration As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColURL As System.Windows.Forms.ColumnHeader
    Friend WithEvents ImgLst As System.Windows.Forms.ImageList
    Friend WithEvents MnuBookmark As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ItmWatch As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmDownload As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmSprtr2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ItmDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmSprtr1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ItmCopyURL As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmCopyDescription As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnNewBookmark As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents BtnView As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents BtnSort As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents BtnSprtr1 As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents BtnSprtr2 As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents MnuView As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MnuSort As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ItmViewIcons As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmViewDetails As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmViewTiles As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmSortTitle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmSortDescription As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmSortDuration As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmViewSprtr1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ItmViewSprtr2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ItmSortSprtr1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ItmRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmSortAsc As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmSortDesc As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItmSortDate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColDate As System.Windows.Forms.ColumnHeader
End Class