#Region "References"

Imports System.IO
Imports System.Xml
Imports System.Drawing
Imports System.Drawing.Drawing2D

#End Region

Module Common

#Region "Declaration"

    Friend _IsPlayerAutoStart As Boolean

    Friend _VideoThumbnail As New PictureBox
    Friend _VideoWebsiteURL, _VideoName, _VideoID, _VideoTitle, _VideoDuration, _VideoDescription, _VideoURL As String

    Friend ReadOnly _RootDir As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Smart PC Soft\MyTube"
    Friend ReadOnly _ReportsDir As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Smart PC Soft\MyTube\Reports"
    Friend ReadOnly _BookmarksDir As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Smart PC Soft\MyTube\Bookmarks"
    Friend ReadOnly _ThumbnailsDir As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Smart PC Soft\MyTube\Bookmarks\Thumbnails"

    Friend ReadOnly _BookmarksFile As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Smart PC Soft\MyTube\Bookmarks\Bookmarks.xml"

#End Region

#Region "Functions"

    Friend Function DownloadVideo() As Boolean

        'Check Temp Downloads Folder

        If Directory.Exists(_TempFolder) = False Then Directory.CreateDirectory(_TempFolder)

        Dim VideoFolder As String = _TempFolder & "\" & _VideoName

        'Check Video Download Folder

        If Directory.Exists(VideoFolder) = False Then

            'Create Video Download Folder
            Directory.CreateDirectory(VideoFolder)

        ElseIf Directory.Exists(VideoFolder) = True AndAlso File.Exists(VideoFolder & "\Info.xml") = True Then

            'Video download already exists

            If MessageBox.Show("The selected video download is already exists." & vbCrLf & "Do you want to overwrite the existing download?", My.Application.Info.Description, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, 0, False) = DialogResult.Yes Then

                Delete_Folder(VideoFolder)
                Directory.CreateDirectory(VideoFolder)

            Else

                Return False

            End If

        ElseIf Directory.Exists(VideoFolder) = True Then

            'Video download folder exists

            Delete_Folder(VideoFolder)
            Directory.CreateDirectory(VideoFolder)

        End If

        'Generate random download ID

        Dim RandomNum As New Random
        Dim RandomID As String = CStr(RandomNum.Next(100, 100000))

        'Create Download Info XML File

        Dim XMLDownloadInfo_Writer As New XmlTextWriter(VideoFolder & "\Info.xml", System.Text.Encoding.UTF8)

        XMLDownloadInfo_Writer.WriteStartDocument(True)
        XMLDownloadInfo_Writer.Formatting = Formatting.Indented
        XMLDownloadInfo_Writer.Indentation = 2

        XMLDownloadInfo_Writer.WriteStartElement("Downloads")
        XMLDownloadInfo_Writer.WriteStartElement("DownloadItem")
        XMLDownloadInfo_Writer.WriteAttributeString("id", RandomID)

        'Insert Video Title

        XMLDownloadInfo_Writer.WriteStartElement("Title")
        XMLDownloadInfo_Writer.WriteString(_VideoTitle)
        XMLDownloadInfo_Writer.WriteEndElement()

        'Insert Video Description

        XMLDownloadInfo_Writer.WriteStartElement("Description")
        XMLDownloadInfo_Writer.WriteString(_VideoDescription)
        XMLDownloadInfo_Writer.WriteEndElement()

        'Insert Video Size

        XMLDownloadInfo_Writer.WriteStartElement("Size")
        XMLDownloadInfo_Writer.WriteString("")
        XMLDownloadInfo_Writer.WriteEndElement()

        'Insert Video Duration

        XMLDownloadInfo_Writer.WriteStartElement("Duration")
        XMLDownloadInfo_Writer.WriteString(_VideoDuration)
        XMLDownloadInfo_Writer.WriteEndElement()

        'Insert Download Status

        XMLDownloadInfo_Writer.WriteStartElement("Status")
        XMLDownloadInfo_Writer.WriteString("")
        XMLDownloadInfo_Writer.WriteEndElement()

        'Insert Download Progress

        XMLDownloadInfo_Writer.WriteStartElement("Progress")
        XMLDownloadInfo_Writer.WriteString("0%")
        XMLDownloadInfo_Writer.WriteEndElement()

        'Insert Download Date

        XMLDownloadInfo_Writer.WriteStartElement("DateAdded")
        XMLDownloadInfo_Writer.WriteString(Now.ToShortDateString & " " & Now.ToShortTimeString)
        XMLDownloadInfo_Writer.WriteEndElement()

        'Insert Download Last Try Date

        XMLDownloadInfo_Writer.WriteStartElement("LastTryDate")
        XMLDownloadInfo_Writer.WriteString("")
        XMLDownloadInfo_Writer.WriteEndElement()

        'Insert Video Download URL

        XMLDownloadInfo_Writer.WriteStartElement("DownloadURL")
        XMLDownloadInfo_Writer.WriteString(_VideoURL)
        XMLDownloadInfo_Writer.WriteEndElement()

        'Insert Video Website URL

        XMLDownloadInfo_Writer.WriteStartElement("WebsiteURL")
        XMLDownloadInfo_Writer.WriteString(_VideoWebsiteURL)
        XMLDownloadInfo_Writer.WriteEndElement()

        'Insert Download Save Location

        XMLDownloadInfo_Writer.WriteStartElement("SaveTo")
        XMLDownloadInfo_Writer.WriteString(_DownloadsFolder)
        XMLDownloadInfo_Writer.WriteEndElement()

        'Insert Download File Name

        XMLDownloadInfo_Writer.WriteStartElement("FileName")
        XMLDownloadInfo_Writer.WriteString(_VideoName)
        XMLDownloadInfo_Writer.WriteEndElement()

        XMLDownloadInfo_Writer.WriteEndElement()
        XMLDownloadInfo_Writer.WriteEndElement()

        XMLDownloadInfo_Writer.WriteEndDocument()
        XMLDownloadInfo_Writer.Close()

        Return True

    End Function

    Friend Sub BookmarkVideo()

        'Check bookmarks directory

        If Directory.Exists(_BookmarksDir) = False Then Directory.CreateDirectory(_BookmarksDir)

        'Generate random bookmark ID

        Dim RandomNum As New Random
        Dim RandomID As String = CStr(RandomNum.Next(100, 100000))

        If File.Exists(_BookmarksFile) = False Then

            Dim XMLBookmarks_Writer As New XmlTextWriter(_BookmarksFile, System.Text.Encoding.UTF8)

            XMLBookmarks_Writer.WriteStartDocument(True)
            XMLBookmarks_Writer.Formatting = Formatting.Indented
            XMLBookmarks_Writer.Indentation = 2

            XMLBookmarks_Writer.WriteStartElement("Bookmarks")
            XMLBookmarks_Writer.WriteStartElement("VideoItem")
            XMLBookmarks_Writer.WriteAttributeString("id", RandomID)

            'Insert video title

            XMLBookmarks_Writer.WriteStartElement("Title")
            XMLBookmarks_Writer.WriteString(_VideoTitle)
            XMLBookmarks_Writer.WriteEndElement()

            'Insert video URL

            XMLBookmarks_Writer.WriteStartElement("WebsiteURL")
            XMLBookmarks_Writer.WriteString(_VideoWebsiteURL)
            XMLBookmarks_Writer.WriteEndElement()

            'Insert video description

            XMLBookmarks_Writer.WriteStartElement("Description")
            XMLBookmarks_Writer.WriteString(_VideoDescription)
            XMLBookmarks_Writer.WriteEndElement()

            'Insert video duration

            XMLBookmarks_Writer.WriteStartElement("Duration")
            XMLBookmarks_Writer.WriteString(_VideoDuration)
            XMLBookmarks_Writer.WriteEndElement()

            'Insert video thumbnail

            XMLBookmarks_Writer.WriteStartElement("Thumbnail")

            If Not _VideoThumbnail.Image Is Nothing Then

                If Directory.Exists(_ThumbnailsDir) = False Then Directory.CreateDirectory(_ThumbnailsDir)

                Dim ThumbnailName As String = ("Thumbnail_" & RandomID & ".png")

                'Resize and save video thumbnail to disk

                Dim ResizedImage As Image = ResizeImage(_VideoThumbnail.Image, 145, 128)
                ResizedImage.Save(_ThumbnailsDir & "\" & ThumbnailName, Drawing.Imaging.ImageFormat.Png)

                XMLBookmarks_Writer.WriteString(ThumbnailName)

            Else

                XMLBookmarks_Writer.WriteString("")

            End If

            XMLBookmarks_Writer.WriteEndElement()

            'Insert bookmark date

            XMLBookmarks_Writer.WriteStartElement("Date")
            XMLBookmarks_Writer.WriteString(Now.ToShortDateString & " " & Now.ToShortTimeString)
            XMLBookmarks_Writer.WriteEndElement()

            'End and save Bookmarks.xml

            XMLBookmarks_Writer.WriteEndElement()
            XMLBookmarks_Writer.WriteEndElement()

            XMLBookmarks_Writer.WriteEndDocument()
            XMLBookmarks_Writer.Close()

        Else

            Dim BookmarksDoc As New XmlDocument

            Try

                BookmarksDoc.Load(_BookmarksFile)

            Catch ex As Exception

                If MessageBox.Show("Error bookmarking video, the bookmarks file is corrupted." & vbCrLf & vbCrLf & "Do you want to remove the corrupted bookmarks file?", My.Application.Info.Description, MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, False) = DialogResult.Yes Then
                    File.SetAttributes(_BookmarksFile, FileAttributes.Normal)
                    File.Delete(_BookmarksFile)
                End If

                Exit Sub

            End Try

            Dim NodeVideo As XmlNode
            NodeVideo = BookmarksDoc.CreateElement("VideoItem")

            'Insert video ID

            Dim Attr As XmlAttribute
            Attr = BookmarksDoc.CreateAttribute("id")
            Attr.Value = RandomID
            NodeVideo.Attributes.Append(Attr)

            'Insert video title

            Dim NodeTitle As XmlNode = BookmarksDoc.CreateElement("Title")
            NodeVideo.AppendChild(NodeTitle)
            NodeTitle.AppendChild(BookmarksDoc.CreateTextNode(_VideoTitle))

            'Insert video URL

            Dim NodeWebsiteURL As XmlNode = BookmarksDoc.CreateElement("WebsiteURL")
            NodeVideo.AppendChild(NodeWebsiteURL)
            NodeWebsiteURL.AppendChild(BookmarksDoc.CreateTextNode(_VideoWebsiteURL))

            'Insert video description

            Dim NodeDescription As XmlNode = BookmarksDoc.CreateElement("Description")
            NodeVideo.AppendChild(NodeDescription)
            NodeDescription.AppendChild(BookmarksDoc.CreateTextNode(_VideoDescription))

            'Insert video duration

            Dim NodeDuration As XmlNode = BookmarksDoc.CreateElement("Duration")
            NodeVideo.AppendChild(NodeDuration)
            NodeDuration.AppendChild(BookmarksDoc.CreateTextNode(_VideoDuration))

            'Insert video thumbnail

            Dim NodeThumbnail As XmlNode = BookmarksDoc.CreateElement("Thumbnail")
            NodeVideo.AppendChild(NodeThumbnail)

            If Not _VideoThumbnail.Image Is Nothing Then

                If Directory.Exists(_ThumbnailsDir) = False Then Directory.CreateDirectory(_ThumbnailsDir)

                Dim ThumbnailName As String = ("Thumbnail_" & RandomID & ".png")

                'Resize and save video thumbnail to disk

                Dim ResizedImage As Image = ResizeImage(_VideoThumbnail.Image, 145, 128)
                ResizedImage.Save(_ThumbnailsDir & "\" & ThumbnailName, Drawing.Imaging.ImageFormat.Png)

                NodeThumbnail.AppendChild(BookmarksDoc.CreateTextNode(ThumbnailName))

            Else

                NodeThumbnail.AppendChild(BookmarksDoc.CreateTextNode(""))

            End If

            'Insert bookmark date

            Dim NodeDate As XmlNode = BookmarksDoc.CreateElement("Date")
            NodeVideo.AppendChild(NodeDate)
            NodeDate.AppendChild(BookmarksDoc.CreateTextNode(Now.ToShortDateString & " " & Now.ToShortTimeString))

            'Save new bookmark

            BookmarksDoc.DocumentElement.AppendChild(NodeVideo)
            If File.GetAttributes(_BookmarksFile) <> FileAttributes.Normal Then File.SetAttributes(_BookmarksFile, FileAttributes.Normal)
            BookmarksDoc.Save(_BookmarksFile)

        End If

    End Sub

    Friend Function Delete_Folder(ByVal FolderPath As String) As Integer

        'Remove files attributes and delete all folder contents

        Try

            Dim FolderInfo As New DirectoryInfo(FolderPath)
            Dim FolderFiles As FileInfo() = FolderInfo.GetFiles("*", SearchOption.AllDirectories)

            For I As Integer = 0 To FolderFiles.Length - 1

                FolderFiles(I).Attributes = FileAttributes.Normal
                FolderFiles(I).Delete()

            Next

            FolderInfo.Attributes = FileAttributes.Normal
            Directory.Delete(FolderPath, True)

            Return 1

        Catch ex As Exception
            Return 0
        End Try

    End Function

    Private Function ResizeImage(ByVal SourceImage As Image, ByVal NewWidth As Integer, ByVal NewHeight As Integer) As Image

        Dim NewImage As Image = New Bitmap(NewWidth, NewHeight)

        Using GraphicsHandle As Graphics = Graphics.FromImage(NewImage)
            GraphicsHandle.InterpolationMode = InterpolationMode.HighQualityBicubic
            GraphicsHandle.DrawImage(SourceImage, 0, 0, NewWidth, NewHeight)
        End Using

        Return NewImage

    End Function

#End Region

#Region "Application Settings"

    Friend _IsAutoHide As Boolean
    Friend _CatchVideos As Boolean
    Friend _TempFolder, _DownloadsFolder As String

    Friend _FastReverse As Integer = 10
    Friend _FastForward As Integer = 10

    Friend _MediaCache As Double
    Friend _ConnectionTimeout As Integer
    Friend _IsMediaCacheDynamic As Boolean

    Friend _IsCompletedEvent, _IsFailedEvent As Boolean
    Friend _IsDisableStandby, _IsBatteryStandby As Boolean
    Friend _CompletedEvent_Path, _FailedEvent_Path As String

    Friend Sub Get_AppSettings()

        'General Settings

        If CInt(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "AutoHide", 0)) = 1 Then
            _IsAutoHide = True
        Else
            _IsAutoHide = False
        End If

        If CInt(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "CatchVideos", 1)) = 1 Then
            _CatchVideos = True
        Else
            _CatchVideos = False
        End If

        'Downloads Settings

        Dim TempDir_Str As String = CStr(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "TempDir", ""))

        If Directory.Exists(TempDir_Str) = True Then
            _TempFolder = TempDir_Str
        Else
            _TempFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Smart PC Soft\MyTube\Downloads"
        End If

        Dim DownloadsDir_Str As String = CStr(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "DownloadsDir", ""))

        If Directory.Exists(DownloadsDir_Str) = True Then
            _DownloadsFolder = DownloadsDir_Str
        Else
            _DownloadsFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\Downloads\MyTube"
        End If

        If CInt(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "CompletedEvent", 0)) = 1 Then
            _IsCompletedEvent = True
        Else
            _IsCompletedEvent = False
        End If

        Dim CompletedEvent_Path As String = CStr(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "CompletedEventPath", ""))

        If File.Exists(CompletedEvent_Path) = True Then
            _CompletedEvent_Path = CompletedEvent_Path
        Else
            _CompletedEvent_Path = ""
            _IsCompletedEvent = False
        End If

        If CInt(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "FailedEvent", 0)) = 1 Then
            _IsFailedEvent = True
        Else
            _IsFailedEvent = False
        End If

        Dim FailedEvent_Path As String = CStr(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "FailedEventPath", ""))

        If File.Exists(FailedEvent_Path) = True Then
            _FailedEvent_Path = FailedEvent_Path
        Else
            _FailedEvent_Path = ""
            _IsFailedEvent = False
        End If

        Dim ConnectionTimout As Integer = CInt(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "ConnectionTimeout", 60000))

        If ConnectionTimout < 30000 OrElse ConnectionTimout > 180000 Then
            _ConnectionTimeout = 60000
        Else
            _ConnectionTimeout = ConnectionTimout
        End If

        'Advanced Settings

        If CInt(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "DynamicCache", 1)) = 1 Then

            _IsMediaCacheDynamic = True

        Else

            _IsMediaCacheDynamic = False

            Dim MediaCache As Integer = CInt(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "MediaCache", 1))

            If MediaCache < 1 OrElse MediaCache > 20 Then
                _MediaCache = 1 * 1024 * 1024
            Else
                _MediaCache = MediaCache * 1024 * 1024
            End If

        End If

        If CInt(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "DisableStandby", 1)) = 1 Then
            _IsDisableStandby = True
        Else
            _IsDisableStandby = False
        End If

        If CInt(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "BatteryStandby", 1)) = 1 Then
            _IsBatteryStandby = True
        Else
            _IsBatteryStandby = False
        End If

    End Sub

#End Region

End Module