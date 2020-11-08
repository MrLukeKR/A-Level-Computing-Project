Public Class Edit_Map

    Dim TempComboIndex As Integer
    Dim TempComboIndex2 As Integer
    Public SelectedStart As String
    Public SelectedEnd As String
    Dim Deleted As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "Createabake Map Files|.cbm"
        OpenFileDialog1.ShowDialog()
        TbxMapDirectory.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        OpenFileDialog1.ShowDialog()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        OpenFileDialog1.ShowDialog()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        OpenFileDialog1.ShowDialog()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RouteFinding.InitialiseMap(Map, TbxMapDirectory.Text)
        If Map.Vertex(0).Name = "" And Map.Vertex.Length = 1 Then
            LblLocationCount.Text = 0
        Else
            LblLocationCount.Text = Map.Vertex.Length
        End If

        UpdateDataGrid()
        UpdateLocationSelections()
        RtbInformation.AppendText("Map loaded" & vbCr)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        RouteFinding.SaveMap(Map, TbxMapDirectory.Text)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        AddVertex(Map, TbxAddLocation.Text)
        UpdateLocationSelections()
    End Sub
    Sub UpdateLocationSelections()
        Try
            LblLocationCount.Text = Map.Vertex.Length
            LblEdgeCount.Text = RouteFinding.EdgeCount
        Catch e As Exception
        End Try

        CbxEndLocation.Items.Clear()
        CbxStartLocation.Items.Clear()
        For counter = 0 To Map.Vertex.Length - 1
            CbxStartLocation.Items.Add(Map.Vertex(counter).Name)
            CbxEndLocation.Items.Add(Map.Vertex(counter).Name)
        Next
    End Sub
    Private Sub Edit_Map_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TbxMapDirectory.Text = MapDirectory
        Try
            CheckMapFile()
            UpdateDataGrid()
            UpdateLocationSelections()
        Catch err As Exception
            MsgBox("Map manipulation tools could not be loaded:" & vbCr & err.Message & vbCr & "Please use another map file, or select 'Create New Map'", MsgBoxStyle.Exclamation, "Map Unavailable")
        End Try
    End Sub

    Private Sub AddEdge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddEdge.Click
        Dim StartV As Integer = FindIndex(Map, SelectedStart)
        Dim EndV As Integer = FindIndex(Map, SelectedEnd)

        AddEdge(Map, StartV, EndV, CDbl(NudDistance.Value.ToString))
        UpdateDataGrid()
        UpdateLocationSelections()
    End Sub

    Sub UpdateDataGrid()
        DvwEdges.Rows.Clear()
        For counter = 0 To Map.Vertex.Length - 1
            For counter2 = 0 To Map.Vertex(counter).Connections.Length - 1
                Dim DataRow As String() = New String() {Map.Vertex(counter).Name, Map.Vertex(counter).Connections(counter2).Destination.Name, Map.Vertex(counter).Connections(counter2).Distance}
                DvwEdges.Rows.Add(DataRow)
            Next
        Next
    End Sub

    Private Sub TbxMapDirectory_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxMapDirectory.TextChanged
        CheckMapFile()
    End Sub
    Sub CheckMapFile()
        If TbxMapDirectory.Text = "" Then

            BtnSave.Enabled = False
            RtbInformation.AppendText("Select a map file to save and load map data." & vbCr)
        Else

            BtnSave.Enabled = True
        End If
    End Sub


    Private Sub CbxStartLocation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbxStartLocation.SelectedIndexChanged
        VerifyEdge()
        SelectedStart = CbxStartLocation.SelectedItem.ToString
    End Sub

    Private Sub CbxEndLocation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbxEndLocation.SelectedIndexChanged
        VerifyEdge()
        SelectedEnd = CbxEndLocation.SelectedItem.ToString
    End Sub
    Sub VerifyEdge()
        If CbxStartLocation.SelectedItem = CbxEndLocation.SelectedItem Then
            MsgBox("Cannot have a road to the same location!", MsgBoxStyle.Exclamation, "Error")
            RtbInformation.AppendText("You cannot connect a location to itself, please select another destination." & vbCr)
            BtnAddEdge.Enabled = False
        Else
            BtnAddEdge.Enabled = True
        End If

    End Sub

   

    Private Sub BtnSaveMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MapDirectory = TbxMapDirectory.Text
        SetupWizard.SaveSettings()
        MainMenu.LoadAll()
        DvwEdges.Refresh()
    End Sub

    Private Sub TbxAddLocation_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxAddLocation.TextChanged
        TbxAddLocation.Text = AntiSQLInjection(TbxAddLocation.Text)
    End Sub

    Private Sub DvwEdges_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DvwEdges.CellContentClick

    End Sub

    Private Sub DvwEdges_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DvwEdges.CellValueChanged
    End Sub

    Private Sub BtnDeleteIsolatedNodes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteIsolatedNodes.Click
        For DeleteCount = 0 To Map.Vertex.Length - 1
            For DeleteCount2 = 0 To Map.Vertex(DeleteCount).Connections.Length - 1
                If Map.Vertex(DeleteCount).Connections(DeleteCount2).Destination.Name = Nothing Then
                    DeleteVertex(Map, FindVertex(Map, Map.Vertex(DeleteCount).Name))
                    Deleted += 1
                    Exit For
                End If
            Next
        Next
        MsgBox(Deleted & " isolated nodes were deleted!", MsgBoxStyle.Information, "Isolation Purge Complete")
    End Sub

    
    Private Sub BtnSaveMap_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLoadMap.Click
        MapDirectory = TbxMapDirectory.Text

        Try
            InitialiseMap(Map, MapDirectory)
        Catch err As Exception
            MsgBox(err.Message)
        End Try
    End Sub
End Class
