
Module coercion1
    ''' <summary>
    ''' Coercion means overriding function to give you the ability to move between 
    ''' function which usually saw in some function with arrow down and arrow up
    ''' </summary>
    ''' <remarks></remarks>
    Function joins(string1 As String, string2 As String) As String
        Return string1 & " " & string2
    End Function
    'This is the coercion for the first function for 3 strings
    Function joins(string1 As String, string2 As String, string3 As String) As String
        Return string1 & " " & string2 & " " & string3
    End Function
    ''now using array of strings as a first functio overriden
    Function joins(strings() As String) As String
        Dim res As String = Nothing

        For i As Integer = 0 To strings.Length - 1

            res &= " " & strings(i)
        Next
        Return res
    End Function
    Sub main()
        Console.SetWindowSize(80, 40)
        Dim selection As Char
        While selection.ToString.ToUpper <> "D"
            Console.WriteLine("(A) first function")
            Console.WriteLine("(B) second function")
            Console.WriteLine("(C) Third function")
            selection = Console.ReadLine
            Select Case selection.ToString.ToUpper
                Case "A"
                    Dim s1, s2 As String

                    Console.Write("Enter your first string: ")
                    s1 = Console.ReadLine
                    Console.Write("Enter your second string: ")
                    s2 = Console.ReadLine
                    Console.WriteLine("The concatenation 2 is: " & joins(s1, s2))
                Case "B"
                    Dim s1, s2, s3 As String
                    Console.Write("Enter your first string: ")
                    s1 = Console.ReadLine
                    Console.Write("Enter your second string: ")
                    s2 = Console.ReadLine
                    Console.Write("Enter you third string: ")
                    s3 = Console.ReadLine
                    Console.WriteLine("The Concatenation 3 is: " & joins(s1, s2, s3))
                Case "C"
                    'Declare the list
                    Dim list As New List(Of String)
                    Dim str As String
                    'using do while until is better this time because we don't need an initial value for str
                    'doing do while str<>"" is require an initial value for str.... and we don't need th user to apply for the value that equals the initial.
                    Do
                        Console.Write("Enter the string you want to type: ")
                        str = Console.ReadLine
                        If str <> "" Then list.Add(str)
                    Loop Until str = ""
                    Console.WriteLine(joins(list.ToArray))

            End Select
        End While
        Console.ReadLine()

    End Sub
End Module
