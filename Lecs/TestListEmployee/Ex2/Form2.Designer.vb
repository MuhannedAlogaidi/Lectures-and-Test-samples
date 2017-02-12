<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.year_of_sales = New System.Windows.Forms.TextBox()
        Me.org_code = New System.Windows.Forms.TextBox()
        Me.ispromo = New System.Windows.Forms.TextBox()
        Me.item_qty = New System.Windows.Forms.TextBox()
        Me.item_cat = New System.Windows.Forms.TextBox()
        Me.code = New System.Windows.Forms.TextBox()
        Me.item_type = New System.Windows.Forms.TextBox()
        Me.item_mark = New System.Windows.Forms.TextBox()
        Me.item_description = New System.Windows.Forms.TextBox()
        Me.item_id = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Panel1MinSize = 40
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.year_of_sales)
        Me.SplitContainer1.Panel2.Controls.Add(Me.org_code)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ispromo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.item_qty)
        Me.SplitContainer1.Panel2.Controls.Add(Me.item_cat)
        Me.SplitContainer1.Panel2.Controls.Add(Me.code)
        Me.SplitContainer1.Panel2.Controls.Add(Me.item_type)
        Me.SplitContainer1.Panel2.Controls.Add(Me.item_mark)
        Me.SplitContainer1.Panel2.Controls.Add(Me.item_description)
        Me.SplitContainer1.Panel2.Controls.Add(Me.item_id)
        Me.SplitContainer1.Size = New System.Drawing.Size(914, 462)
        Me.SplitContainer1.SplitterDistance = 500
        Me.SplitContainer1.TabIndex = 12
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(500, 462)
        Me.DataGridView1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(15, 273)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(292, 33)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "insert"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'year_of_sales
        '
        Me.year_of_sales.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.year_of_sales.Location = New System.Drawing.Point(15, 247)
        Me.year_of_sales.Name = "year_of_sales"
        Me.year_of_sales.Size = New System.Drawing.Size(292, 20)
        Me.year_of_sales.TabIndex = 21
        Me.year_of_sales.Text = "999"
        '
        'org_code
        '
        Me.org_code.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.org_code.Location = New System.Drawing.Point(15, 221)
        Me.org_code.Name = "org_code"
        Me.org_code.Size = New System.Drawing.Size(292, 20)
        Me.org_code.TabIndex = 20
        Me.org_code.Text = "777"
        '
        'ispromo
        '
        Me.ispromo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ispromo.Location = New System.Drawing.Point(15, 195)
        Me.ispromo.Name = "ispromo"
        Me.ispromo.Size = New System.Drawing.Size(292, 20)
        Me.ispromo.TabIndex = 19
        Me.ispromo.Text = "1"
        '
        'item_qty
        '
        Me.item_qty.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.item_qty.Location = New System.Drawing.Point(15, 169)
        Me.item_qty.Name = "item_qty"
        Me.item_qty.Size = New System.Drawing.Size(292, 20)
        Me.item_qty.TabIndex = 18
        Me.item_qty.Text = "555"
        '
        'item_cat
        '
        Me.item_cat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.item_cat.Location = New System.Drawing.Point(15, 143)
        Me.item_cat.Name = "item_cat"
        Me.item_cat.Size = New System.Drawing.Size(292, 20)
        Me.item_cat.TabIndex = 17
        Me.item_cat.Text = "444"
        '
        'code
        '
        Me.code.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.code.Location = New System.Drawing.Point(15, 39)
        Me.code.Name = "code"
        Me.code.Size = New System.Drawing.Size(292, 20)
        Me.code.TabIndex = 16
        Me.code.Text = "333"
        '
        'item_type
        '
        Me.item_type.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.item_type.Location = New System.Drawing.Point(15, 117)
        Me.item_type.Name = "item_type"
        Me.item_type.Size = New System.Drawing.Size(292, 20)
        Me.item_type.TabIndex = 15
        Me.item_type.Text = "222"
        '
        'item_mark
        '
        Me.item_mark.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.item_mark.Location = New System.Drawing.Point(15, 91)
        Me.item_mark.Name = "item_mark"
        Me.item_mark.Size = New System.Drawing.Size(292, 20)
        Me.item_mark.TabIndex = 14
        Me.item_mark.Text = "111"
        '
        'item_description
        '
        Me.item_description.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.item_description.Location = New System.Drawing.Point(15, 65)
        Me.item_description.Name = "item_description"
        Me.item_description.Size = New System.Drawing.Size(292, 20)
        Me.item_description.TabIndex = 13
        Me.item_description.Text = "1019"
        '
        'item_id
        '
        Me.item_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.item_id.Location = New System.Drawing.Point(15, 12)
        Me.item_id.Name = "item_id"
        Me.item_id.Size = New System.Drawing.Size(292, 20)
        Me.item_id.TabIndex = 12
        Me.item_id.Text = "100"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(15, 312)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(292, 33)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(15, 351)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(292, 33)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 462)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Form2"
        Me.Text = "222"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents year_of_sales As System.Windows.Forms.TextBox
    Friend WithEvents org_code As System.Windows.Forms.TextBox
    Friend WithEvents ispromo As System.Windows.Forms.TextBox
    Friend WithEvents item_qty As System.Windows.Forms.TextBox
    Friend WithEvents item_cat As System.Windows.Forms.TextBox
    Friend WithEvents code As System.Windows.Forms.TextBox
    Friend WithEvents item_type As System.Windows.Forms.TextBox
    Friend WithEvents item_mark As System.Windows.Forms.TextBox
    Friend WithEvents item_description As System.Windows.Forms.TextBox
    Friend WithEvents item_id As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
