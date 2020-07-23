<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.grdBook = New System.Windows.Forms.DataGridView()
        Me.txtBname = New System.Windows.Forms.TextBox()
        Me.txtIsbn = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtAname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBid = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAnameSearch = New System.Windows.Forms.TextBox()
        Me.btnSearchBook = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.txtMax = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbCat = New System.Windows.Forms.ComboBox()
        Me.cmbSearchCat = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnSearchCat = New System.Windows.Forms.Button()
        CType(Me.grdBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdBook
        '
        Me.grdBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBook.Location = New System.Drawing.Point(12, 350)
        Me.grdBook.Name = "grdBook"
        Me.grdBook.Size = New System.Drawing.Size(655, 263)
        Me.grdBook.TabIndex = 0
        '
        'txtBname
        '
        Me.txtBname.Location = New System.Drawing.Point(88, 39)
        Me.txtBname.Name = "txtBname"
        Me.txtBname.Size = New System.Drawing.Size(205, 20)
        Me.txtBname.TabIndex = 1
        '
        'txtIsbn
        '
        Me.txtIsbn.Location = New System.Drawing.Point(88, 145)
        Me.txtIsbn.Name = "txtIsbn"
        Me.txtIsbn.Size = New System.Drawing.Size(205, 20)
        Me.txtIsbn.TabIndex = 2
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(88, 106)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(205, 20)
        Me.txtPrice.TabIndex = 3
        '
        'txtAname
        '
        Me.txtAname.Location = New System.Drawing.Point(88, 74)
        Me.txtAname.Name = "txtAname"
        Me.txtAname.Size = New System.Drawing.Size(205, 20)
        Me.txtAname.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "BookName"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Isbn"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Author"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(15, 212)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(87, 36)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Add Book"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "BookID"
        '
        'txtBid
        '
        Me.txtBid.Location = New System.Drawing.Point(88, 7)
        Me.txtBid.Name = "txtBid"
        Me.txtBid.Size = New System.Drawing.Size(205, 20)
        Me.txtBid.TabIndex = 10
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(202, 214)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(97, 33)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "Update Book"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(108, 214)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(88, 34)
        Me.btnDel.TabIndex = 13
        Me.btnDel.Text = "Delete Book"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(424, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Enter Author name to be searched"
        '
        'txtAnameSearch
        '
        Me.txtAnameSearch.Location = New System.Drawing.Point(427, 74)
        Me.txtAnameSearch.Name = "txtAnameSearch"
        Me.txtAnameSearch.Size = New System.Drawing.Size(197, 20)
        Me.txtAnameSearch.TabIndex = 14
        '
        'btnSearchBook
        '
        Me.btnSearchBook.Location = New System.Drawing.Point(427, 101)
        Me.btnSearchBook.Name = "btnSearchBook"
        Me.btnSearchBook.Size = New System.Drawing.Size(197, 32)
        Me.btnSearchBook.TabIndex = 16
        Me.btnSearchBook.Text = "Search Book"
        Me.btnSearchBook.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(425, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(197, 32)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(427, 206)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(197, 32)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Search Book"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(424, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Enter Price range to search"
        '
        'txtMin
        '
        Me.txtMin.Location = New System.Drawing.Point(427, 179)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(81, 20)
        Me.txtMin.TabIndex = 18
        '
        'txtMax
        '
        Me.txtMax.Location = New System.Drawing.Point(541, 179)
        Me.txtMax.Name = "txtMax"
        Me.txtMax.Size = New System.Drawing.Size(81, 20)
        Me.txtMax.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(520, 182)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(10, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "-"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(313, 33)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 36)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "Sort by name"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(313, 97)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(87, 36)
        Me.Button4.TabIndex = 24
        Me.Button4.Text = "Sort by price"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(313, 163)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(87, 36)
        Me.Button5.TabIndex = 25
        Me.Button5.Text = "sort by author"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 186)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Category"
        '
        'cmbCat
        '
        Me.cmbCat.FormattingEnabled = True
        Me.cmbCat.Location = New System.Drawing.Point(88, 183)
        Me.cmbCat.Name = "cmbCat"
        Me.cmbCat.Size = New System.Drawing.Size(205, 21)
        Me.cmbCat.TabIndex = 28
        '
        'cmbSearchCat
        '
        Me.cmbSearchCat.FormattingEnabled = True
        Me.cmbSearchCat.Location = New System.Drawing.Point(427, 268)
        Me.cmbSearchCat.Name = "cmbSearchCat"
        Me.cmbSearchCat.Size = New System.Drawing.Size(197, 21)
        Me.cmbSearchCat.TabIndex = 30
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(425, 244)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Category"
        '
        'btnSearchCat
        '
        Me.btnSearchCat.Location = New System.Drawing.Point(427, 299)
        Me.btnSearchCat.Name = "btnSearchCat"
        Me.btnSearchCat.Size = New System.Drawing.Size(197, 32)
        Me.btnSearchCat.TabIndex = 31
        Me.btnSearchCat.Text = "Search Book"
        Me.btnSearchCat.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 618)
        Me.Controls.Add(Me.btnSearchCat)
        Me.Controls.Add(Me.cmbSearchCat)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbCat)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtMax)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtMin)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSearchBook)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAnameSearch)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBid)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAname)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtIsbn)
        Me.Controls.Add(Me.txtBname)
        Me.Controls.Add(Me.grdBook)
        Me.Name = "Form1"
        CType(Me.grdBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdBook As System.Windows.Forms.DataGridView
    Friend WithEvents txtBname As System.Windows.Forms.TextBox
    Friend WithEvents txtIsbn As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtAname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBid As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAnameSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchBook As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMin As System.Windows.Forms.TextBox
    Friend WithEvents txtMax As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbCat As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSearchCat As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnSearchCat As System.Windows.Forms.Button

End Class
