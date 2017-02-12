Imports System.Data.SqlClient
Public Class Form1
    Dim cn As New SqlConnection("server=mnswin07\sql_ser;database=ICBGHQ;integrated security=true")
    Function GetHashTable()
        Dim comm As New SqlCommand("select borrowercode,fullname from borrowers order by borrowercode", cn)
        Dim da As SqlDataReader = comm.ExecuteReader
        Dim table As New Hashtable
        While da.Read
            table.Add(da("borrowercode").ToString, da("fullname").ToString)

        End While
        Return table

    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.AutoCompleteMode = AutoCompleteMode.Append
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDown
        ComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems
        cn.Open()
        Dim table As Hashtable = GetHashTable()

        For Each element As DictionaryEntry In table
            ComboBox1.Items.Add(element.Key & " - " & element.Value)

        Next
    End Sub
End Class
