<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCatch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCatch))
        Me.LblBookmark = New System.Windows.Forms.Label()
        Me.LblDownload = New System.Windows.Forms.Label()
        Me.LblWatch = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblBookmark
        '
        Me.LblBookmark.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblBookmark.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LblBookmark.Image = CType(resources.GetObject("LblBookmark.Image"), System.Drawing.Image)
        Me.LblBookmark.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblBookmark.Location = New System.Drawing.Point(23, 128)
        Me.LblBookmark.Name = "LblBookmark"
        Me.LblBookmark.Size = New System.Drawing.Size(265, 35)
        Me.LblBookmark.TabIndex = 3
        Me.LblBookmark.Text = "           Bookmark selected video"
        Me.LblBookmark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblDownload
        '
        Me.LblDownload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblDownload.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LblDownload.Image = CType(resources.GetObject("LblDownload.Image"), System.Drawing.Image)
        Me.LblDownload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblDownload.Location = New System.Drawing.Point(23, 75)
        Me.LblDownload.Name = "LblDownload"
        Me.LblDownload.Size = New System.Drawing.Size(265, 35)
        Me.LblDownload.TabIndex = 2
        Me.LblDownload.Text = "           Download selected video"
        Me.LblDownload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblWatch
        '
        Me.LblWatch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblWatch.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LblWatch.ForeColor = System.Drawing.Color.Black
        Me.LblWatch.Image = CType(resources.GetObject("LblWatch.Image"), System.Drawing.Image)
        Me.LblWatch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblWatch.Location = New System.Drawing.Point(23, 22)
        Me.LblWatch.Name = "LblWatch"
        Me.LblWatch.Size = New System.Drawing.Size(265, 35)
        Me.LblWatch.TabIndex = 1
        Me.LblWatch.Text = "           Watch selected video"
        Me.LblWatch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmCatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(359, 182)
        Me.Controls.Add(Me.LblBookmark)
        Me.Controls.Add(Me.LblDownload)
        Me.Controls.Add(Me.LblWatch)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCatch"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "MyTube - Catch New Video"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblBookmark As System.Windows.Forms.Label
    Friend WithEvents LblDownload As System.Windows.Forms.Label
    Friend WithEvents LblWatch As System.Windows.Forms.Label
End Class
