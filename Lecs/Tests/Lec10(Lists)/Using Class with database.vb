Imports System.Data.SqlClient
Module ListWithTableClass

    Class ITEMS
        'Giving a private will ristrict you to create property
        Private _item_id As Integer
        Private _item_type As String
        Private _cn As New SqlConnection("server=mnswin07\sql_ser;database=Tawasulclean;integrated security=true")
        Private _ispromo As Boolean
        Public Property item_id As Integer
            Get
                Return _item_id
            End Get
            Set(value As Integer)
                _item_id = value
            End Set
        End Property
        Public Property item_type As String
            Get
                Return _item_type
            End Get
            Set(value As String)
                _item_type = value
            End Set
        End Property
        Public Property isPromo As Boolean
            Get
                Return _ispromo
            End Get
            Set(value As Boolean)
                _ispromo = value

            End Set
        End Property
        Public Property cn As SqlConnection
            Get
                Return _cn
            End Get
            Set(value As SqlConnection)
                _cn = value
            End Set
        End Property
        Sub connect()
            Try
                cn.Open()
            Catch ex As Exception
            End Try
        End Sub
    End Class
    Sub main()
        Console.SetWindowSize(80, 40)
        Dim i As New ITEMS
        i.connect()
        Dim selection As Char
        While selection.ToString.ToUpper <> "C"
            Console.WriteLine("Insertion is About to Start")
            Console.WriteLine("(A) for Inserting New Item")
            Console.WriteLine("(B) for Viewing the Item list")
            Console.WriteLine("(C) for quiting the program")
            selection = Console.ReadLine
            FileOpen(1, "Hello.txt", OpenMode.Append)
            Select Case selection.ToString.ToUpper
                Case "A"
                    Console.Write("Enter the Item_id: ")
                 
                        i.item_id = Console.ReadLine
                   
                    Console.Write("Enter the Item_type: ")
                    i.item_type = Console.ReadLine
                    Console.Write("Enter the Promo: ")
                    i.isPromo = Console.ReadLine
                    Dim command As New SqlCommand("Insert into item_list_sage (item_id,item_type,ispromo) values ( '" & i.item_id & "','" & i.item_type & "','" & i.isPromo & "')", i.cn)
                    command.ExecuteNonQuery()
                    Console.WriteLine("Successful Insertion")
                    PrintLine(1, i.item_id & "|" & i.item_type & "|" & i.isPromo)
                        FileClose(1)


                Case "B"
                    Dim com As New SqlCommand("select * from item_list_sage", i.cn)
                    Dim da As SqlDataReader
                    da = com.ExecuteReader()
                    While da.Read()
                        i.item_id = da.Item("item_id")
                        i.item_type = da.Item("Item_type")
                        i.isPromo = da.Item("ispromo")
                        Console.WriteLine("Item_id: " & i.item_id)
                        Console.WriteLine("Item_type: " & i.item_type)
                        Console.WriteLine("isPromo: " & i.isPromo)

                    End While
                Case "C"
                    Exit Sub

            End Select
        End While
        Console.ReadLine()




    End Sub
End Module
