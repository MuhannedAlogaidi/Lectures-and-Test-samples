Module Module7
    Sub main()
        Console.SetWindowSize(80, 40)
        Dim selection As Char
        While selection.ToString.ToUpper <> "D"
            Console.WriteLine("Select a choice from the follow")
            Console.WriteLine("(A) Apple")
            Console.WriteLine("(B) Banana")
            Console.WriteLine("(C) Carrots")
            Console.WriteLine("(D) Quit")
            Console.WriteLine("Choice is : ")
            selection = Console.ReadKey.KeyChar
            Console.WriteLine()
            Select Case selection.ToString.ToUpper
                Case "A"
                    Console.WriteLine("You Love Apple")
                Case "B"
                    Console.WriteLine("You love banana")
                Case "C"
                    Console.WriteLine("You love Carrots")
                Case Is <> "D"
                    Console.WriteLine("You don't love food")

            End Select
        End While
        Console.ReadLine()
    End Sub

End Module
