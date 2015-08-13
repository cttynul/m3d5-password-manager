'Copyright © 2015 Alessandro Celso
'GNU General Public License v3

Imports System.Net

Public Class Login
    Const InstalledVersion = 1.5

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Password.Text = My.Settings.Password Then
            Decrypter.Show()
        Else
            MsgBox("Incorrect Password!", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    'Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '   Account.Show()
    'End Sub

    Private Sub Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Help.Click
        'help
        AboutHelp.Show()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseProgram.Click
        Me.Close()
    End Sub

    Private Sub CreateAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateAccountToolStripMenuItem.Click
        Account.Show()
    End Sub

    Private Sub HelpB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpB.Click
        'help
        AboutHelp.Show()
    End Sub

    Private Sub AccountStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountStatus.Click
        If String.IsNullOrEmpty(My.Settings.Password) = False Then
            MsgBox("Data found: Account exists", MsgBoxStyle.Information, "Account")
        Else
            MsgBox("Data not found: Account doesnt exist", MsgBoxStyle.Information, "Account")
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel2.Click
        License.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Account.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim url As String = "https://github.com/zegt"
        Process.Start(url)
    End Sub

    Private Sub Donate_Click(sender As Object, e As EventArgs) Handles Donate.Click
        Dim url As String = "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=P82RVZEYK4HEE"
        Process.Start(url)
    End Sub

    Private Sub CheckForUpdates()
        Dim WebCl As New WebClient
        Try
            Dim OnlineVersion As Single = WebCl.DownloadString("https://raw.githubusercontent.com/zegt/m3d5-password-manager/master/Version.txt")
            If InstalledVersion < OnlineVersion Then
                MsgBox("A new Version of M3D5 Password Manager has been released. Check Github page to download it.", MsgBoxStyle.Information, "Update available!")
            End If
        Catch UpdateException As Exception
            MsgBox(UpdateException, MsgBoxStyle.Critical, "Something went wrong :(")
        End Try

    End Sub

End Class
