Module Module1

    Sub Main()
        'To set the window size of the console use this...
        Console.SetWindowSize(80, 30)
        'To set the window position of the console use this....
        Console.SetWindowPosition(80, 90)
        'the below command is with span symbol which means is a Property and it must have a (=) sign after it
        Console.BackgroundColor = ConsoleColor.Green
        'The below command would change the entire background color
        Console.Clear()
        'First command is to set the cursor for the console... extremly new....
        'the below command is a cubic symbol which means is a METHOD and it must have a (bracket).
        Console.SetCursorPosition(24, 10)
        Console.WriteLine("Hello world")
        Dim selection As String
        selection = Console.ReadLine()
        selection.Remove(",")
        Console.WriteLine(selection)
        Console.ReadLine()




    End Sub

End Module
