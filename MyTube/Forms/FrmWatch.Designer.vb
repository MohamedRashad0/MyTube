<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWatch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmWatch))
        Me.BtnPlay = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.TrkVolume = New ComponentFactory.Krypton.Toolkit.KryptonTrackBar()
        Me.TmrMediaUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.Edg3 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge()
        Me.BtnStop = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.Edg1 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge()
        Me.BtnForward = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.Edg2 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge()
        Me.BtnReverse = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.BWDownload = New System.ComponentModel.BackgroundWorker()
        Me.TxtURL = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.BtnInfo = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.BtnSprtr2 = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.BtnBookmarks = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.MnuBookmarks = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnSprtr1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.BtnDownload = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.BtnTitle = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.BoxBottom = New ComponentFactory.Krypton.Toolkit.KryptonGroup()
        Me.LblSpeed = New System.Windows.Forms.Label()
        Me.PicSpeed = New System.Windows.Forms.PictureBox()
        Me.BtnVolume = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.BtnFullScreen = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.TrkSeek = New ComponentFactory.Krypton.Toolkit.KryptonTrackBar()
        Me.PBDownload = New NeroBar.NeroBar()
        Me.LblTime = New System.Windows.Forms.Label()
        Me.TipInfo = New System.Windows.Forms.ToolTip(Me.components)
        Me.PnlPlayer = New System.Windows.Forms.Panel()
        Me.LblProgress = New System.Windows.Forms.Label()
        Me.PicLogo = New System.Windows.Forms.PictureBox()
        Me.MediaPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.BoxBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxBottom.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BoxBottom.Panel.SuspendLayout()
        Me.BoxBottom.SuspendLayout()
        CType(Me.PicSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlPlayer.SuspendLayout()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediaPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnPlay
        '
        Me.BtnPlay.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnPlay.Location = New System.Drawing.Point(362, 33)
        Me.BtnPlay.Name = "BtnPlay"
        Me.BtnPlay.OverrideDefault.Border.Color1 = System.Drawing.Color.Gray
        Me.BtnPlay.OverrideDefault.Border.Color2 = System.Drawing.Color.Gray
        Me.BtnPlay.OverrideDefault.Border.DrawBorders = CType((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.BtnPlay.OverrideDefault.Border.Rounding = 15
        Me.BtnPlay.OverrideDefault.Border.Width = 2
        Me.BtnPlay.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver
        Me.BtnPlay.Size = New System.Drawing.Size(42, 42)
        Me.BtnPlay.StateNormal.Border.Color1 = System.Drawing.Color.Gray
        Me.BtnPlay.StateNormal.Border.Color2 = System.Drawing.Color.Gray
        Me.BtnPlay.StateNormal.Border.DrawBorders = CType((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.BtnPlay.StateNormal.Border.Rounding = 15
        Me.BtnPlay.StateNormal.Border.Width = 2
        Me.BtnPlay.StatePressed.Back.Color1 = System.Drawing.Color.Gainsboro
        Me.BtnPlay.StatePressed.Back.Color2 = System.Drawing.Color.LightGray
        Me.BtnPlay.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.OneNote
        Me.BtnPlay.StatePressed.Border.Color1 = System.Drawing.Color.Gray
        Me.BtnPlay.StatePressed.Border.Color2 = System.Drawing.Color.Gray
        Me.BtnPlay.StatePressed.Border.DrawBorders = CType((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.BtnPlay.StatePressed.Border.Rounding = 15
        Me.BtnPlay.StatePressed.Border.Width = 2
        Me.BtnPlay.StateTracking.Back.Color1 = System.Drawing.Color.White
        Me.BtnPlay.StateTracking.Back.Color2 = System.Drawing.Color.Gainsboro
        Me.BtnPlay.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.OneNote
        Me.BtnPlay.StateTracking.Border.Color1 = System.Drawing.Color.Gray
        Me.BtnPlay.StateTracking.Border.Color2 = System.Drawing.Color.Gray
        Me.BtnPlay.StateTracking.Border.DrawBorders = CType((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.BtnPlay.StateTracking.Border.Rounding = 15
        Me.BtnPlay.StateTracking.Border.Width = 2
        Me.BtnPlay.StateTracking.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Light
        Me.BtnPlay.TabIndex = 5
        Me.BtnPlay.Tag = "play"
        Me.TipInfo.SetToolTip(Me.BtnPlay, "Pause")
        Me.BtnPlay.Values.Image = Global.MyTube.My.Resources.Resources.media_play
        Me.BtnPlay.Values.Text = ""
        '
        'TrkVolume
        '
        Me.TrkVolume.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TrkVolume.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonStandalone
        Me.TrkVolume.DrawBackground = True
        Me.TrkVolume.Location = New System.Drawing.Point(485, 47)
        Me.TrkVolume.Maximum = 100
        Me.TrkVolume.Name = "TrkVolume"
        Me.TrkVolume.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.TrkVolume.Size = New System.Drawing.Size(60, 15)
        Me.TrkVolume.TabIndex = 8
        Me.TrkVolume.TickStyle = System.Windows.Forms.TickStyle.None
        Me.TipInfo.SetToolTip(Me.TrkVolume, "Volume")
        Me.TrkVolume.TrackBarSize = ComponentFactory.Krypton.Toolkit.PaletteTrackBarSize.Small
        Me.TrkVolume.Value = 50
        Me.TrkVolume.VolumeControl = True
        '
        'TmrMediaUpdate
        '
        Me.TmrMediaUpdate.Interval = 1000
        '
        'Edg3
        '
        Me.Edg3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Edg3.Location = New System.Drawing.Point(403, 35)
        Me.Edg3.Name = "Edg3"
        Me.Edg3.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.Edg3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.Edg3.Size = New System.Drawing.Size(1, 38)
        '
        'BtnStop
        '
        Me.BtnStop.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnStop.Location = New System.Drawing.Point(321, 33)
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.OverrideDefault.Border.Color1 = System.Drawing.Color.Gray
        Me.BtnStop.OverrideDefault.Border.Color2 = System.Drawing.Color.Gray
        Me.BtnStop.OverrideDefault.Border.DrawBorders = CType((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.BtnStop.OverrideDefault.Border.Rounding = 15
        Me.BtnStop.OverrideDefault.Border.Width = 2
        Me.BtnStop.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver
        Me.BtnStop.Size = New System.Drawing.Size(42, 42)
        Me.BtnStop.StateNormal.Border.Color1 = System.Drawing.Color.Gray
        Me.BtnStop.StateNormal.Border.Color2 = System.Drawing.Color.Gray
        Me.BtnStop.StateNormal.Border.DrawBorders = CType((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.BtnStop.StateNormal.Border.Rounding = 15
        Me.BtnStop.StateNormal.Border.Width = 2
        Me.BtnStop.StatePressed.Back.Color1 = System.Drawing.Color.Gainsboro
        Me.BtnStop.StatePressed.Back.Color2 = System.Drawing.Color.LightGray
        Me.BtnStop.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.OneNote
        Me.BtnStop.StatePressed.Border.Color1 = System.Drawing.Color.Gray
        Me.BtnStop.StatePressed.Border.Color2 = System.Drawing.Color.Gray
        Me.BtnStop.StatePressed.Border.DrawBorders = CType((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.BtnStop.StatePressed.Border.Rounding = 15
        Me.BtnStop.StatePressed.Border.Width = 2
        Me.BtnStop.StateTracking.Back.Color1 = System.Drawing.Color.White
        Me.BtnStop.StateTracking.Back.Color2 = System.Drawing.Color.Gainsboro
        Me.BtnStop.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.OneNote
        Me.BtnStop.StateTracking.Border.Color1 = System.Drawing.Color.Gray
        Me.BtnStop.StateTracking.Border.Color2 = System.Drawing.Color.Gray
        Me.BtnStop.StateTracking.Border.DrawBorders = CType((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.BtnStop.StateTracking.Border.Rounding = 15
        Me.BtnStop.StateTracking.Border.Width = 2
        Me.BtnStop.StateTracking.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Light
        Me.BtnStop.TabIndex = 4
        Me.TipInfo.SetToolTip(Me.BtnStop, "Stop")
        Me.BtnStop.Values.Image = CType(resources.GetObject("BtnStop.Values.Image"), System.Drawing.Image)
        Me.BtnStop.Values.Text = ""
        '
        'Edg1
        '
        Me.Edg1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Edg1.Location = New System.Drawing.Point(322, 35)
        Me.Edg1.Name = "Edg1"
        Me.Edg1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.Edg1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.Edg1.Size = New System.Drawing.Size(1, 38)
        '
        'BtnForward
        '
        Me.BtnForward.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnForward.Location = New System.Drawing.Point(404, 33)
        Me.BtnForward.Name = "BtnForward"
        Me.BtnForward.OverrideDefault.Border.Color1 = System.Drawing.Color.Gray
        Me.BtnForward.OverrideDefault.Border.Color2 = System.Drawing.Color.Gray
        Me.BtnForward.OverrideDefault.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.BtnForward.OverrideDefault.Border.Rounding = 15
        Me.BtnForward.OverrideDefault.Border.Width = 2
        Me.BtnForward.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver
        Me.BtnForward.Size = New System.Drawing.Size(42, 42)
        Me.BtnForward.StateNormal.Border.Color1 = System.Drawing.Color.Gray
        Me.BtnForward.StateNormal.Border.Color2 = System.Drawing.Color.Gray
        Me.BtnForward.StateNormal.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.BtnForward.StateNormal.Border.Rounding = 15
        Me.BtnForward.StateNormal.Border.Width = 2
        Me.BtnForward.StatePressed.Back.Color1 = System.Drawing.Color.Gainsboro
        Me.BtnForward.StatePressed.Back.Color2 = System.Drawing.Color.LightGray
        Me.BtnForward.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.OneNote
        Me.BtnForward.StatePressed.Border.Color1 = System.Drawing.Color.Gray
        Me.BtnForward.StatePressed.Border.Color2 = System.Drawing.Color.Gray
        Me.BtnForward.StatePressed.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.BtnForward.StatePressed.Border.Rounding = 15
        Me.BtnForward.StatePressed.Border.Width = 2
        Me.BtnForward.StateTracking.Back.Color1 = System.Drawing.Color.White
        Me.BtnForward.StateTracking.Back.Color2 = System.Drawing.Color.Gainsboro
        Me.BtnForward.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.OneNote
        Me.BtnForward.StateTracking.Border.Color1 = System.Drawing.Color.Gray
        Me.BtnForward.StateTracking.Border.Color2 = System.Drawing.Color.Gray
        Me.BtnForward.StateTracking.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.BtnForward.StateTracking.Border.Rounding = 15
        Me.BtnForward.StateTracking.Border.Width = 2
        Me.BtnForward.StateTracking.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Light
        Me.BtnForward.TabIndex = 6
        Me.TipInfo.SetToolTip(Me.BtnForward, "Fast Forward")
        Me.BtnForward.Values.Image = CType(resources.GetObject("BtnForward.Values.Image"), System.Drawing.Image)
        Me.BtnForward.Values.Text = ""
        '
        'Edg2
        '
        Me.Edg2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Edg2.Location = New System.Drawing.Point(361, 35)
        Me.Edg2.Name = "Edg2"
        Me.Edg2.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.Edg2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.Edg2.Size = New System.Drawing.Size(1, 38)
        '
        'BtnReverse
        '
        Me.BtnReverse.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnReverse.Location = New System.Drawing.Point(280, 33)
        Me.BtnReverse.Name = "BtnReverse"
        Me.BtnReverse.OverrideDefault.Border.Color1 = System.Drawing.Color.Gray
        Me.BtnReverse.OverrideDefault.Border.Color2 = System.Drawing.Color.Gray
        Me.BtnReverse.OverrideDefault.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.BtnReverse.OverrideDefault.Border.Rounding = 15
        Me.BtnReverse.OverrideDefault.Border.Width = 2
        Me.BtnReverse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver
        Me.BtnReverse.Size = New System.Drawing.Size(42, 42)
        Me.BtnReverse.StateNormal.Border.Color1 = System.Drawing.Color.Gray
        Me.BtnReverse.StateNormal.Border.Color2 = System.Drawing.Color.Gray
        Me.BtnReverse.StateNormal.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.BtnReverse.StateNormal.Border.Rounding = 15
        Me.BtnReverse.StateNormal.Border.Width = 2
        Me.BtnReverse.StatePressed.Back.Color1 = System.Drawing.Color.Gainsboro
        Me.BtnReverse.StatePressed.Back.Color2 = System.Drawing.Color.LightGray
        Me.BtnReverse.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.OneNote
        Me.BtnReverse.StatePressed.Border.Color1 = System.Drawing.Color.Gray
        Me.BtnReverse.StatePressed.Border.Color2 = System.Drawing.Color.Gray
        Me.BtnReverse.StatePressed.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.BtnReverse.StatePressed.Border.Rounding = 15
        Me.BtnReverse.StatePressed.Border.Width = 2
        Me.BtnReverse.StateTracking.Back.Color1 = System.Drawing.Color.White
        Me.BtnReverse.StateTracking.Back.Color2 = System.Drawing.Color.Gainsboro
        Me.BtnReverse.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.OneNote
        Me.BtnReverse.StateTracking.Border.Color1 = System.Drawing.Color.Gray
        Me.BtnReverse.StateTracking.Border.Color2 = System.Drawing.Color.Gray
        Me.BtnReverse.StateTracking.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.BtnReverse.StateTracking.Border.Rounding = 15
        Me.BtnReverse.StateTracking.Border.Width = 2
        Me.BtnReverse.StateTracking.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Light
        Me.BtnReverse.TabIndex = 3
        Me.TipInfo.SetToolTip(Me.BtnReverse, "Fast Reverse")
        Me.BtnReverse.Values.Image = CType(resources.GetObject("BtnReverse.Values.Image"), System.Drawing.Image)
        Me.BtnReverse.Values.Text = ""
        '
        'BWDownload
        '
        Me.BWDownload.WorkerSupportsCancellation = True
        '
        'TxtURL
        '
        Me.TxtURL.AllowButtonSpecToolTips = True
        Me.TxtURL.AlwaysActive = False
        Me.TxtURL.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.BtnInfo, Me.BtnSprtr2, Me.BtnBookmarks, Me.BtnSprtr1, Me.BtnDownload, Me.BtnTitle})
        Me.TxtURL.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtURL.Location = New System.Drawing.Point(0, 0)
        Me.TxtURL.Name = "TxtURL"
        Me.TxtURL.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.TxtURL.Size = New System.Drawing.Size(724, 28)
        Me.TxtURL.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtURL.StateActive.Content.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtURL.StateNormal.Back.Color1 = System.Drawing.Color.WhiteSmoke
        Me.TxtURL.StateNormal.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtURL.StateNormal.Content.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtURL.TabIndex = 2
        '
        'BtnInfo
        '
        Me.BtnInfo.Image = CType(resources.GetObject("BtnInfo.Image"), System.Drawing.Image)
        Me.BtnInfo.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Form
        Me.BtnInfo.ToolTipBody = "Video Info"
        Me.BtnInfo.UniqueName = ""
        Me.BtnInfo.Visible = False
        '
        'BtnSprtr2
        '
        Me.BtnSprtr2.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.[False]
        Me.BtnSprtr2.Text = "|"
        Me.BtnSprtr2.UniqueName = ""
        Me.BtnSprtr2.Visible = False
        '
        'BtnBookmarks
        '
        Me.BtnBookmarks.ContextMenuStrip = Me.MnuBookmarks
        Me.BtnBookmarks.Image = CType(resources.GetObject("BtnBookmarks.Image"), System.Drawing.Image)
        Me.BtnBookmarks.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Form
        Me.BtnBookmarks.ToolTipBody = "Bookmarks"
        Me.BtnBookmarks.UniqueName = ""
        Me.BtnBookmarks.Visible = False
        '
        'MnuBookmarks
        '
        Me.MnuBookmarks.DropShadowEnabled = False
        Me.MnuBookmarks.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MnuBookmarks.Name = "MnuBookmarks"
        Me.MnuBookmarks.ShowImageMargin = False
        Me.MnuBookmarks.Size = New System.Drawing.Size(36, 4)
        '
        'BtnSprtr1
        '
        Me.BtnSprtr1.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.[False]
        Me.BtnSprtr1.Text = "|"
        Me.BtnSprtr1.UniqueName = ""
        Me.BtnSprtr1.Visible = False
        '
        'BtnDownload
        '
        Me.BtnDownload.Image = CType(resources.GetObject("BtnDownload.Image"), System.Drawing.Image)
        Me.BtnDownload.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Form
        Me.BtnDownload.ToolTipBody = "Download & Watch"
        Me.BtnDownload.UniqueName = ""
        '
        'BtnTitle
        '
        Me.BtnTitle.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
        Me.BtnTitle.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.[False]
        Me.BtnTitle.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.NavigatorOverflow
        Me.BtnTitle.Text = "Video URL"
        Me.BtnTitle.UniqueName = ""
        '
        'BoxBottom
        '
        Me.BoxBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BoxBottom.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlToolTip
        Me.BoxBottom.Location = New System.Drawing.Point(0, 419)
        Me.BoxBottom.Name = "BoxBottom"
        Me.BoxBottom.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        '
        'BoxBottom.Panel
        '
        Me.BoxBottom.Panel.Controls.Add(Me.LblSpeed)
        Me.BoxBottom.Panel.Controls.Add(Me.PicSpeed)
        Me.BoxBottom.Panel.Controls.Add(Me.BtnVolume)
        Me.BoxBottom.Panel.Controls.Add(Me.BtnFullScreen)
        Me.BoxBottom.Panel.Controls.Add(Me.TrkSeek)
        Me.BoxBottom.Panel.Controls.Add(Me.PBDownload)
        Me.BoxBottom.Panel.Controls.Add(Me.LblTime)
        Me.BoxBottom.Panel.Controls.Add(Me.Edg3)
        Me.BoxBottom.Panel.Controls.Add(Me.BtnReverse)
        Me.BoxBottom.Panel.Controls.Add(Me.BtnPlay)
        Me.BoxBottom.Panel.Controls.Add(Me.Edg2)
        Me.BoxBottom.Panel.Controls.Add(Me.BtnForward)
        Me.BoxBottom.Panel.Controls.Add(Me.TrkVolume)
        Me.BoxBottom.Panel.Controls.Add(Me.Edg1)
        Me.BoxBottom.Panel.Controls.Add(Me.BtnStop)
        Me.BoxBottom.Size = New System.Drawing.Size(724, 85)
        Me.BoxBottom.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.None
        Me.BoxBottom.TabIndex = 1
        '
        'LblSpeed
        '
        Me.LblSpeed.AutoSize = True
        Me.LblSpeed.BackColor = System.Drawing.Color.Transparent
        Me.LblSpeed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblSpeed.Location = New System.Drawing.Point(38, 48)
        Me.LblSpeed.Name = "LblSpeed"
        Me.LblSpeed.Size = New System.Drawing.Size(52, 15)
        Me.LblSpeed.TabIndex = 0
        Me.LblSpeed.Text = "0 KB/sec"
        Me.LblSpeed.Visible = False
        '
        'PicSpeed
        '
        Me.PicSpeed.BackColor = System.Drawing.Color.Transparent
        Me.PicSpeed.ErrorImage = Nothing
        Me.PicSpeed.Image = CType(resources.GetObject("PicSpeed.Image"), System.Drawing.Image)
        Me.PicSpeed.InitialImage = Nothing
        Me.PicSpeed.Location = New System.Drawing.Point(9, 41)
        Me.PicSpeed.Name = "PicSpeed"
        Me.PicSpeed.Size = New System.Drawing.Size(24, 24)
        Me.PicSpeed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicSpeed.TabIndex = 0
        Me.PicSpeed.TabStop = False
        Me.TipInfo.SetToolTip(Me.PicSpeed, "Download Speed")
        Me.PicSpeed.Visible = False
        '
        'BtnVolume
        '
        Me.BtnVolume.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnVolume.Location = New System.Drawing.Point(452, 40)
        Me.BtnVolume.Name = "BtnVolume"
        Me.BtnVolume.OverrideDefault.Border.Color1 = System.Drawing.Color.Gray
        Me.BtnVolume.OverrideDefault.Border.Color2 = System.Drawing.Color.Gray
        Me.BtnVolume.OverrideDefault.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.BtnVolume.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver
        Me.BtnVolume.Size = New System.Drawing.Size(28, 28)
        Me.BtnVolume.StateNormal.Border.Color1 = System.Drawing.Color.Gray
        Me.BtnVolume.StateNormal.Border.Color2 = System.Drawing.Color.Gray
        Me.BtnVolume.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.BtnVolume.StatePressed.Back.Color1 = System.Drawing.Color.Gainsboro
        Me.BtnVolume.StatePressed.Back.Color2 = System.Drawing.Color.LightGray
        Me.BtnVolume.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.OneNote
        Me.BtnVolume.StatePressed.Border.Color1 = System.Drawing.Color.Gray
        Me.BtnVolume.StatePressed.Border.Color2 = System.Drawing.Color.Gray
        Me.BtnVolume.StatePressed.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.BtnVolume.StateTracking.Back.Color1 = System.Drawing.Color.White
        Me.BtnVolume.StateTracking.Back.Color2 = System.Drawing.Color.Gainsboro
        Me.BtnVolume.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.OneNote
        Me.BtnVolume.StateTracking.Border.Color1 = System.Drawing.Color.Gray
        Me.BtnVolume.StateTracking.Border.Color2 = System.Drawing.Color.Gray
        Me.BtnVolume.StateTracking.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.BtnVolume.StateTracking.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Light
        Me.BtnVolume.TabIndex = 7
        Me.TipInfo.SetToolTip(Me.BtnVolume, "Mute")
        Me.BtnVolume.Values.Image = Global.MyTube.My.Resources.Resources.media_volume1
        Me.BtnVolume.Values.Text = ""
        '
        'BtnFullScreen
        '
        Me.BtnFullScreen.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnFullScreen.Location = New System.Drawing.Point(246, 40)
        Me.BtnFullScreen.Name = "BtnFullScreen"
        Me.BtnFullScreen.OverrideDefault.Border.Color1 = System.Drawing.Color.Gray
        Me.BtnFullScreen.OverrideDefault.Border.Color2 = System.Drawing.Color.Gray
        Me.BtnFullScreen.OverrideDefault.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.BtnFullScreen.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver
        Me.BtnFullScreen.Size = New System.Drawing.Size(28, 28)
        Me.BtnFullScreen.StateNormal.Border.Color1 = System.Drawing.Color.Gray
        Me.BtnFullScreen.StateNormal.Border.Color2 = System.Drawing.Color.Gray
        Me.BtnFullScreen.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.BtnFullScreen.StatePressed.Back.Color1 = System.Drawing.Color.Gainsboro
        Me.BtnFullScreen.StatePressed.Back.Color2 = System.Drawing.Color.LightGray
        Me.BtnFullScreen.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.OneNote
        Me.BtnFullScreen.StatePressed.Border.Color1 = System.Drawing.Color.Gray
        Me.BtnFullScreen.StatePressed.Border.Color2 = System.Drawing.Color.Gray
        Me.BtnFullScreen.StatePressed.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.BtnFullScreen.StateTracking.Back.Color1 = System.Drawing.Color.White
        Me.BtnFullScreen.StateTracking.Back.Color2 = System.Drawing.Color.Gainsboro
        Me.BtnFullScreen.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.OneNote
        Me.BtnFullScreen.StateTracking.Border.Color1 = System.Drawing.Color.Gray
        Me.BtnFullScreen.StateTracking.Border.Color2 = System.Drawing.Color.Gray
        Me.BtnFullScreen.StateTracking.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.BtnFullScreen.StateTracking.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Light
        Me.BtnFullScreen.TabIndex = 2
        Me.TipInfo.SetToolTip(Me.BtnFullScreen, "Full Screen")
        Me.BtnFullScreen.Values.Image = CType(resources.GetObject("BtnFullScreen.Values.Image"), System.Drawing.Image)
        Me.BtnFullScreen.Values.Text = ""
        '
        'TrkSeek
        '
        Me.TrkSeek.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.TabLowProfile
        Me.TrkSeek.Dock = System.Windows.Forms.DockStyle.Top
        Me.TrkSeek.DrawBackground = True
        Me.TrkSeek.Location = New System.Drawing.Point(0, 6)
        Me.TrkSeek.Name = "TrkSeek"
        Me.TrkSeek.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.TrkSeek.Size = New System.Drawing.Size(724, 15)
        Me.TrkSeek.SmallChange = 5
        Me.TrkSeek.StateNormal.Position.Color5 = System.Drawing.Color.Silver
        Me.TrkSeek.StateNormal.Track.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TrkSeek.StateNormal.Track.Color2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TrkSeek.StateNormal.Track.Color3 = System.Drawing.Color.Silver
        Me.TrkSeek.TabIndex = 1
        Me.TrkSeek.TickFrequency = 5
        Me.TrkSeek.TickStyle = System.Windows.Forms.TickStyle.None
        Me.TipInfo.SetToolTip(Me.TrkSeek, "Seek")
        Me.TrkSeek.TrackBarSize = ComponentFactory.Krypton.Toolkit.PaletteTrackBarSize.Small
        '
        'PBDownload
        '
        Me.PBDownload.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PBDownload.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PBDownload.BackColor = System.Drawing.Color.Transparent
        Me.PBDownload.Dock = System.Windows.Forms.DockStyle.Top
        Me.PBDownload.ForeColor = System.Drawing.Color.Black
        Me.PBDownload.GlowMode = NeroBar.NeroBar.NeroBarGlowModes.ProgressOnly
        Me.PBDownload.Location = New System.Drawing.Point(0, 0)
        Me.PBDownload.Name = "PBDownload"
        Me.PBDownload.PercentageBasedOn = NeroBar.NeroBar.NeroBarPercentageCalculationModes.WholeControl
        Me.PBDownload.Segment1Color = System.Drawing.Color.Gold
        Me.PBDownload.SegmentCount = NeroBar.NeroBar.NeroBarSegments.One
        Me.PBDownload.Size = New System.Drawing.Size(724, 6)
        Me.PBDownload.TabIndex = 0
        Me.PBDownload.TabStop = False
        Me.PBDownload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.TipInfo.SetToolTip(Me.PBDownload, "Download Progress")
        '
        'LblTime
        '
        Me.LblTime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblTime.AutoSize = True
        Me.LblTime.BackColor = System.Drawing.Color.Transparent
        Me.LblTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblTime.Location = New System.Drawing.Point(187, 47)
        Me.LblTime.Name = "LblTime"
        Me.LblTime.Size = New System.Drawing.Size(49, 15)
        Me.LblTime.TabIndex = 0
        Me.LblTime.Text = "00:00:00"
        '
        'PnlPlayer
        '
        Me.PnlPlayer.BackColor = System.Drawing.Color.Black
        Me.PnlPlayer.Controls.Add(Me.LblProgress)
        Me.PnlPlayer.Controls.Add(Me.PicLogo)
        Me.PnlPlayer.Controls.Add(Me.MediaPlayer)
        Me.PnlPlayer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlPlayer.Location = New System.Drawing.Point(0, 28)
        Me.PnlPlayer.Name = "PnlPlayer"
        Me.PnlPlayer.Size = New System.Drawing.Size(724, 391)
        Me.PnlPlayer.TabIndex = 0
        '
        'LblProgress
        '
        Me.LblProgress.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblProgress.AutoSize = True
        Me.LblProgress.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProgress.ForeColor = System.Drawing.Color.White
        Me.LblProgress.Location = New System.Drawing.Point(13, 364)
        Me.LblProgress.Name = "LblProgress"
        Me.LblProgress.Size = New System.Drawing.Size(69, 17)
        Me.LblProgress.TabIndex = 0
        Me.LblProgress.Text = "Buffering..."
        Me.LblProgress.Visible = False
        '
        'PicLogo
        '
        Me.PicLogo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PicLogo.ErrorImage = Nothing
        Me.PicLogo.Image = CType(resources.GetObject("PicLogo.Image"), System.Drawing.Image)
        Me.PicLogo.InitialImage = Nothing
        Me.PicLogo.Location = New System.Drawing.Point(262, 67)
        Me.PicLogo.Name = "PicLogo"
        Me.PicLogo.Size = New System.Drawing.Size(200, 200)
        Me.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicLogo.TabIndex = 0
        Me.PicLogo.TabStop = False
        '
        'MediaPlayer
        '
        Me.MediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MediaPlayer.Enabled = True
        Me.MediaPlayer.Location = New System.Drawing.Point(0, 0)
        Me.MediaPlayer.Margin = New System.Windows.Forms.Padding(0)
        Me.MediaPlayer.Name = "MediaPlayer"
        Me.MediaPlayer.OcxState = CType(resources.GetObject("MediaPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MediaPlayer.Size = New System.Drawing.Size(724, 391)
        Me.MediaPlayer.TabIndex = 0
        Me.MediaPlayer.TabStop = False
        '
        'FrmWatch
        '
        Me.AcceptButton = Me.BtnPlay
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(724, 504)
        Me.Controls.Add(Me.PnlPlayer)
        Me.Controls.Add(Me.BoxBottom)
        Me.Controls.Add(Me.TxtURL)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "FrmWatch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Watch"
        CType(Me.BoxBottom.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BoxBottom.Panel.ResumeLayout(False)
        Me.BoxBottom.Panel.PerformLayout()
        CType(Me.BoxBottom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BoxBottom.ResumeLayout(False)
        CType(Me.PicSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlPlayer.ResumeLayout(False)
        Me.PnlPlayer.PerformLayout()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediaPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnPlay As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents TrkVolume As ComponentFactory.Krypton.Toolkit.KryptonTrackBar
    Friend WithEvents TmrMediaUpdate As System.Windows.Forms.Timer
    Friend WithEvents Edg1 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents BtnForward As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents Edg2 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents BtnReverse As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents Edg3 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents BtnStop As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents BWDownload As System.ComponentModel.BackgroundWorker
    Friend WithEvents BoxBottom As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents TxtURL As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents BtnDownload As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents LblTime As System.Windows.Forms.Label
    Friend WithEvents TrkSeek As ComponentFactory.Krypton.Toolkit.KryptonTrackBar
    Friend WithEvents PBDownload As NeroBar.NeroBar
    Friend WithEvents BtnFullScreen As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents BtnVolume As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents TipInfo As System.Windows.Forms.ToolTip
    Friend WithEvents LblSpeed As System.Windows.Forms.Label
    Friend WithEvents PicSpeed As System.Windows.Forms.PictureBox
    Friend WithEvents BtnBookmarks As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents MnuBookmarks As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BtnTitle As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents PnlPlayer As System.Windows.Forms.Panel
    Friend WithEvents BtnSprtr1 As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents BtnInfo As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents BtnSprtr2 As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents MediaPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents PicLogo As System.Windows.Forms.PictureBox
    Friend WithEvents LblProgress As System.Windows.Forms.Label
End Class