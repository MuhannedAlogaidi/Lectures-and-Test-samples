Public Class cCube
    Inherits cRectangle
    Protected _depth As Single
    Sub New()
        'This would call the original sub new() of the class cRectangle
        MyBase.New()
        'adding only the depth
        _depth = 0
    End Sub
    Public Property depth As Single
        Get
            Return _depth
        End Get
        Set(value As Single)
            If _depth >= 0 Then
                _depth = value
            End If
        End Set
    End Property
    Sub New(w As Single, h As Single, depth As Single)
        MyBase.New(w, h)
        _depth = depth
    End Sub
    'This is the polymorphzim...
    Overloads Function calculateArea()
        Return width * height * depth

    End Function
    
End Class
