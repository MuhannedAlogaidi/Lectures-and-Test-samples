Module multidimentionalArrays
    Sub main()
        Console.SetWindowSize(80, 20)
        Dim months() As String = {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"}
        For i As Integer = 0 To months.Count - 1
            Console.WriteLine("(" & i + 1 & ")" & months(i))
        Next
        Console.ReadLine()
        'using multi dimensional array become very handy.
        'Consider that you have 5 studends and every one of them has 3 tests per year so working on multi dimensional array come on.
        Dim mark(5, 3) As Integer
        mark(0, 0) = 10 ' first student first test he got 10/10
        mark(0, 1) = 8
        mark(0, 2) = 9

        'Let us start drawing 2 Dimentional Array into the screen.
        'First Identify the 2D Array.
        Dim number(9, 9) As Integer

        'Fill The Array with Values.
        'GetUpperBound illustrate which dimension you want, without it .. i mean (number.length-1) will loop thourgh 100 numbers
        For i = 0 To number.GetUpperBound(0)
            For j = 0 To number.GetUpperBound(1)
                number(i, j) = i - j
            Next
        Next

        'Loop Through items to get the array numbers.
        For x = 0 To number.GetUpperBound(0)
            For y = 0 To number.GetUpperBound(1)
                Console.Write("{0,-2}", number(x, y))

            Next
            Console.WriteLine()
        Next
        Console.Read()

    End Sub

    Sub Mounes()
        For i = 1 To 10

        Next
    End Sub
End Module
