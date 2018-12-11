<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LabelSum = New System.Windows.Forms.Label()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.TextNum = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelAverage = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelNum = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelSum
        '
        Me.LabelSum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelSum.Location = New System.Drawing.Point(148, 86)
        Me.LabelSum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelSum.Name = "LabelSum"
        Me.LabelSum.Size = New System.Drawing.Size(193, 27)
        Me.LabelSum.TabIndex = 10
        '
        'ButtonOK
        '
        Me.ButtonOK.Location = New System.Drawing.Point(263, 25)
        Me.ButtonOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(79, 28)
        Me.ButtonOK.TabIndex = 9
        Me.ButtonOK.Text = "OK"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'TextNum
        '
        Me.TextNum.Location = New System.Drawing.Point(148, 28)
        Me.TextNum.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextNum.Name = "TextNum"
        Me.TextNum.Size = New System.Drawing.Size(105, 22)
        Me.TextNum.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 87)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "ผลรวมทั้งหมด"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "จำนวนตัวเลขที่รับข้อมูล"
        '
        'LabelAverage
        '
        Me.LabelAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelAverage.Location = New System.Drawing.Point(148, 133)
        Me.LabelAverage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelAverage.Name = "LabelAverage"
        Me.LabelAverage.Size = New System.Drawing.Size(193, 27)
        Me.LabelAverage.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 134)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "ค่าเฉลี่ยของตัวเลข"
        '
        'LabelNum
        '
        Me.LabelNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelNum.Location = New System.Drawing.Point(148, 182)
        Me.LabelNum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNum.Name = "LabelNum"
        Me.LabelNum.Size = New System.Drawing.Size(193, 122)
        Me.LabelNum.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(76, 183)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "เลขที่รับมา"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 358)
        Me.Controls.Add(Me.LabelNum)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabelAverage)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LabelSum)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.TextNum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Sum and avg"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelSum As Label
    Friend WithEvents ButtonOK As Button
    Friend WithEvents TextNum As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelAverage As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelNum As Label
    Friend WithEvents Label6 As Label
End Class