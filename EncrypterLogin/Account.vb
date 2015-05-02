'Copyright © 2015 Alessandro Celso
'GNU General Public License v3

Public Class Account

    Private Sub CreateAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateAccount.Click
        If String.IsNullOrEmpty(My.Settings.Password) = True And StrComp(Password.Text, RePassword.Text) = 0 Then
            My.Settings.Password = Password.Text
            My.Settings.Key = Key.Text
            My.Settings.Save()
            MsgBox("Account Created!", MsgBoxStyle.Information, "Account")
            Me.Close()
            Login.Show()
        Else
            MsgBox("Account still exists!", MsgBoxStyle.Critical, "Error")
            Me.Close()
            Login.Show()
        End If
    End Sub

    Private Sub Password_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Password.TextChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If String.IsNullOrEmpty(My.Settings.Password) = False Then
            MsgBox("Data found: Account exists", MsgBoxStyle.Information, "Account")
        Else
            MsgBox("Data not found: Account doesnt exist", MsgBoxStyle.Information, "Account")
        End If
    End Sub

    Private Sub Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Personal account can be set up just one time, you must reinstall M3D5 PM to reset your profile.", MsgBoxStyle.Information, "Account")
    End Sub
End Class