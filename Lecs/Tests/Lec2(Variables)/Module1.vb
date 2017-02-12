Module Module2
    Sub main()
        'Change the background color.....
        Console.BackgroundColor = ConsoleColor.Blue
        'Transfer the above command to show it on entire page....
        Console.Clear()
        'Change the window size.....
        Console.SetWindowSize(80, 30)
        Console.WriteLine("KUS")
        Console.ReadLine()
        'Declare a variable....
        Dim x As Integer = 9
        Dim y As Integer = 20
        Console.WriteLine("summation value of x =" & x + y)
        Console.WriteLine("multiplication value of x =" & x * y)
        Console.WriteLine("Modulus value of x =" & x Mod y)
        Console.WriteLine("Power value of x =" & x ^ y)
        Console.ReadLine()

    End Sub

End Module
