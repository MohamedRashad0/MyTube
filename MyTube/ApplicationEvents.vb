#Region "References"

Imports System.IO

#End Region

Namespace My

    Partial Friend Class MyApplication

        Private Sub MyApplication_StartupNextInstance(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupNextInstanceEventArgs) Handles Me.StartupNextInstance

            If FrmMain.Visible = True Then

                If FrmMain.WindowState <> FormWindowState.Normal Then FrmMain.WindowState = FormWindowState.Normal

            Else

                FrmMain.Visible = True
                FrmMain.NIcon.Visible = False

            End If

        End Sub

        Private Sub MyApplication_UnhandledException(sender As Object, e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException

            If Directory.Exists(_ReportsDir) = False Then Directory.CreateDirectory(_ReportsDir)

            Dim ErrNum As New Random
            Dim ErrFile As String = _ReportsDir & "\Error_" & ErrNum.Next(0, 10000).ToString & ".txt"

            Dim ErrWriter As New StreamWriter(ErrFile, False, System.Text.Encoding.Default)

            With ErrWriter

                .WriteLine("Application name: " & My.Application.Info.AssemblyName)
                .WriteLine("Product name: " & My.Application.Info.ProductName)
                .WriteLine("Application version: " & My.Application.Info.Version.ToString)
                .WriteLine(New String("-"c, 100))
                .WriteLine(e.Exception)
                .WriteLine(New String("-"c, 100))
                .WriteLine("[Load Assemblies]")
                .WriteLine()

                For I As Integer = 0 To Application.Info.LoadedAssemblies.Count - 1
                    .WriteLine(Application.Info.LoadedAssemblies.Item(I).FullName)
                Next

                .Close()

            End With

            If MessageBox.Show("An exception has occurred in MyTube." & vbCrLf & "Do you want to open the exception's details?", My.Application.Info.Description, MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, False) = DialogResult.Yes Then

                Try
                    Process.Start(ErrFile)
                Catch ex As Exception
                End Try

            End If

            e.ExitApplication = False

        End Sub

    End Class

End Namespace