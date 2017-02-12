Module Module14
    Sub main()
        Console.SetWindowSize(80, 40)
        Dim selection As Char

        While selection.ToString.ToUpper <> "C"
            Console.WriteLine("Welcome to Text Writing: ")
            Console.WriteLine("(A) for Insert Text and save")
            Console.WriteLine("(B) for View the data inside the text")
            Console.WriteLine("(C) for quit")
            selection = Console.ReadLine()
            'Using FileNum as freefile in order to work on the specific last file opened (Fresh one) just in case you have multiple text document opened in atime..
            Dim fileNum As Integer = FreeFile()
            Select Case selection.ToString.ToUpper

                Case "A"
                    'Start Entering Data to the File. using these 3 nice commands (fileopen,printline,closefile)
                    Dim a As String
                    Console.Write("Start Entering your Data: ")
                    a = Console.ReadLine
                    FileOpen(fileNum, "Hello.txt", OpenMode.Append)
                    PrintLine(fileNum, a)
                    FileClose(fileNum)
                Case "B"
                    'check if the File is already Exists....
                    If IO.File.Exists("Hello.txt") Then
                        'Start reading data from the file. using these nice commands (fileopen,lineinput,closefile)
                        FileOpen(fileNum, "Hello.txt", OpenMode.Input)
                        'Using this EOF is allow us to prevent crashing the program while reaching to the end of it.
                        While Not EOF(fileNum)
                            Console.WriteLine(LineInput(fileNum))
                        End While
                        FileClose(fileNum)
                    Else
                        Console.WriteLine("File Not Found")
                    End If
                Case "C"
                    Exit Sub

            End Select
       
        End While
        Console.ReadLine()
    End Sub
End Module
