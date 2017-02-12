Module _2ClassesInOneClass
    Public Class Foo
        Class a
            Private _x As Integer
            Public Property x As Integer
                Get
                    Return _x
                End Get
                Set(value As Integer)
                    _x = value
                End Set
            End Property
            Public Sub New(ByVal x As Integer)
                _x = x
            End Sub
        End Class
        Class b
            Private _y As Integer
            Public Property y As Integer
                Get
                    Return _y
                End Get
                Set(value As Integer)
                    _y = value
                End Set
            End Property
            Public Sub New(ByVal y As Integer)
                _y = y
            End Sub
        End Class
       
    End Class
    Sub main()
        Dim ss As New Foo.a(10)
        Dim mm As New Foo.b(20)


        Console.SetWindowSize(80, 20)
        Console.WriteLine(ss.x - mm.y)
        Console.ReadLine()
    End Sub
End Module
