Public Class FrmCatch

#Region "Tasks"

    Private Sub LblWatch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LblWatch.Click

        Me.Hide()
        FrmVideoInfo.ActionType = 1
        FrmVideoInfo.ShowDialog(FrmMain)
        Me.Close()

    End Sub

    Private Sub LblDownload_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LblDownload.Click

        Me.Hide()
        FrmVideoInfo.ActionType = 2
        FrmVideoInfo.ShowDialog(FrmMain)
        Me.Close()

    End Sub

    Private Sub LblBookmark_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LblBookmark.Click

        Me.Hide()
        FrmVideoInfo.ActionType = 3
        FrmVideoInfo.ShowDialog(FrmMain)
        Me.Close()

    End Sub

    Private Sub LblWatch_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles LblWatch.MouseEnter, LblDownload.MouseEnter, LblBookmark.MouseEnter

        Dim LblSender As Label = CType(sender, Label)
        LblSender.ForeColor = Color.SteelBlue

    End Sub

    Private Sub LblWatch_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LblWatch.MouseLeave, LblDownload.MouseLeave, LblBookmark.MouseLeave

        Dim LblSender As Label = CType(sender, Label)
        LblSender.ForeColor = Color.Black

    End Sub

#End Region

End Class