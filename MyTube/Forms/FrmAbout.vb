Public Class FrmAbout

#Region "General"

    Private Sub FrmAbout_Load(sender As System.Object, e As System.EventArgs) Handles Me.Load

        LblVersion.Text = ("Version: " & Application.ProductVersion)
        LblLicense.Text = ("Licensed to: " & System.Environment.UserName)
        LblCRight.Text = My.Application.Info.Copyright

    End Sub

    Private Sub LnkInternet_LinkClicked(sender As Object, e As System.EventArgs) Handles LnkInternet.LinkClicked

        Try
            Process.Start("http://smartpcsoft.com/support.html")
        Catch ex As Exception
        End Try

    End Sub

    Private Sub LnkSoftwareLicense_LinkClicked(sender As Object, e As System.EventArgs) Handles LnkSoftwareLicense.LinkClicked

        Try
            Process.Start("http://www.gnu.org/licenses/gpl.html")
        Catch ex As Exception
        End Try

    End Sub

#End Region

 
End Class