<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSearch))
        Me.PicProgress = New System.Windows.Forms.PictureBox()
        Me.HdrMain = New ComponentFactory.Krypton.Toolkit.KryptonHeader()
        Me.BtnForward = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.BtnSprtr2 = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.BtnBack = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.BtnSprtr = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.BtnHome = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.PnlProgress = New System.Windows.Forms.Panel()
        Me.LblProgress = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BWGenrateSearch = New System.ComponentModel.BackgroundWorker()
        CType(Me.PicProgress, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlProgress.SuspendLayout()
        Me.SuspendLayout()
        '
        'PicProgress
        '
        Me.PicProgress.Dock = System.Windows.Forms.DockStyle.Left
        Me.PicProgress.ErrorImage = Nothing
        Me.PicProgress.Image = CType(resources.GetObject("PicProgress.Image"), System.Drawing.Image)
        Me.PicProgress.InitialImage = Nothing
        Me.PicProgress.Location = New System.Drawing.Point(0, 0)
        Me.PicProgress.Name = "PicProgress"
        Me.PicProgress.Size = New System.Drawing.Size(48, 50)
        Me.PicProgress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicProgress.TabIndex = 0
        Me.PicProgress.TabStop = False
        '
        'HdrMain
        '
        Me.HdrMain.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.BtnForward, Me.BtnSprtr2, Me.BtnBack, Me.BtnSprtr, Me.BtnHome})
        Me.HdrMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.HdrMain.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HdrMain.Location = New System.Drawing.Point(0, 0)
        Me.HdrMain.Name = "HdrMain"
        Me.HdrMain.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.HdrMain.Size = New System.Drawing.Size(724, 30)
        Me.HdrMain.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.HdrMain.TabIndex = 0
        Me.HdrMain.TabStop = False
        Me.HdrMain.Values.Description = ""
        Me.HdrMain.Values.Heading = ""
        Me.HdrMain.Values.Image = Nothing
        '
        'BtnForward
        '
        Me.BtnForward.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
        Me.BtnForward.Image = CType(resources.GetObject("BtnForward.Image"), System.Drawing.Image)
        Me.BtnForward.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Form
        Me.BtnForward.Text = "Forward"
        Me.BtnForward.UniqueName = ""
        '
        'BtnSprtr2
        '
        Me.BtnSprtr2.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
        Me.BtnSprtr2.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.[False]
        Me.BtnSprtr2.Text = "|"
        Me.BtnSprtr2.UniqueName = "BEB3E06A36C24ADD4A8FB163A886DF67"
        '
        'BtnBack
        '
        Me.BtnBack.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
        Me.BtnBack.Image = CType(resources.GetObject("BtnBack.Image"), System.Drawing.Image)
        Me.BtnBack.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Form
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UniqueName = ""
        '
        'BtnSprtr
        '
        Me.BtnSprtr.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
        Me.BtnSprtr.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.[False]
        Me.BtnSprtr.Text = "|"
        Me.BtnSprtr.UniqueName = ""
        '
        'BtnHome
        '
        Me.BtnHome.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
        Me.BtnHome.Image = CType(resources.GetObject("BtnHome.Image"), System.Drawing.Image)
        Me.BtnHome.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Form
        Me.BtnHome.Text = "Home"
        Me.BtnHome.UniqueName = "455DD24F65E54A5682B9DE96188A24EE"
        '
        'PnlProgress
        '
        Me.PnlProgress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PnlProgress.Controls.Add(Me.LblProgress)
        Me.PnlProgress.Controls.Add(Me.PicProgress)
        Me.PnlProgress.Location = New System.Drawing.Point(247, 230)
        Me.PnlProgress.Name = "PnlProgress"
        Me.PnlProgress.Size = New System.Drawing.Size(230, 50)
        Me.PnlProgress.TabIndex = 0
        '
        'LblProgress
        '
        Me.LblProgress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblProgress.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProgress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblProgress.Location = New System.Drawing.Point(48, 0)
        Me.LblProgress.Name = "LblProgress"
        Me.LblProgress.Size = New System.Drawing.Size(182, 50)
        Me.LblProgress.TabIndex = 0
        Me.LblProgress.Text = "Searching Videos..."
        Me.LblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.LargeImageList = Me.ImageList1
        Me.ListView1.Location = New System.Drawing.Point(25, 30)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(699, 474)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.Visible = False
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(120, 90)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'BWGenrateSearch
        '
        Me.BWGenrateSearch.WorkerSupportsCancellation = True
        '
        'FrmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(724, 504)
        Me.Controls.Add(Me.PnlProgress)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.HdrMain)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "FrmSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search"
        CType(Me.PicProgress, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlProgress.ResumeLayout(False)
        Me.PnlProgress.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PicProgress As System.Windows.Forms.PictureBox
    Friend WithEvents HdrMain As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents BtnBack As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents BtnForward As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents BtnSprtr As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents PnlProgress As System.Windows.Forms.Panel
    Friend WithEvents LblProgress As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents BWGenrateSearch As System.ComponentModel.BackgroundWorker
    Friend WithEvents BtnHome As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents BtnSprtr2 As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
End Class