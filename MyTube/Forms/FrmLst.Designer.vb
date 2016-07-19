<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLst
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLst))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BWGenrateVideos = New System.ComponentModel.BackgroundWorker()
        Me.PnlProgress = New System.Windows.Forms.Panel()
        Me.PBProgress = New NeroBar.NeroBar()
        Me.LblProgress = New System.Windows.Forms.Label()
        Me.TmrProgress = New System.Windows.Forms.Timer(Me.components)
        Me.PnlProgress.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.LargeImageList = Me.ImageList1
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(763, 441)
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.Visible = False
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(120, 90)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'BWGenrateVideos
        '
        Me.BWGenrateVideos.WorkerSupportsCancellation = True
        '
        'PnlProgress
        '
        Me.PnlProgress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PnlProgress.Controls.Add(Me.PBProgress)
        Me.PnlProgress.Controls.Add(Me.LblProgress)
        Me.PnlProgress.Location = New System.Drawing.Point(211, 178)
        Me.PnlProgress.Name = "PnlProgress"
        Me.PnlProgress.Size = New System.Drawing.Size(340, 85)
        Me.PnlProgress.TabIndex = 3
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
        'LblProgress
        '
        Me.LblProgress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblProgress.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.LblProgress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblProgress.Location = New System.Drawing.Point(15, 20)
        Me.LblProgress.Name = "LblProgress"
        Me.LblProgress.Size = New System.Drawing.Size(310, 25)
        Me.LblProgress.TabIndex = 0
        Me.LblProgress.Text = "Getting Videos Info..."
        Me.LblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TmrProgress
        '
        Me.TmrProgress.Enabled = True
        '
        'FrmLst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(763, 441)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.PnlProgress)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(720, 480)
        Me.Name = "FrmLst"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Play List"
        Me.PnlProgress.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents BWGenrateVideos As System.ComponentModel.BackgroundWorker
    Friend WithEvents PnlProgress As System.Windows.Forms.Panel
    Friend WithEvents PBProgress As NeroBar.NeroBar
    Friend WithEvents LblProgress As System.Windows.Forms.Label
    Friend WithEvents TmrProgress As System.Windows.Forms.Timer
End Class
