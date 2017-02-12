Public Class Form1
    Dim list As New List(Of Employee)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim emp As Employee = New Employee(TextBox1.Text, list.Count)
        list.Add(emp)
        TextBox1.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        For Each emp As Employee In list
            ComboBox1.Items.Add(emp.id & "-" & emp.name)
        Next

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class
