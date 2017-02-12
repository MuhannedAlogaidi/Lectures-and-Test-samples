Imports System.Globalization
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each ctn As Control In Me.Controls
            If TypeOf (ctn) Is TextBox Then
                AddHandler ctn.Validated, AddressOf tb_textValidated
            End If
        Next
    End Sub
    Private Sub tb_textValidated(sender As Object, e As EventArgs)
        If sender.text = "" Then sender.text = 0
        sender.text = FormatNumber(sender.text)
    End Sub
End Class
