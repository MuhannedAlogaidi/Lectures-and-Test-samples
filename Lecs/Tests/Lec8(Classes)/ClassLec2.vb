Module ClassLec2
    Sub main()
        Console.SetWindowSize(80, 40)
        Dim x1 As Single
        Dim y1 As Single
        Dim x2 As Single
        Dim y2 As Single

        Console.Write("Enter the value of x1: ")
        x1 = Console.ReadLine

        Console.Write("Enter the value of y1: ")
        y1 = Console.ReadLine
        Dim rec1 As New cRectangle(x1, y1)
        Console.WriteLine("The area is: " & rec1.calculateArea() & " " & cRectangle.RecCount) 'Shared Member don't recognize the new rec it just has to take name of the original Class which is in this case cRectangle.
        Console.ReadLine()
        Console.Write("Enter the value of x2: ")
        x2 = Console.ReadLine
        Console.Write("Enter the value of y2: ")
        y2 = Console.ReadLine
        Dim rec2 As New cRectangle(x2, y2)
        Console.WriteLine("The area is: " & rec2.calculateArea() & " " & cRectangle.RecCount)
        Console.ReadLine()
        'Calculating the Cube
        Dim z As Single
        Console.Write("Enter the Value of Depth: ")
        z = Console.ReadLine()
        Dim cube As New cCube(x1, y1, z)
        Console.WriteLine("The Volume is: " & cube.calculateArea() & " " & cRectangle.RecCount)
        Dim cube2 As New cCube(x2, y2, z)
        Console.WriteLine("The Volume is: " & cube2.calculateArea() & " " & cRectangle.RecCount)
        'Check Your equal operator
        If rec1 = rec2 Then
            Console.WriteLine("2 rec are ok")
            'Use your Summing Operator
            Dim RecOpr As New cRectangle()
            RecOpr = rec1 + rec2
            Console.WriteLine(RecOpr.height & " " & RecOpr.width & " " & cRectangle.RecCount)

        Else
            Console.WriteLine("2 rec are not ok")
        End If
        Console.WriteLine(rec1.ToString)

        Console.ReadLine()
    End Sub
End Module
