Imports System.Data.SqlClient
Public Class Form2
    Dim _db As New _dbManager("TawasulClean")

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dTable As DataTable = _db.getData("Item_list_sage", "Item_id,Item_description,Item_mark")
        DataGridView1.DataSource = dTable
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        _db.InsertCMD("item_list_sage", "item_id,code,item_description,item_mark,item_type,item_cat,item_qty,ispromo,org_code,year_of_sales", item_id.Text & ",'" & code.Text & "',N'" & item_description.Text & "','" & item_mark.Text & "','" & item_type.Text & "','" & item_cat.Text & "'," & item_qty.Text & "," & ispromo.Text & "," & org_code.Text & "," & year_of_sales.Text)
        Trace.WriteLine("Correct Insertion!")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        _db.UpdateCMD("item_list_sage", "Item_mark", item_mark.Text, "item_id", item_id.Text)
        Trace.WriteLine("Correct Update!")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        _db.DeleteCMD("ITEM_LIST_sage", "item_id", item_id.Text)
        Trace.WriteLine("Correct Deletion!")


    End Sub
End Class