#Region "References"

Imports System.IO
Imports System.Xml

#End Region

Public Class FrmBookmarks

#Region "Declarations"

    Dim NewWidth As Integer
    Dim OldWidth As Integer = 724
    Dim CustomColor As Color = Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))

#End Region

#Region "General"

    Private Sub FrmBookmarks_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

        'Load saved bookmarks from Bookmarks.xml
        Get_Bookmarks()

        'Get bookmarks view setting

        If CInt(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "BookmarksView", 1)) = 1 Then
            ItmViewIcons.PerformClick()
        ElseIf CInt(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "BookmarksView", 1)) = 2 Then
            ItmViewDetails.PerformClick()
        ElseIf CInt(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "BookmarksView", 1)) = 3 Then
            ItmViewTiles.PerformClick()
        End If

    End Sub

    Private Sub FrmBookmarks_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Resize LstBookmarks columns and Tile view size

        NewWidth = Me.Width

        If NewWidth <> OldWidth Then

            If NewWidth > OldWidth Then

                Try
                    LstBookmarks.TileSize = New Size(LstBookmarks.TileSize.Width + (NewWidth - OldWidth), LstBookmarks.TileSize.Height)
                    ColTitle.Width += CInt((NewWidth - OldWidth) / 2)
                    ColDescription.Width += CInt((NewWidth - OldWidth) / 2)
                Catch ex As Exception
                End Try

            Else

                Try
                    LstBookmarks.TileSize = New Size(LstBookmarks.TileSize.Width - (OldWidth - NewWidth), LstBookmarks.TileSize.Height)
                    ColTitle.Width -= CInt((OldWidth - NewWidth) / 2)
                    ColDescription.Width -= CInt((OldWidth - NewWidth) / 2)
                Catch ex As Exception
                End Try

            End If

            OldWidth = NewWidth

        End If

    End Sub

    Private Sub BtnNewBookmark_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnNewBookmark.Click

        FrmNewVideo.ActionType = 2
        If FrmNewVideo.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then Get_Bookmarks()

    End Sub

    Private Sub LstBookmarks_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LstBookmarks.SelectedIndexChanged

        Dim SelectedItemsNum As Integer

        For I As Integer = 0 To LstBookmarks.SelectedItems.Count - 1
            SelectedItemsNum += 1
        Next

        If SelectedItemsNum > 1 Then

            For Each Item As ToolStripItem In MnuBookmark.Items
                Item.Enabled = False
            Next

            ItmDelete.Enabled = True
            ItmRefresh.Enabled = True

        ElseIf SelectedItemsNum = 1 Then

            For Each Item As ToolStripItem In MnuBookmark.Items
                Item.Enabled = True
            Next

        End If

    End Sub

    Private Sub LstBookmarks_ItemActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles LstBookmarks.ItemActivate

        Try
            Process.Start(LstBookmarks.FocusedItem.SubItems(3).Text.Trim)
        Catch ex As Exception
        End Try

    End Sub

#End Region

#Region "Tasks"

    Private Sub ItmWatch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItmWatch.Click

        _VideoWebsiteURL = LstBookmarks.FocusedItem.SubItems(3).Text.Trim
        _VideoID = _VideoWebsiteURL.Replace("http://www.youtube.com/watch?v=", "").Trim

        FrmVideoInfo.ActionType = 1
        FrmVideoInfo.ShowDialog(FrmMain)

    End Sub

    Private Sub ItmDownload_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItmDownload.Click

        _VideoWebsiteURL = LstBookmarks.FocusedItem.SubItems(3).Text.Trim
        _VideoID = _VideoWebsiteURL.Replace("http://www.youtube.com/watch?v=", "").Trim

        FrmVideoInfo.ActionType = 2
        FrmVideoInfo.ShowDialog(FrmMain)

    End Sub

    Private Sub ItmOpen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItmOpen.Click

        Try
            Process.Start(LstBookmarks.FocusedItem.SubItems(3).Text.Trim)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub ItmCopyURL_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItmCopyURL.Click

        Try
            Clipboard.SetText(LstBookmarks.FocusedItem.SubItems(3).Text.Trim)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub ItmCopyDescription_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItmCopyDescription.Click

        Try
            Clipboard.SetText(LstBookmarks.FocusedItem.SubItems(1).Text.Trim)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub ItmDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItmDelete.Click

        Try

            'Load Bookmarks.xml in XML Document

            Dim BookmarksDoc As New XmlDocument
            BookmarksDoc.Load(_BookmarksFile)

            For I As Integer = 0 To LstBookmarks.SelectedItems.Count - 1

                'Get selected bookmark ID

                Dim ItemTag As String = LstBookmarks.Items.Item(LstBookmarks.SelectedItems(I).Index).Tag.ToString

                'Delete bookmark node from Bookmarks.xml

                For Each VideoNode As XmlNode In BookmarksDoc.DocumentElement

                    If VideoNode.Attributes.ItemOf("id").Value = ItemTag Then
                        BookmarksDoc.DocumentElement.RemoveChild(VideoNode)
                    End If

                Next

            Next

            'Save Bookmarks

            BookmarksDoc.Save(_BookmarksFile)
            Get_Bookmarks()

        Catch ex As Exception

            MessageBox.Show("Error deleting the selected bookmark(s).", My.Application.Info.Description, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, False)
            Get_Bookmarks()

        End Try

    End Sub

    Private Sub ItmRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItmRefresh.Click

        If ItmViewDetails.Checked = True Then
            LstBookmarks.Visible = False
            LstBookmarks.View = View.Tile
        End If

        Get_Bookmarks()

        If ItmViewDetails.Checked = True Then
            LstBookmarks.View = View.Details
            LstBookmarks.Visible = True
        End If

    End Sub

