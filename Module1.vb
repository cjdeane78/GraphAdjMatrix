Module Module1

    Sub Main()
        Dim AM As Integer(,) =
            {
            {0, 1, 0, 0, 0, 0},
            {1, 0, 0, 1, 0, 0},
            {0, 0, 0, 0, 0, 1},
            {0, 1, 0, 0, 1, 0},
            {0, 0, 0, 1, 0, 0},
            {0, 0, 1, 0, 0, 0}
            }

        For i = 0 To 5
            For j = 0 To 5
                If AM(i, j) = 1 Then
                    Console.WriteLine("Connection betweeen " & i + 1 & " and " & j + 1)
                End If
            Next
        Next

        Console.ReadLine()
    End Sub

End Module
