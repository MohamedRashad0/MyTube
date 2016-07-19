Imports System.Net
Imports System.Text
Imports System.Xml
Imports System.IO
Imports System.Runtime.InteropServices
Imports Newtonsoft.Json
Public Class FrmSearch
    Friend SearchURL As String
    Dim lst_Title As New List(Of String)
    Dim lst_id As New List(Of String)
    Dim lst_description As New List(Of String)
    Dim pageNext As String
    Dim pagePrev As String
#Region "General"

    <DllImport("uxtheme", CharSet:=CharSet.Unicode)> _
    Public Shared Function SetWindowTheme(ByVal hWnd As IntPtr, ByVal textSubAppName As String, ByVal textSubIdList As String) As Integer
    End Function

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim CP As CreateParams = MyBase.CreateParams
            CP.ExStyle = &H2000000
            Return CP
        End Get
    End Property

    Private Sub FrmSearch_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        BWGenrateSearch.CancelAsync()
    End Sub

    Private Sub FrmSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Back Then
            If BtnBack.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True Then
                BtnBack.PerformClick()
            Else
                BWGenrateSearch.CancelAsync()
                FrmMain.BtnSearch.PerformClick()
            End If
            e.Handled = True
        End If
    End Sub

#End Region

#Region "Search"

    Private Sub BtnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBack.Click
        If Not pagePrev = String.Empty Then
            Dim token() As String = Nothing
            If SearchURL.Contains("&pageToken=") Then
                token = Split(SearchURL, "&pageToken=")
                SearchURL = token(0) & "&pageToken=" & pagePrev
            Else
                SearchURL &= "&pageToken=" & pagePrev
            End If

            BtnBack.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            BWGenrateSearch.RunWorkerAsync()
        End If
    End Sub

    Private Sub BtnForward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnForward.Click
        If Not pageNext = String.Empty Then
            Dim token() As String = Nothing
            If SearchURL.Contains("&pageToken=") Then
                token = Split(SearchURL, "&pageToken=")
                SearchURL = token(0) & "&pageToken=" & pageNext
            Else
                SearchURL &= "&pageToken=" & pageNext
            End If

            BtnBack.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            BWGenrateSearch.RunWorkerAsync()
        End If
    End Sub

#End Region


    Private Sub FrmSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SetWindowTheme(ListView1.Handle, "explorer", Nothing)
        Catch ex As Exception
        End Try
        BWGenrateSearch.RunWorkerAsync()
    End Sub

    Private Sub BWGenrateSearch_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BWGenrateSearch.DoWork
        Try
            Form.CheckForIllegalCrossThreadCalls = False
            PnlProgress.Visible = True
            ListView1.Visible = False
            If Not SearchURL = Nothing Then
                Dim web As New WebClient
                web.Encoding = Encoding.UTF8
                Dim sourceString As String = web.DownloadString(SearchURL)
                Dim node As XNode = JsonConvert.DeserializeXNode(sourceString, "Root")
                Dim XMLStr As XmlReader = New XmlTextReader(New StringReader(node.ToString))
                web.Encoding = Encoding.UTF8
                lst_id.Clear()
                lst_Title.Clear()
                lst_description.Clear()
                pageNext = String.Empty
                pagePrev = String.Empty
                Do While XMLStr.Read()
                    If XMLStr.NodeType = XmlNodeType.Element Then
                        If XMLStr.Name = "videoId" Then lst_id.Add(XMLStr.ReadElementString)
                        If XMLStr.Name = "title" Then lst_Title.Add(XMLStr.ReadElementString)
                        If XMLStr.Name = "description" Then lst_description.Add(XMLStr.ReadElementString)
                        If XMLStr.Name = "nextPageToken" Then pageNext = XMLStr.ReadElementString
                        If XMLStr.Name = "prevPageToken" Then pagePrev = XMLStr.ReadElementString
                    End If
                Loop
                ListView1.View = View.Tile
                ListView1.Items.Clear()
                ImageList1.Images.Clear()
                For i As Integer = 0 To lst_id.Count - 1
                    Dim ph As String
                    ph = "https://img.youtube.com/vi/" & lst_id.Item(i) & "/default.jpg"
                    ListView1.Items.Add(lst_Title.Item(i).ToString)
                    ListView1.Items.Item(i).SubItems.Add(lst_description.Item(i).ToString)
                    Try
                        ImageList1.Images.Add(New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(ph))))
                    Catch ex As Exception
                        ImageList1.Images.Add(Image.FromFile(Application.StartupPath & "\404"))
                    End Try
                    ListView1.Items.Item(i).ImageIndex = i
                Next
            End If
            ListView1.Refresh()
            If pageNext = String.Empty Then
                BtnForward.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            Else
                BtnForward.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            End If

            If pagePrev = String.Empty Then
                BtnBack.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            Else
                BtnBack.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            End If
        Catch ex As Exception
            MessageBox.Show("Could not search YouTube for videos." & vbCrLf & "Please, check your Internet connection.", My.Application.Info.Description, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, False)
            FrmMain.BtnSearch.PerformClick()
        End Try
    End Sub


        Private Sub BWGenrateSearch_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BWGenrateSearch.RunWorkerCompleted
            PnlProgress.Visible = False
            ListView1.Visible = True
        End Sub

        Private Sub BtnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHome.Click
            BWGenrateSearch.CancelAsync()
            FrmMain.BtnSearch.PerformClick()
        End Sub

        Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
            If ListView1.SelectedItems.Count > 0 Then
                _VideoWebsiteURL = "https://www.youtube.com/watch?v=" & lst_id.Item(ListView1.SelectedItems(0).Index)
                _VideoID = lst_id.Item(ListView1.SelectedItems(0).Index)
                FrmTasks.ShowDialog(Me)
            End If
        End Sub

    End Class