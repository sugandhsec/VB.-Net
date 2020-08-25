<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StringFunction2
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
        Me.txtstr = New System.Windows.Forms.TextBox()
        Me.btnmid = New System.Windows.Forms.Button()
        Me.txtmid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnoc = New System.Windows.Forms.TextBox()
        Me.btninstr = New System.Windows.Forms.Button()
        Me.txtinstr = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtword = New System.Windows.Forms.TextBox()
        Me.btnrtrim = New System.Windows.Forms.Button()
        Me.txtrtrim = New System.Windows.Forms.TextBox()
        Me.btnltrim = New System.Windows.Forms.Button()
        Me.txtltrim = New System.Windows.Forms.TextBox()
        Me.btnchar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtgascii = New System.Windows.Forms.TextBox()
        Me.txtchar = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter String"
        '
        'txtstr
        '
        Me.txtstr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstr.Location = New System.Drawing.Point(153, 13)
        Me.txtstr.Name = "txtstr"
        Me.txtstr.Size = New System.Drawing.Size(509, 24)
        Me.txtstr.TabIndex = 1
        '
        'btnmid
        '
        Me.btnmid.Location = New System.Drawing.Point(37, 90)
        Me.btnmid.Name = "btnmid"
        Me.btnmid.Size = New System.Drawing.Size(291, 23)
        Me.btnmid.TabIndex = 2
        Me.btnmid.Text = "Display Character From String"
        Me.btnmid.UseVisualStyleBackColor = True
        '
        'txtmid
        '
        Me.txtmid.Location = New System.Drawing.Point(346, 92)
        Me.txtmid.Name = "txtmid"
        Me.txtmid.Size = New System.Drawing.Size(331, 20)
        Me.txtmid.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Enter Starting Position"
        '
        'txtpos
        '
        Me.txtpos.Location = New System.Drawing.Point(193, 59)
        Me.txtpos.Name = "txtpos"
        Me.txtpos.Size = New System.Drawing.Size(59, 20)
        Me.txtpos.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(290, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(174, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Enter No. Of Character Want"
        '
        'txtnoc
        '
        Me.txtnoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnoc.Location = New System.Drawing.Point(499, 60)
        Me.txtnoc.Name = "txtnoc"
        Me.txtnoc.Size = New System.Drawing.Size(92, 22)
        Me.txtnoc.TabIndex = 7
        '
        'btninstr
        '
        Me.btninstr.Location = New System.Drawing.Point(37, 172)
        Me.btninstr.Name = "btninstr"
        Me.btninstr.Size = New System.Drawing.Size(303, 23)
        Me.btninstr.TabIndex = 8
        Me.btninstr.Text = "Find Word Position Between The String"
        Me.btninstr.UseVisualStyleBackColor = True
        '
        'txtinstr
        '
        Me.txtinstr.Location = New System.Drawing.Point(364, 172)
        Me.txtinstr.Name = "txtinstr"
        Me.txtinstr.Size = New System.Drawing.Size(247, 20)
        Me.txtinstr.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(207, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Enter Word You Want To Find"
        '
        'txtword
        '
        Me.txtword.Location = New System.Drawing.Point(364, 140)
        Me.txtword.Name = "txtword"
        Me.txtword.Size = New System.Drawing.Size(247, 20)
        Me.txtword.TabIndex = 11
        '
        'btnrtrim
        '
        Me.btnrtrim.Location = New System.Drawing.Point(37, 227)
        Me.btnrtrim.Name = "btnrtrim"
        Me.btnrtrim.Size = New System.Drawing.Size(303, 23)
        Me.btnrtrim.TabIndex = 12
        Me.btnrtrim.Text = "Remove Trailing Spaces From Right"
        Me.btnrtrim.UseVisualStyleBackColor = True
        '
        'txtrtrim
        '
        Me.txtrtrim.Location = New System.Drawing.Point(364, 227)
        Me.txtrtrim.Name = "txtrtrim"
        Me.txtrtrim.Size = New System.Drawing.Size(247, 20)
        Me.txtrtrim.TabIndex = 13
        '
        'btnltrim
        '
        Me.btnltrim.Location = New System.Drawing.Point(37, 287)
        Me.btnltrim.Name = "btnltrim"
        Me.btnltrim.Size = New System.Drawing.Size(303, 23)
        Me.btnltrim.TabIndex = 14
        Me.btnltrim.Text = "Remove Trailing Spaces From Left"
        Me.btnltrim.UseVisualStyleBackColor = True
        '
        'txtltrim
        '
        Me.txtltrim.Location = New System.Drawing.Point(364, 289)
        Me.txtltrim.Name = "txtltrim"
        Me.txtltrim.Size = New System.Drawing.Size(254, 20)
        Me.txtltrim.TabIndex = 15
        '
        'btnchar
        '
        Me.btnchar.Location = New System.Drawing.Point(455, 341)
        Me.btnchar.Name = "btnchar"
        Me.btnchar.Size = New System.Drawing.Size(108, 23)
        Me.btnchar.TabIndex = 16
        Me.btnchar.Text = "Get Character"
        Me.btnchar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 340)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(281, 18)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Enter ASCII Value Of Character You Want"
        '
        'txtgascii
        '
        Me.txtgascii.Location = New System.Drawing.Point(333, 341)
        Me.txtgascii.Name = "txtgascii"
        Me.txtgascii.Size = New System.Drawing.Size(100, 20)
        Me.txtgascii.TabIndex = 18
        '
        'txtchar
        '
        Me.txtchar.Location = New System.Drawing.Point(589, 344)
        Me.txtchar.Name = "txtchar"
        Me.txtchar.Size = New System.Drawing.Size(44, 20)
        Me.txtchar.TabIndex = 19
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(121, 370)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(449, 47)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "OPEN PREVIOUS PAGE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'StringFunction2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 429)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtchar)
        Me.Controls.Add(Me.txtgascii)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnchar)
        Me.Controls.Add(Me.txtltrim)
        Me.Controls.Add(Me.btnltrim)
        Me.Controls.Add(Me.txtrtrim)
        Me.Controls.Add(Me.btnrtrim)
        Me.Controls.Add(Me.txtword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtinstr)
        Me.Controls.Add(Me.btninstr)
        Me.Controls.Add(Me.txtnoc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtpos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtmid)
        Me.Controls.Add(Me.btnmid)
        Me.Controls.Add(Me.txtstr)
        Me.Controls.Add(Me.Label1)
        Me.Name = "StringFunction2"
        Me.Text = "    "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtstr As System.Windows.Forms.TextBox
    Friend WithEvents btnmid As System.Windows.Forms.Button
    Friend WithEvents txtmid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtpos As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtnoc As System.Windows.Forms.TextBox
    Friend WithEvents btninstr As System.Windows.Forms.Button
    Friend WithEvents txtinstr As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtword As System.Windows.Forms.TextBox
    Friend WithEvents btnrtrim As System.Windows.Forms.Button
    Friend WithEvents txtrtrim As System.Windows.Forms.TextBox
    Friend WithEvents btnltrim As System.Windows.Forms.Button
    Friend WithEvents txtltrim As System.Windows.Forms.TextBox
    Friend WithEvents btnchar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtgascii As System.Windows.Forms.TextBox
    Friend WithEvents txtchar As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
