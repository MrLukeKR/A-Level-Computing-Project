Public Class OrderArchive

    Private Sub OrderArchive_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DgvOrderArchive.DataSource = DataSetVar.Tables("Orders")
    End Sub
End Class