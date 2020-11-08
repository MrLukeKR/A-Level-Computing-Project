Public Class ChangePassword

    Private Sub TbxPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxOldPassword.TextChanged

    End Sub

    Private Sub BtnChangePassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnChangePassword.Click
        If Encrypt(TbxOldPassword.Text) = AdminEncryptedPassword Then
            If TbxNewPassword.Text = TbxConfirmPassword.Text Then
                AdminEncryptedPassword = Encrypt(TbxNewPassword.Text)
                SetupWizard.SaveSettings()
                Me.Close()
            Else
                MsgBox("New passwords do not match!", MsgBoxStyle.Exclamation, "Incorrect Password")
            End If
        Else
            MsgBox("The current password you have entered is incorrect.", MsgBoxStyle.Exclamation, "Incorrect Password")
        End If

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class