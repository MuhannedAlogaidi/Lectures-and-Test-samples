
Module ListWithClassAndOpenFile
    Class Student
        Public firstname As String
        Public lastname As String
        Public dob As Date
    End Class
    Sub main()
        Console.SetWindowSize(80, 40)
        'Declare the List of Students
        Dim std As New List(Of Student)

        Console.WriteLine("Welcome to Student Database: ")
        Dim selection As Char
        While selection.ToString.ToUpper <> "C"
            Console.WriteLine("Please Choose from the below list: ")
            Console.WriteLine("(A) Add Student")
            Console.WriteLine("(B) View Student")
            Console.WriteLine("(C) Quit Program")
            selection = Console.ReadLine.ToUpper
            Select Case selection.ToString.ToUpper
                Case "A"
                    FileOpen(1, "Hello.txt", OpenMode.Append)
                    'You must delare the new student here.... for correct increment
                    Dim stdNew As New Student
                    Console.Write("Please Enter the firstname: ")
                    stdNew.firstname = Console.ReadLine
                    Console.Write("Please Enter the lastname: ")
                    stdNew.lastname = Console.ReadLine
                    Console.Write("Please Enter the DataOfBirth: ")
                    stdNew.dob = Console.ReadLine
                    'add the filled student to the list
                    std.Add(stdNew)
                    Console.WriteLine(std.Count)
                    PrintLine(1, stdNew.firstname & "," & stdNew.lastname & "," & stdNew.dob)
                    FileClose()

                    Console.WriteLine("Student Successfully Added")
                Case "B"

                    For Each element As Student In std
                        Console.WriteLine(element.firstname & "," & element.lastname & "," & element.dob)
                        'Write the Output Data to file.



                    Next

                Case "C"
                    Exit Sub

            End Select

        End While
        Console.ReadLine()
    End Sub
End Module
