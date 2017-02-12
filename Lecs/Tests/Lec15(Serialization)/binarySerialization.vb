Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Module binarySerialization
    <Serializable> _
    Class vector
        Public x As Integer
        Public y As Integer
        Public z As Integer
        Sub New(a As Integer, b As Integer, c As Integer)
            x = a
            y = b
            z = c
        End Sub
    End Class
    Sub main()
        Console.SetWindowSize(80, 40)
        Dim v1 As New List(Of vector)
        v1.Add(New vector(1, 2, 3))
        v1.Add(New vector(2, 4, 3))
        v1.Add(New vector(4, 4, 4))
        v1.Add(New vector(5, 5, 5))
        'Craete the file steam.
        Dim st As FileStream = File.Create("Hello.txt")
        'Create the formatter to save the data.
        Dim format As New BinaryFormatter
        'Saving the data into file .... FYI ... this command will save all your class info... so it can be helpful in future by saving the current state of your
        'Game.
        format.Serialize(st, v1)
        st.Close()

        'Reading the data through Deserialization.

        Dim Stream As FileStream = File.OpenRead("Hello.txt")
        Dim v2 As New List(Of vector)
        v2 = format.Deserialize(Stream)

        Console.WriteLine(v2.Count)
        Console.WriteLine(v2.Item(1))

        Console.Read()




    End Sub
End Module
