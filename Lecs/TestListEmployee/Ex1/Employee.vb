Public Class Employee
    Private _name As String
    Private _id As Integer
    Public Property name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property
    Public Property id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Public Sub New(ByVal name As String, ByVal id As Integer)
        _name = name
        _id = id


    End Sub
End Class
