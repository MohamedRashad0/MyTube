<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSettings
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
        Me.TabMain = New System.Windows.Forms.TabControl()
        Me.PageGeneral = New System.Windows.Forms.TabPage()
        Me.ChkCatch = New System.Windows.Forms.CheckBox()
        Me.ChkAutoUpdate = New System.Windows.Forms.CheckBox()
        Me.ChkAutoHide = New System.Windows.Forms.CheckBox()
        Me.PageDownloads = New System.Windows.Forms.TabPage()
        Me.BtnFailedEvent_Play = New System.Windows.Forms.Button()
        Me.BtnCompletedEvent_Play = New System.Windows.Forms.Button()
        Me.BtnFailedEvent = New System.Windows.Forms.Button()
        Me.TxtFailedEvent_Path = New System.Windows.Forms.TextBox()
        Me.ChkFailedEvent = New System.Windows.Forms.CheckBox()
        Me.ChkCompletedEvent = New System.Windows.Forms.CheckBox()
        Me.BtnCompletedEvent = New System.Windows.Forms.Button()
        Me.TxtCompletedEvent_Path = New System.Windows.Forms.TextBox()
        Me.LblTimeOut = New System.Windows.Forms.Label()
        Me.NumTimeOut = New System.Windows.Forms.NumericUpDown()
        Me.LblTempDir = New System.Windows.Forms.Label()
        Me.BtnTempDir = New System.Windows.Forms.Button()
        Me.BtnDownloadsDir = New System.Windows.Forms.Button()
        Me.TxtTempDir = New System.Windows.Forms.TextBox()
        Me.TxtDownloadsDir = New System.Windows.Forms.TextBox()
        Me.LblDownloadsDir = New System.Windows.Forms.Label()
        Me.PageAdvanced = New System.Windows.Forms.TabPage()
        Me.BoxPowerMngr = New System.Windows.Forms.GroupBox()
        Me.ChkBatteryStandby = New System.Windows.Forms.CheckBox()
        Me.ChkDisableStandby = New System.Windows.Forms.CheckBox()
        Me.BoxMediaCache = New System.Windows.Forms.GroupBox()
        Me.NumMediaCache = New System.Windows.Forms.NumericUpDown()
        Me.RdoCustomCache = New System.Windows.Forms.RadioButton()
        Me.RdoDynamicCache = New System.Windows.Forms.RadioButton()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.FolderDlg = New System.Windows.Forms.FolderBrowserDialog()
        Me.FileDlg = New System.Windows.Forms.OpenFileDialog()
        Me.TabMain.SuspendLayout()
        Me.PageGeneral.SuspendLayout()
        Me.PageDownloads.SuspendLayout()
        CType(Me.NumTimeOut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PageAdvanced.SuspendLayout()
        Me.BoxPowerMngr.SuspendLayout()
        Me.BoxMediaCache.SuspendLayout()
        CType(Me.NumMediaCache, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabMain
        '
        Me.TabMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabMain.Controls.Add(Me.PageGeneral)
        Me.TabMain.Controls.Add(Me.PageDownloads)
        Me.TabMain.Controls.Add(Me.PageAdvanced)
        Me.TabMain.Location = New System.Drawing.Point(12, 12)
        Me.TabMain.Name = "TabMain"
        Me.TabMain.SelectedIndex = 0
        Me.TabMain.Size = New System.Drawing.Size(440, 422)
        Me.TabMain.TabIndex = 1
        '
        'PageGeneral
        '
        Me.PageGeneral.BackColor = System.Drawing.Color.White
        Me.PageGeneral.Controls.Add(Me.ChkCatch)
        Me.PageGeneral.Controls.Add(Me.ChkAutoUpdate)
        Me.PageGeneral.Controls.Add(Me.ChkAutoHide)
        Me.PageGeneral.Location = New System.Drawing.Point(4, 24)
        Me.PageGeneral.Name = "PageGeneral"
        Me.PageGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.PageGeneral.Size = New System.Drawing.Size(432, 394)
        Me.PageGeneral.TabIndex = 0
        Me.PageGeneral.Text = "General"
        '
        'ChkCatch
        '
        Me.ChkCatch.AutoSize = True
        Me.ChkCatch.Location = New System.Drawing.Point(20, 90)
        Me.ChkCatch.Name = "ChkCatch"
        Me.ChkCatch.Size = New System.Drawing.Size(173, 19)
        Me.ChkCatch.TabIndex = 3
        Me.ChkCatch.Text = "Catch videos from browsers"
        Me.ChkCatch.UseVisualStyleBackColor = True
        '
        'ChkAutoUpdate
        '
        Me.ChkAutoUpdate.AutoSize = True
        Me.ChkAutoUpdate.Location = New System.Drawing.Point(20, 60)
        Me.ChkAutoUpdate.Name = "ChkAutoUpdate"
        Me.ChkAutoUpdate.Size = New System.Drawing.Size(271, 19)
        Me.ChkAutoUpdate.TabIndex = 2
        Me.ChkAutoUpdate.Text = "Check for new available updates automatically"
        Me.ChkAutoUpdate.UseVisualStyleBackColor = True
        '
        'ChkAutoHide
        '
        Me.ChkAutoHide.AutoSize = True
        Me.ChkAutoHide.Location = New System.Drawing.Point(20, 30)
        Me.ChkAutoHide.Name = "ChkAutoHide"
        Me.ChkAutoHide.Size = New System.Drawing.Size(268, 19)
        Me.ChkAutoHide.TabIndex = 1
        Me.ChkAutoHide.Text = "Minimize MyTube to system tray when closed"
        Me.ChkAutoHide.UseVisualStyleBackColor = True
        '
        'PageDownloads
        '
        Me.PageDownloads.BackColor = System.Drawing.Color.White
        Me.PageDownloads.Controls.Add(Me.BtnFailedEvent_Play)
        Me.PageDownloads.Controls.Add(Me.BtnCompletedEvent_Play)
        Me.PageDownloads.Controls.Add(Me.BtnFailedEvent)
        Me.PageDownloads.Controls.Add(Me.TxtFailedEvent_Path)
        Me.PageDownloads.Controls.Add(Me.ChkFailedEvent)
        Me.PageDownloads.Controls.Add(Me.ChkCompletedEvent)
        Me.PageDownloads.Controls.Add(Me.BtnCompletedEvent)
        Me.PageDownloads.Controls.Add(Me.TxtCompletedEvent_Path)
        Me.PageDownloads.Controls.Add(Me.LblTimeOut)
        Me.PageDownloads.Controls.Add(Me.NumTimeOut)
        Me.PageDownloads.Controls.Add(Me.LblTempDir)
        Me.PageDownloads.Controls.Add(Me.BtnTempDir)
        Me.PageDownloads.Controls.Add(Me.BtnDownloadsDir)
        Me.PageDownloads.Controls.Add(Me.TxtTempDir)
        Me.PageDownloads.Controls.Add(Me.TxtDownloadsDir)
        Me.PageDownloads.Controls.Add(Me.LblDownloadsDir)
        Me.PageDownloads.Location = New System.Drawing.Point(4, 24)
        Me.PageDownloads.Name = "PageDownloads"
        Me.PageDownloads.Padding = New System.Windows.Forms.Padding(3)
        Me.PageDownloads.Size = New System.Drawing.Size(432, 394)
        Me.PageDownloads.TabIndex = 1
        Me.PageDownloads.Text = "Downloads"
        '
        'BtnFailedEvent_Play
        '
        Me.BtnFailedEvent_Play.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFailedEvent_Play.BackColor = System.Drawing.Color.White
        Me.BtnFailedEvent_Play.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.BtnFailedEvent_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFailedEvent_Play.Image = Global.MyTube.My.Resources.Resources.media_volume2
        Me.BtnFailedEvent_Play.Location = New System.Drawing.Point(382, 263)
        Me.BtnFailedEvent_Play.Name = "BtnFailedEvent_Play"
        Me.BtnFailedEvent_Play.Size = New System.Drawing.Size(35, 23)
        Me.BtnFailedEvent_Play.TabIndex = 14
        Me.BtnFailedEvent_Play.UseVisualStyleBackColor = False
        '
        'BtnCompletedEvent_Play
        '
        Me.BtnCompletedEvent_Play.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCompletedEvent_Play.BackColor = System.Drawing.Color.White
        Me.BtnCompletedEvent_Play.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.BtnCompletedEvent_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCompletedEvent_Play.Image = Global.MyTube.My.Resources.Resources.media_volume2
        Me.BtnCompletedEvent_Play.Location = New System.Drawing.Point(382, 192)
        Me.BtnCompletedEvent_Play.Name = "BtnCompletedEvent_Play"
        Me.BtnCompletedEvent_Play.Size = New System.Drawing.Size(35, 23)
        Me.BtnCompletedEvent_Play.TabIndex = 10
        Me.BtnCompletedEvent_Play.UseVisualStyleBackColor = False
        '
        'BtnFailedEvent
        '
        Me.BtnFailedEvent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFailedEvent.BackColor = System.Drawing.Color.White
        Me.BtnFailedEvent.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.BtnFailedEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFailedEvent.Location = New System.Drawing.Point(341, 263)
        Me.BtnFailedEvent.Name = "BtnFailedEvent"
        Me.BtnFailedEvent.Size = New System.Drawing.Size(35, 23)
        Me.BtnFailedEvent.TabIndex = 13
        Me.BtnFailedEvent.Text = "..."
        Me.BtnFailedEvent.UseVisualStyleBackColor = False
        '
        'TxtFailedEvent_Path
        '
        Me.TxtFailedEvent_Path.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtFailedEvent_Path.BackColor = System.Drawing.Color.White
        Me.TxtFailedEvent_Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFailedEvent_Path.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TxtFailedEvent_Path.Location = New System.Drawing.Point(23, 263)
        Me.TxtFailedEvent_Path.Name = "TxtFailedEvent_Path"
        Me.TxtFailedEvent_Path.ReadOnly = True
        Me.TxtFailedEvent_Path.Size = New System.Drawing.Size(312, 23)
        Me.TxtFailedEvent_Path.TabIndex = 12
        '
        'ChkFailedEvent
        '
        Me.ChkFailedEvent.AutoSize = True
        Me.ChkFailedEvent.Location = New System.Drawing.Point(23, 241)
        Me.ChkFailedEvent.Name = "ChkFailedEvent"
        Me.ChkFailedEvent.Size = New System.Drawing.Size(156, 17)
        Me.ChkFailedEvent.TabIndex = 11
        Me.ChkFailedEvent.Text = "Download &failed notification"
        Me.ChkFailedEvent.UseVisualStyleBackColor = True
        '
        'ChkCompletedEvent
        '
        Me.ChkCompletedEvent.AutoSize = True
        Me.ChkCompletedEvent.Location = New System.Drawing.Point(24, 168)
        Me.ChkCompletedEvent.Name = "ChkCompletedEvent"
        Me.ChkCompletedEvent.Size = New System.Drawing.Size(180, 17)
        Me.ChkCompletedEvent.TabIndex = 7
        Me.ChkCompletedEvent.Text = "Download &completed notification"
        Me.ChkCompletedEvent.UseVisualStyleBackColor = True
        '
        'BtnCompletedEvent
        '
        Me.BtnCompletedEvent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCompletedEvent.BackColor = System.Drawing.Color.White
        Me.BtnCompletedEvent.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.BtnCompletedEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCompletedEvent.Location = New System.Drawing.Point(341, 192)
        Me.BtnCompletedEvent.Name = "BtnCompletedEvent"
        Me.BtnCompletedEvent.Size = New System.Drawing.Size(35, 23)
        Me.BtnCompletedEvent.TabIndex = 9
        Me.BtnCompletedEvent.Text = "..."
        Me.BtnCompletedEvent.UseVisualStyleBackColor = False
        '
        'TxtCompletedEvent_Path
        '
        Me.TxtCompletedEvent_Path.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCompletedEvent_Path.BackColor = System.Drawing.Color.White
        Me.TxtCompletedEvent_Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCompletedEvent_Path.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TxtCompletedEvent_Path.Location = New System.Drawing.Point(23, 192)
        Me.TxtCompletedEvent_Path.Name = "TxtCompletedEvent_Path"
        Me.TxtCompletedEvent_Path.ReadOnly = True
        Me.TxtCompletedEvent_Path.Size = New System.Drawing.Size(312, 23)
        Me.TxtCompletedEvent_Path.TabIndex = 8
        '
        'LblTimeOut
        '
        Me.LblTimeOut.AutoSize = True
        Me.LblTimeOut.Location = New System.Drawing.Point(20, 310)
        Me.LblTimeOut.Name = "LblTimeOut"
        Me.LblTimeOut.Size = New System.Drawing.Size(174, 15)
        Me.LblTimeOut.TabIndex = 15
        Me.LblTimeOut.Text = "Connection Time&out (seconds):"
        '
        'NumTimeOut
        '
        Me.NumTimeOut.Location = New System.Drawing.Point(200, 308)
        Me.NumTimeOut.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.NumTimeOut.Minimum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NumTimeOut.Name = "NumTimeOut"
        Me.NumTimeOut.Size = New System.Drawing.Size(64, 23)
        Me.NumTimeOut.TabIndex = 16
        Me.NumTimeOut.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'LblTempDir
        '
        Me.LblTempDir.AutoSize = True
        Me.LblTempDir.Location = New System.Drawing.Point(20, 30)
        Me.LblTempDir.Name = "LblTempDir"
        Me.LblTempDir.Size = New System.Drawing.Size(118, 15)
        Me.LblTempDir.TabIndex = 1
        Me.LblTempDir.Text = "&Temporary directory:"
        '
        'BtnTempDir
        '
        Me.BtnTempDir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnTempDir.BackColor = System.Drawing.Color.White
        Me.BtnTempDir.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.BtnTempDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTempDir.Location = New System.Drawing.Point(382, 53)
        Me.BtnTempDir.Name = "BtnTempDir"
        Me.BtnTempDir.Size = New System.Drawing.Size(35, 23)
        Me.BtnTempDir.TabIndex = 3
        Me.BtnTempDir.Text = "..."
        Me.BtnTempDir.UseVisualStyleBackColor = False
        '
        'BtnDownloadsDir
        '
        Me.BtnDownloadsDir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDownloadsDir.BackColor = System.Drawing.Color.White
        Me.BtnDownloadsDir.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.BtnDownloadsDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDownloadsDir.Location = New System.Drawing.Point(382, 122)
        Me.BtnDownloadsDir.Name = "BtnDownloadsDir"
        Me.BtnDownloadsDir.Size = New System.Drawing.Size(35, 23)
        Me.BtnDownloadsDir.TabIndex = 6
        Me.BtnDownloadsDir.Text = "..."
        Me.BtnDownloadsDir.UseVisualStyleBackColor = False
        '
        'TxtTempDir
        '
        Me.TxtTempDir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTempDir.BackColor = System.Drawing.Color.White
        Me.TxtTempDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTempDir.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TxtTempDir.Location = New System.Drawing.Point(23, 53)
        Me.TxtTempDir.Name = "TxtTempDir"
        Me.TxtTempDir.ReadOnly = True
        Me.TxtTempDir.Size = New System.Drawing.Size(353, 23)
        Me.TxtTempDir.TabIndex = 2
        '
        'TxtDownloadsDir
        '
        Me.TxtDownloadsDir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDownloadsDir.BackColor = System.Drawing.Color.White
        Me.TxtDownloadsDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDownloadsDir.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TxtDownloadsDir.Location = New System.Drawing.Point(23, 122)
        Me.TxtDownloadsDir.Name = "TxtDownloadsDir"
        Me.TxtDownloadsDir.ReadOnly = True
        Me.TxtDownloadsDir.Size = New System.Drawing.Size(353, 23)
        Me.TxtDownloadsDir.TabIndex = 5
        '
        'LblDownloadsDir
        '
        Me.LblDownloadsDir.AutoSize = True
        Me.LblDownloadsDir.Location = New System.Drawing.Point(20, 99)
        Me.LblDownloadsDir.Name = "LblDownloadsDir"
        Me.LblDownloadsDir.Size = New System.Drawing.Size(119, 15)
        Me.LblDownloadsDir.TabIndex = 4
        Me.LblDownloadsDir.Text = "&Downloads directory:"
        '
        'PageAdvanced
        '
        Me.PageAdvanced.BackColor = System.Drawing.Color.White
        Me.PageAdvanced.Controls.Add(Me.BoxPowerMngr)
        Me.PageAdvanced.Controls.Add(Me.BoxMediaCache)
        Me.PageAdvanced.Location = New System.Drawing.Point(4, 24)
        Me.PageAdvanced.Name = "PageAdvanced"
        Me.PageAdvanced.Padding = New System.Windows.Forms.Padding(3)
        Me.PageAdvanced.Size = New System.Drawing.Size(432, 394)
        Me.PageAdvanced.TabIndex = 2
        Me.PageAdvanced.Text = "Advanced"
        '
        'BoxPowerMngr
        '
        Me.BoxPowerMngr.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BoxPowerMngr.Controls.Add(Me.ChkBatteryStandby)
        Me.BoxPowerMngr.Controls.Add(Me.ChkDisableStandby)
        Me.BoxPowerMngr.Location = New System.Drawing.Point(25, 141)
        Me.BoxPowerMngr.Name = "BoxPowerMngr"
        Me.BoxPowerMngr.Size = New System.Drawing.Size(385, 95)
        Me.BoxPowerMngr.TabIndex = 2
        Me.BoxPowerMngr.TabStop = False
        Me.BoxPowerMngr.Text = "Power Management"
        '
        'ChkBatteryStandby
        '
        Me.ChkBatteryStandby.AutoSize = True
        Me.ChkBatteryStandby.Location = New System.Drawing.Point(20, 57)
        Me.ChkBatteryStandby.Name = "ChkBatteryStandby"
        Me.ChkBatteryStandby.Size = New System.Drawing.Size(218, 17)
        Me.ChkBatteryStandby.TabIndex = 2
        Me.ChkBatteryStandby.Text = "Allow system standby when using &battery"
        Me.ChkBatteryStandby.UseVisualStyleBackColor = True
        '
        'ChkDisableStandby
        '
        Me.ChkDisableStandby.AutoSize = True
        Me.ChkDisableStandby.Location = New System.Drawing.Point(20, 32)
        Me.ChkDisableStandby.Name = "ChkDisableStandby"
        Me.ChkDisableStandby.Size = New System.Drawing.Size(260, 17)
        Me.ChkDisableStandby.TabIndex = 1
        Me.ChkDisableStandby.Text = "Disable system &standby while downloading videos"
        Me.ChkDisableStandby.UseVisualStyleBackColor = True
        '
        'BoxMediaCache
        '
        Me.BoxMediaCache.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BoxMediaCache.Controls.Add(Me.NumMediaCache)
        Me.BoxMediaCache.Controls.Add(Me.RdoCustomCache)
        Me.BoxMediaCache.Controls.Add(Me.RdoDynamicCache)
        Me.BoxMediaCache.Location = New System.Drawing.Point(25, 30)
        Me.BoxMediaCache.Name = "BoxMediaCache"
        Me.BoxMediaCache.Size = New System.Drawing.Size(385, 100)
        Me.BoxMediaCache.TabIndex = 1
        Me.BoxMediaCache.TabStop = False
        Me.BoxMediaCache.Text = "Media Player Cache"
        '
        'NumMediaCache
        '
        Me.NumMediaCache.Location = New System.Drawing.Point(195, 64)
        Me.NumMediaCache.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.NumMediaCache.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumMediaCache.Name = "NumMediaCache"
        Me.NumMediaCache.Size = New System.Drawing.Size(64, 23)
        Me.NumMediaCache.TabIndex = 3
        Me.NumMediaCache.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'RdoCustomCache
        '
        Me.RdoCustomCache.AutoSize = True
        Me.RdoCustomCache.Location = New System.Drawing.Point(20, 65)
        Me.RdoCustomCache.Name = "RdoCustomCache"
        Me.RdoCustomCache.Size = New System.Drawing.Size(152, 17)
        Me.RdoCustomCache.TabIndex = 2
        Me.RdoCustomCache.Text = "&Custom media cache (MB):"
        Me.RdoCustomCache.UseVisualStyleBackColor = True
        '
        'RdoDynamicCache
        '
        Me.RdoDynamicCache.AutoSize = True
        Me.RdoDynamicCache.Checked = True
        Me.RdoDynamicCache.Location = New System.Drawing.Point(20, 31)
        Me.RdoDynamicCache.Name = "RdoDynamicCache"
        Me.RdoDynamicCache.Size = New System.Drawing.Size(280, 17)
        Me.RdoDynamicCache.TabIndex = 1
        Me.RdoDynamicCache.TabStop = True
        Me.RdoDynamicCache.Text = "&Dynamic media cache according to connection speed"
        Me.RdoDynamicCache.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(377, 445)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 25)
        Me.BtnCancel.TabIndex = 3
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnOK
        '
        Me.BtnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOK.Location = New System.Drawing.Point(296, 445)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(75, 25)
        Me.BtnOK.TabIndex = 2
        Me.BtnOK.Text = "&OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'FileDlg
        '
        Me.FileDlg.DefaultExt = "wav"
        Me.FileDlg.Filter = "WAV Sound|*.wav"
        '
        'FrmSettings
        '
        Me.AcceptButton = Me.BtnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(464, 482)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.TabMain)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(480, 520)
        Me.Name = "FrmSettings"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MyTube Settings"
        Me.TabMain.ResumeLayout(False)
        Me.PageGeneral.ResumeLayout(False)
        Me.PageGeneral.PerformLayout()
        Me.PageDownloads.ResumeLayout(False)
        Me.PageDownloads.PerformLayout()
        CType(Me.NumTimeOut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PageAdvanced.ResumeLayout(False)
        Me.BoxPowerMngr.ResumeLayout(False)
        Me.BoxPowerMngr.PerformLayout()
        Me.BoxMediaCache.ResumeLayout(False)
        Me.BoxMediaCache.PerformLayout()
        CType(Me.NumMediaCache, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabMain As System.Windows.Forms.TabControl
    Friend WithEvents PageGeneral As System.Windows.Forms.TabPage
    Friend WithEvents PageDownloads As System.Windows.Forms.TabPage
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents LblDownloadsDir As System.Windows.Forms.Label
    Friend WithEvents LblTempDir As System.Windows.Forms.Label
    Friend WithEvents BtnDownloadsDir As System.Windows.Forms.Button
    Friend WithEvents BtnTempDir As System.Windows.Forms.Button
    Friend WithEvents TxtDownloadsDir As System.Windows.Forms.TextBox
    Friend WithEvents TxtTempDir As System.Windows.Forms.TextBox
    Friend WithEvents FolderDlg As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ChkAutoHide As System.Windows.Forms.CheckBox
    Friend WithEvents ChkAutoUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents PageAdvanced As System.Windows.Forms.TabPage
    Friend WithEvents BoxMediaCache As System.Windows.Forms.GroupBox
    Friend WithEvents NumMediaCache As System.Windows.Forms.NumericUpDown
    Friend WithEvents RdoCustomCache As System.Windows.Forms.RadioButton
    Friend WithEvents RdoDynamicCache As System.Windows.Forms.RadioButton
    Friend WithEvents BoxPowerMngr As System.Windows.Forms.GroupBox
    Friend WithEvents ChkBatteryStandby As System.Windows.Forms.CheckBox
    Friend WithEvents ChkDisableStandby As System.Windows.Forms.CheckBox
    Friend WithEvents FileDlg As System.Windows.Forms.OpenFileDialog
    Friend WithEvents LblTimeOut As System.Windows.Forms.Label
    Friend WithEvents NumTimeOut As System.Windows.Forms.NumericUpDown
    Friend WithEvents BtnCompletedEvent As System.Windows.Forms.Button
    Friend WithEvents TxtCompletedEvent_Path As System.Windows.Forms.TextBox
    Friend WithEvents ChkCompletedEvent As System.Windows.Forms.CheckBox
    Friend WithEvents ChkFailedEvent As System.Windows.Forms.CheckBox
    Friend WithEvents BtnFailedEvent As System.Windows.Forms.Button
    Friend WithEvents TxtFailedEvent_Path As System.Windows.Forms.TextBox
    Friend WithEvents BtnFailedEvent_Play As System.Windows.Forms.Button
    Friend WithEvents BtnCompletedEvent_Play As System.Windows.Forms.Button
    Friend WithEvents ChkCatch As System.Windows.Forms.CheckBox
End Class