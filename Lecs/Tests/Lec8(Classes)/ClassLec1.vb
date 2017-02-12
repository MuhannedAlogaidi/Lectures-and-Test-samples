Module ClassLec1
    Class Student
        Public firstname As String
        Public lastname As String
        Public dob As Date
    End Class
    Sub main()
        Dim std As New Student
        Dim selection As Char
        While selection.ToString.ToUpper <> "D"
            Console.SetWindowSize(80, 40)
            Console.WriteLine("Welcome to students database")
            Console.WriteLine()
            Console.WriteLine("(A) add a Student")
            Console.WriteLine("(B) view Student")
            Console.WriteLine("(C) Quit")
            selection = Console.ReadLine.ToUpper
            Select Case selection.ToString.ToUpper
                Case "A"
                    Console.Write("Enter the firstname of student: ")
                    std.firstname = Console.ReadLine
                    Console.Write("Enter the lastname of student: ")
                    std.lastname = Console.ReadLine
                    Console.Write("Enter the date of birthday of student: ")
                    std.dob = Console.ReadLine
                    Console.WriteLine("Student added successfully")
                Case "B"
                    Console.WriteLine("Student Firstname: (" & std.firstname & ") Student Lastname is: (" & std.lastname & ") Student Date of Birth is: (" & std.dob & ")")
            End Select
        End While

    End Sub
End Module
