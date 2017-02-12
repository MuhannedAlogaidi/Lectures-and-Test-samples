Module dates
    Sub main()
        Console.SetWindowSize(80, 20)
        Dim date1 As Date
        date1 = Now
        Console.WriteLine(date1.DayOfYear)
        Console.WriteLine(date1.DayOfWeek)
        Console.WriteLine(date1.AddDays(14))
        Console.WriteLine(date1.Subtract("2016-11-01"))
        Console.WriteLine(date1.ToLocalTime())
        Console.ReadLine()
        Console.WriteLine(date1.ToShortDateString)
        Console.WriteLine(date1.ToString("m-dd-yyyy"))
        Console.WriteLine(date1.ToLongDateString)
        Console.ReadLine()
    End Sub
End Module

