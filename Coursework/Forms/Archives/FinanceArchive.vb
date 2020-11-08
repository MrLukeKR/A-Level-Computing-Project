Public Class FinanceArchive

    Private Sub FinanceArchive_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DgvFinanceArchive.DataSource = DataSetVar.Tables("Finances")
    End Sub
End Class