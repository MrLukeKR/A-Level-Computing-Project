Public Class DeleteDocument
    Dim TempDocument As Document
    Private Sub LbxSelectDocument_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbxSelectDocument.SelectedIndexChanged
        Try
            TempDocument = FindDocumentByName(LbxSelectDocument.SelectedItem)
        Catch er As Exception
            MsgBox("Selection cannot be empty!", MsgBoxStyle.Exclamation, "Document Error")
        End Try
    End Sub

    Private Sub BtnDeleteCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteDocument.Click
        DatabaseHandling.DeleteDocument(TempDocument)
        MainMenu.LoadAll()
        Me.Close()
    End Sub

    Private Sub TbxConfirmDeletion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxConfirmDeletion.TextChanged
        If TbxConfirmDeletion.Text = "CREATEABAKE" Then
            BtnDeleteDocument.Enabled = True
        Else
            BtnDeleteDocument.Enabled = False
        End If
    End Sub

    Private Sub BtnSearchDocument_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearchDocument.Click
        LbxSelectDocument.Items.Clear()
        For Count = 0 To Documents.Length - 1
            If Documents(Count).DocumentName.ToUpper = Trim(TbxNameSearch.Text.ToUpper) Then
                LbxSelectDocument.Items.Add(Documents(Count).DocumentName)
            End If
        Next
    End Sub
End Class