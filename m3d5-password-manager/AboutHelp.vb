'Copyright © 2015 Alessandro Celso
'GNU General Public License v3

Public Class AboutHelp

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim url As String = "https://github.com/zegt"
        Process.Start(url)
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim url As String = "https://github.com/Zegt/m3d5-password-manager"
        Process.Start(url)
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Dim url As String = "http://uiconstock.com"
        Process.Start(url)
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Dim url As String = "http://www.iconarchive.com"
        Process.Start(url)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim url As String = "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=P82RVZEYK4HEE"
        Process.Start(url)
    End Sub
End Class