Imports System.Security.Cryptography
Public Class AdminRightsForm

    Private Sub ExitClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxPassword.TextChanged
        CheckInput()
    End Sub
    Sub CheckInput()
        If TbxPassword.Text = "" Then
            BtnLogin.Enabled = False
        Else
            BtnLogin.Enabled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CheckInput()
    End Sub

    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click
        VerifyCredentials(TbxPassword.Text)
    End Sub

    Sub VerifyCredentials(ByVal Password As String)
        Dim TempPassword As String

        TempPassword = TbxPassword.Text
        If Encrypt(TempPassword) = AdminEncryptedPassword Then
            Variables.IsAdmin = True
            MainMenu.GbxAdminPanel.Enabled = True
            MainMenu.LblUsername.Text = "ADMINISTRATOR"
            MainMenu.LblUsername.ForeColor = Drawing.Color.Red
            MainMenu.TsbLogoutAdmin.Enabled = True
            MainMenu.TsbLogoutAdmin.Visible = True
            MainMenu.TsbChangePassword.Enabled = True
            MainMenu.TsbChangePassword.Visible = True
            Me.Close()
        Else
            Variables.IsAdmin = False
            MsgBox("Password was incorrect.", MsgBoxStyle.Exclamation, "Access Denied")
        End If





    End Sub




    Private Sub AdminRightsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class