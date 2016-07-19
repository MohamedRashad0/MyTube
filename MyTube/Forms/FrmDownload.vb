#Region "References"

Imports System.IO
Imports System.Net
Imports System.Xml
Imports System.Runtime.InteropServices

#End Region

Public Class FrmDownload

#Region "Declarations"

    Dim IsFirstRun As Boolean = True
    Dim _Thread1_ID, _Thread2_ID, _Thread3_ID, _Thread4_ID, _Thread5_ID As Integer

    <FlagsAttribute()> Private Enum EXECUTION_STATE As UInteger
        ES_SYSTEM_REQUIRED = &H1
        ES_DISPLAY_REQUIRED = &H2
        ES_CONTINUOUS = &H80000000UI
    End Enum

    <DllImport("Kernel32.DLL", CharSet:=CharSet.Auto, SetLastError:=True)> Private Shared Function SetThreadExecutionState(ByVal state As EXECUTION_STATE) As EXECUTION_STATE
    End Function

#End Region

#Region "General"

    Private Sub FrmDownload_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        'Get Downloads view settings

        Dim DownloadsView_Test As String = CStr(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "DownloadsView", ""))

        If String.IsNullOrWhiteSpace(DownloadsView_Test) = False Then

            Dim DownloadsView As String()
            DownloadsView = DownloadsView_Test.Trim.Split(","c)

            If DownloadsView.Length > 1 Then

                If DownloadsView.Contains("0") = True AndAlso ItmViewTitle.Checked = False Then
                    ItmViewTitle.PerformClick()
                ElseIf DownloadsView.Contains("0") = False AndAlso ItmViewTitle.Checked = True Then
                    ItmViewTitle.PerformClick()
                End If

                If DownloadsView.Contains("1") = True AndAlso ItmViewDescription.Checked = False Then
                    ItmViewDescription.PerformClick()
                ElseIf DownloadsView.Contains("1") = False AndAlso ItmViewDescription.Checked = True Then
                    ItmViewDescription.PerformClick()
                End If

                If DownloadsView.Contains("2") = True AndAlso ItmViewSize.Checked = False Then
                    ItmViewSize.PerformClick()
                ElseIf DownloadsView.Contains("2") = False AndAlso ItmViewSize.Checked = True Then
                    ItmViewSize.PerformClick()
                End If

                If DownloadsView.Contains("3") = True AndAlso ItmViewDuration.Checked = False Then
                    ItmViewDuration.PerformClick()
                ElseIf DownloadsView.Contains("3") = False AndAlso ItmViewDuration.Checked = True Then
                    ItmViewDuration.PerformClick()
                End If

                If DownloadsView.Contains("4") = True AndAlso ItmViewStatus.Checked = False Then
                    ItmViewStatus.PerformClick()
                ElseIf DownloadsView.Contains("4") = False AndAlso ItmViewStatus.Checked = True Then
                    ItmViewStatus.PerformClick()
                End If

                If DownloadsView.Contains("5") = True AndAlso ItmViewProgress.Checked = False Then
                    ItmViewProgress.PerformClick()
                ElseIf DownloadsView.Contains("5") = False AndAlso ItmViewProgress.Checked = True Then
                    ItmViewProgress.PerformClick()
                End If

                If DownloadsView.Contains("6") = True AndAlso ItmViewTransferRate.Checked = False Then
                    ItmViewTransferRate.PerformClick()
                ElseIf DownloadsView.Contains("6") = False AndAlso ItmViewTransferRate.Checked = True Then
                    ItmViewTransferRate.PerformClick()
                End If

                If DownloadsView.Contains("7") = True AndAlso ItmViewDate.Checked = False Then
                    ItmViewDate.PerformClick()
                ElseIf DownloadsView.Contains("7") = False AndAlso ItmViewDate.Checked = True Then
                    ItmViewDate.PerformClick()
                End If

                If DownloadsView.Contains("8") = True AndAlso ItmViewLastTry.Checked = False Then
                    ItmViewLastTry.PerformClick()
                ElseIf DownloadsView.Contains("8") = False AndAlso ItmViewLastTry.Checked = True Then
                    ItmViewLastTry.PerformClick()
                End If

                If DownloadsView.Contains("9") = True AndAlso ItmViewURL.Checked = False Then
                    ItmViewURL.PerformClick()
                ElseIf DownloadsView.Contains("9") = False AndAlso ItmViewURL.Checked = True Then
                    ItmViewURL.PerformClick()
                End If

                If DownloadsView.Contains("10") = True AndAlso ItmViewReferer.Checked = False Then
                    ItmViewReferer.PerformClick()
                ElseIf DownloadsView.Contains("10") = False AndAlso ItmViewReferer.Checked = True Then
                    ItmViewReferer.PerformClick()
                End If

            End If

        End If

    End Sub

    Private Sub ItmCon_WMV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItmCon_WMV.Click
        Dim SelectedIndex As Integer
        For I As Integer = 0 To LstDownloads.SelectedItems.Count - 1
            SelectedIndex = LstDownloads.SelectedItems.Item(I).Index
        Next
        Dim VFPath As String = _DownloadsFolder & "\" & LstDownloads.Items.Item(SelectedIndex).SubItems.Item(12).Text
        Dim extension As String = Path.GetExtension(LstDownloads.Items.Item(SelectedIndex).SubItems.Item(12).Text)
        If File.Exists(VFPath) = True Then
            Try
                FrmConvert.TxtConvertDir.Text = _DownloadsFolder & "\Converts\"
                FrmConvert.input = VFPath
                FrmConvert.out = _DownloadsFolder & "\Converts\" & Replace(LstDownloads.Items.Item(SelectedIndex).SubItems.Item(12).Text, extension, "")
                FrmConvert.tovid.SelectedItem = "Windows Media Video (V.7 WMV)"
                FrmConvert.ShowDialog(Me)
            Catch ex As Exception
                MessageBox.Show("The selected download is missing or corrupted.", My.Application.Info.Description, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, False)
            End Try
        Else
            MessageBox.Show("The selected download is missing or corrupted.", My.Application.Info.Description, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, False)
        End If
    End Sub

    Private Sub ItmCon_AVI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItmCon_AVI.Click
        Dim SelectedIndex As Integer

        For I As Integer = 0 To LstDownloads.SelectedItems.Count - 1
            SelectedIndex = LstDownloads.SelectedItems.Item(I).Index
        Next
        Dim VFPath As String = _DownloadsFolder & "\" & LstDownloads.Items.Item(SelectedIndex).SubItems.Item(12).Text
        Dim extension As String = Path.GetExtension(LstDownloads.Items.Item(SelectedIndex).SubItems.Item(12).Text)
        If File.Exists(VFPath) = True Then
            Try
                FrmConvert.TxtConvertDir.Text = _DownloadsFolder & "\Converts\"
                FrmConvert.input = VFPath
                FrmConvert.out = _DownloadsFolder & "\Converts\" & Replace(LstDownloads.Items.Item(SelectedIndex).SubItems.Item(12).Text, extension, "")
                FrmConvert.tovid.SelectedItem = "Xvid MPEG-4 Codec (AVI)"
                FrmConvert.ShowDialog(Me)
            Catch ex As Exception
                MessageBox.Show("The selected download is missing or corrupted.", My.Application.Info.Description, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, False)
            End Try
        Else
            MessageBox.Show("The selected download is missing or corrupted.", My.Application.Info.Description, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, False)
        End If
    End Sub

    Private Sub ItmCon_MOV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItmCon_MOV.Click
        Dim SelectedIndex As Integer
        For I As Integer = 0 To LstDownloads.SelectedItems.Count - 1
            SelectedIndex = LstDownloads.SelectedItems.Item(I).Index
        Next
        Dim VFPath As String = _DownloadsFolder & "\" & LstDownloads.Items.Item(SelectedIndex).SubItems.Item(12).Text
        Dim extension As String = Path.GetExtension(LstDownloads.Items.Item(SelectedIndex).SubItems.Item(12).Text)
        If File.Exists(VFPath) = True Then
            Try
                FrmConvert.TxtConvertDir.Text = _DownloadsFolder & "\Converts\"
                FrmConvert.input = VFPath
                FrmConvert.out = _DownloadsFolder & "\Converts\" & Replace(LstDownloads.Items.Item(SelectedIndex).SubItems.Item(12).Text, extension, "")
                FrmConvert.tovid.SelectedItem = "iPod Video (Apple QuickTime MOV)"
                FrmConvert.ShowDialog(Me)
            Catch ex As Exception
                MessageBox.Show("The selected download is missing or corrupted.", My.Application.Info.Description, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, False)
            End Try
        Else
            MessageBox.Show("The selected download is missing or corrupted.", My.Application.Info.Description, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, False)
        End If
    End Sub

    Private Sub ItmCon_MP3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItmCon_MP3.Click
        Dim SelectedIndex As Integer

        For I As Integer = 0 To LstDownloads.SelectedItems.Count - 1
            SelectedIndex = LstDownloads.SelectedItems.Item(I).Index
        Next

        Dim VFPath As String = _DownloadsFolder & "\" & LstDownloads.Items.Item(SelectedIndex).SubItems.Item(12).Text
        Dim extension As String = Path.GetExtension(LstDownloads.Items.Item(SelectedIndex).SubItems.Item(12).Text)
        If File.Exists(VFPath) = True Then
            Try
                FrmConvert.TxtConvertDir.Text = _DownloadsFolder & "\Converts\"
                FrmConvert.input = VFPath
                FrmConvert.out = _DownloadsFolder & "\Converts\" & Replace(LstDownloads.Items.Item(SelectedIndex).SubItems.Item(12).Text, extension, "")
                FrmConvert.tovid.SelectedItem = "MPEG Audio Layer 3 (MP3)"
                FrmConvert.ShowDialog(Me)
            Catch ex As Exception
                MessageBox.Show("The selected download is missing or corrupted.", My.Application.Info.Description, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, False)
            End Try

        Else
            MessageBox.Show("The selected download is missing or corrupted.", My.Application.Info.Description, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, False)
        End If
    End Sub

    Private Sub BtnConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConvert.Click
        Dim SelectedIndex As Integer
        For I As Integer = 0 To LstDownloads.SelectedItems.Count - 1
            SelectedIndex = LstDownloads.SelectedItems.Item(I).Index
        Next
        Dim VFPath As String = _DownloadsFolder & "\" & LstDownloads.Items.Item(SelectedIndex).SubItems.Item(12).Text
        Dim extension As String = Path.GetExtension(LstDownloads.Items.Item(SelectedIndex).SubItems.Item(12).Text)
        If File.Exists(VFPath) = True Then
            Try
                FrmConvert.TxtConvertDir.Text = _DownloadsFolder & "\Converts\"
                FrmConvert.input = VFPath
                FrmConvert.out = _DownloadsFolder & "\Converts\" & Replace(LstDownloads.Items.Item(SelectedIndex).SubItems.Item(12).Text, extension, "")
                FrmConvert.ShowDialog(Me)
            Catch ex As Exception
                MessageBox.Show("The selected download is missing or corrupted.", My.Application.Info.Description, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, False)
            End Try
        Else
            MessageBox.Show("The selected download is missing or corrupted.", My.Application.Info.Description, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, False)
        End If
    End Sub

    Private Sub FrmDownload_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        'Get video downloads

        Get_Downloads()
        IsFirstRun = False

    End Sub

    Private Sub FrmDownload_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged

        If IsFirstRun = False Then

            If Me.Visible = True Then
                Get_Downloads()
            Else
                Save_Settings()
            End If

        End If

    End Sub

    Private Sub FrmDownload_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Save_Settings()
    End Sub

    Private Sub LstDownloads_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LstDownloads.SelectedIndexChanged

        'Get the selected downloads number

        Dim SelectedItemsNum As Integer

        For I As Integer = 0 To LstDownloads.SelectedItems.Count - 1
            SelectedItemsNum += 1
        Next

        If SelectedItemsNum > 1 Then

            'More than one item is selected

            'Disable all buttons in HdrDownload except the Add Download and Remove buttons

            For I As Integer = 0 To HdrDownload.ButtonSpecs.Count - 2
                HdrDownload.ButtonSpecs.Item(I).Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            Next

            BtnRemove.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True

            'Disable all items of MnuDownload

            For I As Integer = 0 To MnuDownload.Items.Count - 1
                MnuDownload.Items.Item(I).Enabled = False
            Next

            ItmRemoveDownload.Enabled = True

        Else

            'Get selected download Index

            Dim SelectedIndex As Integer

            For I As Integer = 0 To LstDownloads.SelectedItems.Count - 1
                SelectedIndex = LstDownloads.SelectedItems.Item(I).Index
            Next

            Dim DownloadStatus As String = LstDownloads.Items.Item(SelectedIndex).SubItems.Item(4).Text.ToLower

            If DownloadStatus <> "completed" AndAlso DownloadStatus <> "starting" AndAlso DownloadStatus <> "downloading" AndAlso DownloadStatus <> "moving video" Then
                BtnStartDownload.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
                ItmStartDownload.Enabled = True
                BtnConvert.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False

            Else
                BtnStartDownload.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                ItmStartDownload.Enabled = False
                BtnConvert.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            End If

            If DownloadStatus = "downloading" OrElse DownloadStatus = "starting" Then
                BtnStopDownload.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
                ItmStopDownload.Enabled = True
            Else
                BtnStopDownload.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                ItmStopDownload.Enabled = False
            End If

            BtnRemove.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            BtnCopyDownloadURL.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True

            If DownloadStatus = "completed" Then

                ItmOpen.Enabled = True
                ItmOpenWith.Enabled = True
                ItmLocation.Enabled = True
                ItmConvert.Enabled = True
            Else

                ItmOpen.Enabled = False
                ItmOpenWith.Enabled = False
                ItmLocation.Enabled = False
                ItmConvert.Enabled = False
            End If

            ItmRemoveDownload.Enabled = True
            ItmCopyDescription.Enabled = True
            ItmCopyDownloadURL.Enabled = True
            ItmCopyRefererURL.Enabled = True

        End If

    End Sub

