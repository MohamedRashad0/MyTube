#Region "References"

Imports System.IO

#End Region

Public Class FrmSettings

#Region "General"

    Private Sub FrmSettings_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        'General Settings

        If CInt(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "AutoHide", 0)) = 1 Then
            ChkAutoHide.Checked = True
        Else
            ChkAutoHide.Checked = False
        End If


        If CInt(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "CatchVideos", 1)) = 1 Then
            ChkCatch.Checked = True
        Else
            ChkCatch.Checked = False
        End If


        If CInt(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "AutoUpdate", 1)) = 1 Then
            ChkAutoUpdate.Checked = True
        Else
            ChkAutoUpdate.Checked = False
        End If

        'Downloads Settings

        Dim TempDir_Str As String = CStr(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "TempDir", ""))

        If Directory.Exists(TempDir_Str) = True Then
            TxtTempDir.Text = TempDir_Str
        Else
            TxtTempDir.Text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Smart PC Soft\MyTube\Downloads"
        End If

        Dim DownloadsDir_Str As String = CStr(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "DownloadsDir", ""))

        If Directory.Exists(DownloadsDir_Str) = True Then
            TxtDownloadsDir.Text = DownloadsDir_Str
        Else
            TxtDownloadsDir.Text = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\Downloads\MyTube"
        End If

        If CInt(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "CompletedEvent", 0)) = 1 Then
            ChkCompletedEvent.Checked = True
        Else
            ChkCompletedEvent.Checked = False
        End If

        Dim CompletedEvent_Path As String = CStr(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "CompletedEventPath", ""))

        If File.Exists(CompletedEvent_Path) = True Then
            TxtCompletedEvent_Path.Text = CompletedEvent_Path
        Else
            TxtCompletedEvent_Path.Text = ""
            ChkCompletedEvent.Checked = False
        End If

        If CInt(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "FailedEvent", 0)) = 1 Then
            ChkFailedEvent.Checked = True
        Else
            ChkFailedEvent.Checked = False
        End If

        Dim FailedEvent_Path As String = CStr(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "FailedEventPath", ""))

        If File.Exists(FailedEvent_Path) = True Then
            TxtFailedEvent_Path.Text = FailedEvent_Path
        Else
            TxtFailedEvent_Path.Text = ""
            ChkFailedEvent.Checked = False
        End If

        Dim ConnectionTimout As Decimal = CDec(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "ConnectionTimeout", 60000))

        If ConnectionTimout < 30000 OrElse ConnectionTimout > 180000 Then
            NumTimeOut.Value = 60
        Else
            NumTimeOut.Value = CDec(ConnectionTimout / 1000)
        End If

        'Advanced Settings

        If CInt(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "DynamicCache", 1)) = 1 Then

            RdoDynamicCache.Checked = True

        Else

            RdoCustomCache.Checked = True

            Dim MediaCache As Decimal = CDec(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "MediaCache", 1))

            If MediaCache < 1 OrElse MediaCache > 20 Then
                NumMediaCache.Value = 1
            Else
                NumMediaCache.Value = MediaCache
            End If

        End If

        If CInt(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "DisableStandby", 1)) = 1 Then
            ChkDisableStandby.Checked = True
            ChkBatteryStandby.Enabled = True
        Else
            ChkDisableStandby.Checked = False
            ChkBatteryStandby.Enabled = False
        End If

        If CInt(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "BatteryStandby", 1)) = 1 Then
            ChkBatteryStandby.Checked = True
        Else
            ChkBatteryStandby.Checked = False
        End If

    End Sub

    Private Sub BtnTempDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTempDir.Click

        FolderDlg.Description = "Select a directory to contain temporary files."
        If FolderDlg.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then TxtTempDir.Text = FolderDlg.SelectedPath

        FolderDlg.Description = ""
        FolderDlg.SelectedPath = ""

    End Sub

    Private Sub BtnDownloadsDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDownloadsDir.Click

        FolderDlg.Description = "Select a directory to contain video downloads."
        If FolderDlg.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then TxtDownloadsDir.Text = FolderDlg.SelectedPath

        FolderDlg.Description = ""
        FolderDlg.SelectedPath = ""

    End Sub

    Private Sub ChkCompletedEvent_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkCompletedEvent.CheckedChanged

        If ChkCompletedEvent.Checked = True AndAlso String.IsNullOrWhiteSpace(TxtCompletedEvent_Path.Text) = True Then

            BtnCompletedEvent.PerformClick()
            If String.IsNullOrWhiteSpace(TxtCompletedEvent_Path.Text) = True Then ChkCompletedEvent.Checked = False

        End If

    End Sub

    Private Sub TxtCompletedEvent_Path_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCompletedEvent_Path.TextChanged

        If File.Exists(TxtCompletedEvent_Path.Text) = True Then
            ChkCompletedEvent.Checked = True
        Else
            ChkCompletedEvent.Checked = False
        End If

    End Sub

    Private Sub BtnCompletedEvent_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCompletedEvent.Click

        FileDlg.Title = "Download Completed Sound"
        If FileDlg.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then TxtCompletedEvent_Path.Text = FileDlg.FileName

        FileDlg.Title = ""
        FileDlg.FileName = ""

    End Sub

    Private Sub BtnCompletedEvent_Play_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCompletedEvent_Play.Click

        If File.Exists(TxtCompletedEvent_Path.Text) = True Then

            Try
                My.Computer.Audio.Play(TxtCompletedEvent_Path.Text, AudioPlayMode.Background)
            Catch ex As Exception
                MessageBox.Show("The selected audio format is not supported.", My.Application.Info.Description, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, 0, False)
            End Try

        End If

    End Sub

    Private Sub ChkFailedEvent_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkFailedEvent.CheckedChanged

        If ChkFailedEvent.Checked = True AndAlso String.IsNullOrWhiteSpace(TxtFailedEvent_Path.Text) = True Then

            BtnFailedEvent.PerformClick()
            If String.IsNullOrWhiteSpace(TxtFailedEvent_Path.Text) = True Then ChkFailedEvent.Checked = False

        End If

    End Sub

    Private Sub TxtFailedEvent_Path_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtFailedEvent_Path.TextChanged

        If File.Exists(TxtFailedEvent_Path.Text) = True Then
            ChkFailedEvent.Checked = True
        Else
            ChkFailedEvent.Checked = False
        End If

    End Sub

    Private Sub BtnFailedEvent_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnFailedEvent.Click

        FileDlg.Title = "Download Failed Sound"
        If FileDlg.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then TxtFailedEvent_Path.Text = FileDlg.FileName

        FileDlg.Title = ""
        FileDlg.FileName = ""

    End Sub

    Private Sub BtnFailedEvent_Play_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnFailedEvent_Play.Click

        If File.Exists(TxtFailedEvent_Path.Text) = True Then

            Try
                My.Computer.Audio.Play(TxtFailedEvent_Path.Text, AudioPlayMode.Background)
            Catch ex As Exception
                MessageBox.Show("The selected audio format is not supported.", My.Application.Info.Description, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, 0, False)
            End Try

        End If

    End Sub

    Private Sub RdoDynamicCache_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoDynamicCache.CheckedChanged

        If RdoDynamicCache.Checked = True Then
            NumMediaCache.Enabled = False
        Else
            NumMediaCache.Enabled = True
        End If

    End Sub

    Private Sub ChkDisableStandby_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkDisableStandby.CheckedChanged

        If ChkDisableStandby.Checked = True Then
            ChkBatteryStandby.Enabled = True
        Else
            ChkBatteryStandby.Enabled = False
        End If

    End Sub

    Private Sub BtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOK.Click

        'General Settings

        If ChkAutoHide.Checked = True Then
            _IsAutoHide = True
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "AutoHide", 1, Microsoft.Win32.RegistryValueKind.DWord)
        Else
            _IsAutoHide = False
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "AutoHide", 0, Microsoft.Win32.RegistryValueKind.DWord)
        End If


        If ChkCatch.Checked = True Then
            _CatchVideos = True
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "CatchVideos", 1, Microsoft.Win32.RegistryValueKind.DWord)
        Else
            _CatchVideos = False
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "CatchVideos", 0, Microsoft.Win32.RegistryValueKind.DWord)
        End If


        If ChkAutoUpdate.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "AutoUpdate", 1, Microsoft.Win32.RegistryValueKind.DWord)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "AutoUpdate", 0, Microsoft.Win32.RegistryValueKind.DWord)
        End If

        'Downloads Settings

        If Directory.Exists(TxtTempDir.Text) = False Then Directory.CreateDirectory(TxtTempDir.Text)
        _TempFolder = TxtTempDir.Text
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "TempDir", TxtTempDir.Text, Microsoft.Win32.RegistryValueKind.String)

        If Directory.Exists(TxtDownloadsDir.Text) = False Then Directory.CreateDirectory(TxtDownloadsDir.Text)
        _DownloadsFolder = TxtDownloadsDir.Text
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "DownloadsDir", TxtDownloadsDir.Text, Microsoft.Win32.RegistryValueKind.String)

        If ChkCompletedEvent.Checked = True Then
            _IsCompletedEvent = True
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "CompletedEvent", 1, Microsoft.Win32.RegistryValueKind.DWord)
        Else
            _IsCompletedEvent = False
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "CompletedEvent", 0, Microsoft.Win32.RegistryValueKind.DWord)
        End If

        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "CompletedEventPath", TxtCompletedEvent_Path.Text, Microsoft.Win32.RegistryValueKind.String)

        If ChkFailedEvent.Checked = True Then
            _IsFailedEvent = True
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "FailedEvent", 1, Microsoft.Win32.RegistryValueKind.DWord)
        Else
            _IsFailedEvent = False
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "FailedEvent", 0, Microsoft.Win32.RegistryValueKind.DWord)
        End If

        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "FailedEventPath", TxtFailedEvent_Path.Text, Microsoft.Win32.RegistryValueKind.String)

        _ConnectionTimeout = CInt(NumTimeOut.Value * 1000)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "ConnectionTimeout", NumTimeOut.Value * 1000, Microsoft.Win32.RegistryValueKind.DWord)

        'Advanced Settings

        If RdoDynamicCache.Checked = True Then
            _IsMediaCacheDynamic = True
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "DynamicCache", 1, Microsoft.Win32.RegistryValueKind.DWord)
        Else
            _IsMediaCacheDynamic = False
            _MediaCache = NumMediaCache.Value * 1024 * 1024
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "DynamicCache", 0, Microsoft.Win32.RegistryValueKind.DWord)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "MediaCache", NumMediaCache.Value, Microsoft.Win32.RegistryValueKind.DWord)

        End If

        If ChkDisableStandby.Checked = True Then
            _IsDisableStandby = True
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "DisableStandby", 1, Microsoft.Win32.RegistryValueKind.DWord)
        Else
            _IsDisableStandby = False
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "DisableStandby", 0, Microsoft.Win32.RegistryValueKind.DWord)
        End If

        If ChkBatteryStandby.Checked = True Then
            _IsBatteryStandby = True
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "BatteryStandby", 1, Microsoft.Win32.RegistryValueKind.DWord)
        Else
            _IsBatteryStandby = False
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "BatteryStandby", 0, Microsoft.Win32.RegistryValueKind.DWord)
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub

#End Region

End Class