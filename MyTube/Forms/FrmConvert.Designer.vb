<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConvert
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
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tovid = New System.Windows.Forms.ComboBox()
        Me.LblURL = New System.Windows.Forms.Label()
        Me.BtnConvertDir = New System.Windows.Forms.Button()
        Me.TxtConvertDir = New System.Windows.Forms.TextBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.FolderDlg = New System.Windows.Forms.FolderBrowserDialog()
        Me.BWConvert = New System.ComponentModel.BackgroundWorker()
        Me.PnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.White
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlMain.Controls.Add(Me.ProgressBar1)
        Me.PnlMain.Controls.Add(Me.Label1)
        Me.PnlMain.Controls.Add(Me.tovid)
        Me.PnlMain.Controls.Add(Me.LblURL)
        Me.PnlMain.Controls.Add(Me.BtnConvertDir)
        Me.PnlMain.Controls.Add(Me.TxtConvertDir)
        Me.PnlMain.Location = New System.Drawing.Point(-3, -2)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(381, 164)
        Me.PnlMain.TabIndex = 2
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(-1, 145)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(380, 15)
        Me.ProgressBar1.Step = 40
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 4
        Me.ProgressBar1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Converts directory:"
        '
        'tovid
        '
        Me.tovid.BackColor = System.Drawing.Color.White
        Me.tovid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tovid.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tovid.Items.AddRange(New Object() {"Windows Media Video (V.7 WMV)", "Xvid MPEG-4 Codec (AVI)", "iPod Video (Apple QuickTime MOV)", "MPEG Audio Layer 3 (MP3)"})
        Me.tovid.Location = New System.Drawing.Point(17, 47)
        Me.tovid.Name = "tovid"
        Me.tovid.Size = New System.Drawing.Size(343, 23)
        Me.tovid.TabIndex = 0
        '
        'LblURL
        '
        Me.LblURL.AutoSize = True
        Me.LblURL.Location = New System.Drawing.Point(13, 20)
        Me.LblURL.Name = "LblURL"
        Me.LblURL.Size = New System.Drawing.Size(161, 21)
        Me.LblURL.TabIndex = 1
        Me.LblURL.Text = "Convert Video &File To:"
        '
        'BtnConvertDir
        '
        Me.BtnConvertDir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnConvertDir.BackColor = System.Drawing.Color.White
        Me.BtnConvertDir.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.BtnConvertDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConvertDir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConvertDir.Location = New System.Drawing.Point(326, 109)
        Me.BtnConvertDir.Name = "BtnConvertDir"
        Me.BtnConvertDir.Size = New System.Drawing.Size(34, 23)
        Me.BtnConvertDir.TabIndex = 2
        Me.BtnConvertDir.Text = "..."
        Me.BtnConvertDir.UseVisualStyleBackColor = False
        '
        'TxtConvertDir
        '
        Me.TxtConvertDir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtConvertDir.BackColor = System.Drawing.Color.White
        Me.TxtConvertDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtConvertDir.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TxtConvertDir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtConvertDir.Location = New System.Drawing.Point(17, 109)
        Me.TxtConvertDir.Name = "TxtConvertDir"
        Me.TxtConvertDir.ReadOnly = True
        Me.TxtConvertDir.Size = New System.Drawing.Size(302, 23)
        Me.TxtConvertDir.TabIndex = 1
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnCancel.Location = New System.Drawing.Point(288, 172)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 4
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnOK
        '
        Me.BtnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOK.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOK.Location = New System.Drawing.Point(207, 172)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(75, 23)
        Me.BtnOK.TabIndex = 3
        Me.BtnOK.Text = "&OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'BWConvert
        '
        Me.BWConvert.WorkerReportsProgress = True
        Me.BWConvert.WorkerSupportsCancellation = True
        '
        'FrmConvert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(375, 203)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.PnlMain)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConvert"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Convert"
        Me.PnlMain.ResumeLayout(False)
        Me.PnlMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents LblURL As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents tovid As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents BtnConvertDir As System.Windows.Forms.Button
    Friend WithEvents TxtConvertDir As System.Windows.Forms.TextBox
    Friend WithEvents FolderDlg As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents BWConvert As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
End Class
