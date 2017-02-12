Module RoomGame
    Class room
        Public name As String
        Public description As String
        Sub New(name As String, description As String)
            Me.name = name
            Me.description = description
        End Sub
    End Class
    Dim room1(9, 9) As room
    Dim playerX As Integer = 0
    Dim playerY As Integer = 0
    Dim RunningGame As Boolean = True

    Sub createRooms()

        For i = 0 To 9
            For j = 0 To 9
                room1(i, j) = New room("Room " & i + j * 10 + 1, "You are standing in Room " & i + j)
            Next
        Next
    End Sub
    Sub drawRoom()
        Console.WriteLine("you are currently standing in room " & room1(playerX, playerX).name)
        Console.WriteLine()
        Console.WriteLine("you are you in " & room1(playerX, playerY).description)
    End Sub
    Sub moveRoom()
        Dim direction As String
        Console.Write("Where you want to move ")
        direction = Console.ReadLine.ToUpper
        Console.ReadLine()
        Select Case direction.ToString.ToUpper
            Case "UP"
                playerY -= 1
            Case "DOWN"
                playerY += 1
            Case "LEFT"
                playerX -= 1
            Case "RIGHT"
                playerX += 1
            Case Else
                RunningGame = False
        End Select
    End Sub
    Sub main()
        Console.SetWindowSize(80, 40)
        createRooms()

        While RunningGame = True
            drawRoom()
            moveRoom()

        End While
        Console.ReadLine()
    End Sub
End Module
