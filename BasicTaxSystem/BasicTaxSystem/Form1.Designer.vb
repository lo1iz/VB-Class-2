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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextSalary = New System.Windows.Forms.TextBox()
        Me.ButtonTax = New System.Windows.Forms.Button()
        Me.LabelTax = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "เงินเดือน(ต่อเดือน)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ต้องเสียภาษี"
        '
        'TextSalary
        '
        Me.TextSalary.Location = New System.Drawing.Point(143, 47)
        Me.TextSalary.Name = "TextSalary"
        Me.TextSalary.Size = New System.Drawing.Size(111, 20)
        Me.TextSalary.TabIndex = 2
        '
        'ButtonTax
        '
        Me.ButtonTax.Location = New System.Drawing.Point(143, 162)
        Me.ButtonTax.Name = "ButtonTax"
        Me.ButtonTax.Size = New System.Drawing.Size(111, 23)
        Me.ButtonTax.TabIndex = 4
        Me.ButtonTax.Text = "คำนวณภาษีอย่างง่าย"
        Me.ButtonTax.UseVisualStyleBackColor = True
        '
        'LabelTax
        '
        Me.LabelTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelTax.Location = New System.Drawing.Point(144, 116)
        Me.LabelTax.Name = "LabelTax"
        Me.LabelTax.Size = New System.Drawing.Size(110, 23)
        Me.LabelTax.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 227)
        Me.Controls.Add(Me.LabelTax)
        Me.Controls.Add(Me.ButtonTax)
        Me.Controls.Add(Me.TextSalary)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextSalary As TextBox
    Friend WithEvents ButtonTax As Button
    Friend WithEvents LabelTax As Label
End Class
