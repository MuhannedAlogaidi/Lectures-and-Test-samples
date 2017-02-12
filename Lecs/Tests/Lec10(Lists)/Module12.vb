Module Module12
    Sub main()
        Console.SetWindowSize(80, 40)
        'Declare the list
        'You can Also use the benefit of ArrayList() which you can identify more than 1 type of data inside the list.
        Dim list As New List(Of Integer)
        Dim num As Integer = -1
        Console.WriteLine("If you want to stop adding numbers to your list hit 0")
        While num <> 0
            'Let User add numbers to the list
            Console.Write("Please add your number to the list: ")
            num = Console.ReadLine()
            If num <> 0 Then
                list.Add(num)
            End If
        End While
        'Using List Class functionality
        Console.WriteLine("The total number of elements of the list is: " & list.Count)
        Console.WriteLine("The first element is: " & list(0))
        Console.WriteLine("The last element is: " & list(list.Count - 1))
        Console.WriteLine("The Minimum number is: " & list.Min)
        Console.WriteLine("The Maximum number is: " & list.Max)
        Console.WriteLine("The Capacity of the List is: " & list.Capacity)
        Console.WriteLine("The Average number is: " & list.Average)

        Console.ReadLine()
    End Sub
End Module
