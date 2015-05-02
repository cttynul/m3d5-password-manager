'Copyright © 2015 Alessandro Celso
'GNU General Public License v3

Public Class License

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim url As String = "http://www.gnu.org/licenses/gpl.html"
        Process.Start(url)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim url As String = "http://www.gnu.org/copyleft/gpl.html"
        Process.Start(url)
    End Sub
End Class