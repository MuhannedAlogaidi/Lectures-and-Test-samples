Module parametersArray
    'Define num() array as paramenter for the function.
    Function calculateAverageAndTotals(num() As Single, Optional ByRef total As Single = 0)
        'Make loop for every sinle item in that array to add the number to the total.
        For i = 0 To num.Length - 1
            total += i
        Next
        If total <> 0 Then
            Return total / 3
        Else
            Return total / 2
        End If
    End Function
    Sub main()
        'Declare the list and add number to it to provide the array parameter in the function.
        Dim arr As New List(Of Single)
        Dim item As Single
        Dim total As Single
        Console.SetWindowSize(80, 40)
        'A tricky way to add an infinite loop.
        Do
            Console.Write("Please Enter item number: ")
            item = Console.ReadLine
            arr.Add(item)
        Loop Until item = 0
        Console.WriteLine("the average of your numbers is: " & calculateAverageAndTotals(arr.ToArray, total) & " And Total is: " & total)
        Console.ReadLine()

    End Sub
End Module