#End Region

#Region "Tasks"

    Private Sub ItmSingleVideo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItmSingleVideo.Click
        FrmNewVideo.ActionType = 1
        If FrmNewVideo.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then Get_Downloads()
    End Sub

    Private Sub ItmPlayList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItmPlayList.Click
        FrmNewVideo.ActionType = 3
        If FrmNewVideo.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then FrmLst.ShowDialog(Me)
    End Sub

    Private Sub BtnStartDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStartDownload.Click, ItmStartDownload.Click

        'Start the download in a new thread

        Dim SelectedIndex As Integer

        For I As Integer = 0 To LstDownloads.SelectedItems.Count - 1
            SelectedIndex = LstDownloads.SelectedItems.Item(I).Index
        Next

        Dim DownloadID As Integer = CInt(LstDownloads.Items.Item(SelectedIndex).Tag)

        If BWThread1.IsBusy = False Then

            BtnStartDownload.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            BtnStopDownload.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            ItmStartDownload.Enabled = False
            ItmStopDownload.Enabled = True

            _Thread1_ID = DownloadID
            BWThread1.RunWorkerAsync()

            Disable_Standby()
            LstDownloads.Items.Item(SelectedIndex).SubItems(4).Text = "Starting"

        ElseIf BWThread2.IsBusy = False Then

            BtnStartDownload.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            BtnStopDownload.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            ItmStartDownload.Enabled = False
            ItmStopDownload.Enabled = True

            _Thread2_ID = DownloadID
            BWThread2.RunWorkerAsync()

            Disable_Standby()
            LstDownloads.Items.Item(SelectedIndex).SubItems(4).Text = "Starting"

        ElseIf BWThread3.IsBusy = False Then

            BtnStartDownload.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            BtnStopDownload.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            ItmStartDownload.Enabled = False
            ItmStopDownload.Enabled = True

            _Thread3_ID = DownloadID
            BWThread3.RunWorkerAsync()

            Disable_Standby()
            LstDownloads.Items.Item(SelectedIndex).SubItems(4).Text = "Starting"

        ElseIf BWThread4.IsBusy = False Then

            BtnStartDownload.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            BtnStopDownload.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            ItmStartDownload.Enabled = False
            ItmStopDownload.Enabled = True

            _Thread4_ID = DownloadID
            BWThread4.RunWorkerAsync()

            Disable_Standby()
            LstDownloads.Items.Item(SelectedIndex).SubItems(4).Text = "Starting"

        ElseIf BWThread5.IsBusy = False Then

            BtnStartDownload.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            BtnStopDownload.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            ItmStartDownload.Enabled = False
            ItmStopDownload.Enabled = True

            _Thread5_ID = DownloadID
            BWThread5.RunWorkerAsync()

            Disable_Standby()
            LstDownloads.Items.Item(SelectedIndex).SubItems(4).Text = "Starting"

        Else
            MessageBox.Show("Maximum downloads limit is reached." & vbCrLf & "Please, wait for the current downloads to complete.", My.Application.Info.Description, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0, False)
        End If

    End Sub

    Private Sub BtnStopDownload_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnStopDownload.Click, ItmStopDownload.Click

        Dim SelectedIndex As Integer

        For I As Integer = 0 To LstDownloads.SelectedItems.Count - 1
            SelectedIndex = LstDownloads.SelectedItems.Item(I).Index
        Next

        Dim DownloadID As Integer = CInt(LstDownloads.Items.Item(SelectedIndex).Tag)

        If _Thread1_ID = DownloadID Then

            BtnStartDownload.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            BtnStopDownload.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            ItmStartDownload.Enabled = True
            ItmStopDownload.Enabled = False

            LstDownloads.Items.Item(SelectedIndex).SubItems(4).Text = "Stopping"
            BWThread1.CancelAsync()

        ElseIf _Thread2_ID = DownloadID Then

            BtnStartDownload.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            BtnStopDownload.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            ItmStartDownload.Enabled = True
            ItmStopDownload.Enabled = False

            LstDownloads.Items.Item(SelectedIndex).SubItems(4).Text = "Stopping"
            BWThread2.CancelAsync()

        ElseIf _Thread3_ID = DownloadID Then

            BtnStartDownload.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            BtnStopDownload.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            ItmStartDownload.Enabled = True
            ItmStopDownload.Enabled = False

            LstDownloads.Items.Item(SelectedIndex).SubItems(4).Text = "Stopping"
            BWThread3.CancelAsync()

        ElseIf _Thread4_ID = DownloadID Then

            BtnStartDownload.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            BtnStopDownload.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            ItmStartDownload.Enabled = True
            ItmStopDownload.Enabled = False

            LstDownloads.Items.Item(SelectedIndex).SubItems(4).Text = "Stopping"
            BWThread4.CancelAsync()

        ElseIf _Thread5_ID = DownloadID Then

            BtnStartDownload.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            BtnStopDownload.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            ItmStartDownload.Enabled = True
            ItmStopDownload.Enabled = False

            LstDownloads.Items.Item(SelectedIndex).SubItems(4).Text = "Stopping"
            BWThread5.CancelAsync()

        End If

    End Sub

    Private Sub BtnRemove_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnRemove.Click, ItmRemoveDownload.Click

        'Delete selected downloads and remove them from downloads list

        For Each ItemDownload As ListViewItem In LstDownloads.SelectedItems

            If ItemDownload.SubItems.Item(4).Text.ToLower <> "starting" AndAlso ItemDownload.SubItems.Item(4).Text.ToLower <> "downloading" AndAlso ItemDownload.SubItems.Item(4).Text.ToLower <> "moving video" AndAlso ItemDownload.SubItems.Item(4).Text.ToLower <> "Stopping" Then
                Delete_Folder(ItemDownload.SubItems.Item(13).Text)
                ItemDownload.Remove()
            End If

        Next

        If LstDownloads.Items.Count > 0 Then

            LstDownloads.SelectedItems.Clear()
            LstDownloads.Items.Item(0).Selected = True

        Else

            For I As Integer = 0 To HdrDownload.ButtonSpecs.Count - 2
                HdrDownload.ButtonSpecs.Item(I).Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            Next

            For I As Integer = 0 To MnuDownload.Items.Count - 1
                MnuDownload.Items.Item(I).Enabled = False
            Next

        End If

    End Sub

    Private Sub ItmOpen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItmOpen.Click

        Dim SelectedIndex As Integer

        For I As Integer = 0 To LstDownloads.SelectedItems.Count - 1
            SelectedIndex = LstDownloads.SelectedItems.Item(I).Index
        Next

        Dim DownloadPath As String = _DownloadsFolder & "\" & LstDownloads.Items.Item(SelectedIndex).SubItems.Item(12).Text

        If File.Exists(DownloadPath) = True Then

            Try
                Process.Start(DownloadPath)
            Catch ex As Exception
                MessageBox.Show("The selected download is missing or corrupted.", My.Application.Info.Description, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, False)
            End Try

        Else
            MessageBox.Show("The selected download is missing or corrupted.", My.Application.Info.Description, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, False)
        End If

    End Sub

    Private Sub ItmOpenWith_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItmOpenWith.Click

        Dim SelectedIndex As Integer

        For I As Integer = 0 To LstDownloads.SelectedItems.Count - 1
            SelectedIndex = LstDownloads.SelectedItems.Item(I).Index
        Next

        Dim DownloadPath As String = _DownloadsFolder & "\" & LstDownloads.Items.Item(SelectedIndex).SubItems.Item(12).Text

        If File.Exists(DownloadPath) = True Then

            Try
                Process.Start("rundll32.exe", "shell32.dll, OpenAs_RunDLL " & DownloadPath)
            Catch ex As Exception
                MessageBox.Show("The selected download is missing or corrupted.", My.Application.Info.Description, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, False)
            End Try

        Else
            MessageBox.Show("The selected download is missing or corrupted.", My.Application.Info.Description, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, False)
        End If

    End Sub

    Private Sub ItmLocation_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItmLocation.Click

        Dim SelectedIndex As Integer

        For I As Integer = 0 To LstDownloads.SelectedItems.Count - 1
            SelectedIndex = LstDownloads.SelectedItems.Item(I).Index
        Next

        Dim DownloadPath As String = _DownloadsFolder & "\" & LstDownloads.Items.Item(SelectedIndex).SubItems.Item(12).Text

        If File.Exists(DownloadPath) = True Then

            Try
                Process.Start(Path.GetDirectoryName(DownloadPath))
            Catch ex As Exception
                MessageBox.Show("The selected download is missing or corrupted.", My.Application.Info.Description, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, False)
            End Try

        Else
            MessageBox.Show("The selected download is missing or corrupted.", My.Application.Info.Description, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, False)
        End If

    End Sub

    Private Sub ItmCopyDescription_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItmCopyDescription.Click

        Dim SelectedIndex As Integer

        For I As Integer = 0 To LstDownloads.SelectedItems.Count - 1
            SelectedIndex = LstDownloads.SelectedItems.Item(I).Index
        Next

        Try
            Clipboard.SetText(LstDownloads.Items.Item(SelectedIndex).SubItems(1).Text)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub ItmCopyDownloadURL_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItmCopyDownloadURL.Click, BtnCopyDownloadURL.Click

        Dim SelectedIndex As Integer

        For I As Integer = 0 To LstDownloads.SelectedItems.Count - 1
            SelectedIndex = LstDownloads.SelectedItems.Item(I).Index
        Next

        Try
            Clipboard.SetText(LstDownloads.Items.Item(SelectedIndex).SubItems(9).Text)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub ItmCopyRefererURL_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItmCopyRefererURL.Click

        Dim SelectedIndex As Integer

        For I As Integer = 0 To LstDownloads.SelectedItems.Count - 1
            SelectedIndex = LstDownloads.SelectedItems.Item(I).Index
        Next

        Try
            Clipboard.SetText(LstDownloads.Items.Item(SelectedIndex).SubItems(10).Text)
        Catch ex As Exception
        End Try

    End Sub

