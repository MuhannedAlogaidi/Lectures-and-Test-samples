Module Module11
    Class Student
        Friend firstname As String
        Friend lastname As String
        Friend dob As Date
    End Class
    Sub main()
        Dim std(9) As Student
        'Adding the count of student to loop through them
        Dim stdCount As Integer = 0
        'Can't adding dim std(9) as new student''
        'So, you have to allocate memory for every item in the std(9) array
        For i = 0 To 9
            std(i) = New Student
        Next
        Dim selection As Char
        While selection.ToString.ToUpper <> "C"
            Console.SetWindowSize(80, 40)
            Console.WriteLine("Welcome to students database")

            'Showing the number of Students
            Console.WriteLine("Number of Students are: " & stdCount)

            Console.WriteLine()
            Console.WriteLine("(A) add a Student")
            Console.WriteLine("(B) view Student")
            Console.WriteLine("(C) Quit")
            selection = Console.ReadLine.ToUpper
            Select Case selection.ToString.ToUpper
                Case "A"
                    Console.Write("Enter the firstname of student: ")
                    std(stdCount).firstname = Console.ReadLine
                    Console.Write("Enter the lastname of student: ")
                    std(stdCount).lastname = Console.ReadLine
                    Console.Write("Enter the date of birthday of student: ")
                    std(stdCount).dob = Console.ReadLine
                    Console.WriteLine("Student added successfully")
                    'Add the count by 1
                    If stdCount >= 9 Then
                        Exit Sub
                    Else
                        stdCount += 1

                    End If

                Case "B"
                    For Each element As Student In std
                        'Stop the elements from being printed if they have no values
                        If element.firstname = "" And element.lastname = "" Then
                            Exit For
                        Else

                            Console.WriteLine("Student Firstname: (" & element.firstname & ") Student Lastname is: (" & element.lastname & ") Student Date of Birth is: (" & element.dob & ")")

                        End If
                    Next
            End Select
        End While

    End Sub
End Module
