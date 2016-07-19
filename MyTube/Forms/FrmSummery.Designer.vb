<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSummery
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSummery))
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.BtnOpenLink = New System.Windows.Forms.Button()
        Me.TxtWebsiteURL = New System.Windows.Forms.TextBox()
        Me.LblWebsiteURL = New System.Windows.Forms.Label()
        Me.PicThumbnail = New System.Windows.Forms.PictureBox()
        Me.TxtDescription = New System.Windows.Forms.TextBox()
        Me.LblDescription = New System.Windows.Forms.Label()
        Me.TxtDuration = New System.Windows.Forms.TextBox()
        Me.LblDuration = New System.Windows.Forms.Label()
        Me.TxtTitle = New System.Windows.Forms.TextBox()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.PnlMain.SuspendLayout()
        CType(Me.PicThumbnail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.PnlMain.Controls.Add(Me.TxtTitle)
        Me.PnlMain.Controls.Add(Me.LblTitle)
        Me.PnlMain.Location = New System.Drawing.Point(-5, -2)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(507, 348)
        Me.PnlMain.TabIndex = 1
        '
        'BtnOpenLink
        '
        Me.BtnOpenLink.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOpenLink.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnOpenLink.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnOpenLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOpenLink.Image = CType(resources.GetObject("BtnOpenLink.Image"), System.Drawing.Image)
        Me.BtnOpenLink.Location = New System.Drawing.Point(449, 285)
        Me.BtnOpenLink.Name = "BtnOpenLink"
        Me.BtnOpenLink.Size = New System.Drawing.Size(40, 23)
        Me.BtnOpenLink.TabIndex = 9
        Me.BtnOpenLink.UseVisualStyleBackColor = False
        '
        'TxtWebsiteURL
        '
        Me.TxtWebsiteURL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtWebsiteURL.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtWebsiteURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtWebsiteURL.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TxtWebsiteURL.Location = New System.Drawing.Point(17, 285)
        Me.TxtWebsiteURL.Name = "TxtWebsiteURL"
        Me.TxtWebsiteURL.ReadOnly = True
        Me.TxtWebsiteURL.Size = New System.Drawing.Size(426, 23)
        Me.TxtWebsiteURL.TabIndex = 8
        '
        'LblWebsiteURL
        '
        Me.LblWebsiteURL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.PicThumbnail.Location = New System.Drawing.Point(345, 33)
        Me.PicThumbnail.Name = "PicThumbnail"
        Me.PicThumbnail.Size = New System.Drawing.Size(145, 128)
        Me.PicThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicThumbnail.TabIndex = 0
        Me.PicThumbnail.TabStop = False
        '
        'TxtDescription
        '
        Me.TxtDescription.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDescription.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDescription.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TxtDescription.Location = New System.Drawing.Point(17, 190)
        Me.TxtDescription.Multiline = True
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.ReadOnly = True
        Me.TxtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDescription.Size = New System.Drawing.Size(472, 50)
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
        Me.TxtDuration.Size = New System.Drawing.Size(304, 23)
        Me.TxtDuration.TabIndex = 4
        '
        'LblDuration
        '
        Me.LblDuration.AutoSize = True
        Me.LblDuration.Location = New System.Drawing.Point(16, 95)
        Me.LblDuration.Name = "LblDuration"
        Me.LblDuration.Size = New System.Drawing.Size(110, 15)
        Me.LblDuration.TabIndex = 3
        Me.LblDuration.Text = "D&uration: (seconds)"
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
        Me.TxtTitle.Size = New System.Drawing.Size(304, 23)
        Me.TxtTitle.TabIndex = 2
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
        'BtnOK
        '
        Me.BtnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BtnOK.Location = New System.Drawing.Point(412, 352)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(75, 23)
        Me.BtnOK.TabIndex = 2
        Me.BtnOK.Text = "&OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'FrmSummery
        '
        Me.AcceptButton = Me.BtnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(499, 387)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.PnlMain)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(515, 425)
        Me.Name = "FrmSummery"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Video Information"
        Me.PnlMain.ResumeLayout(False)
        Me.PnlMain.PerformLayout()
        CType(Me.PicThumbnail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents TxtWebsiteURL As System.Windows.Forms.TextBox
    Friend WithEvents LblWebsiteURL As System.Windows.Forms.Label
    Friend WithEvents PicThumbnail As System.Windows.Forms.PictureBox
    Friend WithEvents TxtDescription As System.Windows.Forms.TextBox
    Friend WithEvents LblDescription As System.Windows.Forms.Label
    Friend WithEvents TxtDuration As System.Windows.Forms.TextBox
    Friend WithEvents LblDuration As System.Windows.Forms.Label
    Friend WithEvents TxtTitle As System.Windows.Forms.TextBox
    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents BtnOpenLink As System.Windows.Forms.Button
    Friend WithEvents BtnOK As System.Windows.Forms.Button
End Class