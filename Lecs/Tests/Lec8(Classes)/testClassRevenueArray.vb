Module testClassRevenueArray
    Public Class _revenue
        Private _clsInitRev As Double
        Private _clsRevArr() As Double

        Public Sub New(clsInitRev As Double)
            _clsInitRev = clsInitRev
        End Sub
        Public Property clsInitRev As Double
            Get
                Return _clsInitRev
            End Get
            Set(value As Double)
                _clsInitRev = value
            End Set
        End Property
        Public Property clsRevArr As Double()
            Get
                Return {_clsInitRev * 25, _clsInitRev * 12, _clsInitRev * 12}

            End Get
            Set(value As Double())
                _clsRevArr = value
            End Set
        End Property
    End Class
    Sub main()
        Console.SetWindowSize(80, 20)
        Dim _rev As New _revenue(100)
        Console.WriteLine(_rev.clsInitRev)
        For Each elem As Integer In _rev.clsRevArr
            Console.WriteLine(elem)
        Next
        Console.ReadLine()
    End Sub
End Module
