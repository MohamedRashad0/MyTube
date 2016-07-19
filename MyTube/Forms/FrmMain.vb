#Region "References"

Imports System.IO
Imports System.Net
Imports NDde.Client
Imports System.Threading.Tasks

#End Region

Public Class FrmMain

#Region "Declarations"
    Dim ChildWidth, ChildHeight As Integer
    Dim UpdatesCheck_Thread As New Threading.Thread(AddressOf UpdatesCheck)
    Friend browserIE As String = "Windows Internet Explorer"
    Friend browserchrome As String = "Google Chrome"
    Friend classNameIE As String = "Edit"
    Friend classNamechrome As String = "Chrome_WidgetWin_1"
    Friend lst As ComboBox
    Dim appNameIE As String = "iexplore"
    Dim appNamechrome As String = "chrome"
    Dim proc_IE As System.Diagnostics.Process = GetIE(appNameIE)
    Dim proc_chrome As System.Diagnostics.Process = GetIE(appNamechrome)
    Dim stitle, NewTitle As String
    Delegate Sub showform()
#End Region

#Region "General"

    Private Sub TmrCatch_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrCatch.Tick
        Try
            If BwCatch.IsBusy = False Then
                BwCatch.RunWorkerAsync()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BwCatch_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BwCatch.DoWork
        Try
            Dim sh As New showform(AddressOf shfrm)
            If proc_IE IsNot Nothing Then
                Dim s As String = GetCurrentUrl(proc_IE.MainWindowHandle, browserIE, classNameIE, lst)
                If s <> "" Then
                    If s.StartsWith("http") Or s.StartsWith("https") Or s.StartsWith("www") Then
                        If s.Contains("youtube.com") = True And s.Contains("v=") = True Then
                            NewTitle = s
                            Me.Invoke(sh)
                        End If
                    End If
                End If
            End If
            Dim fffUrl As String = GetFirefoxUrl()
            Dim ffUrl() As String
            ffUrl = Split(fffUrl, ",")
            ffUrl(0) = ffUrl(0).Replace("""", "")
            If ffUrl(0).StartsWith("http") Or ffUrl(0).StartsWith("https") Or ffUrl(0).StartsWith("www") Then
                If ffUrl(0).Contains("youtube.com") = True And ffUrl(0).Contains("v=") = True Then
                    NewTitle = ffUrl(0)
                    Me.Invoke(sh)
                End If
            End If
            If proc_chrome IsNot Nothing Then
                Dim s As String = GetCurrentUrl(proc_chrome.MainWindowHandle, browserchrome, classNamechrome, lst)
                If s.Contains("||") = True Then
                    Dim curl() As String = Split(s, "||")
                    s = curl(1)
                    s = s.Trim
                    If s <> "" Then
                        If s.StartsWith("http") Or s.StartsWith("https") Or s.StartsWith("www") Then
                            If s.Contains("youtube.com") = True And s.Contains("v=") = True Then
                                NewTitle = s
                                Me.Invoke(sh)
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Get MyTube general settings
        Get_AppSettings()

        'Set the maximum connections allowed when downloading videos
        ServicePointManager.DefaultConnectionLimit = 10

        If _CatchVideos = True Then
            TmrCatch.Enabled = True
        End If

        'Allow resize of child forms
        ChildWidth = Me.Width - PnlSearch.Width
        ChildHeight = Me.Height - PnlSearch.Height

        'Check for new updates for MyTube
        If CInt(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Smart PC Soft\MyTube", "AutoUpdate", 0)) = 1 AndAlso My.Computer.Network.IsAvailable = True Then
            UpdatesCheck_Thread.Start()
        End If

    End Sub

    Private Sub FrmMain_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Resize child forms

        For Each FrmChild As Form In Me.MdiChildren
            FrmChild.Size = New Size(Me.Width - ChildWidth, Me.Height - ChildHeight)
        Next

        BoxSide.Refresh()

    End Sub

    Private Sub FrmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If PnlSearch.Visible = True AndAlso e.KeyCode = Keys.Enter Then

            BtnSearchYoutube.PerformClick()
            e.Handled = True

        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then

            BtnSearch.PerformClick()
            e.Handled = True

        ElseIf e.Control AndAlso e.KeyCode = Keys.W Then

            BtnWatch.PerformClick()
            e.Handled = True

        ElseIf e.Control AndAlso e.KeyCode = Keys.D Then

            BtnDownload.PerformClick()
            e.Handled = True

        ElseIf e.Control AndAlso e.KeyCode = Keys.B Then

            BtnBookmark.PerformClick()
            e.Handled = True

        ElseIf e.Alt AndAlso e.KeyCode = Keys.F4 Then

            Me.Close()
            e.Handled = True

        End If

    End Sub

    Private Sub FrmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If _IsAutoHide = True Then

            e.Cancel = True
            Me.Hide()
            NIcon.Visible = True

        Else

            'Save current downloads
            FrmDownload.Save_RunningDownloads()

        End If

    End Sub

    Private Sub BtnSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSettings.Click

        FrmSettings.TabMain.SelectedIndex = 0
        FrmSettings.ShowDialog(Me)

    End Sub

    Private Sub NIcon_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NIcon.MouseDoubleClick
        ItmRestore.PerformClick()
    End Sub

    Private Sub ItmRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItmRestore.Click

        Me.Show()
        NIcon.Visible = False

    End Sub

    Private Sub ItmExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItmExit.Click

        _IsAutoHide = False
        Me.Close()

    End Sub

    Private Sub TmrFade_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrFade.Tick

        'FrmMain fading effect

        If Me.Opacity < 1 Then
            Me.Opacity += 0.2
        Else
            TmrFade.Enabled = False
        End If

    End Sub

#End Region

#Region "Help Menu"

    Private Sub ItmDoc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItmDoc.Click

        If File.Exists(Application.StartupPath & "\Help.chm") = True Then
            Help.ShowHelp(Me, (Application.StartupPath & "\Help.chm"), HelpNavigator.Topic, "Welcome.htm")
        Else
            MessageBox.Show("MyTube Help is missing or corrupted.", My.Application.Info.Description, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, False)
        End If

    End Sub

    Private Sub ItmSupport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItmSupport.Click

        Try
            Process.Start("http://smartpcsoft.com/support.html")
        Catch ex As Exception
        End Try

    End Sub

    Private Sub ItmUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItmUpdate.Click

        Try
            Process.Start("http://smartpcsoft.com/mytube.html")
        Catch ex As Exception
        End Try

    End Sub

    Private Sub ItmAbout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItmAbout.Click
        FrmAbout.ShowDialog(Me)
    End Sub

#End Region

#Region "Navigation"

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        If PnlSearch.Visible = False Then
            TxtSearch.Text = ""
            LstDate.SelectedIndex = -1
            LstDuration.SelectedIndex = -1
            LstSort.SelectedIndex = -1
            For Each ChildForm As Form In Me.MdiChildren
                If ChildForm.Text = "Download" Then
                    If ChildForm.Visible = True Then ChildForm.Hide()
                Else
                    ChildForm.Close()
                End If
            Next
            PnlSearch.Visible = True
            TxtSearch.Focus()
        End If
    End Sub

    Private Sub BtnWatch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnWatch.Click

        For Each ChildForm As Form In Me.MdiChildren
            If ChildForm.Text = "Watch" Then Exit Sub
        Next

        PnlSearch.Visible = True

        For Each ChildForm As Form In Me.MdiChildren

            If ChildForm.Text = "Download" Then
                If ChildForm.Visible = True Then ChildForm.Hide()
            Else
                ChildForm.Close()
            End If

        Next

        FrmWatch.Size = New Size(Me.Width - ChildWidth, Me.Height - ChildHeight)
        FrmWatch.MdiParent = Me
        FrmWatch.Show()

        PnlSearch.Visible = False

    End Sub

    Private Sub BtnDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDownload.Click

        Dim IsFrmDownloadLoaded As Boolean

        For Each ChildForm As Form In Me.MdiChildren

            If ChildForm.Text = "Download" Then
                IsFrmDownloadLoaded = True
                Exit For
            End If

        Next

        If IsFrmDownloadLoaded = False Then

            PnlSearch.Visible = True

            For Each ChildForm As Form In Me.MdiChildren
                ChildForm.Close()
            Next

        Else

            If FrmDownload.Visible = False Then

                PnlSearch.Visible = True

                For Each ChildForm As Form In Me.MdiChildren
                    If ChildForm.Text <> "Download" Then ChildForm.Close()
                Next

            Else

                Exit Sub

            End If

        End If

        FrmDownload.Size = New Size(Me.Width - ChildWidth, Me.Height - ChildHeight)
        FrmDownload.MdiParent = Me
        FrmDownload.Show()

        PnlSearch.Visible = False

    End Sub

    Private Sub BtnBookmark_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBookmark.Click

        For Each ChildForm As Form In Me.MdiChildren
            If ChildForm.Text = "Bookmarks" Then Exit Sub
        Next

        PnlSearch.Visible = True

        For Each ChildForm As Form In Me.MdiChildren

            If ChildForm.Text = "Download" Then
                If ChildForm.Visible = True Then ChildForm.Hide()
            Else
                ChildForm.Close()
            End If

        Next

        FrmBookmarks.Size = New Size(Me.Width - ChildWidth, Me.Height - ChildHeight)
        FrmBookmarks.MdiParent = Me
        FrmBookmarks.Show()

        PnlSearch.Visible = False

    End Sub

#End Region

#Region "YouTube Search"


    Private Sub BtnSearchYoutube_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearchYoutube.Click

        If String.IsNullOrWhiteSpace(TxtSearch.Text) = False Then
            Dim SearchStr As String = "https://www.googleapis.com/youtube/v3/search?q=" & TxtSearch.Text.Replace(" "c, "+"c).Trim & "&part=snippet&fields=items(id%2Csnippet),nextPageToken,prevPageToken&type=video&maxResults=25&key=YOUR_KEY_HERE"

            'Add Date filter

            If LstDate.SelectedIndex = 0 Then
                SearchStr &= "&time=today"
            ElseIf LstDate.SelectedIndex = 1 Then
                SearchStr &= "&time=this_week"
            ElseIf LstDate.SelectedIndex = 2 Then
                SearchStr &= "&time=this_month"
            End If

           
            If LstDuration.SelectedIndex <> -1 AndAlso LstDuration.SelectedIndex <> 3 Then
                'Add Video Duration filter
                If LstDuration.SelectedIndex = 0 Then
                    SearchStr &= "&videoDuration=short"
                ElseIf LstDuration.SelectedIndex = 1 Then
                    SearchStr &= "&videoDuration=medium"
                ElseIf LstDuration.SelectedIndex = 2 Then
                    SearchStr &= "&videoDuration=long"
                End If

            End If

            'Search sorting

            If LstSort.SelectedIndex = 0 Then
                SearchStr &= "&order=title"
            ElseIf LstSort.SelectedIndex = 1 Then
                SearchStr &= "&order=relevance"
            ElseIf LstSort.SelectedIndex = 2 Then
                SearchStr &= "&order=date"
            ElseIf LstSort.SelectedIndex = 3 Then
                SearchStr &= "&order=viewCount"
            ElseIf LstSort.SelectedIndex = 4 Then
                SearchStr &= "&order=videoCount"
            ElseIf LstSort.SelectedIndex = 5 Then
                SearchStr &= "&order=rating"
            End If

            FrmSearch.SearchURL = SearchStr
            FrmSearch.Size = New Size(Me.Width - ChildWidth, Me.Height - ChildHeight)
            FrmSearch.MdiParent = Me
            FrmSearch.Show()
            PnlSearch.Visible = False
        End If

    End Sub

#End Region

#Region "Social Links"

    Private Sub LblFacebook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblFacebook.Click

        Try
            Process.Start("https://www.facebook.com/Smartpcsoft")
        Catch ex As Exception
        End Try

    End Sub

    Private Sub LblTwitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblTwitter.Click

        Try
            Process.Start("https://twitter.com/Smartpcsoft")
        Catch ex As Exception
        End Try

    End Sub

    Private Sub LblYoutube_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblYoutube.Click

        Try
            Process.Start("https://www.google.com/+Smartpcsoft")
        Catch ex As Exception
        End Try

    End Sub

#End Region

#Region "Functions"

    Private Shared Sub UpdatesCheck()
        Threading.Thread.CurrentThread.Priority = Threading.ThreadPriority.Lowest
        Threading.Thread.Sleep(4000)
        Try
            Dim getver As String = "http://smartpcsoft.com/info/my-tube/version.php"
            Dim Request = Net.WebRequest.Create(getver)
            Dim Response = TryCast(Request.GetResponse(), Net.HttpWebResponse)
            Dim Result = New IO.StreamReader(Response.GetResponseStream(), System.Text.Encoding.UTF8).ReadToEnd()
            Response.Close()
            Dim ver As String = Result
            If Val(ver) > Val(Application.ProductVersion) Then

                If MessageBox.Show("New updates are available for MyTube." & vbCrLf & "Do you want to download the new updates?", My.Application.Info.Description, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0, False) = Windows.Forms.DialogResult.Yes Then
                    Try
                        Process.Start("http://smartpcsoft.com/mytube.html")
                    Catch ex As Exception
                    End Try
                End If

            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Function GetIE(ByVal appName As String) As System.Diagnostics.Process
        Try
            Dim pList() As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessesByName(appName)
            For Each proc As System.Diagnostics.Process In pList
                If proc.ProcessName = appName Then
                    Return proc
                End If
            Next
        Catch ex As Exception
            Return Nothing
        End Try
        Return Nothing
    End Function

    Public Shared Function GetFirefoxUrl() As String
        Try
            Dim dde As New DdeClient("Firefox", "WWW_GetWindowInfo")
            dde.Connect()
            Dim url As String = dde.Request("URL", Integer.MaxValue)
            dde.Disconnect()
            Return url
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Sub shfrm()
        Try
            If Not NewTitle = stitle Then
                Dim f As New FrmCatch
                f.Text = "MyTube - Catch New Video."
                f.Location = New Point(My.Computer.Screen.WorkingArea.Width - 370, My.Computer.Screen.WorkingArea.Height - 220)
                stitle = NewTitle
                _VideoWebsiteURL = NewTitle.Trim
                _VideoID = _VideoWebsiteURL.Replace("https://www.youtube.com/watch?v=", "").Trim
                f.Show()
            End If
        Catch ex As Exception
        End Try
    End Sub

#End Region

End Class