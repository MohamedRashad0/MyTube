<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTasks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTasks))
        Me.LblWatch = New System.Windows.Forms.Label()
        Me.LblDownload = New System.Windows.Forms.Label()
        Me.LblBookmark = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblWatch
        '
        Me.LblWatch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblWatch.ForeColor = System.Drawing.Color.Black
        Me.LblWatch.Image = CType(resources.GetObject("LblWatch.Image"), System.Drawing.Image)
        Me.LblWatch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblWatch.Location = New System.Drawing.Point(22, 21)
        Me.LblWatch.Name = "LblWatch"
        Me.LblWatch.Size = New System.Drawing.Size(265, 35)
        Me.LblWatch.TabIndex = 0
        Me.LblWatch.Text = "           Watch selected video"
        Me.LblWatch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblDownload
        '
        Me.LblDownload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblDownload.Image = CType(resources.GetObject("LblDownload.Image"), System.Drawing.Image)
        Me.LblDownload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblDownload.Location = New System.Drawing.Point(22, 74)
        Me.LblDownload.Name = "LblDownload"
        Me.LblDownload.Size = New System.Drawing.Size(265, 35)
        Me.LblDownload.TabIndex = 0
        Me.LblDownload.Text = "           Download selected video"
        Me.LblDownload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblBookmark
        '
        Me.LblBookmark.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblBookmark.Image = CType(resources.GetObject("LblBookmark.Image"), System.Drawing.Image)
        Me.LblBookmark.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblBookmark.Location = New System.Drawing.Point(22, 127)
        Me.LblBookmark.Name = "LblBookmark"
        Me.LblBookmark.Size = New System.Drawing.Size(265, 35)
        Me.LblBookmark.TabIndex = 0
        Me.LblBookmark.Text = "           Bookmark selected video"
        Me.LblBookmark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmTasks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(359, 182)
        Me.Controls.Add(Me.LblBookmark)
        Me.Controls.Add(Me.LblDownload)
        Me.Controls.Add(Me.LblWatch)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTasks"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MyTube"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblWatch As System.Windows.Forms.Label
    Friend WithEvents LblDownload As System.Windows.Forms.Label
    Friend WithEvents LblBookmark As System.Windows.Forms.Label
End Class