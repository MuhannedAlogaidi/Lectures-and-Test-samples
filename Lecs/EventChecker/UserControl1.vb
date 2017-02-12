Public Class UserControl1
    Public Event RadioChecker_Change(ByVal sender As String)
    Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each c As Control In Me.Controls
            If TypeOf c Is RadioButton Then
                Dim radioChanging As RadioButton = CType(c, RadioButton)
                AddHandler radioChanging.CheckedChanged, AddressOf RadioButton_CheckedChanged
            End If
        Next
    End Sub

    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs)
        If TypeOf sender Is RadioButton Then
            Dim radioButton As RadioButton = CType(sender, RadioButton)
            If radioButton.Checked = True Then
                RaiseEvent RadioChecker_Change(radioButton.Text)
            End If
        End If

    End Sub
End Class
