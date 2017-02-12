Public Class Form1
    Public Event MyCustomEvent()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text.ToLower.Equals("donut") Then
            RaiseEvent MyCustomEvent()
        End If
    End Sub

    Private Sub Form1_MyCustomEvent() Handles Me.MyCustomEvent
        MsgBox("Hello World")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub UserControl11_RadioChecker_Change(sender As String) Handles UserControl11.RadioChecker_Change
        MsgBox(sender)

    End Sub
End Class
