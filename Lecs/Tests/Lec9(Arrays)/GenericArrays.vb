Module GenericArrays
    ''' <summary>
    ''' Creating a Generic Array with Random number
    ''' you need to have:
    ''' 1-Size which is the size of the array()
    ''' 2-min and max number for the random.
    ''' 3-optional unique which represent the uniquness of array items.
    ''' </summary>

    Function generateArray(size As Integer,
                           min As Integer,
                           max As Integer,
                           Optional Unique As Boolean = False)

        'Declare a random class
        Dim random = New Random()
        'Declare the array with its givin size.
        Dim number(size - 1) As Integer
        'Make Loop for Array items.
        For i As Integer = 0 To size - 1
            'Adding Item to that integer to added in the end of the routaine to the array.
            Dim randNum As Integer = random.Next(min, max + 1)
            'Here we have to check if the user want to have a unique list of items.
            If Unique = True Then
                'Create a loop to check wheather number has duplicate.
                While number.Contains(randNum)
                    randNum = random.Next(min, max + 1)
                End While
            End If
            'Adding the randNum to the number array.
            number(i) = randNum
        Next


        Return number
    End Function
    Function FindNumber(numbers() As Integer, number As Integer) As Integer
        For i = 0 To numbers.Length - 1
            If numbers(i) = number Then
                Return i
            End If
        Next
        Return -1

    End Function
    ''' <summary>
    ''' Understanding bubble sort....
    ''' 10 2 11 -3 4 compare every 2 number and push the largest to the end.
    ''' 2 10 11 -3 4
    ''' 2 10 11 -3 4
    ''' 2 10 -3 11 4
    ''' 2 10 -3 4 11
    ''' </summary>
    ''' <param name="numToSort"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function sortArray(numToSort() As Integer) As Integer()
        For i As Integer = 0 To numToSort.Count - 1
            '-i is to ignore the last number sorted.
            For j As Integer = 0 To numToSort.Count - 2 - i
                If numToSort(j) > numToSort(j + 1) Then
                    'Swap the numbers.
                    Dim temp As Integer
                    temp = numToSort(j)
                    numToSort(j) = numToSort(j + 1)
                    numToSort(j + 1) = temp
                End If
            Next
        Next
        Return numToSort

    End Function
    Sub main()
        Console.SetWindowSize(80, 40)
        Dim x As Integer
        Dim numArr() As Integer = generateArray(10, 1, 15, True)
        'This is for sorting numbers of the array.
        numArr = sortArray(numArr)

        For i = 0 To numArr.Count - 1
            Console.WriteLine(numArr(i))
        Next
        Console.Write("Enter you number to be found from the array: ")
        x = Console.ReadLine()
        Console.WriteLine("The index of your number is: " & FindNumber(numArr, x))
        Console.ReadLine()

    End Sub
End Module
