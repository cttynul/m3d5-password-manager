' ============================================
' ||           it.heisenbug.eu.org           ||
' ============================================

'Copyright © 2015 Alessandro Celso
'GNU General Public License v3

Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class Decrypter

    Dim key As String = My.Settings.Key

    'DATA STORAGE

    'Amazon
    Private Sub Amazon_En_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Amazon_En.Click
        'percorso di default "C:\Users\YOURACCOUNTNAME\Documents\M3D5 Password Manager\example.txt"
        If Not My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\") Then
            MkDir(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\")
        End If

        If File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\am.txt") = False Or File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\am.txt") = True Or Amazon.Text = Nothing Then
            Dim write As String = Amazon.Text
            Dim output As Byte() = encry(write, key)
            Dim con As String = Convert.ToBase64String(output)
            File.WriteAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\am.txt", con)
            MsgBox("Text crypted and saved! Textbox is going to be deleted!", MsgBoxStyle.Information, "Saved")
            'svuota la textbox dopo aver salvato
            Amazon.Text = "Click decrypt to show password"
        End If
    End Sub

    Private Sub Amazon_De_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Amazon_De.Click
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\am.txt") = True Then
            Dim source As String = File.ReadAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\am.txt")
            Dim decr As String = decry(source, key)
            Amazon.Text = decr
        Else
            MsgBox("No data found", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    'Dropbox
    Private Sub Dropbox_En_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dropbox_En.Click

        If Not My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\") Then
            MkDir(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\")
        End If

        If File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\dp.txt") = False Or File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\dp.txt") = True Or Dropbox.Text = Nothing Then
            Dim write As String = Dropbox.Text
            Dim output As Byte() = encry(write, key)
            Dim con As String = Convert.ToBase64String(output)
            File.WriteAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\dp.txt", con)
            MsgBox("Text crypted and saved! Textbox is going to be deleted!", MsgBoxStyle.Information, "Saved")
            'svuota la textbox dopo aver salvato
            Dropbox.Text = "Click decrypt to show password"
        End If
    End Sub

    Private Sub Dropbox_De_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dropbox_De.Click
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\dp.txt") = True Then
            Dim source As String = File.ReadAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\dp.txt")
            Dim decr As String = decry(source, key)
            Dropbox.Text = decr
        Else
            MsgBox("No data found", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    'Facebook
    Private Sub FB_En_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FB_En.Click

        If Not My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\") Then
            MkDir(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\")
        End If

        If File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\fb.txt") = False Or File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\fb.txt") = True Or FB.Text = Nothing Then
            Dim write As String = FB.Text
            Dim output As Byte() = encry(write, key)
            Dim con As String = Convert.ToBase64String(output)
            File.WriteAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\fb.txt", con)
            MsgBox("Text crypted and saved! Textbox is going to be deleted!", MsgBoxStyle.Information, "Saved")
            'svuota la textbox dopo aver salvato
            FB.Text = "Click decrypt to show password"
        End If
    End Sub

    Private Sub FB_De_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FB_De.Click
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\fb.txt") = True Then
            Dim source As String = File.ReadAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\fb.txt")
            Dim decr As String = decry(source, key)
            FB.Text = decr
        Else
            MsgBox("No data found", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    'Google
    Private Sub Google_En_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Google_En.Click

        If Not My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\") Then
            MkDir(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\")
        End If

        If File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\goo.txt") = False Or File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\goo.txt") = True Or Google.Text = Nothing Then
            Dim write As String = Google.Text
            Dim output As Byte() = encry(write, key)
            Dim con As String = Convert.ToBase64String(output)
            File.WriteAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\goo.txt", con)
            MsgBox("Text crypted and saved! Textbox is going to be deleted!", MsgBoxStyle.Information, "Saved")
            'svuota la textbox dopo aver salvato
            FB.Text = "Click decrypt to show password"
        End If
    End Sub

    Private Sub Google_De_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Google_De.Click
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\goo.txt") = True Then
            Dim source As String = File.ReadAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\goo.txt")
            Dim decr As String = decry(source, key)
            Google.Text = decr
        Else
            MsgBox("No data found", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    'Instagram
    Private Sub Instagram_En_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Instagram_En.Click

        If Not My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\") Then
            MkDir(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\")
        End If

        If File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\insta.txt") = False Or File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\insta.txt") = True Or Instagram.Text = Nothing Then
            Dim write As String = Instagram.Text
            Dim output As Byte() = encry(write, key)
            Dim con As String = Convert.ToBase64String(output)
            File.WriteAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\insta.txt", con)
            MsgBox("Text crypted and saved! Textbox is going to be deleted!", MsgBoxStyle.Information, "Saved")
            'svuota la textbox dopo aver salvato
            FB.Text = "Click decrypt to show password"
        End If
    End Sub

    Private Sub Instagram_De_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Instagram_De.Click
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\insta.txt") = True Then
            Dim source As String = File.ReadAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\insta.txt")
            Dim decr As String = decry(source, key)
            Instagram.Text = decr
        Else
            MsgBox("No data found", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    'Twitter
    Private Sub Twitter_En_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Twitter_En.Click

        If Not My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\") Then
            MkDir(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\")
        End If

        If File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\twt.txt") = False Or File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\twt.txt") = True Or Twitter.Text = Nothing Then
            Dim write As String = Twitter.Text
            Dim output As Byte() = encry(write, key)
            Dim con As String = Convert.ToBase64String(output)
            File.WriteAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\twt.txt", con)
            MsgBox("Text crypted and saved! Textbox is going to be deleted!", MsgBoxStyle.Information, "Saved")
            'svuota la textbox dopo aver salvato
            FB.Text = "Click decrypt to show password"
        End If
    End Sub

    Private Sub Twitter_De_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Twitter_De.Click
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\twt.txt") = True Then
            Dim source As String = File.ReadAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\twt.txt")
            Dim decr As String = decry(source, key)
            Twitter.Text = decr
        Else
            MsgBox("No data found", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    'Paypal
    Private Sub Paypal_En_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Paypal_En.Click

        If Not My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\") Then
            MkDir(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\")
        End If

        If File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\pyp.txt") = False Or File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\pyp.txt") = True Or Paypal.Text = Nothing Then
            Dim write As String = Paypal.Text
            Dim output As Byte() = encry(write, key)
            Dim con As String = Convert.ToBase64String(output)
            File.WriteAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\pyp.txt", con)
            MsgBox("Text crypted and saved! Textbox is going to be deleted!", MsgBoxStyle.Information, "Saved")
            'svuota la textbox dopo aver salvato
            FB.Text = "Click decrypt to show password"
        End If
    End Sub

    Private Sub Paypal_De_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Paypal_De.Click
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\pyp.txt") = True Then
            Dim source As String = File.ReadAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\pyp.txt")
            Dim decr As String = decry(source, key)
            Paypal.Text = decr
        Else
            MsgBox("No data found", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    'Outlook
    Private Sub Outlook_En_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Outlook_En.Click

        If Not My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\") Then
            MkDir(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\")
        End If

        If File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\out.txt") = False Or File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\out.txt") = True Or Outlook.Text = Nothing Then
            Dim write As String = Outlook.Text
            Dim output As Byte() = encry(write, key)
            Dim con As String = Convert.ToBase64String(output)
            File.WriteAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\out.txt", con)
            MsgBox("Text crypted and saved! Textbox is going to be deleted!", MsgBoxStyle.Information, "Saved")
            'svuota la textbox dopo aver salvato
            FB.Text = "Click decrypt to show password"
        End If
    End Sub

    Private Sub Outlook_De_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Outlook_De.Click
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\out.txt") = True Then
            Dim source As String = File.ReadAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\out.txt")
            Dim decr As String = decry(source, key)
            Outlook.Text = decr
        Else
            MsgBox("No data found", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    'Yahoo
    Private Sub Yahoo_En_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Yahoo_En.Click

        If Not My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\") Then
            MkDir(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\")
        End If

        If File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\yah.txt") = False Or File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\yah.txt") = True Or Yahoo.Text = Nothing Then
            Dim write As String = Yahoo.Text
            Dim output As Byte() = encry(write, key)
            Dim con As String = Convert.ToBase64String(output)
            File.WriteAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\yah.txt", con)
            MsgBox("Text crypted and saved! Textbox is going to be deleted!", MsgBoxStyle.Information, "Saved")
            'svuota la textbox dopo aver salvato
            FB.Text = "Click decrypt to show password"
        End If
    End Sub

    Private Sub Yahoo_De_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Yahoo_De.Click
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\yah.txt") = True Then
            Dim source As String = File.ReadAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\yah.txt")
            Dim decr As String = decry(source, key)
            Yahoo.Text = decr
        Else
            MsgBox("No data found", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    'CreditCard
    Private Sub CreditCard_En_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreditCard_En.Click

        If Not My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\") Then
            MkDir(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\")
        End If

        If File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\ccrd.txt") = False Or File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\ccrd.txt") = True Or CreditCard.Text = Nothing Then
            Dim write As String = CreditCard.Text
            Dim output As Byte() = encry(write, key)
            Dim con As String = Convert.ToBase64String(output)
            File.WriteAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\ccrd.txt", con)
            MsgBox("Text crypted and saved! Textbox is going to be deleted!", MsgBoxStyle.Information, "Saved")
            'svuota la textbox dopo aver salvato
            FB.Text = "Click decrypt to show password"
        End If
    End Sub

    Private Sub CreditCard_De_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreditCard_De.Click
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\ccrd.txt") = True Then
            Dim source As String = File.ReadAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\ccrd.txt")
            Dim decr As String = decry(source, key)
            CreditCard.Text = decr
        Else
            MsgBox("No data found", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    'Github
    Private Sub Github_En_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Github_En.Click

        If Not My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\") Then
            MkDir(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\")
        End If

        If File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\gth.txt") = False Or File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\gth.txt") = True Or Github.Text = Nothing Then
            Dim write As String = Github.Text
            Dim output As Byte() = encry(write, key)
            Dim con As String = Convert.ToBase64String(output)
            File.WriteAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\gth.txt", con)
            MsgBox("Text crypted and saved! Textbox is going to be deleted!", MsgBoxStyle.Information, "Saved")
            'svuota la textbox dopo aver salvato
            FB.Text = "Click decrypt to show password"
        End If
    End Sub

    Private Sub Github_De_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Github_De.Click
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\gth.txt") = True Then
            Dim source As String = File.ReadAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\gth.txt")
            Dim decr As String = decry(source, key)
            Github.Text = decr
        Else
            MsgBox("No data found", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    'Note
    Private Sub Note_En_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Note_En.Click

        If Not My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\") Then
            MkDir(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\")
        End If

        If File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\note.txt") = False Or File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\note.txt") = True Or Note.Text = Nothing Then
            Dim write As String = Note.Text
            Dim output As Byte() = encry(write, key)
            Dim con As String = Convert.ToBase64String(output)
            File.WriteAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\note.txt", con)
            MsgBox("Text crypted and saved! Textbox is going to be deleted!", MsgBoxStyle.Information, "Saved")
            'svuota la textbox dopo aver salvato
            FB.Text = "Click decrypt to show password"
        End If
    End Sub

    Private Sub Note_De_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Note_De.Click
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\note.txt") = True Then
            Dim source As String = File.ReadAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\note.txt")
            Dim decr As String = decry(source, key)
            Note.Text = decr
        Else
            MsgBox("No data found", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    'OTHER

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ChecktxtStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChecktxtStatusToolStripMenuItem.Click
        If My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\") = False Then
            MsgBox("Data not found: There arent informations that clould be decrypted", MsgBoxStyle.Information, "Data status")
        Else
            MsgBox("Data found: There are informations that clould be decrypted", MsgBoxStyle.Information, "Data status")
        End If
    End Sub


    Private Sub HelpAb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpAb.Click
        AboutHelp.Show()
    End Sub

    Private Sub Decrypter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\M3D5 Password Manager\") = False Then
            MsgBox("Data not found: There arent informations that clould be decrypted", MsgBoxStyle.Information, "Data status")
        Else
            MsgBox("Data found: There are informations that clould be decrypted", MsgBoxStyle.Information, "Data status")
        End If
    End Sub

    Private Function encode(ByVal key As String) As TripleDES
        Dim md5 As MD5 = New MD5CryptoServiceProvider
        Dim des As TripleDES = New TripleDESCryptoServiceProvider
        des.Key = md5.ComputeHash(Encoding.Unicode.GetBytes(key))
        des.IV = New Byte(((des.BlockSize / 8)) - 1) {}
        Return des
    End Function

    Private Function encry(value As String, key As String) As Byte()
        Dim des As TripleDES = encode(key)
        Dim encr As ICryptoTransform = des.CreateEncryptor
        Dim input() As Byte = Encoding.Unicode.GetBytes(value)
        Return encr.TransformFinalBlock(input, 0, input.Length)
    End Function

    Private Function decry(value As String, key As String) As String
        Dim by() As Byte = Convert.FromBase64String(value)
        Dim des As TripleDES = encode(key)
        Dim cry As ICryptoTransform = des.CreateDecryptor
        Dim output() As Byte = cry.TransformFinalBlock(by, 0, by.Length)
        Return Encoding.Unicode.GetString(output)
    End Function

    Private Sub Donate_Click(sender As Object, e As EventArgs) Handles Donate.Click
        Dim url As String = "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=P82RVZEYK4HEE"
        Process.Start(url)
    End Sub

    Private Sub Amazon_TextChanged(sender As Object, e As EventArgs) Handles Amazon.TextChanged

    End Sub
End Class