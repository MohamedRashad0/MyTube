#Region "References"
Imports System.IO
#End Region

Public Class FrmConvert

#Region "Declarations"
    Dim proc As New Process
    Dim CancelCon As Boolean
    Friend input As String
    Friend out As String
    Friend TmpOut As String
#End Region

#Region "General"

    Private Sub BtnConvertDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConvertDir.Click
        FolderDlg.Description = "Select a directory to Converted files."
        If FolderDlg.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            TxtConvertDir.Text = FolderDlg.SelectedPath
            out = out.Replace(Path.GetDirectoryName(out), FolderDlg.SelectedPath)
        End If
        FolderDlg.Description = ""
        FolderDlg.SelectedPath = ""
    End Sub

    Public Sub startConversion()
        Try
            Control.CheckForIllegalCrossThreadCalls = False
            Dim exepath As String = Application.StartupPath & "/cf.exe"
            Dim quality As Integer = 30
            Dim res As String = ""
            Dim codec As String = ""
            Dim rate As String = ""
            Dim brate As String = ""
            Dim ab As String = ""
            Dim ac As String = ""
            Dim cmd As String = " -i """ + input + """ -ar 22050 -qscale " & quality & codec & res & " -y """ + out + """" 'ffmpeg commands -y replace
            Dim startinfo As New System.Diagnostics.ProcessStartInfo
            Dim sr As StreamReader
            Dim ffmpegOutput As String
            startinfo.FileName = exepath
            startinfo.Arguments = cmd
            startinfo.UseShellExecute = False
            startinfo.WindowStyle = ProcessWindowStyle.Hidden
            startinfo.RedirectStandardError = True
            startinfo.RedirectStandardOutput = True
            startinfo.CreateNoWindow = True
            proc.StartInfo = startinfo
            proc.Start()
            sr = proc.StandardError
            Do Until proc.HasExited
                ffmpegOutput = sr.ReadLine
                If Me.BWConvert.CancellationPending Then
                    Exit Sub
                End If
            Loop
            tovid.Enabled = True
            TxtConvertDir.Enabled = True
            BtnOK.Enabled = True
            ProgressBar1.Visible = False
            File.Delete(input)
            Rename(out, TmpOut)
            CancelCon = False
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOK.Click

        If tovid.Text = "" Then
            MessageBox.Show("Select file extension!", "file extension not Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            tovid.Focus()
            Exit Sub
        End If
        If TxtConvertDir.Text = "" Then
            MessageBox.Show("Select Converts directory!", "Converts directory not Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            BtnConvertDir.PerformClick()
        End If
        If tovid.Text = "Windows Media Video (V.7 WMV)" Then
            out = out & ".wmv"
        End If
        If tovid.Text = "Xvid MPEG-4 Codec (AVI)" Then
            out = out & ".avi"
        End If
        If tovid.Text = "iPod Video (Apple QuickTime MOV)" Then
            out = out & ".mov"
        End If
        If tovid.Text = "MPEG Audio Layer 3 (MP3)" Then
            out = out & ".mp3"
        End If
        TmpOut = out
        Dim DuFilePath As String = Path.GetDirectoryName(input)
        Dim DuFileEx As String = Path.GetExtension(input)
        Dim duout As String = Path.GetDirectoryName(out)
        Dim Duexout As String = Path.GetExtension(out)
        Try
            If File.Exists(Application.StartupPath & "/cf.exe") = False Then
                MessageBox.Show("Video Converter application is missing or corrupted.", "File is missing or corrupted.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Exit Sub
            End If
            If File.Exists(TmpOut) = True Then
                If MessageBox.Show("The selected video is already converted." & vbNewLine & "Do you want to overwrite the existing file?", "existing file", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.No Then
                    Me.Close()
                    Exit Sub
                Else
                    File.Delete(TmpOut)
                End If

            End If
            File.Copy(input, DuFilePath & "\tmpfc" & DuFileEx, True)
            input = DuFilePath & "\tmpfc" & DuFileEx
            out = duout & "\tmpfc" & Duexout
            tovid.Enabled = False
            TxtConvertDir.Enabled = False
            ProgressBar1.Visible = True
            BtnOK.Enabled = False
            If TxtConvertDir.Text = _DownloadsFolder & "\Converts\" And Directory.Exists(_DownloadsFolder & "\Converts") = False Then
                Directory.CreateDirectory(_DownloadsFolder & "\Converts")
            End If
            BWConvert.RunWorkerAsync()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BWConvert_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BWConvert.DoWork
        startConversion()
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        If BWConvert.IsBusy = True Then
            If MessageBox.Show("Are you sure, Want to Cancel Conversion", "Cancel Conversion?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                CancelCon = True
                Me.BWConvert.CancelAsync()
            End If
        End If
        Me.Close()
    End Sub

    Private Sub BWConvert_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BWConvert.RunWorkerCompleted
        If CancelCon = True Then
            proc.Kill()
            proc.WaitForExit()
            MessageBox.Show("Converting file has been canceled", "Conversion has been canceled", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tovid.Enabled = True
            TxtConvertDir.Enabled = True
            BtnOK.Enabled = True
            ProgressBar1.Visible = False
            File.Delete(out)
            File.Delete(input)
            Me.Close()
        Else
            MessageBox.Show("Done! File has been Converted", "File Converted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

#End Region

End Class