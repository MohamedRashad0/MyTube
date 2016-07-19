#Region "References"

Imports System.IO
Imports System.Xml
Imports System.Net
Imports System.Diagnostics

#End Region

Class FrmWatch

#Region "Declarations"

    Dim MediaFolder As String
    Dim MediaCacheIncrement, Local_MediaCache As Double
    Dim IsMediaStopped, IsMediaPaused, IsDownloadCompleted As Boolean
    Dim MediaSize, DownloadedSize, MediaPosition, RealMediaDuration As Double

#End Region

#Region "General"

    Private Sub FrmWatch_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Get_Bookmarks()
        MediaPlayer.uiMode = "none"

    End Sub

    Private Sub FrmWatch_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

        If _IsPlayerAutoStart = True Then

            TxtURL.Text = _VideoWebsiteURL
            BtnDownload.PerformClick()
            _IsPlayerAutoStart = False

        End If

    End Sub

    Private Sub FrmWatch_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Try

            If BWDownload.IsBusy = True Then BWDownload.CancelAsync()
            ResetUI()

        Catch ex As Exception
        End Try

    End Sub

    Private Sub BtnInfo_Click(sender As System.Object, e As System.EventArgs) Handles BtnInfo.Click
        FrmSummery.ShowDialog(Me)
    End Sub

    Private Sub BtnDownload_Click(sender As System.Object, e As System.EventArgs) Handles BtnDownload.Click

        If _IsPlayerAutoStart = False Then
            'Validate video URL
            If TxtURL.Text.StartsWith("www.youtube.com/watch?v=") = True Then
                _VideoWebsiteURL = "https://" & TxtURL.Text.Trim
            ElseIf TxtURL.Text.StartsWith("http://youtube.com/watch?v=") = True Then
                _VideoWebsiteURL = TxtURL.Text.Trim.Replace("http://youtube.com/watch?v=", "https://www.youtube.com/watch?v=")
            ElseIf TxtURL.Text.StartsWith("http://www.youtube.com/watch?v=") = True Then
                _VideoWebsiteURL = TxtURL.Text.Trim.Replace("http://www.youtube.com/watch?v=", "https://www.youtube.com/watch?v=")
            ElseIf TxtURL.Text.StartsWith("youtube.com/watch?v=") = True Then
                _VideoWebsiteURL = "https://www." & TxtURL.Text.Trim
            ElseIf TxtURL.Text.StartsWith("https://www.youtube.com/watch?v=") Then
                _VideoWebsiteURL = TxtURL.Text.Trim
            Else
                MessageBox.Show("Invalid YouTube video address.", My.Application.Info.Description, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, False)
                TxtURL.Focus()
                Exit Sub
            End If

            'Validate YouTube Video ID
            _VideoID = TxtURL.Text.Replace("https://www.youtube.com/watch?v=", "").Trim

            If String.IsNullOrWhiteSpace(_VideoID) = True Then
                MessageBox.Show("Invalid YouTube video web address.", My.Application.Info.Description, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, False)
                TxtURL.Focus()
                Exit Sub
            End If

            'Check whatever there is an existing download running

            If BWDownload.IsBusy = True Then

                If MessageBox.Show("There is an active video download." & vbCrLf & "Do you want to stop the current download?", My.Application.Info.Description, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, 0, False) = Windows.Forms.DialogResult.Yes Then
                    BWDownload.CancelAsync()
                Else
                    Exit Sub
                End If

            End If

            'Check Internet connection

            If My.Computer.Network.IsAvailable = False Then
                MessageBox.Show("The computer is disconnected from the Internet." & vbCrLf & "Please, check your Internet connection.", My.Application.Info.Description, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, False)
                Exit Sub
            End If

            _VideoWebsiteURL = TxtURL.Text

            FrmVideoInfo.ActionType = 1
            If FrmVideoInfo.ShowDialog(Me) <> Windows.Forms.DialogResult.OK Then Exit Sub

        End If

        'Reset user interface

        BtnInfo.Visible = True
        BtnSprtr2.Visible = True

        MediaPlayer.URL = ""

        PicLogo.Visible = False
        LblProgress.Visible = True

        PBDownload.Value = 0
        TrkSeek.Value = 0

        PicSpeed.Visible = True
        LblSpeed.Visible = True
        LblSpeed.Text = "0 KB/sec"
        LblTime.Text = "00:00:00"

        BtnPlay.Values.Image = My.Resources.media_pause
        TipInfo.SetToolTip(BtnPlay, "Pause")
        BtnPlay.Tag = "pause"

        IsMediaPaused = False
        IsMediaStopped = False
        IsDownloadCompleted = False

        TmrMediaUpdate.Start()
        If BWDownload.IsBusy = False Then BWDownload.RunWorkerAsync()

    End Sub

    Private Sub MnuBookmarks_ItemClicked(sender As Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MnuBookmarks.ItemClicked

        TxtURL.Text = e.ClickedItem.Tag.ToString
        BtnDownload.PerformClick()
        TxtURL.Text = _VideoWebsiteURL

    End Sub

#End Region

#Region "Media Player"

    Private Sub TrkSeek_Scroll(sender As Object, e As System.EventArgs) Handles TrkSeek.Scroll

        If MediaPlayer.playState = WMPLib.WMPPlayState.wmppsPlaying OrElse MediaPlayer.playState = WMPLib.WMPPlayState.wmppsPaused Then

            If TrkSeek.Value < RealMediaDuration Then
                MediaPlayer.Ctlcontrols.currentPosition = TrkSeek.Value
            Else
                TrkSeek.Value = CInt(RealMediaDuration)
            End If

        ElseIf BWDownload.IsBusy = True AndAlso IsMediaStopped = False AndAlso IsMediaPaused = False AndAlso TrkSeek.Value < RealMediaDuration Then

            MediaPlayer.settings.volume = TrkVolume.Value
            MediaPlayer.Ctlcontrols.currentPosition = TrkSeek.Value
            MediaPlayer.Ctlcontrols.play()

        Else

            TrkSeek.Value = TrkSeek.Minimum

        End If

    End Sub

    Private Sub BtnFullScreen_Click(sender As System.Object, e As System.EventArgs) Handles BtnFullScreen.Click

        If MediaPlayer.playState = WMPLib.WMPPlayState.wmppsPlaying OrElse MediaPlayer.playState = WMPLib.WMPPlayState.wmppsPaused Then
            MediaPlayer.fullScreen = True
        End If

    End Sub

    Private Sub BtnReverse_Click(sender As System.Object, e As System.EventArgs) Handles BtnReverse.Click

        Try

            If MediaPlayer.playState = WMPLib.WMPPlayState.wmppsPlaying OrElse MediaPlayer.playState = WMPLib.WMPPlayState.wmppsPaused Then

                If MediaPlayer.Ctlcontrols.currentPosition > 0 AndAlso MediaPlayer.Ctlcontrols.currentPosition - _FastReverse > 0 Then
                    MediaPlayer.Ctlcontrols.currentPosition -= _FastReverse
                Else
                    MediaPlayer.Ctlcontrols.currentPosition = 0
                End If

                TrkSeek.Value = CInt(Math.Truncate(MediaPlayer.Ctlcontrols.currentPosition))

            ElseIf BWDownload.IsBusy = True AndAlso IsMediaStopped = False AndAlso IsMediaPaused = False AndAlso MediaPosition - _FastReverse > 0 Then

                MediaPlayer.settings.volume = TrkVolume.Value
                MediaPlayer.Ctlcontrols.currentPosition = MediaPosition - _FastReverse
                MediaPlayer.Ctlcontrols.play()

                TrkSeek.Value = CInt(Math.Truncate(MediaPlayer.Ctlcontrols.currentPosition))

            End If

        Catch ex As Exception
        End Try

    End Sub

    Private Sub BtnStop_Click(sender As System.Object, e As System.EventArgs) Handles BtnStop.Click

        If MediaPlayer.playState = WMPLib.WMPPlayState.wmppsPlaying OrElse MediaPlayer.playState = WMPLib.WMPPlayState.wmppsPaused OrElse BWDownload.IsBusy = True Then

            IsMediaStopped = True
            If BWDownload.IsBusy = True Then BWDownload.CancelAsync()
            ResetUI()

        End If

    End Sub

    Private Sub BtnPlay_Click(sender As System.Object, e As System.EventArgs) Handles BtnPlay.Click

        If BtnPlay.Tag.ToString = "play" Then

            If File.Exists(MediaPlayer.URL) = True OrElse BWDownload.IsBusy = True Then

                PicLogo.Visible = False
                MediaPlayer.Ctlcontrols.play()

                BtnPlay.Values.Image = My.Resources.media_pause
                TipInfo.SetToolTip(BtnPlay, "Pause")
                BtnPlay.Tag = "pause"

                IsMediaPaused = False
                IsMediaStopped = False

            End If

        Else

            If MediaPlayer.playState = WMPLib.WMPPlayState.wmppsPlaying OrElse BWDownload.IsBusy = True Then

                If MediaPlayer.playState = WMPLib.WMPPlayState.wmppsPlaying Then MediaPlayer.Ctlcontrols.pause()

                BtnPlay.Values.Image = My.Resources.media_play
                TipInfo.SetToolTip(BtnPlay, "Play")
                BtnPlay.Tag = "play"

                IsMediaPaused = True
                IsMediaStopped = False

            End If

        End If

    End Sub

    Private Sub BtnForward_Click(sender As System.Object, e As System.EventArgs) Handles BtnForward.Click

        Try

            If MediaPlayer.playState = WMPLib.WMPPlayState.wmppsPlaying OrElse MediaPlayer.playState = WMPLib.WMPPlayState.wmppsPaused Then

                If MediaPlayer.Ctlcontrols.currentPosition < RealMediaDuration AndAlso MediaPlayer.Ctlcontrols.currentPosition + _FastForward < RealMediaDuration Then

                    MediaPlayer.Ctlcontrols.currentPosition += _FastForward
                    TrkSeek.Value = CInt(Math.Truncate(MediaPlayer.Ctlcontrols.currentPosition))

                End If

            End If

        Catch ex As Exception
        End Try

    End Sub

    Private Sub BtnVolume_Click(sender As System.Object, e As System.EventArgs) Handles BtnVolume.Click

        If MediaPlayer.settings.volume = 0 Then

            MediaPlayer.settings.volume = 50
            BtnVolume.Values.Image = My.Resources.media_volume1
            TrkVolume.Value = 50
            TipInfo.SetToolTip(BtnVolume, "Mute")

        Else

            MediaPlayer.settings.volume = 0
            BtnVolume.Values.Image = My.Resources.media_volume0
            TrkVolume.Value = 0
            TipInfo.SetToolTip(BtnVolume, "Sound")

        End If

    End Sub

    Private Sub TrkVolume_Scroll(sender As Object, e As System.EventArgs) Handles TrkVolume.Scroll

        If TrkVolume.Value = 0 Then

            MediaPlayer.settings.volume = 0
            BtnVolume.Values.Image = My.Resources.media_volume0
            TipInfo.SetToolTip(BtnVolume, "Sound")

        ElseIf TrkVolume.Value <= 50 Then

            MediaPlayer.settings.volume = TrkVolume.Value
            BtnVolume.Values.Image = My.Resources.media_volume1
            TipInfo.SetToolTip(BtnVolume, "Mute")

        Else

            MediaPlayer.settings.volume = TrkVolume.Value
            BtnVolume.Values.Image = My.Resources.media_volume2
            TipInfo.SetToolTip(BtnVolume, "Mute")

        End If

    End Sub

    Private Sub MediaPlayer_PlayStateChange(sender As Object, e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles MediaPlayer.PlayStateChange

        If MediaPlayer.playState = WMPLib.WMPPlayState.wmppsStopped Then

            If IsMediaStopped = False AndAlso IsDownloadCompleted = False AndAlso BWDownload.IsBusy = True Then

                If DownloadedSize >= MediaCacheIncrement Then
                    RaiseEvent MediaUpdated()
                Else
                    LblProgress.Visible = True
                End If

            ElseIf IsDownloadCompleted = True Then

                PicLogo.Visible = True

                TrkSeek.Value = 0
                LblTime.Text = "00:00:00"

                BtnPlay.Values.Image = My.Resources.media_play
                TipInfo.SetToolTip(BtnPlay, "Play")
                BtnPlay.Tag = "play"

            End If

        ElseIf MediaPlayer.playState = WMPLib.WMPPlayState.wmppsPaused Then

            BtnPlay.Values.Image = My.Resources.media_play
            TipInfo.SetToolTip(BtnPlay, "Play")
            BtnPlay.Tag = "play"

            IsMediaPaused = True
            TmrMediaUpdate.Stop()

        ElseIf MediaPlayer.playState = WMPLib.WMPPlayState.wmppsPlaying Then

            BtnPlay.Values.Image = My.Resources.media_pause
            TipInfo.SetToolTip(BtnPlay, "Pause")
            BtnPlay.Tag = "pause"

            LblProgress.Visible = False
            TrkSeek.Maximum = CInt(MediaPlayer.Ctlcontrols.currentItem.duration)

            IsMediaPaused = False
            IsMediaStopped = False
            TmrMediaUpdate.Start()

        End If

    End Sub

    Private Sub TmrMediaUpdate_Tick(sender As System.Object, e As System.EventArgs) Handles TmrMediaUpdate.Tick

        If MediaPlayer.playState = WMPLib.WMPPlayState.wmppsPlaying Then

            'Set video timing

            Dim ISpan As TimeSpan = TimeSpan.FromSeconds(MediaPlayer.Ctlcontrols.currentPosition)
            LblTime.Text = ISpan.Hours.ToString.PadLeft(2, "0"c) & ":" & ISpan.Minutes.ToString.PadLeft(2, "0"c) & ":" & ISpan.Seconds.ToString.PadLeft(2, "0"c)

            'Get loaded video duration

            If PBDownload.Value < 100 Then
                RealMediaDuration = CInt((PBDownload.Value / 100) * MediaPlayer.Ctlcontrols.currentItem.duration)
            Else
                RealMediaDuration = MediaPlayer.Ctlcontrols.currentItem.duration
            End If

            'Show video progress in track bar

            If MediaPlayer.Ctlcontrols.currentPosition <= RealMediaDuration Then

                Try
                    TrkSeek.Value = CInt(Math.Truncate(MediaPlayer.Ctlcontrols.currentPosition))
                Catch ex As Exception
                End Try

            End If

            'Set global video position
            MediaPosition = MediaPlayer.Ctlcontrols.currentPosition

        End If

    End Sub

#End Region

#Region "Download Videos"

    Private Sub BWDownload_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BWDownload.DoWork

        MediaFolder = _TempFolder & "\" & _VideoName
        If Directory.Exists(MediaFolder) = True Then Delete_Folder(MediaFolder)

        Common.DownloadVideo()
        Download_Video(_VideoURL, MediaFolder & "\" & _VideoName)

    End Sub

    Private Sub Download_Video(ByVal SourceURL As String, ByVal DestinationPath As String)

        Try

            Dim RemainingSize As Integer
            Dim ProgressCache As Double = 102400
            Dim ProgressCacheIncrement As Double = ProgressCache

            Dim ResponseStream As Stream
            Dim SaveFileStream As FileStream
            Dim MemBuffer As Byte() = New Byte(8192) {}

            If _IsMediaCacheDynamic = True Then
                Local_MediaCache = 1 * 1024 * 1024
            Else
                Local_MediaCache = _MediaCache
            End If

            MediaCacheIncrement = Local_MediaCache

            SaveFileStream = New FileStream(DestinationPath, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite)

            Dim WebRequest As HttpWebRequest = CType(HttpWebRequest.Create(SourceURL), HttpWebRequest)
            Dim WebResponse As WebResponse

            WebRequest.Timeout = _ConnectionTimeout

            WebResponse = WebRequest.GetResponse
            ResponseStream = WebResponse.GetResponseStream()

            MediaSize = WebResponse.ContentLength

            Dim SpeedWatch As New Stopwatch
            SpeedWatch.Start()

            RemainingSize = ResponseStream.Read(MemBuffer, 0, MemBuffer.Length)

            SpeedWatch.Start()

            While (RemainingSize > 0)

                If BWDownload.CancellationPending = True Then 'If canceled by user

                    ResponseStream.Close()
                    SaveFileStream.Close()

                    'Raise DownloadStopped event
                    RaiseEvent DownloadStopped()

                    Exit Sub

                End If

                SaveFileStream.Write(MemBuffer, 0, RemainingSize)
                DownloadedSize = SaveFileStream.Length

                If DownloadedSize >= ProgressCacheIncrement Then

                    SpeedWatch.Stop()
                    
                    'Report download progress and speed
                    RaiseEvent DownloadProgressChanged(CInt((DownloadedSize / MediaSize) * 100), CInt((ProgressCache / 1024) / (SpeedWatch.ElapsedMilliseconds / 1000)))

                    ProgressCacheIncrement += ProgressCache
                    SpeedWatch.Restart()

                End If

                If DownloadedSize >= MediaCacheIncrement Then
                    RaiseEvent MediaUpdated()
                End If

                RemainingSize = (ResponseStream.Read(MemBuffer, 0, MemBuffer.Length))

            End While

            ResponseStream.Close()
            SaveFileStream.Close()

            RaiseEvent DownloadCompleted()

        Catch ex As Exception

            If BWDownload.CancellationPending = True Then
                RaiseEvent DownloadStopped()
            Else
                RaiseEvent DownloadFailed(ex.Message)
            End If

        End Try

    End Sub

#End Region

#Region "Events"

    Private Event MediaUpdated()
    Private Event DownloadStopped()
    Private Event DownloadCompleted()
    Private Event DownloadFailed(ByVal Reason As String)
    Private Event DownloadProgressChanged(ByVal Download_Progress As Integer, ByVal Download_Speed As Integer)

    Private Sub Download_ProgressChanged(ByVal Download_Progress As Integer, ByVal Download_Speed As Integer) Handles Me.DownloadProgressChanged

        'Set Download Progress
        If Download_Progress > 0 AndAlso Download_Progress <= 100 Then PBDownload.Value = Download_Progress

        'Set Download Speed

        If Download_Speed > 0 Then
            LblSpeed.Text = CStr(Download_Speed) & " KB/sec"
        Else
            LblSpeed.Text = "0 KB/sec"
        End If

        'Set Media Cache

        If _IsMediaCacheDynamic = True Then

            If Download_Speed <= 50 Then
                Local_MediaCache = 1 * 1024 * 1024

            ElseIf Download_Speed > 50 AndAlso Download_Speed <= 150 Then
                Local_MediaCache = 2 * 1024 * 1024

            ElseIf Download_Speed > 150 Then
                Local_MediaCache = 3 * 1024 * 1024

            End If

        Else

            Local_MediaCache = _MediaCache

        End If
        
    End Sub

    Private Sub Media_Updated() Handles Me.MediaUpdated

        If IsMediaPaused = False AndAlso IsMediaStopped = False AndAlso MediaPlayer.playState <> WMPLib.WMPPlayState.wmppsPlaying Then

            MediaPlayer.settings.volume = TrkVolume.Value
            MediaPlayer.URL = ""
            MediaPlayer.URL = MediaFolder & "\" & _VideoName
            MediaPlayer.Ctlcontrols.currentPosition = MediaPosition

            MediaCacheIncrement += Local_MediaCache

        End If

    End Sub

    Private Sub Downlaod_Completed() Handles Me.DownloadCompleted

        PBDownload.Value = 100

        PicSpeed.Visible = False
        LblSpeed.Visible = False
        LblSpeed.Text = "0 KB/sec"

        'Check downloads directory
        If Directory.Exists(_DownloadsFolder) = False Then Directory.CreateDirectory(_DownloadsFolder)

        'Overwrite any existing videos

        If File.Exists(_DownloadsFolder & "\" & _VideoName) = True Then
            File.SetAttributes(_DownloadsFolder & "\" & _VideoName, FileAttributes.Normal)
            File.Delete(_DownloadsFolder & "\" & _VideoName)
        End If

        MediaPlayer.URL = ""
        LblProgress.Visible = True

        'Move video file to downloads directory
        File.Move(MediaFolder & "\" & _VideoName, _DownloadsFolder & "\" & _VideoName)

        'Start the media player

        MediaPlayer.settings.volume = TrkVolume.Value
        MediaPlayer.URL = _DownloadsFolder & "\" & _VideoName
        MediaPlayer.Ctlcontrols.currentPosition = MediaPosition

        IsDownloadCompleted = True
        Update_XMLInfo("Completed")

        MessageBox.Show("Video download completed and saved to:" & vbCrLf & vbCrLf & _DownloadsFolder, My.Application.Info.Description, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0, False)

    End Sub

    Private Sub Download_Failed(ByVal Reason As String) Handles Me.DownloadFailed

        Update_XMLInfo("Error")
        ResetUI()

        MessageBox.Show("Error downloading the selected video." & vbCrLf & vbCrLf & Reason & ".", My.Application.Info.Description, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, False)

    End Sub

    Private Sub Download_Stopped() Handles Me.DownloadStopped

        Update_XMLInfo("Stopped")
        ResetUI()

    End Sub

#End Region

#Region "Functions"

    Private Sub Get_Bookmarks()

        If File.Exists(_BookmarksFile) = True Then

            MnuBookmarks.Items.Clear()

            Try

                Dim Video_Title, Video_Website As New String(" "c, 0)

                'Load Bookmarks.xml in XMLDocument

                Dim BookmarksDoc As New XmlDocument
                BookmarksDoc.Load(_BookmarksFile)

                For Each BookmarkNode As XmlNode In BookmarksDoc.DocumentElement

                    Try

                        'Load video bookmark information

                        For I As Integer = 0 To BookmarkNode.ChildNodes.Count - 1

                            If BookmarkNode.ChildNodes(I).Name = "Title" Then Video_Title = BookmarkNode.ChildNodes(I).InnerText.Trim
                            If BookmarkNode.ChildNodes(I).Name = "WebsiteURL" Then Video_Website = BookmarkNode.ChildNodes(I).InnerText.Trim

                        Next

                        'Validate each video bookmark

                        If String.IsNullOrWhiteSpace(Video_Title) = False AndAlso Video_Website.ToLower.StartsWith("http://") = True AndAlso String.IsNullOrWhiteSpace(BookmarkNode.Attributes.ItemOf("id").Value) = False Then

                            Dim BookmarkItem As New ToolStripMenuItem

                            'Add Video title item
                            BookmarkItem.Text = Video_Title

                            'Add video Website item
                            BookmarkItem.Tag = Video_Website

                            MnuBookmarks.Items.Add(BookmarkItem)

                        End If

                    Catch ex As Exception
                    End Try

                Next

            Catch ex As Exception
            End Try

        End If

        'Check bookmarks items

        If MnuBookmarks.Items.Count > 0 Then
            BtnBookmarks.Visible = True
            BtnSprtr1.Visible = True
        Else
            BtnBookmarks.Visible = False
            BtnSprtr1.Visible = False
        End If

    End Sub

    Private Sub ResetUI()

        'Reset user interface

        BtnInfo.Visible = False
        BtnSprtr2.Visible = False

        MediaPlayer.URL = ""

        PicLogo.Visible = True
        LblProgress.Visible = False

        PBDownload.Value = 0
        TrkSeek.Value = 0

        PicSpeed.Visible = False
        LblSpeed.Visible = False
        LblSpeed.Text = "0 KB/sec"
        LblTime.Text = "00:00:00"

        BtnPlay.Values.Image = My.Resources.media_play
        TipInfo.SetToolTip(BtnPlay, "Play")
        BtnPlay.Tag = "play"

        TmrMediaUpdate.Stop()

    End Sub

    Private Sub Update_XMLInfo(ByVal Status As String)

        'Update download XML information file

        Try

            Dim XMLPath As String = MediaFolder & "\Info.xml"

            Dim XMLInfo_Doc As New XmlDocument
            XMLInfo_Doc.Load(XMLPath)

            For Each NodeInfo As XmlNode In XMLInfo_Doc.DocumentElement

                For Each ChildNode As XmlNode In NodeInfo.ChildNodes

                    If ChildNode.Name = "Size" Then ChildNode.InnerText = Math.Round(MediaSize / 1024 / 1024, 2) & " MB"
                    If ChildNode.Name = "Status" Then ChildNode.InnerText = Status
                    If ChildNode.Name = "Progress" Then ChildNode.InnerText = CStr(PBDownload.Value) & "%"
                    If ChildNode.Name = "LastTryDate" Then ChildNode.InnerText = Now.ToShortDateString & " " & Now.ToShortTimeString

                Next

            Next

            File.SetAttributes(XMLPath, FileAttributes.Normal)
            XMLInfo_Doc.Save(XMLPath)

        Catch ex As Exception
        End Try

    End Sub

#End Region

End Class