#End Region

#Region "Views"

    Private Sub ItmViewTitle_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItmViewTitle.Click

        If ItmViewTitle.Checked = True Then

            ColTitle.Width = 0
            ItmViewTitle.Checked = False

        Else

            ColTitle.Width = 180
            ItmViewTitle.Checked = True

        End If

    End Sub

    Private Sub ItmViewDescription_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItmViewDescription.Click

        If ItmViewDescription.Checked = True Then

            ColDescription.Width = 0
            ItmViewDescription.Checked = False

        Else

            ColDescription.Width = 180
            ItmViewDescription.Checked = True

        End If

    End Sub

    Private Sub ItmViewSize_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItmViewSize.Click

        If ItmViewSize.Checked = True Then

            ColSize.Width = 0
            ItmViewSize.Checked = False

        Else

            ColSize.Width = 90
            ItmViewSize.Checked = True

        End If

    End Sub

    Private Sub ItmViewDuration_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItmViewDuration.Click

        If ItmViewDuration.Checked = True Then

            ColDuration.Width = 0
            ItmViewDuration.Checked = False

        Else

            ColDuration.Width = 90
            ItmViewDuration.Checked = True

        End If

    End Sub

    Private Sub ItmViewStatus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItmViewStatus.Click

        If ItmViewStatus.Checked = True Then

            ColStatus.Width = 0
            ItmViewStatus.Checked = False

        Else

            ColStatus.Width = 110
            ItmViewStatus.Checked = True

        End If

    End Sub

    Private Sub ItmViewProgress_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItmViewProgress.Click

        If ItmViewProgress.Checked = True Then

            ColProgress.Width = 0
            ItmViewProgress.Checked = False

        Else

            ColProgress.Width = 95
            ItmViewProgress.Checked = True

        End If

    End Sub

    Private Sub ItmViewTransferRate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItmViewTransferRate.Click

        If ItmViewTransferRate.Checked = True Then

            ColTransferRate.Width = 0
            ItmViewTransferRate.Checked = False

        Else

            ColTransferRate.Width = 90
            ItmViewTransferRate.Checked = True

        End If

    End Sub

    Private Sub ItmViewDate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItmViewDate.Click

        If ItmViewDate.Checked = True Then

            ColDate.Width = 0
            ItmViewDate.Checked = False

        Else

            ColDate.Width = 110
            ItmViewDate.Checked = True

        End If

    End Sub

    Private Sub ItmViewLastTry_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItmViewLastTry.Click

        If ItmViewLastTry.Checked = True Then

            ColLastTry.Width = 0
            ItmViewLastTry.Checked = False

        Else

            ColLastTry.Width = 110
            ItmViewLastTry.Checked = True

        End If

    End Sub

    Private Sub ItmViewURL_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItmViewURL.Click

        If ItmViewURL.Checked = True Then

            ColURL.Width = 0
            ItmViewURL.Checked = False

        Else

            ColURL.Width = 150
            ItmViewURL.Checked = True

        End If

    End Sub

    Private Sub ItmViewReferer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItmViewReferer.Click

        If ItmViewReferer.Checked = True Then

            ColReferer.Width = 0
            ItmViewReferer.Checked = False

        Else

            ColReferer.Width = 150
            ItmViewReferer.Checked = True

        End If

    End Sub

