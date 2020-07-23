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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.lstbox1 = New System.Windows.Forms.ListBox()
        Me.btmrmv = New System.Windows.Forms.Button()
        Me.btnclr = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Country Name:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(165, 50)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(166, 20)
        Me.TextBox1.TabIndex = 1
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(168, 100)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 23)
        Me.btnadd.TabIndex = 2
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'lstbox1
        '
        Me.lstbox1.FormattingEnabled = True
        Me.lstbox1.Location = New System.Drawing.Point(57, 154)
        Me.lstbox1.Name = "lstbox1"
        Me.lstbox1.Size = New System.Drawing.Size(167, 173)
        Me.lstbox1.TabIndex = 3
        '
        'btmrmv
        '
        Me.btmrmv.Location = New System.Drawing.Point(277, 154)
        Me.btmrmv.Name = "btmrmv"
        Me.btmrmv.Size = New System.Drawing.Size(75, 23)
        Me.btmrmv.TabIndex = 4
        Me.btmrmv.Text = "Remove"
        Me.btmrmv.UseVisualStyleBackColor = True
        '
        'btnclr
        '
        Me.btnclr.Location = New System.Drawing.Point(277, 224)
        Me.btnclr.Name = "btnclr"
        Me.btnclr.Size = New System.Drawing.Size(75, 23)
        Me.btnclr.TabIndex = 4
        Me.btnclr.Text = "Clear"
        Me.btnclr.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(277, 304)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 23)
        Me.btnexit.TabIndex = 4
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 397)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnclr)
        Me.Controls.Add(Me.btmrmv)
        Me.Controls.Add(Me.lstbox1)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents lstbox1 As System.Windows.Forms.ListBox
    Friend WithEvents btmrmv As System.Windows.Forms.Button
    Friend WithEvents btnclr As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button

End Class
