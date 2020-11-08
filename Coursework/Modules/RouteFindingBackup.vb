Module RouteFinding
    Public EdgeCount As Integer
    Public PublicVisited() As Vertex
   
    Private VertexArrayLocation As Integer = 0 ' Initialising all of the indexes
    Private EdgeArrayLocation As Integer = 0

    Public Sub ResetArrayCounters() 'Returns all indexes to zero
        VertexArrayLocation = 0
        EdgeArrayLocation = 0
    End Sub
    Public Sub AddVertex(ByRef Map As Graph, ByVal Name As String) 'Adds a new location to the map (graph structure)
        ReDim Preserve Map.Vertex(VertexArrayLocation) 'Increases the array of locations' size to the size of the index, whilst keeping all previous contents
        ReDim Map.Vertex(VertexArrayLocation).Connections(0) 'Initialise the connections array
        Map.Vertex(VertexArrayLocation).Index = 0
        Map.Vertex(VertexArrayLocation).Name = Name 'Adds the entered location to the map (graph structure)
        VertexArrayLocation += 1 'Increases the index by 1
    End Sub
    Public Sub AddEdge(ByRef Map As Graph, ByRef StartLocationIndex As Integer, ByRef EndLocationIndex As Integer, ByVal Distance As Double) 'FIX THIS ASAP!!! Map is unused which is why nothing is saved!!! Set it to use map, not locations
        ReDim Preserve Map.Vertex(StartLocationIndex).Connections(Map.Vertex(StartLocationIndex).Index)
        Dim AddConnection As Edge = New Edge
        AddConnection.Destination = Map.Vertex(EndLocationIndex)
        AddConnection.Distance = Distance
        Map.Vertex(StartLocationIndex).Connections(Map.Vertex(StartLocationIndex).Index) = AddConnection
        Map.Vertex(StartLocationIndex).Index += 1
        EdgeCount = EdgeCount + 1
    End Sub
    Sub InitialiseMap(ByRef Map As Graph, ByVal MapFileDirectory As String)
        Dim TempDistance As String = ""
        Dim TempLine As String = ""
        Dim TempVertexIndex As Integer
        Dim TempDestination As String
        ReDim Map.Vertex(0)
        VertexArrayLocation = 0
        EdgeArrayLocation = 0
        MainMenu.TssLoadingStatus.Text = "Initialising map"
        FileOpen(1, MapFileDirectory, OpenMode.Input)
        Do
            TempLine = LineInput(1)
            If TempLine = "/// START OF VERTICES \\\" Or TempLine = "\\\ END OF VERTICES ///" Then
            Else
                AddVertex(Map, TempLine)
            End If
        Loop Until TempLine = "\\\ END OF VERTICES ///"

        Do
            TempLine = LineInput(1)
            If TempLine = "/// START OF CONNECTIONS \\\" Or TempLine = "\\\ END OF CONNECTIONS ///" Then
            Else
                If Mid(TempLine, 1, 1) = "$" Then
                    TempVertexIndex = FindIndex(Map, Mid(TempLine, 2, TempLine.Length - 1))
                End If

                If Mid(TempLine, 1, 1) = "!" Then
                    TempDestination = Mid(TempLine, 2, TempLine.Length - 1)
                End If
                If Mid(TempLine, 1, 1) = "#" Then
                    AddEdge(Map, TempVertexIndex, FindIndex(Map, TempDestination), Mid(TempLine, 2, TempLine.Length - 1))
                End If
            End If

        Loop Until TempLine = "\\\ END OF CONNECTIONS ///"

        FileClose(1)

    End Sub
    Function FindVertex(ByVal Map As Graph, ByVal VertexName As String) As Vertex
        Dim Counter As Integer
        Dim VertexFound As Vertex = Nothing
        Counter = -1
        Do
            Counter += 1
            If Trim(Map.Vertex(Counter).Name.ToUpper) = Trim(VertexName.ToUpper) Then
                VertexFound = Map.Vertex(Counter)
            End If

        Loop Until Counter = Map.Vertex.Length - 1 Or Trim(Map.Vertex(Counter).Name.ToUpper) = Trim(VertexName.ToUpper)
        Return VertexFound
    End Function
    Function FindIndex(ByVal Map As Graph, ByVal VertexName As String) As Integer
        Dim Counter As Integer
        Dim VertexIndex As Integer
        Counter = -1
        Do
            Counter += 1
            If Trim(Map.Vertex(Counter).Name.ToUpper) = Trim(VertexName.ToUpper) Then
                VertexIndex = Counter
            End If

        Loop Until Counter = Map.Vertex.Length - 1 Or Trim(Map.Vertex(Counter).Name.ToUpper) = Trim(VertexName.ToUpper)
        Return VertexIndex
    End Function
    Sub SaveMap(ByRef Map As Graph, ByVal MapFileDirectory As String)
        Dim TempDistance As String = ""
        Dim TempLine As String = ""

        FileOpen(1, MapFileDirectory, OpenMode.Output)
        PrintLine(1, "/// START OF VERTICES \\\")
        For counter = 0 To Map.Vertex.Length - 1
            PrintLine(1, Map.Vertex(counter).Name)
        Next
        PrintLine(1, "\\\ END OF VERTICES ///")
        PrintLine(1, "/// START OF CONNECTIONS \\\")
        For Counter = 0 To Map.Vertex.Length - 1
            PrintLine(1, "$" & Map.Vertex(Counter).Name) ' Start vertex
            For Counter2 = 0 To Map.Vertex(Counter).Connections.Length - 1
                PrintLine(1, "!" & Map.Vertex(Counter).Connections(Counter2).Destination.Name) ' End Vertex
                PrintLine(1, "#" & Map.Vertex(Counter).Connections(Counter2).Distance) ' Distance
            Next
        Next
        PrintLine(1, "\\\ END OF CONNECTIONS ///")

        FileClose(1)
        MsgBox("Map was saved to " & MapFileDirectory, MsgBoxStyle.OkOnly, "Save Successful")
    End Sub
    Function Dijkstra(ByVal Map As Graph, ByVal StartPoint As Vertex, ByVal EndPoint As Vertex, ByVal ReturnDistance As Boolean)
        Dim Visited() As Vertex '
        Dim RootNode As Vertex
        Dim StringRoute As String
        Dim ClosestNode As Vertex
        Dim NextVertex As Vertex
        Dim CurrentVertexDistance As Double
        Dim NextVertexDistance As Double
        Dim Route() As Vertex
        ReDim Visited(0)
        ReDim Route(0)

        RootNode = Nothing
        ClosestNode = Nothing
        For count = 0 To Map.Vertex.Length - 1 '
            If Map.Vertex(count).Name = StartPoint.Name Then '
                Map.Vertex(count).DistanceToStart = 0 '
                RootNode = Map.Vertex(count)
            Else '
                Map.Vertex(count).DistanceToStart = Double.PositiveInfinity '
            End If '
            Map.Vertex(count).Visited = False '
        Next '


        Do
           
            ClosestNode.DistanceToStart = Double.PositiveInfinity
            For UpdateCount = 0 To Map.Vertex.Length - 1 'Update all connections to be the same as the root equivalents (not just copies)
                Map.Vertex(UpdateCount) = FindVertex(Map, Map.Vertex(UpdateCount).Name)
                For UpdateCount2 = 0 To Map.Vertex(UpdateCount).Connections.Length - 1
                    Map.Vertex(UpdateCount).Connections(UpdateCount2).Destination = FindVertex(Map, Map.Vertex(UpdateCount).Connections(UpdateCount2).Destination.Name)
                Next
            Next
            For count2 = 0 To Map.Vertex.Length - 1 'Find the next node to visit
                If (Map.Vertex(count2).DistanceToStart < ClosestNode.DistanceToStart) And (Map.Vertex(count2).Visited = False) Then
                    RootNode = Map.Vertex(count2)
                    ClosestNode = RootNode
                End If
            Next
            RootNode.Visited = True
            Map.Vertex(FindVertexIndex(Map, RootNode)).Visited = True
            Visited(Visited.Length - 1) = RootNode
            Route(Route.Length - 1) = RootNode
            ReDim Preserve Route(Route.Length)
            ReDim Preserve Visited(Visited.Length)



            For count2 = 0 To RootNode.Connections.Length - 1
                NextVertex = FindVertex(Map, RootNode.Connections(count2).Destination.Name)
                CurrentVertexDistance = FindVertex(Map, RootNode.Name).DistanceToStart
                NextVertexDistance = FindVertex(Map, RootNode.Name).Connections(count2).Distance

                If (CurrentVertexDistance + NextVertexDistance) < NextVertex.DistanceToStart Then
                    NextVertex.DistanceToStart = CurrentVertexDistance + NextVertexDistance

                End If
                If RootNode.Name = NextVertex.Name Then
                    Exit For
                End If
                Map.Vertex(FindVertexIndex(Map, NextVertex)) = NextVertex 'Update original map
                'MsgBox(Map.Vertex(0).Name & ":" & Map.Vertex(0).DistanceToStart & vbCr & Map.Vertex(1).Name & ":" & Map.Vertex(1).DistanceToStart & vbCr & Map.Vertex(2).Name & ":" & Map.Vertex(2).DistanceToStart & vbCr & Map.Vertex(3).Name & ":" & Map.Vertex(3).DistanceToStart & vbCr & Map.Vertex(4).Name & ":" & Map.Vertex(4).DistanceToStart & vbCr & Map.Vertex(5).Name & ":" & Map.Vertex(5).DistanceToStart & vbCr & Map.Vertex(6).Name & ":" & Map.Vertex(6).DistanceToStart & vbCr & Map.Vertex(7).Name & ":" & Map.Vertex(7).DistanceToStart & vbCr & Map.Vertex(8).Name & ":" & Map.Vertex(8).DistanceToStart)
            Next
        Loop Until Visited.Length = Map.Vertex.Length

        For count = 0 To Route.Length - 1
            StringRoute = StringRoute & "" & Route(count).Name
        Next
        Visited(Visited.Length - 1) = RootNode
        PublicVisited = Visited
        ReDim Preserve PublicVisited(PublicVisited.Length - 2)
        If ReturnDistance = True Then
            For count = 0 To Map.Vertex.Length - 1
                If Map.Vertex(count).Name = EndPoint.Name Then
                    Return Map.Vertex(count).DistanceToStart
                End If
            Next
        Else
            Return Route
        End If

    End Function 'CALCULATES DISTANCES BUT NEEDS ROUTE RECORDING
    Function FindVertexIndex(ByVal Map As Graph, ByVal Vertex As Vertex)
        For count = 0 To Map.Vertex.Length - 1
            If Map.Vertex(count).Name = Vertex.Name Then
                Return count
            End If
        Next
    End Function
End Module