#End Region

#Region "Views"

    Private Sub ItmViewIcons_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItmViewIcons.Click

        If ItmViewIcons.Checked = False Then

            LstBookmarks.View = View.LargeIcon
            ItmViewIcons.Checked = True
            ItmViewDetails.Checked = False
            ItmViewTiles.Checked = False
            LstBookmarks.FullRowSelect = False
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "BookmarksView", 1, Microsoft.Win32.RegistryValueKind.DWord)

        End If

    End Sub

    Private Sub ItmViewDetails_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItmViewDetails.Click

        If ItmViewDetails.Checked = False Then

            LstBookmarks.View = View.Details
            ItmViewIcons.Checked = False
            ItmViewDetails.Checked = True
            ItmViewTiles.Checked = False
            LstBookmarks.FullRowSelect = True
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "BookmarksView", 2, Microsoft.Win32.RegistryValueKind.DWord)

        End If

    End Sub

    Private Sub ItmViewTiles_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItmViewTiles.Click

        If ItmViewTiles.Checked = False Then

            LstBookmarks.View = View.Tile
            ItmViewIcons.Checked = False
            ItmViewDetails.Checked = False
            ItmViewTiles.Checked = True
            LstBookmarks.FullRowSelect = False
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "BookmarksView", 3, Microsoft.Win32.RegistryValueKind.DWord)

        End If

    End Sub

#End Region

