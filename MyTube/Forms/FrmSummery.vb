Public Class FrmSummery

#Region "General"

    Private Sub FrmSummery_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

        'Get selected video information

        If Not _VideoThumbnail.Image Is Nothing Then PicThumbnail.Image = _VideoThumbnail.Image

        TxtTitle.Text = _VideoTitle
        TxtDuration.Text = _VideoDuration
        TxtDescription.Text = _VideoDescription
        TxtWebsiteURL.Text = _VideoWebsiteURL

    End Sub

    Private Sub FrmSummery_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        'Clear video information

        PicThumbnail.Image = Nothing

        TxtTitle.Text = ""
        TxtDuration.Text = ""
        TxtDescription.Text = ""
        TxtWebsiteURL.Text = ""

    End Sub

    Private Sub BtnOpenLink_Click(sender As System.Object, e As System.EventArgs) Handles BtnOpenLink.Click

        Try
            Process.Start(TxtWebsiteURL.Text)
        Catch ex As Exception
        End Try

    End Sub

#End Region

End Class