
Module Module4

    ''''using 3 colon before the Method you would get the summary of comments below....REALlY POWERFUL!!!!.

    ''' <summary>
    ''' that one is really perfect
    ''' </summary>
    ''' <remarks></remarks>
    Sub main()

mounes:
        Console.SetWindowSize(80, 40)
        Console.Write("the mark is : ")
        Dim mark As Integer = Console.ReadLine()
        'Using if statement for mark
        'check 0-49 "Fail"
        'check 50-64 "Pass"
        'check 65-74 "Credit"
        'check 75-84 "Distinction"
        'check 85-100 "High distinction"
        If mark >= 0 And mark <= 49 Then
            Console.WriteLine("Fail")
        ElseIf mark >= 50 And mark <= 64 Then
            Console.WriteLine("Pass")
        ElseIf mark >= 65 And mark <= 74 Then
            Console.WriteLine("Credit")
        ElseIf mark >= 75 And mark <= 84 Then
            Console.WriteLine("Distinction")
        ElseIf mark >= 85 And mark <= 100 Then
            Console.WriteLine("high Distinction")
        Else
            Console.WriteLine("INVALID Mark")


        End If
        Console.ReadLine()
        GoTo mounes

    End Sub


End Module
