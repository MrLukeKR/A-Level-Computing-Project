Module PriorityCalculations
    Sub PopulatePriorityQueue()
        ReDim PriorityQueue(0)
        Dim TempSize As Integer = 0
        Dim TempIndex As Integer = 0
        For count = 0 To Orders.Length - 1
            If Orders(count).Deadline >= Today And Orders(count).Completed = False Then
                TempSize += 1
            End If
        Next
        ReDim Preserve PriorityQueue(TempSize - 1)
        For count = 0 To Orders.Length - 1

            Orders(count).ETADays = DetermineCompletion(Orders(count))
            If Orders(count).Deadline >= Today And Orders(count).Completed = False Then
                PriorityQueue(TempIndex) = Orders(count)
                TempIndex += 1
            End If
        Next
    End Sub
    Sub SortPriorityQueue()
        Dim TempOrder As Order
        Dim DebugText As String = ""
        Dim DebugText2 As String = ""
        Dim ValidateCounter As Integer
        Dim DaySum1 As Double
        Dim DaySum2 As Double
        If PriorityQueue.Length > 1 Then
            Do
                For count = 0 To PriorityQueue.Length - 2
                    DebugText = DebugText & ", " & (DaysToDeadline(PriorityQueue(count)) - PriorityQueue(count).ETADays)
                    DaySum1 = (DaysToDeadline(PriorityQueue(count + 1)) - PriorityQueue(count).ETADays)
                    DaySum2 = (DaysToDeadline(PriorityQueue(count)) - PriorityQueue(count + 1).ETADays)
                    If DaySum1 < DaySum2 Then
                        TempOrder = PriorityQueue(count)
                        PriorityQueue(count) = PriorityQueue(count + 1)
                        PriorityQueue(count + 1) = TempOrder
                    Else
                        ValidateCounter += 1
                    End If
                Next
            Loop Until ValidateCounter > PriorityQueue.Length
        End If
        For count = 0 To PriorityQueue.Length - 2
            DebugText2 = DebugText2 & ", " & (DaysToDeadline(PriorityQueue(count)) - PriorityQueue(count).ETADays)
        Next
    End Sub
End Module
