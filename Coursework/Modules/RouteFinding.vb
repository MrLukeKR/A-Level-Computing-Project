Module RouteFinding
    Public EdgeCount As Integer
    Public PublicVisited() As Vertex
   
    Private VertexArrayLocation As Integer = 0 'Initialising all of the indexes
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
        Dim TempDestination As String = Nothing
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
        Dim RouteStack() As Vertex
        Dim Route(0) As Vertex
        Dim RootNode As Vertex
        Dim StringRoute As String = Nothing
        Dim ClosestNode As Vertex
        Dim NextVertex As Vertex
        Dim CurrentVertexDistance As Double
        Dim NextVertexDistance As Double
        Dim Found As Boolean = False
        Dim Count2 As Integer
        Dim ErrorShown As Boolean = False
        Dim LoopCounter As Integer = 0

        ReDim Visited(0)
        ReDim RouteStack(0)

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
                    If Map.Vertex(UpdateCount).Connections(UpdateCount2).Destination.Name <> Nothing Then
                        Map.Vertex(UpdateCount).Connections(UpdateCount2).Destination = FindVertex(Map, Map.Vertex(UpdateCount).Connections(UpdateCount2).Destination.Name)
                    ElseIf ErrorShown = False Or LoopCounter < 1 Then
                        MsgBox(Map.Vertex(UpdateCount).Name & " is an isolated node." & vbCr & "Due to the integrity of this process, warnings will not be suppressed until the nodes are no longer isolated." & vbCr & "Please contact an administrator to add pathways or delete the isolated nodes!", MsgBoxStyle.Critical, "Delivery Path Error")
                        ErrorShown = True
                        Exit For
                    End If
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

            ReDim Preserve Visited(Visited.Length)



            For count2 = 0 To RootNode.Connections.Length - 1
                NextVertex = FindVertex(Map, RootNode.Connections(count2).Destination.Name)
                CurrentVertexDistance = FindVertex(Map, RootNode.Name).DistanceToStart
                NextVertexDistance = FindVertex(Map, RootNode.Name).Connections(count2).Distance

                If (CurrentVertexDistance + NextVertexDistance) < NextVertex.DistanceToStart Then
                    NextVertex.DistanceToStart = CurrentVertexDistance + NextVertexDistance
                End If
                Map.Vertex(FindVertexIndex(Map, NextVertex)) = NextVertex 'Update original map
                If RootNode.Name = NextVertex.Name Then
                 Found = False
                    Exit Do
                End If
                If RootNode.Name.ToUpper = EndPoint.Name.ToUpper Then
                    Visited(Visited.Length - 1) = RootNode
                    PublicVisited = Visited
                    Found = True
                    Exit For

                End If

                'MsgBox(Map.Vertex(0).Name & ":" & Map.Vertex(0).DistanceToStart & vbCr & Map.Vertex(1).Name & ":" & Map.Vertex(1).DistanceToStart & vbCr & Map.Vertex(2).Name & ":" & Map.Vertex(2).DistanceToStart & vbCr & Map.Vertex(3).Name & ":" & Map.Vertex(3).DistanceToStart & vbCr & Map.Vertex(4).Name & ":" & Map.Vertex(4).DistanceToStart & vbCr & Map.Vertex(5).Name & ":" & Map.Vertex(5).DistanceToStart & vbCr & Map.Vertex(6).Name & ":" & Map.Vertex(6).DistanceToStart & vbCr & Map.Vertex(7).Name & ":" & Map.Vertex(7).DistanceToStart & vbCr & Map.Vertex(8).Name & ":" & Map.Vertex(8).DistanceToStart)
            Next
            LoopCounter = 1
        Loop Until Visited.Length >= Map.Vertex.Length + 1 Or Found = True
        If Found = True Then
            Dim TempVertex As Vertex
            ReDim Preserve Visited(Visited.Length - 2)
            For count = 0 To Visited.Length - 1
                TempVertex = FindVertex(Map, Visited(count).Name)
                TempVertex.VisitedIndex = count + 1
            Next

            Dim PreviousVertex As Vertex = EndPoint
            RootNode = Map.Vertex(FindVertexIndex(Map, EndPoint))
            RouteStack(0) = RootNode
            ReDim Preserve RouteStack(RouteStack.Length)
            Do
                Count2 = 0
                For Count2 = 0 To RootNode.Connections.Length - 1
                    If RootNode.Connections(Count2).Distance = RootNode.DistanceToStart - RootNode.Connections(Count2).Destination.DistanceToStart Then

                        RouteStack(RouteStack.Length - 1) = FindVertex(Map, RootNode.Connections(Count2).Destination.Name)
                        ReDim Preserve RouteStack(RouteStack.Length)
                        PreviousVertex = RootNode
                        RootNode = FindVertex(Map, RootNode.Connections(Count2).Destination.Name)
                        Exit For

                    End If

                Next
            Loop Until RootNode.Name = StartPoint.Name
            ReDim Preserve RouteStack(RouteStack.Length - 2)
            ReDim Route(0)
            For count = RouteStack.Length - 1 To 0 Step -1
                Route(Route.Length - 1) = RouteStack(count)
                ReDim Preserve Route(Route.Length)
            Next
            ReDim Preserve Route(Route.Length - 2)
            For count = 0 To Route.Length - 1
                StringRoute = StringRoute & "" & Route(count).Name
            Next

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
        Else
            Return Nothing
        End If
    End Function
    Function FindVertexIndex(ByVal Map As Graph, ByVal Vertex As Vertex)
        For count = 0 To Map.Vertex.Length - 1
            If Map.Vertex(count).Name = Vertex.Name Then
                Return count
            End If
        Next
    End Function
    Sub DeleteVertex(ByVal Map As Graph, ByVal Vertex As Vertex)
        Dim Index As Integer
        For count = 0 To Map.Vertex.Length - 1
            If Map.Vertex(count).Name = Vertex.Name Then
                Index = count
                Exit For
            End If
        Next
        For count = Index To Map.Vertex.Length - 2
            Map.Vertex(count) = Map.Vertex(count + 1)
        Next
        ReDim Map.Vertex(Map.Vertex.Length - 2)
        SaveMap(Map, MapDirectory)

    End Sub
End Module
