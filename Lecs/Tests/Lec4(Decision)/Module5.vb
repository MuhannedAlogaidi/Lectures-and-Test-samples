Module Module5
    Sub main()
        Dim selection As Char = Console.ReadKey.KeyChar
        While selection.ToString.ToUpper <> "L"
            selection = Console.ReadLine()
            Select Case selection
                Case "a"
                    Console.WriteLine("you love Moumen")
                Case "b"
                    Console.WriteLine("you love Mounes")
                Case "c"
                    Console.WriteLine("you love inaam")
                Case "d"
                    Console.WriteLine("you love don crist")
                Case Else
                    Console.WriteLine("You love nothing")
            End Select
        End While
      
        Console.ReadLine()
    End Sub
End Module