#End Region

#Region "Sorting"

    Private Sub ItmSortTitle_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItmSortTitle.Click

        Dim SortOrder As System.Windows.Forms.SortOrder

        If ItmSortDesc.Checked = True Then
            SortOrder = SortOrder.Descending
        Else
            SortOrder = SortOrder.Ascending
        End If

        LstDownloads.ListViewItemSorter = New ListViewSort(0, SortOrder)
        LstDownloads.Sort()

        ItmSortTitle.Checked = True
        ItmSortDescription.Checked = False
        ItmSortSize.Checked = False
        ItmSortDuration.Checked = False
        ItmSortStatus.Checked = False
        ItmSortProgress.Checked = False
        ItmSortTransferRate.Checked = False
        ItmSortDate.Checked = False
        ItmSortLastTry.Checked = False

    End Sub

    Private Sub ItmSortDescription_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItmSortDescription.Click

        Dim SortOrder As System.Windows.Forms.SortOrder

        If ItmSortDesc.Checked = True Then
            SortOrder = SortOrder.Descending
        Else
            SortOrder = SortOrder.Ascending
        End If

        LstDownloads.ListViewItemSorter = New ListViewSort(1, SortOrder)
        LstDownloads.Sort()

        ItmSortTitle.Checked = False
        ItmSortDescription.Checked = True
        ItmSortSize.Checked = False
        ItmSortDuration.Checked = False
        ItmSortStatus.Checked = False
        ItmSortProgress.Checked = False
        ItmSortTransferRate.Checked = False
        ItmSortDate.Checked = False
        ItmSortLastTry.Checked = False

    End Sub

    Private Sub ItmSortSize_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItmSortSize.Click

        Dim SortOrder As System.Windows.Forms.SortOrder

        If ItmSortDesc.Checked = True Then
            SortOrder = SortOrder.Descending
        Else
            SortOrder = SortOrder.Ascending
        End If

        LstDownloads.ListViewItemSorter = New ListViewSort(2, SortOrder)
        LstDownloads.Sort()

        ItmSortTitle.Checked = False
        ItmSortDescription.Checked = False
        ItmSortSize.Checked = True
        ItmSortDuration.Checked = False
        ItmSortStatus.Checked = False
        ItmSortProgress.Checked = False
        ItmSortTransferRate.Checked = False
        ItmSortDate.Checked = False
        ItmSortLastTry.Checked = False

    End Sub

    Private Sub ItmSortDuration_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItmSortDuration.Click

        Dim SortOrder As System.Windows.Forms.SortOrder

        If ItmSortDesc.Checked = True Then
            SortOrder = SortOrder.Descending
        Else
            SortOrder = SortOrder.Ascending
        End If

        LstDownloads.ListViewItemSorter = New ListViewSort(3, SortOrder)
        LstDownloads.Sort()

        ItmSortTitle.Checked = False
        ItmSortDescription.Checked = False
        ItmSortSize.Checked = False
        ItmSortDuration.Checked = True
        ItmSortStatus.Checked = False
        ItmSortProgress.Checked = False
        ItmSortTransferRate.Checked = False
        ItmSortDate.Checked = False
        ItmSortLastTry.Checked = False

    End Sub

    Private Sub ItmSortStatus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItmSortStatus.Click

        Dim SortOrder As System.Windows.Forms.SortOrder

        If ItmSortDesc.Checked = True Then
            SortOrder = SortOrder.Descending
        Else
            SortOrder = SortOrder.Ascending
        End If

        LstDownloads.ListViewItemSorter = New ListViewSort(4, SortOrder)
        LstDownloads.Sort()

        ItmSortTitle.Checked = False
        ItmSortDescription.Checked = False
        ItmSortSize.Checked = False
        ItmSortDuration.Checked = False
        ItmSortStatus.Checked = True
        ItmSortProgress.Checked = False
        ItmSortTransferRate.Checked = False
        ItmSortDate.Checked = False
        ItmSortLastTry.Checked = False

    End Sub

    Private Sub ItmSortProgress_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItmSortProgress.Click

        Dim SortOrder As System.Windows.Forms.SortOrder

        If ItmSortDesc.Checked = True Then
            SortOrder = SortOrder.Descending
        Else
            SortOrder = SortOrder.Ascending
        End If

        LstDownloads.ListViewItemSorter = New ListViewSort(5, SortOrder)
        LstDownloads.Sort()

        ItmSortTitle.Checked = False
        ItmSortDescription.Checked = False
        ItmSortSize.Checked = False
        ItmSortDuration.Checked = False
        ItmSortStatus.Checked = False
        ItmSortProgress.Checked = True
        ItmSortTransferRate.Checked = False
        ItmSortDate.Checked = False
        ItmSortLastTry.Checked = False

    End Sub

    Private Sub ItmSortTransferRate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItmSortTransferRate.Click

        Dim SortOrder As System.Windows.Forms.SortOrder

        If ItmSortDesc.Checked = True Then
            SortOrder = SortOrder.Descending
        Else
            SortOrder = SortOrder.Ascending
        End If

        LstDownloads.ListViewItemSorter = New ListViewSort(6, SortOrder)
        LstDownloads.Sort()

        ItmSortTitle.Checked = False
        ItmSortDescription.Checked = False
        ItmSortSize.Checked = False
        ItmSortDuration.Checked = False
        ItmSortStatus.Checked = False
        ItmSortProgress.Checked = False
        ItmSortTransferRate.Checked = True
        ItmSortDate.Checked = False
        ItmSortLastTry.Checked = False

    End Sub

    Private Sub ItmSortDate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItmSortDate.Click

        Dim SortOrder As System.Windows.Forms.SortOrder

        If ItmSortDesc.Checked = True Then
            SortOrder = SortOrder.Descending
        Else
            SortOrder = SortOrder.Ascending
        End If

        LstDownloads.ListViewItemSorter = New ListViewSort(7, SortOrder)
        LstDownloads.Sort()

        ItmSortTitle.Checked = False
        ItmSortDescription.Checked = False
        ItmSortSize.Checked = False
        ItmSortDuration.Checked = False
        ItmSortStatus.Checked = False
        ItmSortProgress.Checked = False
        ItmSortTransferRate.Checked = False
        ItmSortDate.Checked = True
        ItmSortLastTry.Checked = False

    End Sub

    Private Sub ItmSortLastTry_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItmSortLastTry.Click

        Dim SortOrder As System.Windows.Forms.SortOrder

        If ItmSortDesc.Checked = True Then
            SortOrder = SortOrder.Descending
        Else
            SortOrder = SortOrder.Ascending
        End If

        LstDownloads.ListViewItemSorter = New ListViewSort(8, SortOrder)
        LstDownloads.Sort()

        ItmSortTitle.Checked = False
        ItmSortDescription.Checked = False
        ItmSortSize.Checked = False
        ItmSortDuration.Checked = False
        ItmSortStatus.Checked = False
        ItmSortProgress.Checked = False
        ItmSortTransferRate.Checked = False
        ItmSortDate.Checked = False
        ItmSortLastTry.Checked = True

    End Sub

    Private Sub ItmSortAsc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItmSortAsc.Click

        If ItmSortAsc.Checked = False Then

            ItmSortAsc.Checked = True
            ItmSortDesc.Checked = False

            If ItmSortTitle.Checked = True Then
                ItmSortTitle.PerformClick()
            ElseIf ItmSortDescription.Checked = True Then
                ItmSortDescription.PerformClick()
            ElseIf ItmSortSize.Checked = True Then
                ItmSortSize.PerformClick()
            ElseIf ItmSortDuration.Checked = True Then
                ItmSortDuration.PerformClick()
            ElseIf ItmSortStatus.Checked = True Then
                ItmSortStatus.PerformClick()
            ElseIf ItmSortProgress.Checked = True Then
                ItmSortProgress.PerformClick()
            ElseIf ItmSortTransferRate.Checked = True Then
                ItmSortTransferRate.PerformClick()
            ElseIf ItmSortDate.Checked = True Then
                ItmSortDate.PerformClick()
            ElseIf ItmSortLastTry.Checked = True Then
                ItmSortLastTry.PerformClick()
            End If

        End If

    End Sub

    Private Sub ItmSortDesc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItmSortDesc.Click

        If ItmSortDesc.Checked = False Then

            ItmSortAsc.Checked = False
            ItmSortDesc.Checked = True

            If ItmSortTitle.Checked = True Then
                ItmSortTitle.PerformClick()
            ElseIf ItmSortDescription.Checked = True Then
                ItmSortDescription.PerformClick()
            ElseIf ItmSortSize.Checked = True Then
                ItmSortSize.PerformClick()
            ElseIf ItmSortDuration.Checked = True Then
                ItmSortDuration.PerformClick()
            ElseIf ItmSortStatus.Checked = True Then
                ItmSortStatus.PerformClick()
            ElseIf ItmSortProgress.Checked = True Then
                ItmSortProgress.PerformClick()
            ElseIf ItmSortTransferRate.Checked = True Then
                ItmSortTransferRate.PerformClick()
            ElseIf ItmSortDate.Checked = True Then
                ItmSortDate.PerformClick()
            ElseIf ItmSortLastTry.Checked = True Then
                ItmSortLastTry.PerformClick()
            End If

        End If

    End Sub

    Private Sub LstDownloads_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles LstDownloads.ColumnClick

        If e.Column = 0 Then 'Sort by Title Column

            If ItmSortTitle.Checked = False Then

                ItmSortTitle.PerformClick()

            Else

                If ItmSortAsc.Checked = False Then
                    ItmSortAsc.PerformClick()
                Else
                    ItmSortDesc.PerformClick()
                End If

            End If

        ElseIf e.Column = 1 Then 'Sort by Description Column

            If ItmSortDescription.Checked = False Then

                ItmSortDescription.PerformClick()

            Else

                If ItmSortAsc.Checked = False Then
                    ItmSortAsc.PerformClick()
                Else
                    ItmSortDesc.PerformClick()
                End If

            End If

        ElseIf e.Column = 2 Then 'Sort by Size Column

            If ItmSortSize.Checked = False Then

                ItmSortSize.PerformClick()

            Else

                If ItmSortAsc.Checked = False Then
                    ItmSortAsc.PerformClick()
                Else
                    ItmSortDesc.PerformClick()
                End If

            End If

        ElseIf e.Column = 3 Then 'Sort by Duration Column

            If ItmSortDuration.Checked = False Then

                ItmSortDuration.PerformClick()

            Else

                If ItmSortAsc.Checked = False Then
                    ItmSortAsc.PerformClick()
                Else
                    ItmSortDesc.PerformClick()
                End If

            End If

        ElseIf e.Column = 4 Then 'Sort by Status Column

            If ItmSortStatus.Checked = False Then

                ItmSortStatus.PerformClick()

            Else

                If ItmSortAsc.Checked = False Then
                    ItmSortAsc.PerformClick()
                Else
                    ItmSortDesc.PerformClick()
                End If

            End If

        ElseIf e.Column = 5 Then 'Sort by Progress Column

            If ItmSortProgress.Checked = False Then

                ItmSortProgress.PerformClick()

            Else

                If ItmSortAsc.Checked = False Then
                    ItmSortAsc.PerformClick()
                Else
                    ItmSortDesc.PerformClick()
                End If

            End If

        ElseIf e.Column = 6 Then 'Sort by Transfer Rate Column

            If ItmSortTransferRate.Checked = False Then

                ItmSortTransferRate.PerformClick()

            Else

                If ItmSortAsc.Checked = False Then
                    ItmSortAsc.PerformClick()
                Else
                    ItmSortDesc.PerformClick()
                End If

            End If

        ElseIf e.Column = 7 Then 'Sort by Date Column

            If ItmSortDate.Checked = False Then

                ItmSortDate.PerformClick()

            Else

                If ItmSortAsc.Checked = False Then
                    ItmSortAsc.PerformClick()
                Else
                    ItmSortDesc.PerformClick()
                End If

            End If

        ElseIf e.Column = 8 Then 'Sort by Last Try Date Column

            If ItmSortLastTry.Checked = False Then

                ItmSortLastTry.PerformClick()

            Else

                If ItmSortAsc.Checked = False Then
                    ItmSortAsc.PerformClick()
                Else
                    ItmSortDesc.PerformClick()
                End If

            End If

        End If

    End Sub

