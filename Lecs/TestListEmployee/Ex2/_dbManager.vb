Imports System.Data.SqlClient

Public Class _dbManager
    Private _connection As SqlConnection
    Public Sub New(database As String)
        'call the connect method
        connect(database)

    End Sub
    Public Sub connect(database As String)
        _connection = New SqlConnection("server=mnswin07\sql_ser;database=" & database & " ;integrated security=true")

        Try
            _connection.Open()
            Trace.WriteLine("Good One Mounes")

        Catch ex As Exception
            MessageBox.Show("Error")
            _connection = Nothing
        End Try
    End Sub
    Public Function getData(table As String, Optional fields As String = "*", Optional where As String = "", Optional orderby As String = "") As DataTable
        Dim dt As New DataTable

        Dim _query As String = "select " & fields & " from " & table
        If where <> "" Then
            _query &= " where " & where
        End If
        If orderby <> "" Then
            _query &= " Orderby" & orderby
        End If
        Try
            Dim com As New SqlCommand(_query, _connection)
            com.ExecuteNonQuery()
            Dim da As New SqlDataAdapter(com)
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            MessageBox.Show("Error showing data" & ex.Message)

            dt = Nothing
        End Try
        Return Nothing
    End Function
    Public Function InsertCMD(table As String, fields As String, values As String) As Boolean
        Dim check As Boolean
        Dim _query As String = "Insert into " & table & " ( " & fields & " ) values (" & values & " )"
        Dim com As New SqlCommand(_query, _connection)
        Try
            com.ExecuteNonQuery()
            Return check
        Catch ex As Exception
            MessageBox.Show("Error Inserting data" & ex.Message)
            check = False
        End Try
        Return check
    End Function
    Public Function UpdateCMD(table As String, field As String, value As String, field2 As String, id As String) As Boolean
        Dim check As Boolean
        Dim _query As String = "update " & table & " set " & field & "='" & value & "' where " & field2 & "='" & id & "'"
        Dim com As New SqlCommand(_query, _connection)
        Try
            com.ExecuteNonQuery()
            Return check
        Catch ex As Exception
            MessageBox.Show("Error Updating Data" & ex.Message)
            check = False
        End Try
        Return check
    End Function
    Public Function DeleteCMD(table As String, field As String, value As String) As Boolean
        Dim check As Boolean
        Dim _query As String = "Delete from " & table & " where " & field & "='" & value & "'"
        Dim com As New SqlCommand(_query, _connection)
        Try
            com.ExecuteNonQuery()
            Return check
        Catch ex As Exception
            MessageBox.Show("Error Deletion" & ex.Message)
            Return check
        End Try
    End Function
End Class
