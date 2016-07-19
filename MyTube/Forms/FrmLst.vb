
Imports System.Net
Imports System.Text
Imports System.Xml
Imports System.IO
Imports System.Runtime.InteropServices
Imports Newtonsoft.Json

Public Class FrmLst
    Friend PlayLstID As String
    Dim lst_Title As New List(Of String)
    Dim lst_id As New List(Of String)
    Dim lst_duration As New List(Of String)
    Dim lst_description As New List(Of String)

    <DllImport("uxtheme", CharSet:=CharSet.Unicode)> _
    Public Shared Function SetWindowTheme(ByVal hWnd As IntPtr, ByVal textSubAppName As String, ByVal textSubIdList As String) As Integer
    End Function

    Private Sub FrmLst_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        BWGenrateVideos.CancelAsync()
    End Sub

    Private Sub FrmLst_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SetWindowTheme(ListView1.Handle, "explorer", Nothing)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FrmLst_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        lst_Title.Clear()
        lst_id.Clear()
        lst_duration.Clear()
        lst_description.Clear()
        ListView1.View = View.Tile
        ListView1.Items.Clear()
        ImageList1.Images.Clear()
        ListView1.Visible = False
        PnlProgress.Visible = True
        BWGenrateVideos.RunWorkerAsync()
    End Sub

    Private Sub BWGenrateVideos_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BWGenrateVideos.DoWork
        Try
            Form.CheckForIllegalCrossThreadCalls = False
            If Not PlayLstID = Nothing Then
                Dim web As New WebClient
                web.Encoding = Encoding.UTF8
                Dim sourceString As String = web.DownloadString(" https://www.googleapis.com/youtube/v3/playlistItems?part=snippet&maxResults=50&key=YOUR_KEY_HERE&playlistId=" & PlayLstID.Trim)
                Dim node As XNode = JsonConvert.DeserializeXNode(sourceString, "Root")
                Dim XMLStr As XmlReader = New XmlTextReader(New StringReader(node.ToString))
                web.Encoding = Encoding.UTF8
                Do While XMLStr.Read()
                    If XMLStr.NodeType = XmlNodeType.Element Then
                        If XMLStr.Name = "title" Then lst_Title.Add(XMLStr.ReadElementString)
                        If XMLStr.Name = "description" Then lst_description.Add(XMLStr.ReadElementString)
                        If XMLStr.Name = "videoId" Then lst_id.Add(XMLStr.ReadElementString)
                    End If
                Loop
                For i As Integer = 0 To lst_id.Count - 1
                    Dim ph As String
                    ph = "https://img.youtube.com/vi/" & lst_id.Item(i) & "/default.jpg"
                    ImageList1.Images.Add(New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(ph))))
                    ListView1.Items.Add(lst_Title.Item(i).ToString)
                    ListView1.Items.Item(i).SubItems.Add(lst_description.Item(i).ToString)
                    ListView1.Items.Item(i).ImageIndex = i
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Could not get videos." & vbCrLf & "Please, check your Internet connection.", My.Application.Info.Description, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, False)
            Me.Close()
        End Try
    End Sub

    Private Sub BWGenrateVideos_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BWGenrateVideos.RunWorkerCompleted
        ListView1.Visible = True
        PnlProgress.Visible = False
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        If ListView1.SelectedItems.Count > 0 Then
            _VideoWebsiteURL = "https://www.youtube.com/watch?v=" & lst_id.Item(ListView1.SelectedItems(0).Index)
            _VideoID = lst_id.Item(ListView1.SelectedItems(0).Index)
            FrmTasks.ShowDialog(Me)
        End If
    End Sub

    Private Sub TmrProgress_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrProgress.Tick
        If PBProgress.Value < 100 Then
            PBProgress.Value += 2
        Else
            PBProgress.Value = 2
        End If
    End Sub


End Class