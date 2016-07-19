#Region "References"

Imports System.IO
Imports System.Net
Imports System.Xml
Imports System.Text
Imports Newtonsoft.Json
#End Region

Public Class FrmVideoInfo

#Region "Declarations"

    Friend ActionType As Byte
    Dim IsCanceled As Boolean
    Dim VideoExtractor_Str As String

#End Region

#Region "General"

    Private Sub FrmVideoInfo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        If ActionType = 1 Then
            BtnAction.Text = "Watch"

        ElseIf ActionType = 2 Then
            BtnAction.Text = "Download"

        ElseIf ActionType = 3 Then

            TxtTitle.ReadOnly = False
            TxtDuration.ReadOnly = False
            TxtDescription.ReadOnly = False
            BtnAction.Text = "Bookmark"
        End If

        'Clear all general video information

        _VideoThumbnail.Image = Nothing
        _VideoTitle = ""
        _VideoName = ""
        _VideoDuration = ""
        _VideoDescription = ""
        _VideoURL = ""

    End Sub

    Private Sub FrmVideoInfo_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

        If String.IsNullOrWhiteSpace(_VideoWebsiteURL) = True OrElse String.IsNullOrWhiteSpace(_VideoID) = True Then
            MessageBox.Show("Error retrieving video information." & vbCrLf & "Please, check Internet connection and video URL.", My.Application.Info.Description, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, False)
            Me.Close()
        End If

        If My.Computer.Network.IsAvailable = True Then

            TmrProgress.Start()

            'Start capturing video information
            BWVideoInfo.RunWorkerAsync()

        Else

            MessageBox.Show("The computer is disconnected from the Internet." & vbCrLf & "Please, check your Internet connection.", My.Application.Info.Description, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, False)
            Me.Close()

        End If

    End Sub

    Private Sub FrmVideoInfo_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Try

            'Cancel all running tasks

            Me.Opacity = 0
            IsCanceled = True
            If BWVideoInfo.IsBusy = True Then BWVideoInfo.CancelAsync()

            'Close Video Extractor process

            For Each Prcs As Process In Process.GetProcessesByName("ve")

                Try
                    Prcs.Kill()
                Catch ex As Exception
                End Try

            Next

            Me.Dispose()

        Catch ex As Exception
        End Try

    End Sub

    Private Sub BtnOpenLink_Click(sender As System.Object, e As System.EventArgs) Handles BtnOpenLink.Click

        Try
            Process.Start(TxtWebsiteURL.Text)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub ItmCopyURL_Click(sender As Object, e As System.EventArgs) Handles ItmCopyURL.Click

        Try
            Clipboard.SetText(LstLinks.FocusedItem.Text)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub BtnAction_Click(sender As System.Object, e As System.EventArgs) Handles BtnAction.Click

        Dim SelectedIndex As Integer

        For I As Integer = 0 To LstLinks.SelectedItems.Count - 1
            SelectedIndex = LstLinks.SelectedItems.Item(I).Index
        Next

        'Set video information into the general variables

        If Not PicThumbnail.Image Is Nothing Then _VideoThumbnail.Image = PicThumbnail.Image

        _VideoName = TxtTitle.Text
        _VideoTitle = TxtTitle.Text
        _VideoDuration = TxtDuration.Text
        _VideoDescription = TxtDescription.Text
        _VideoWebsiteURL = TxtWebsiteURL.Text
        _VideoID = _VideoWebsiteURL.Replace("https://www.youtube.com/watch?v=", "").Trim

        If ActionType = 1 OrElse ActionType = 2 Then

            'Format video name and combine extension

            If _VideoName.Contains("?") = True Then _VideoName = _VideoName.Replace("?", "").Trim
            If _VideoName.Contains("/") = True Then _VideoName = _VideoName.Replace("/", "").Trim
            If _VideoName.Contains("\") = True Then _VideoName = _VideoName.Replace("\", "").Trim
            If _VideoName.Contains("*") = True Then _VideoName = _VideoName.Replace("*", "").Trim
            If _VideoName.Contains("|") = True Then _VideoName = _VideoName.Replace("|", "").Trim
            If _VideoName.Contains(":") = True Then _VideoName = _VideoName.Replace(":", "").Trim
            If _VideoName.Contains("<") = True Then _VideoName = _VideoName.Replace("<", "").Trim
            If _VideoName.Contains(">") = True Then _VideoName = _VideoName.Replace(">", "").Trim
            If _VideoName.Contains("""") = True Then _VideoName = _VideoName.Replace("""", "").Trim

            Dim VideoType As String = LstLinks.Items.Item(SelectedIndex).SubItems(2).Text.ToLower

            If VideoType.Contains("webm") = True Then
                _VideoName &= ".webm"
            ElseIf VideoType.Contains("mp4") = True Then
                _VideoName &= ".mp4"
            ElseIf VideoType.Contains("flv") = True Then
                _VideoName &= ".flv"
            ElseIf VideoType.Contains("3gp") = True Then
                _VideoName &= ".3gp"
            End If

            _VideoURL = LstLinks.Items.Item(SelectedIndex).Text

        End If

        'Perform an Action

        If ActionType = 1 Then 'Watch video

            If FrmWatch.Visible = False Then

                _IsPlayerAutoStart = True
                FrmMain.BtnWatch.PerformClick()

            End If

        ElseIf ActionType = 2 Then 'Download video

            If DownloadVideo() = True Then
                If FrmDownload.Visible = False Then
                    FrmMain.BtnDownload.PerformClick()
                Else
                    FrmDownload.Get_Downloads()
                End If
            Else
                Exit Sub
            End If

        ElseIf ActionType = 3 Then 'Bookmark video

            BookmarkVideo()

        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub

    Private Sub BtnClose_Click(sender As System.Object, e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub TmrProgress_Tick(sender As System.Object, e As System.EventArgs) Handles TmrProgress.Tick

        If PBProgress.Value < 100 Then
            PBProgress.Value += 2
        Else
            PBProgress.Value = 2
        End If

    End Sub

#End Region

#Region "Video Information"

    Private Sub BWVideoInfo_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BWVideoInfo.DoWork

        Form.CheckForIllegalCrossThreadCalls = False

        Try

            Dim DownloadClient As New WebClient
            DownloadClient.Encoding = Encoding.UTF8

            Dim VideoInfo_URL As String = "https://www.googleapis.com/youtube/v3/videos?part=snippet%2CcontentDetails&fields=items&key=YOUR_KEY_HERE&id=" & _VideoID
            VideoInfo_URL = VideoInfo_URL.Replace(" "c, "+"c)

            'Download video information in XML format

            Dim VideoInfoStr As String = DownloadClient.DownloadString(VideoInfo_URL)
            Dim node As XNode = JsonConvert.DeserializeXNode(VideoInfoStr, "Root")

            Dim XML_Reader As XmlReader = XmlReader.Create(New StringReader(node.ToString))

            'Read video information


            Do While XML_Reader.Read()


                'Load video thumbnail

                Try

                    If XML_Reader.NodeType = XmlNodeType.Element AndAlso XML_Reader.Name = "url" Then
                        PicThumbnail.Load(XML_Reader.ReadElementString("url").Trim)
                    End If

                Catch ex As Exception
                    PicThumbnail.Image = Image.FromFile(Application.StartupPath & "\404")
                End Try

                'Get video title

                If XML_Reader.NodeType = XmlNodeType.Element AndAlso XML_Reader.Name = "title" Then
                    TxtTitle.Text = XML_Reader.ReadElementString.Trim
                End If

                'Get video duration

                If XML_Reader.NodeType = XmlNodeType.Element AndAlso XML_Reader.Name = "duration" Then
                    TxtDuration.Text = XmlConvert.ToTimeSpan(XML_Reader.ReadElementString.Trim).ToString

                End If

                'Get video description

                If XML_Reader.NodeType = XmlNodeType.Element AndAlso XML_Reader.Name = "description" Then
                    TxtDescription.Text = XML_Reader.ReadElementString.Trim
                End If

            Loop

            TxtWebsiteURL.Text = _VideoWebsiteURL

            'If Watch or Download video 

            If ActionType = 1 OrElse ActionType = 2 Then

                Dim PrcsExtractor As New Process
                PrcsExtractor.StartInfo.FileName = Application.StartupPath & "\ve.exe"
                PrcsExtractor.StartInfo.Arguments = _VideoWebsiteURL & " -g --all-formats --get-format"
                PrcsExtractor.StartInfo.UseShellExecute = False
                PrcsExtractor.StartInfo.RedirectStandardOutput = True
                PrcsExtractor.StartInfo.CreateNoWindow = True
                PrcsExtractor.Start()

                'Get Video Extractor Output

                Dim Prcs_Reader As StreamReader = PrcsExtractor.StandardOutput
                VideoExtractor_Str = Prcs_Reader.ReadToEnd
                PrcsExtractor.WaitForExit()

                LblProgress.Text = "Validating Video Links..."
                Parse_VideoInfo(VideoExtractor_Str)

            End If

        Catch ex As Exception

            _VideoID = ""
            _VideoWebsiteURL = ""

            If IsCanceled = False Then

                IsCanceled = True

                LblProgress.Text = "Error Getting Video Info"
                TmrProgress.Stop()
                PBProgress.Value = 0

                If File.Exists(Application.StartupPath & "\ve.exe") = True Then
                    MessageBox.Show("Error retrieving video information." & vbCrLf & "Please, check Internet connection and video URL.", My.Application.Info.Description, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, False)
                Else
                    MessageBox.Show("Video Extractor application is missing or corrupted.", My.Application.Info.Description, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, False)
                End If

                Me.Close()

            End If

        End Try

    End Sub

    Private Sub BWVideoInfo_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BWVideoInfo.RunWorkerCompleted

        If IsCanceled = False Then

            If ActionType = 3 Then

                'If video Bookmark action

                PnlProgress.Visible = False
                LblLinks.Visible = False
                LstLinks.Visible = False
                PnlMain.Visible = True
                BtnAction.Visible = True
                BtnClose.Visible = True

            Else

                'If video watch or download actions

                PnlProgress.Visible = False
                PnlMain.Visible = True
                BtnAction.Visible = True
                BtnClose.Visible = True

                If LstLinks.Items.Count = 0 Then

                    'No valid download links found

                    BtnAction.Enabled = False

                    If MessageBox.Show("The video does not contain valid download links." & vbCrLf & vbCrLf & "Do you want to open the video in YouTube?", My.Application.Info.Description, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, 0, False) = Windows.Forms.DialogResult.Yes Then
                        Process.Start(_VideoWebsiteURL)
                        Me.Close()
                    End If

                Else

                    LstLinks.Items.Item(0).Selected = True
                    LstLinks.ContextMenuStrip = MnuLinks

                End If

            End If

        End If

    End Sub

#End Region

#Region "Functions"

    Private Sub Parse_VideoInfo(ByVal VideoInfoStr As String)

        Dim VideoSize As Long
        Dim Increment As Integer

        Dim WebRequest As HttpWebRequest
        Dim WebResponse As WebResponse

        Dim InfoElements() As String = VideoInfoStr.Split(CChar(vbCrLf))
        Dim ElementsNum As Integer = CInt(InfoElements.Length / 2)

        For I As Integer = 0 To ElementsNum - 1

            Try

                Dim VideoType As String = InfoElements(Increment + 1).Trim

                'Filter videos by type

                If VideoType.StartsWith("38") OrElse VideoType.StartsWith("46") OrElse _
                    VideoType.StartsWith("37") OrElse VideoType.StartsWith("45") OrElse _
                    VideoType.StartsWith("22") OrElse VideoType.StartsWith("44") OrElse _
                    VideoType.StartsWith("35") OrElse VideoType.StartsWith("43") OrElse _
                    VideoType.StartsWith("34") OrElse VideoType.StartsWith("18") OrElse _
                    VideoType.StartsWith("6") OrElse VideoType.StartsWith("5") OrElse _
                    VideoType.StartsWith("36") OrElse VideoType.StartsWith("17") OrElse _
                    VideoType.StartsWith("13") Then

                    'Get video file size

                    WebRequest = CType(HttpWebRequest.Create(InfoElements(Increment)), HttpWebRequest)
                    WebRequest.Timeout = _ConnectionTimeout
                    WebResponse = WebRequest.GetResponse()

                    VideoSize = WebResponse.ContentLength
                    WebRequest.Abort()

                    Dim ItemLink As New ListViewItem

                    'Add video download link
                    ItemLink.Text = InfoElements(Increment).Trim

                    'Add video type and quality

                    If VideoType.StartsWith("38") = True Then
                        ItemLink.SubItems.Add("High")
                        ItemLink.SubItems.Add("MP4")
                    ElseIf VideoType.StartsWith("46") = True Then
                        ItemLink.SubItems.Add("High")
                        ItemLink.SubItems.Add("WEBM")
                    ElseIf VideoType.StartsWith("37") = True Then
                        ItemLink.SubItems.Add("High")
                        ItemLink.SubItems.Add("MP4")
                    ElseIf VideoType.StartsWith("45") = True Then
                        ItemLink.SubItems.Add("High")
                        ItemLink.SubItems.Add("WEBM")
                    ElseIf VideoType.StartsWith("22") = True Then
                        ItemLink.SubItems.Add("High")
                        ItemLink.SubItems.Add("MP4")
                    ElseIf VideoType.StartsWith("44") = True Then
                        ItemLink.SubItems.Add("Medium")
                        ItemLink.SubItems.Add("WEBM")
                    ElseIf VideoType.StartsWith("35") = True Then
                        ItemLink.SubItems.Add("Medium")
                        ItemLink.SubItems.Add("FLV")
                    ElseIf VideoType.StartsWith("35") = True Then
                        ItemLink.SubItems.Add("Medium")
                        ItemLink.SubItems.Add("FLV")
                    ElseIf VideoType.StartsWith("43") = True Then
                        ItemLink.SubItems.Add("Medium")
                        ItemLink.SubItems.Add("WEBM")
                    ElseIf VideoType.StartsWith("34") = True Then
                        ItemLink.SubItems.Add("Medium")
                        ItemLink.SubItems.Add("FLV")
                    ElseIf VideoType.StartsWith("18") = True Then
                        ItemLink.SubItems.Add("Medium")
                        ItemLink.SubItems.Add("MP4")
                    ElseIf VideoType.StartsWith("6") = True Then
                        ItemLink.SubItems.Add("Low")
                        ItemLink.SubItems.Add("FLV")
                    ElseIf VideoType.StartsWith("5") = True Then
                        ItemLink.SubItems.Add("Low")
                        ItemLink.SubItems.Add("FLV")
                    ElseIf VideoType.StartsWith("36") = True Then
                        ItemLink.SubItems.Add("Low")
                        ItemLink.SubItems.Add("3GP")
                    ElseIf VideoType.StartsWith("17") = True Then
                        ItemLink.SubItems.Add("Low")
                        ItemLink.SubItems.Add("3GP")
                    ElseIf VideoType.StartsWith("13") = True Then
                        ItemLink.SubItems.Add("Low")
                        ItemLink.SubItems.Add("3GP")
                    End If

                    'Add video file size
                    ItemLink.SubItems.Add(CStr(Math.Round((VideoSize / 1000 / 1000), 2)) & " MB")

                    LstLinks.Items.Add(ItemLink)

                End If

            Catch ex As Exception
            End Try

            Increment += 2

        Next

    End Sub

#End Region

End Class