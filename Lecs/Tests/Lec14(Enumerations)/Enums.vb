Imports System.Collections
Imports System.Collections.Generic
Module Enums
    Enum color
        red = 1
        black = 2
        yellow = 3
        green = 4
    End Enum
    Sub main()
        Console.SetWindowSize(80, 40)
        Dim x As color = 1
        x += 1

        Console.WriteLine(x)
        Console.ReadLine()
    End Sub
End Module
