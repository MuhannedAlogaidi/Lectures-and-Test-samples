Module parameters
    'Adding the Fourth Param as byRef is very important in order to use the (total param) as reference from the original function
    Function calculateAverageAndTotal(x As Integer,
                                      y As Integer,
                                      Optional z As Integer = -1,
                                      Optional ByRef total As Single = 0) As Double
        If z <> -1 Then
            total = x + y + z
            Return total / 3
        Else
            total = total
            Return x + y / 2
        End If
    End Function
    Sub main()
        Dim num1 As Integer
        Dim num2 As Integer
        Dim num3 As Integer
        Dim total As Single
        Console.SetWindowSize(80, 40)
        Console.Write("Please Enter the first number: ")
        num1 = Console.ReadLine()
        Console.Write("Please Enter the Second number: ")
        num2 = Console.ReadLine()
        Console.Write("Please Enter the Third number: ")
        num3 = Console.ReadLine()
        Console.WriteLine("Average= " & calculateAverageAndTotal(num1, num2, num3,total) & " The Total is: " & total)
        Console.ReadLine()
    End Sub
End Module