#End Region

#Region "Download Threads"

    Private Sub BWThread_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BWThread1.DoWork, BWThread2.DoWork, BWThread3.DoWork, BWThread4.DoWork, BWThread5.DoWork

        Dim SelectedIndex As Integer

        For I As Integer = 0 To LstDownloads.SelectedItems.Count - 1
            SelectedIndex = LstDownloads.SelectedItems.Item(I).Index
        Next

        Download_Video(CInt(LstDownloads.Items.Item(SelectedIndex).Tag), LstDownloads.Items.Item(SelectedIndex).SubItems.Item(9).Text, LstDownloads.Items.Item(SelectedIndex).SubItems.Item(13).Text & "\" & LstDownloads.Items.Item(SelectedIndex).SubItems(12).Text, CType(sender, System.ComponentModel.BackgroundWorker))

    End Sub

    Private Sub BWThread_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BWThread1.RunWorkerCompleted, BWThread2.RunWorkerCompleted, BWThread3.RunWorkerCompleted, BWThread4.RunWorkerCompleted, BWThread5.RunWorkerCompleted

        If _IsDisableStandby = True AndAlso BWThread1.IsBusy = False AndAlso BWThread2.IsBusy = False AndAlso BWThread3.IsBusy = False AndAlso BWThread4.IsBusy = False AndAlso BWThread5.IsBusy = False Then
            SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS)
        End If

    End Sub

