Public Class cRectangle
    'Declaring the below variable with private wouldn't give any access in any other class for them.
    'so, the solution is to change them to protected in order to access it when INHERITANCE only.
    Protected _height As Single
    Protected _width As Single
    Public Shared RecCount As Integer = 0
    Public Property height As Single
        Set(value As Single)
            If _height >= 0 Then
                _height = value
            ElseIf _height = "" Then
                _height = 0
            End If
        End Set
        Get
            Return _height
        End Get
    End Property
    Public Property width As Single
        Get
            Return _width
        End Get
        Set(value As Single)
            If _width >= 0 Then
                _width = value
            ElseIf _width = "" Then
                _width = 0
            End If
        End Set
    End Property
    'constructors can be overriden just like functions coercion
    Sub New()
        _height = 0
        _width = 0
        RecCount += 1
    End Sub
    Sub New(x As Single, y As Single)
        _height = y
        _width = x
        RecCount += 1
    End Sub
    Function calculateArea()
        Return height * width
    End Function
    'Adding Operators
    'Operator for summing two rectanges
    Public Shared Operator +(a As cRectangle, b As cRectangle) As cRectangle
        Return New cRectangle(a.width + b.width, a.height + b.height)
    End Operator
    'Operator for comparing two rectanges.
    Public Shared Operator =(a As cRectangle, b As cRectangle) As Boolean
        If a.height = b.height And a.width = b.width Then
            Return True
        Else
            Return False
        End If

    End Operator
    'You have to add <> operator in order to move the bug in = operator
    Public Shared Operator <>(a As cRectangle, b As cRectangle) As Boolean
        Return Not (a = b)
    End Operator
    'Overriding an original method for any glass "Writing Overrides and space will show you the default VB methods
    Public Overrides Function ToString() As String
        'change the below code to your code
        'Return MyBase.ToString()
        Return "Width= " & width & "| Height= " & height
    End Function
    'This is very important method you have to use in your classes when you are using variables like bytes , arrays , lists not standard in vb.net
    'Remember you have to dispose (finalize) to garbig collection all you allocated memory for variable to stablizing your project. 
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
