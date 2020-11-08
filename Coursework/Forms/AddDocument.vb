Public Class AddDocument
    Dim TempDocument As Document
    Private Sub AddDocument_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TbxDocumentName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxDocumentName.TextChanged
        TempDocument.DocumentName = AntiSQLInjection(TbxDocumentName.Text)
    End Sub

    Private Sub BtnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBrowse.Click
        OpenFileDialog.ShowDialog()
        TbxDocumentDirectory.Text = OpenFileDialog.FileName.ToString
    End Sub

    Private Sub TbxDocumentDirectory_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxDocumentDirectory.TextChanged
        TempDocument.DocumentDirectory = TbxDocumentDirectory.Text
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnAddDocument_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddDocument.Click
        If TbxDocumentDirectory.Text <> Nothing And TbxDocumentName.Text <> Nothing Then
            DatabaseHandling.AddDocument(TempDocument)
            MainMenu.LoadAll()
            Me.Close()
        Else
            MsgBox("There was an error with your input!", MsgBoxStyle.Exclamation, "Incorrect Entry")
        End If
       
    End Sub

End Class