#End Region

#Region "Functions"

    Friend Sub Get_Downloads()

        LstDownloads.BeginUpdate()

        'Check downloads temp folder

        If Directory.Exists(_TempFolder) = True Then

            'Get downloads temp folder information

            Dim TempFolder_Info As New DirectoryInfo(_TempFolder)
            Dim TempFolder_Col() As DirectoryInfo = TempFolder_Info.GetDirectories("*", SearchOption.TopDirectoryOnly)

            For I As Integer = 0 To TempFolder_Col.Length - 1

                If File.Exists(TempFolder_Col(I).FullName & "/Info.xml") = True Then

                    Try

                        Dim XMLInfo_Doc As New XmlDocument
                        XMLInfo_Doc.Load(TempFolder_Col(I).FullName & "/Info.xml")

                        'New download item

                        Dim SubItems(13) As String
                        Dim ItemDownload As New ListViewItem(SubItems)

                        For Each NodeInfo As XmlNode In XMLInfo_Doc.DocumentElement

                            'Get  Video Download Information

                            For ChildIndex As Integer = 0 To NodeInfo.ChildNodes.Count - 1

                                'Get Download ID
                                ItemDownload.Tag = NodeInfo.Attributes.ItemOf("id").Value.Trim

                                'Get Download Title
                                If NodeInfo.ChildNodes(ChildIndex).Name = "Title" Then ItemDownload.Text = NodeInfo.ChildNodes(ChildIndex).InnerText.Trim

                                'Get Download Description
                                If NodeInfo.ChildNodes(ChildIndex).Name = "Description" Then ItemDownload.SubItems.Item(1).Text = NodeInfo.ChildNodes(ChildIndex).InnerText.Trim

                                'Get Download Size
                                If NodeInfo.ChildNodes(ChildIndex).Name = "Size" Then ItemDownload.SubItems.Item(2).Text = NodeInfo.ChildNodes(ChildIndex).InnerText.Trim

                                'Get Video Duration
                                If NodeInfo.ChildNodes(ChildIndex).Name = "Duration" Then ItemDownload.SubItems.Item(3).Text = NodeInfo.ChildNodes(ChildIndex).InnerText.Trim

                                'Get Download Status

                                If NodeInfo.ChildNodes(ChildIndex).Name = "Status" Then

                                    If NodeInfo.ChildNodes(ChildIndex).InnerText.Trim.ToLower = "completed" Then
                                        ItemDownload.SubItems.Item(4).Text = "Completed"
                                    ElseIf NodeInfo.ChildNodes(ChildIndex).InnerText.Trim.ToLower = "error" Then
                                        ItemDownload.SubItems.Item(4).Text = "Error"
                                    Else
                                        ItemDownload.SubItems.Item(4).Text = "Stopped"
                                    End If

                                End If

                                'Get Download Progress
                                If NodeInfo.ChildNodes(ChildIndex).Name = "Progress" Then ItemDownload.SubItems.Item(5).Text = NodeInfo.ChildNodes(ChildIndex).InnerText.Trim

                                'Get Download Date
                                If NodeInfo.ChildNodes(ChildIndex).Name = "DateAdded" Then ItemDownload.SubItems.Item(7).Text = NodeInfo.ChildNodes(ChildIndex).InnerText.Trim

                                'Get Download Last Try Date
                                If NodeInfo.ChildNodes(ChildIndex).Name = "LastTryDate" Then ItemDownload.SubItems.Item(8).Text = NodeInfo.ChildNodes(ChildIndex).InnerText.Trim

                                'Get Download URL
                                If NodeInfo.ChildNodes(ChildIndex).Name = "DownloadURL" Then ItemDownload.SubItems.Item(9).Text = NodeInfo.ChildNodes(ChildIndex).InnerText.Trim

                                'Get Download Website
                                If NodeInfo.ChildNodes(ChildIndex).Name = "WebsiteURL" Then ItemDownload.SubItems.Item(10).Text = NodeInfo.ChildNodes(ChildIndex).InnerText.Trim

                                'Get Download Location
                                If NodeInfo.ChildNodes(ChildIndex).Name = "SaveTo" Then ItemDownload.SubItems.Item(11).Text = NodeInfo.ChildNodes(ChildIndex).InnerText.Trim

                                'Get Download Filename
                                If NodeInfo.ChildNodes(ChildIndex).Name = "FileName" Then ItemDownload.SubItems.Item(12).Text = NodeInfo.ChildNodes(ChildIndex).InnerText.Trim

                                'Get Download Temp Folder
                                ItemDownload.SubItems.Item(13).Text = TempFolder_Col(I).FullName

                            Next

                        Next

                        'Validate Download Item

                        If Get_IndexByID(CInt(ItemDownload.Tag)) = -1 AndAlso String.IsNullOrWhiteSpace(ItemDownload.Text) = False AndAlso String.IsNullOrWhiteSpace(ItemDownload.SubItems(9).Text) = False AndAlso String.IsNullOrWhiteSpace(ItemDownload.SubItems(12).Text) = False Then

                            ItemDownload.ImageKey = "videofile"
                            LstDownloads.Items.Add(ItemDownload)

                        Else
                            ItemDownload = Nothing
                        End If

                    Catch ex As Exception
                    End Try

                End If

            Next

        End If

        'Remove missing downloads

        For Each ItemDownload As ListViewItem In LstDownloads.Items
            If Directory.Exists(ItemDownload.SubItems(13).Text) = False Then ItemDownload.Remove()
        Next

        LstDownloads.EndUpdate()

        'Check downloads number

        If LstDownloads.Items.Count = 0 Then

            For I As Integer = 0 To HdrDownload.ButtonSpecs.Count - 2
                HdrDownload.ButtonSpecs.Item(I).Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            Next

            For I As Integer = 0 To MnuDownload.Items.Count - 1
                MnuDownload.Items.Item(I).Enabled = False
            Next

        Else

            LstDownloads.SelectedItems.Clear()
            LstDownloads.Items.Item(0).Selected = True

        End If

    End Sub

    Private Sub Download_Video(ByVal DownloadID As Integer, ByVal SourceURL As String, ByVal DestinationPath As String, ByVal BWThread As System.ComponentModel.BackgroundWorker)

        Try

            If My.Computer.Network.IsAvailable = False Then
                RaiseEvent DownloadFailed(Get_IndexByID(DownloadID), "Your computer is disconnected from the Internet")
                Exit Sub
            End If

            Dim RemainingSize As Integer
            Dim ProgressCache As Double = 102400
            Dim ProgressCacheIncrement As Double = ProgressCache
            Dim FullSize, ResumedFileSize, DownloadedSize As Long

            Dim ResponseStream As Stream
            Dim SaveFileStream As FileStream
            Dim MemBuffer As Byte() = New Byte(8192) {}

            If File.Exists(DestinationPath) = True Then
                Dim ResumedFileInfo As New FileInfo(DestinationPath)
                ResumedFileSize = ResumedFileInfo.Length
            End If

            If ResumedFileSize > 0 Then
                SaveFileStream = New FileStream(DestinationPath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite)
            Else
                SaveFileStream = New FileStream(DestinationPath, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite)
            End If

            Dim WebRequest As HttpWebRequest = CType(HttpWebRequest.Create(SourceURL), HttpWebRequest)
            Dim WebResponse As WebResponse

            WebRequest.Timeout = _ConnectionTimeout

            If ResumedFileSize > 0 Then WebRequest.AddRange(ResumedFileSize)

            WebResponse = WebRequest.GetResponse
            ResponseStream = WebResponse.GetResponseStream()

            FullSize = WebResponse.ContentLength

            'Update Video Download Information

            LstDownloads.Items.Item(Get_IndexByID(DownloadID)).SubItems(4).Text = "Downloading"
            LstDownloads.Items.Item(Get_IndexByID(DownloadID)).SubItems(8).Text = Now.ToShortDateString & " " & Now.ToShortTimeString
            LstDownloads.Items.Item(Get_IndexByID(DownloadID)).SubItems(2).Text = Math.Round(FullSize / 1024 / 1024, 2) & " MB"

            Dim SpeedWatch As New Stopwatch
            SpeedWatch.Start()

            RemainingSize = ResponseStream.Read(MemBuffer, 0, MemBuffer.Length)

            While (RemainingSize > 0)

                If BWThread.CancellationPending = True Then 'If canceled by user

                    ResponseStream.Close()
                    SaveFileStream.Close()

                    'Raise DownloadStopped event
                    RaiseEvent DownloadStopped(Get_IndexByID(DownloadID))

                    Exit Sub

                End If

                SaveFileStream.Write(MemBuffer, 0, RemainingSize)
                DownloadedSize = SaveFileStream.Length

                If DownloadedSize >= ProgressCacheIncrement Then

                    SpeedWatch.Stop()
                    Dim DownloadSpeed As Integer = CInt((ProgressCache / 1024) / (SpeedWatch.ElapsedMilliseconds / 1000))

                    'Report download progress and speed
                    RaiseEvent DownloadProgressChanged(Get_IndexByID(DownloadID), CInt((DownloadedSize / FullSize) * 100), DownloadSpeed)
                    ProgressCacheIncrement += ProgressCache

                    SpeedWatch.Restart()

                End If

                RemainingSize = (ResponseStream.Read(MemBuffer, 0, MemBuffer.Length))

            End While

            ResponseStream.Close()
            SaveFileStream.Close()

            'Raise DownloadCompleted event
            RaiseEvent DownloadCompleted(Get_IndexByID(DownloadID))

        Catch ex As Exception

            If LstDownloads.Items.Item(Get_IndexByID(DownloadID)).SubItems.Item(4).Text = "Stopping" Then

                'Raise DownloadStopped event
                RaiseEvent DownloadStopped(Get_IndexByID(DownloadID))

            Else

                'Raise DownloadFailed event with the reason
                RaiseEvent DownloadFailed(Get_IndexByID(DownloadID), ex.Message)

            End If

        End Try

    End Sub

    Private Sub Update_XMLInfo(ByVal DownloadIndex As Integer)

        Try

            Dim XMLPath As String = LstDownloads.Items.Item(DownloadIndex).SubItems.Item(13).Text & "/Info.xml"

            Dim XMLInfo_Doc As New XmlDocument
            XMLInfo_Doc.Load(XMLPath)

            For Each NodeInfo As XmlNode In XMLInfo_Doc.DocumentElement

                For Each ChildNode As XmlNode In NodeInfo.ChildNodes

                    If ChildNode.Name = "Size" Then ChildNode.InnerText = LstDownloads.Items.Item(DownloadIndex).SubItems(2).Text
                    If ChildNode.Name = "Status" Then ChildNode.InnerText = LstDownloads.Items.Item(DownloadIndex).SubItems(4).Text
                    If ChildNode.Name = "Progress" Then ChildNode.InnerText = LstDownloads.Items.Item(DownloadIndex).SubItems(5).Text
                    If ChildNode.Name = "LastTryDate" Then ChildNode.InnerText = LstDownloads.Items.Item(DownloadIndex).SubItems(8).Text

                Next

            Next

            File.SetAttributes(XMLPath, FileAttributes.Normal)
            XMLInfo_Doc.Save(XMLPath)

        Catch ex As Exception
        End Try

    End Sub

    Private Function Get_IndexByID(ByVal DownloadID As Integer) As Integer

        Dim DownloadIndex As Integer = -1

        Try

            For I As Integer = 0 To LstDownloads.Items.Count - 1

                Try

                    If CInt(LstDownloads.Items.Item(I).Tag) = DownloadID Then
                        DownloadIndex = I
                        Exit For
                    End If

                Catch ex As Exception
                End Try

            Next

            Return DownloadIndex

        Catch ex As Exception
            Return -1
        End Try

    End Function

    Friend Function Save_RunningDownloads() As Boolean

        FrmMain.Hide()

        If BWThread1.IsBusy = True Then BWThread1.CancelAsync()
        If BWThread2.IsBusy = True Then BWThread2.CancelAsync()
        If BWThread3.IsBusy = True Then BWThread3.CancelAsync()
        If BWThread4.IsBusy = True Then BWThread4.CancelAsync()
        If BWThread5.IsBusy = True Then BWThread5.CancelAsync()

        While (BWThread1.IsBusy OrElse BWThread2.IsBusy OrElse BWThread3.IsBusy OrElse BWThread4.IsBusy OrElse BWThread5.IsBusy)
            Application.DoEvents()
        End While

        Return True

    End Function

    Private Sub Save_Settings()

        'Save Downloads view settings

        Dim DownloadsView As String = ""

        If ItmViewTitle.Checked = True Then DownloadsView &= "0,"
        If ItmViewDescription.Checked = True Then DownloadsView &= "1,"
        If ItmViewSize.Checked = True Then DownloadsView &= "2,"
        If ItmViewDuration.Checked = True Then DownloadsView &= "3,"
        If ItmViewStatus.Checked = True Then DownloadsView &= "4,"
        If ItmViewProgress.Checked = True Then DownloadsView &= "5,"
        If ItmViewTransferRate.Checked = True Then DownloadsView &= "6,"
        If ItmViewDate.Checked = True Then DownloadsView &= "7,"
        If ItmViewLastTry.Checked = True Then DownloadsView &= "8,"
        If ItmViewURL.Checked = True Then DownloadsView &= "9,"
        If ItmViewReferer.Checked = True Then DownloadsView &= "10,"

        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "DownloadsView", DownloadsView, Microsoft.Win32.RegistryValueKind.String)

    End Sub

    Private Sub Disable_Standby()

        If _IsDisableStandby = True Then

            If SystemInformation.PowerStatus.BatteryChargeStatus = BatteryChargeStatus.NoSystemBattery Then
                SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS Or EXECUTION_STATE.ES_SYSTEM_REQUIRED)
            Else
                If _IsBatteryStandby = False Then SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS Or EXECUTION_STATE.ES_SYSTEM_REQUIRED)
            End If

        End If

    End Sub