#Region "Sorting"

    Private Sub ItmSortTitle_Click(sender As Object, e As System.EventArgs) Handles ItmSortTitle.Click

        Dim SortOrder As System.Windows.Forms.SortOrder

        If ItmSortDesc.Checked = True Then
            SortOrder = SortOrder.Descending
        Else
            SortOrder = SortOrder.Ascending
        End If

        LstBookmarks.ListViewItemSorter = New ListViewSort(0, SortOrder)
        LstBookmarks.Sort()

        ItmSortTitle.Checked = True
        ItmSortDescription.Checked = False
        ItmSortDuration.Checked = False
        ItmSortDate.Checked = False

    End Sub

    Private Sub ItmSortDescription_Click(sender As Object, e As System.EventArgs) Handles ItmSortDescription.Click

        Dim SortOrder As System.Windows.Forms.SortOrder

        If ItmSortDesc.Checked = True Then
            SortOrder = SortOrder.Descending
        Else
            SortOrder = SortOrder.Ascending
        End If

        LstBookmarks.ListViewItemSorter = New ListViewSort(1, SortOrder)
        LstBookmarks.Sort()

        ItmSortTitle.Checked = False
        ItmSortDescription.Checked = True
        ItmSortDuration.Checked = False
        ItmSortDate.Checked = False

    End Sub

    Private Sub ItmSortDuration_Click(sender As Object, e As System.EventArgs) Handles ItmSortDuration.Click

        Dim SortOrder As System.Windows.Forms.SortOrder

        If ItmSortDesc.Checked = True Then
            SortOrder = SortOrder.Descending
        Else
            SortOrder = SortOrder.Ascending
        End If

        LstBookmarks.ListViewItemSorter = New ListViewSort(2, SortOrder)
        LstBookmarks.Sort()

        ItmSortTitle.Checked = False
        ItmSortDescription.Checked = False
        ItmSortDuration.Checked = True
        ItmSortDate.Checked = False

    End Sub

    Private Sub ItmSortDate_Click(sender As Object, e As System.EventArgs) Handles ItmSortDate.Click

        Dim SortOrder As System.Windows.Forms.SortOrder

        If ItmSortDesc.Checked = True Then
            SortOrder = SortOrder.Descending
        Else
            SortOrder = SortOrder.Ascending
        End If

        LstBookmarks.ListViewItemSorter = New ListViewSort(4, SortOrder)
        LstBookmarks.Sort()

        ItmSortTitle.Checked = False
        ItmSortDescription.Checked = False
        ItmSortDuration.Checked = False
        ItmSortDate.Checked = True

    End Sub

    Private Sub ItmSortAsc_Click(sender As Object, e As System.EventArgs) Handles ItmSortAsc.Click

        If ItmSortAsc.Checked = False Then

            ItmSortAsc.Checked = True
            ItmSortDesc.Checked = False

            If ItmSortTitle.Checked = True Then
                ItmSortTitle.PerformClick()
            ElseIf ItmSortDescription.Checked = True Then
                ItmSortDescription.PerformClick()
            ElseIf ItmSortDuration.Checked = True Then
                ItmSortDuration.PerformClick()
            ElseIf ItmSortDate.Checked = True Then
                ItmSortDate.PerformClick()
            End If

        End If

    End Sub

    Private Sub ItmSortDesc_Click(sender As Object, e As System.EventArgs) Handles ItmSortDesc.Click

        If ItmSortDesc.Checked = False Then

            ItmSortAsc.Checked = False
            ItmSortDesc.Checked = True

            If ItmSortTitle.Checked = True Then
                ItmSortTitle.PerformClick()
            ElseIf ItmSortDescription.Checked = True Then
                ItmSortDescription.PerformClick()
            ElseIf ItmSortDuration.Checked = True Then
                ItmSortDuration.PerformClick()
            ElseIf ItmSortDate.Checked = True Then
                ItmSortDate.PerformClick()
            End If

        End If

    End Sub

    Private Sub LstBookmarks_ColumnClick(sender As Object, e As System.Windows.Forms.ColumnClickEventArgs) Handles LstBookmarks.ColumnClick

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

        ElseIf e.Column = 2 Then 'Sort by Duration Column

            If ItmSortDuration.Checked = False Then

                ItmSortDuration.PerformClick()

            Else

                If ItmSortAsc.Checked = False Then
                    ItmSortAsc.PerformClick()
                Else
                    ItmSortDesc.PerformClick()
                End If

            End If

        ElseIf e.Column = 4 Then 'Sort by Date Column

            If ItmSortDate.Checked = False Then

                ItmSortDate.PerformClick()

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

