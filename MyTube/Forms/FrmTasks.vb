Public Class FrmTasks

#Region "Tasks"

    Private Sub LblWatch_Click(sender As Object, e As System.EventArgs) Handles LblWatch.Click

        Me.Hide()
        FrmVideoInfo.ActionType = 1
        FrmVideoInfo.ShowDialog(FrmMain)
        Me.Close()

    End Sub

    Private Sub LblDownload_Click(sender As Object, e As System.EventArgs) Handles LblDownload.Click

        Me.Hide()
        FrmVideoInfo.ActionType = 2
        FrmVideoInfo.ShowDialog(FrmMain)
        Me.Close()

    End Sub

    Private Sub LblBookmark_Click(sender As Object, e As System.EventArgs) Handles LblBookmark.Click

        Me.Hide()
        FrmVideoInfo.ActionType = 3
        FrmVideoInfo.ShowDialog(FrmMain)
        Me.Close()

    End Sub

    Private Sub LblWatch_MouseEnter(sender As Object, e As System.EventArgs) Handles LblWatch.MouseEnter, LblDownload.MouseEnter, LblBookmark.MouseEnter

        Dim LblSender As Label = CType(sender, Label)
        LblSender.ForeColor = Color.SteelBlue

    End Sub

    Private Sub LblWatch_MouseLeave(sender As Object, e As System.EventArgs) Handles LblWatch.MouseLeave, LblDownload.MouseLeave, LblBookmark.MouseLeave

        Dim LblSender As Label = CType(sender, Label)
        LblSender.ForeColor = Color.Black

    End Sub

#End Region

End Class