#End Region

#Region "Events"

    Private Event DownloadStopped(ByVal Download_Index As Integer)
    Private Event DownloadCompleted(ByVal Download_Index As Integer)
    Private Event DownloadFailed(ByVal Download_Index As Integer, ByVal Reason As String)
    Private Event DownloadProgressChanged(ByVal Download_Index As Integer, ByVal Download_Progress As Integer, ByVal Download_Speed As Integer)

    Private Sub Download_ProgressChanged(ByVal Download_Index As Integer, ByVal Download_Progress As Integer, ByVal Download_Speed As Integer) Handles Me.DownloadProgressChanged

        'Set Download Progress
        If Download_Progress > 0 AndAlso Download_Progress <= 100 Then LstDownloads.Items.Item(Download_Index).SubItems(5).Text = CStr(Download_Progress) & "%"

        'Set Download Speed

        If Download_Speed > 0 Then
            LstDownloads.Items.Item(Download_Index).SubItems(6).Text = CStr(Download_Speed) & " KB/sec"
        Else
            LstDownloads.Items.Item(Download_Index).SubItems(6).Text = "0 KB/sec"
        End If

    End Sub

    Private Sub Downlaod_Completed(ByVal Download_Index As Integer) Handles Me.DownloadCompleted

        Try

            LstDownloads.Items.Item(Download_Index).SubItems(4).Text = "Moving Video"
            LstDownloads.Items.Item(Download_Index).SubItems(5).Text = "100%"
            LstDownloads.Items.Item(Download_Index).SubItems(6).Text = ""

            'Check Downloads Folder
            If Directory.Exists(_DownloadsFolder) = False Then Directory.CreateDirectory(_DownloadsFolder)

            'Move Video to Downloads Folder

            Dim DestPath As String = _DownloadsFolder & "\" & LstDownloads.Items.Item(Download_Index).SubItems.Item(12).Text

            If File.Exists(DestPath) = True Then
                File.SetAttributes(DestPath, FileAttributes.Normal)
                File.Delete(DestPath)
            End If

            File.Move(LstDownloads.Items.Item(Download_Index).SubItems.Item(13).Text & "\" & LstDownloads.Items.Item(Download_Index).SubItems.Item(12).Text, DestPath)

            LstDownloads.Items.Item(Download_Index).SubItems(4).Text = "Completed"

            LstDownloads.SelectedItems.Clear()
            LstDownloads.Items.Item(Download_Index).Selected = True

            'Update Download XML Info File
            Update_XMLInfo(Download_Index)

            'Play DownloadCompleted sound

            If _IsCompletedEvent = True AndAlso File.Exists(_CompletedEvent_Path) = True Then

                Try
                    My.Computer.Audio.Play(_CompletedEvent_Path, AudioPlayMode.Background)
                Catch ex As Exception
                End Try

            End If

        Catch ex As Exception
        End Try

    End Sub

    Private Sub Download_Failed(ByVal Download_Index As Integer, ByVal Reason As String) Handles Me.DownloadFailed

        LstDownloads.Items.Item(Download_Index).SubItems(4).Text = "Error"
        LstDownloads.Items.Item(Download_Index).SubItems(6).Text = ""

        LstDownloads.SelectedItems.Clear()
        LstDownloads.Items.Item(Download_Index).Selected = True

        'Update Download XML Info File
        Update_XMLInfo(Download_Index)

        'Play DownloadFailed sound

        If _IsFailedEvent = True AndAlso File.Exists(_FailedEvent_Path) = True Then

            Try
                My.Computer.Audio.Play(_FailedEvent_Path, AudioPlayMode.Background)
            Catch ex As Exception
            End Try

        End If

        MessageBox.Show("Error downloading the selected video." & vbCrLf & vbCrLf & Reason & ".", My.Application.Info.Description, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, False)

    End Sub

    Private Sub Download_Stopped(ByVal Download_Index As Integer) Handles Me.DownloadStopped

        LstDownloads.Items.Item(Download_Index).SubItems(4).Text = "Stopped"
        LstDownloads.Items.Item(Download_Index).SubItems(6).Text = ""

        LstDownloads.SelectedItems.Clear()
        LstDownloads.Items.Item(Download_Index).Selected = True

        'Update Download XML Info File
        Update_XMLInfo(Download_Index)

    End Sub

#End Region

End Class