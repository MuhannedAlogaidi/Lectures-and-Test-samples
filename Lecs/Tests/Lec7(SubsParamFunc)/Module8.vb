Module Module8
    Sub main()
        Menu()
        Console.ReadLine()
    End Sub
    Dim x As Integer
    Dim y As Integer
    Sub menu()
        Dim selection As Char
        Console.SetWindowSize(80, 40)
        Console.Write("Give the value of x: ")
        x = Console.ReadLine()
        Console.Write("Give the value of y: ")
        y = Console.ReadLine()
        While selection.ToString.ToUpper <> "E"
            Console.WriteLine("Choose one of the below operations: ")
            Console.WriteLine("(A) Addition")
            Console.WriteLine("(B) Subtraction")
            Console.WriteLine("(C) Multiplication")
            Console.WriteLine("(D) Division")
            Console.WriteLine("(E) Quit")

            selection = Console.ReadKey.KeyChar
            Console.WriteLine()
            Select Case selection.ToString.ToUpper
                Case "A"
                    addition()
                Case "B"
                    subtraction()
                Case "C"
                    multiplication()
                Case "D"
                    division()
                Case "T"
                    addition()
                    subtraction()
                    multiplication()
                    division()

                Case Is <> "E"
                    Console.WriteLine("You didn't choose a good aggregation method")
                Case Else
                    Console.Read()

            End Select
        End While

    End Sub
    Sub addition()
        Dim z As Integer = x + y
        Console.WriteLine("Addition result is: " & z)
    End Sub
    Sub subtraction()
        Dim z As Integer = x - y
        Console.WriteLine("Subtraction result is: " & z)
    End Sub
    Sub multiplication()
        Dim z As Integer = x * y
        Console.WriteLine("Subtraction result is: " & z)
    End Sub
    Sub division()
        Try
            Dim z As Integer = x / y
            Console.WriteLine("Subtraction result is: " & z)
        Catch ex As Exception
            Console.WriteLine("Error Division by Zero")
        End Try
        
    End Sub
End Module
