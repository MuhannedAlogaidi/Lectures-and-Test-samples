Module Module6
    Sub main()
        Console.SetWindowSize(80, 40)
        Console.Write("Please enter some text: ")
        Dim s As String = Console.ReadLine()
        Console.WriteLine("the value you entered is: " & s)
        Console.WriteLine("the length of the string is: " & s.Length)
        Console.WriteLine("contains: " & s.Contains("Hello"))
        Console.WriteLine("ends with: " & s.EndsWith("Good Boy"))
        Console.WriteLine("IndexOf: " & s.IndexOf("s"))
        Console.WriteLine("Insert Into: " & s.Insert(3, "Perfect Imagination"))
        Console.WriteLine("LastIndexOf Hello: " & s.LastIndexOf("S"))
        Console.WriteLine("Remove: " & s.Remove(0, 3))
        Console.WriteLine("Replcae: " & s.Replace("Hello", ""))
        Console.WriteLine("Sub String: " & s.Substring(0, s.IndexOf(" ")))

        Console.ReadLine()
    End Sub
End Module
