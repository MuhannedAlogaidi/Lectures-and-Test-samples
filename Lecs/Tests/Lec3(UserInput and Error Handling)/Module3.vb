Module Module3
    Sub main()
        Console.SetWindowSize(90, 40)
        Dim input As String
        'To remember the input variable at the console.
        input = Console.ReadLine()
        Console.WriteLine(input)
        Console.BackgroundColor = ConsoleColor.Blue
        Console.ReadLine()
        Console.Clear()
        'test declaring 2 variables and get the operators numbers with the console....
        Dim x As Integer
        Dim y As Integer
        'Using console.write to keep the user input into the same line unlike console.writeline() which led to another line..
        Try
            Console.Write("Please enter the value of x : ")
            x = Console.ReadLine
            Console.Write("Please enter the value of y : ")
            y = Console.ReadLine
            Console.WriteLine("the sum operation is : " & x + y)
            Console.ReadLine()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Console.ReadLine()
        End Try

        another()

    End Sub
    Sub another()
        Dim c As Char
        Console.Write("Please press a char : ")
        'The powerful command below is to help you jump to the result without hitting enter.
        c = Console.ReadKey.KeyChar

        Console.WriteLine("You pressed " & c)
        Console.ReadLine()
    End Sub

End Module