#Region "Functions"

    Private Sub Get_Bookmarks()

        If File.Exists(_BookmarksFile) = True Then

            'Clear bookmarks items and thumbnails

            LstBookmarks.BeginUpdate()
            LstBookmarks.Items.Clear()

            If ImgLst.Images.Count > 1 Then

                For Each ImgKey As String In ImgLst.Images.Keys
                    If ImgKey <> "nopreview" Then ImgLst.Images.RemoveByKey(ImgKey)
                Next

            End If

            Try

                Dim Video_Title, Video_Description, Video_Duration, Video_Website, Video_Thumbnail, Video_Date As New String(" "c, 0)

                'Load Bookmarks.xml in XMLDocument

                Dim BookmarksDoc As New XmlDocument
                BookmarksDoc.Load(_BookmarksFile)

                For Each VideoNode As XmlNode In BookmarksDoc.DocumentElement

                    Try

                        'Load video bookmark information

                        For I As Integer = 0 To VideoNode.ChildNodes.Count - 1

                            If VideoNode.ChildNodes(I).Name = "Title" Then Video_Title = VideoNode.ChildNodes(I).InnerText.Trim
                            If VideoNode.ChildNodes(I).Name = "WebsiteURL" Then Video_Website = VideoNode.ChildNodes(I).InnerText.Trim
                            If VideoNode.ChildNodes(I).Name = "Description" Then Video_Description = VideoNode.ChildNodes(I).InnerText.Trim
                            If VideoNode.ChildNodes(I).Name = "Duration" Then Video_Duration = VideoNode.ChildNodes(I).InnerText.Trim
                            If VideoNode.ChildNodes(I).Name = "Thumbnail" Then Video_Thumbnail = VideoNode.ChildNodes(I).InnerText.Trim
                            If VideoNode.ChildNodes(I).Name = "Date" Then Video_Date = VideoNode.ChildNodes(I).InnerText.Trim

                        Next

                        'Validate each video bookmark

                        If String.IsNullOrWhiteSpace(Video_Title) = False AndAlso Video_Website.ToLower.StartsWith("https://") = True AndAlso String.IsNullOrWhiteSpace(VideoNode.Attributes.ItemOf("id").Value) = False Then

                            Dim BookmarkItem As New ListViewItem
                            BookmarkItem.UseItemStyleForSubItems = False
                            BookmarkItem.Tag = VideoNode.Attributes.ItemOf("id").Value

                            'Add Video title item
                            BookmarkItem.Text = "  " & Video_Title

                            'Add video description item

                            If String.IsNullOrWhiteSpace(Video_Description) = False Then
                                BookmarkItem.SubItems.Add("  " & Video_Description)
                                BookmarkItem.SubItems.Item(1).Font = New Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular)
                                BookmarkItem.SubItems.Item(1).ForeColor = CustomColor
                            Else
                                BookmarkItem.SubItems.Add("  Not Available")
                                BookmarkItem.SubItems.Item(1).Font = New Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
                                BookmarkItem.SubItems.Item(1).ForeColor = Color.DimGray
                            End If

                            'Add video duration item

                            If String.IsNullOrWhiteSpace(Video_Duration) = False Then
                                BookmarkItem.SubItems.Add("  " & Video_Duration & " seconds")
                                BookmarkItem.SubItems.Item(2).Font = New Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular)
                                BookmarkItem.SubItems.Item(2).ForeColor = CustomColor
                            Else
                                BookmarkItem.SubItems.Add("  Not Available")
                                BookmarkItem.SubItems.Item(2).Font = New Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
                                BookmarkItem.SubItems.Item(2).ForeColor = Color.DimGray
                            End If

                            'Add video Website item

                            BookmarkItem.SubItems.Add("  " & Video_Website)
                            BookmarkItem.SubItems.Item(3).Font = New Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular)
                            BookmarkItem.SubItems.Item(3).ForeColor = CustomColor

                            'Add video date item

                            If String.IsNullOrWhiteSpace(Video_Date) = False Then
                                BookmarkItem.SubItems.Add("  " & Video_Date)
                                BookmarkItem.SubItems.Item(4).Font = New Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular)
                                BookmarkItem.SubItems.Item(4).ForeColor = CustomColor
                            Else
                                BookmarkItem.SubItems.Add("  Not Available")
                                BookmarkItem.SubItems.Item(4).Font = New Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
                                BookmarkItem.SubItems.Item(4).ForeColor = Color.DimGray
                            End If

                            'Add video thumbnail

                            If File.Exists(_ThumbnailsDir & "\" & Video_Thumbnail) = True Then

                                Dim ThumbnailImage As Image = New Bitmap(_ThumbnailsDir & "\" & Video_Thumbnail)
                                ImgLst.Images.Add(BookmarkItem.Tag.ToString, ThumbnailImage)
                                BookmarkItem.ImageKey = BookmarkItem.Tag.ToString

                            Else

                                BookmarkItem.ImageKey = "nopreview"

                            End If

                            LstBookmarks.Items.Add(BookmarkItem)

                        End If

                    Catch ex As Exception
                    End Try

                Next

                LstBookmarks.EndUpdate()

            Catch ex As Exception

                If MessageBox.Show("Error loading Video Bookmarks, the bookmarks file is corrupted." & vbCrLf & vbCrLf & "Do you want to remove the corrupted bookmarks file?", My.Application.Info.Description, MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, False) = DialogResult.Yes Then
                    File.SetAttributes(_BookmarksFile, FileAttributes.Normal)
                    File.Delete(_BookmarksFile)
                End If

            End Try

        End If

        'Check Lstbookmarks items

        If LstBookmarks.Items.Count > 0 Then

            For Each Item As ToolStripItem In MnuBookmark.Items
                Item.Enabled = True
            Next

        Else

            For Each Item As ToolStripItem In MnuBookmark.Items
                Item.Enabled = False
            Next

            ItmRefresh.Enabled = True

        End If

    End Sub

#End Region

End Class