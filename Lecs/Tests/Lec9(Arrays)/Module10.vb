Module Module10
    Sub main()
        Console.SetWindowSize(80, 40)
        Dim num(9) As Integer
        For i = 0 To 9
            Console.Write("Please enter you Number: ")
            num(i) = Console.ReadLine()
        Next
        'Sorting array....
        Array.Sort(num)
        For Each elm As Integer In num
            Console.WriteLine("Items in the array are sorted asc" & elm.ToString)

        Next
        Console.ReadLine()
    End Sub
End Module
