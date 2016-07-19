
Public Class FrmNewVideo

#Region "General"

    Friend ActionType As Byte

    Private Sub FrmNewBookmark_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        'Reset UI

        If ActionType = 1 Then
            Me.Text = "New Download"
            LblURL.Text = "YouTube Video &Address:"
        ElseIf ActionType = 2 Then
            Me.Text = "New Bookmark"
            LblURL.Text = "YouTube Video &Address:"
        ElseIf ActionType = 3 Then
            Me.Text = "New Play List"
            LblURL.Text = "YouTube Play List &Address:"
        End If
        TxtURL.Text = ""
        TxtURL.Focus()
        Me.Opacity = 1

    End Sub

    Private Sub FrmNewVideo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ActionType = 0
    End Sub

    Private Sub TxtURL_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtURL.TextChanged

        If String.IsNullOrWhiteSpace(TxtURL.Text) = False Then
            BtnOK.Enabled = True
        Else
            BtnOK.Enabled = False
        End If

    End Sub

    Private Sub BtnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnOK.Click
        If ActionType = 3 Then
            Dim INurl() As String
            Dim pid() As String
            If TxtURL.Text.Contains("list=") = True Then
                INurl = Split(TxtURL.Text, "list=")
                pid = Split(INurl(1), "&")
                If pid(0) = String.Empty Then
                    MessageBox.Show("Invalid YouTube play list address.", My.Application.Info.Description, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, False)
                    TxtURL.Focus()
                    Exit Sub
                Else
                    FrmLst.PlayLstID = pid(0).Trim
                End If
            Else
                MessageBox.Show("Invalid YouTube play list address.", My.Application.Info.Description, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, False)
                TxtURL.Focus()
                Exit Sub
            End If
            FrmVideoInfo.ActionType = 2
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            ' Validate YouTube Video URL
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
            _VideoID = _VideoWebsiteURL.Replace("https://www.youtube.com/watch?v=", "").Trim

            If String.IsNullOrWhiteSpace(_VideoID) = True Then
                MessageBox.Show("Invalid YouTube video address.", My.Application.Info.Description, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, False)
                TxtURL.Focus()
                Exit Sub
            End If

            Me.Opacity = 0

            If ActionType = 1 Then
                FrmVideoInfo.ActionType = 2
            ElseIf ActionType = 2 Then
                FrmVideoInfo.ActionType = 3
            End If

            'Get Video Information

            If FrmVideoInfo.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            End If
        End If

    End Sub

#End Region

End Class