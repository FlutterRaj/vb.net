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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(281, 209)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter num 1:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(223, 276)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(344, 38)
        Me.TextBox1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label3.Location = New System.Drawing.Point(281, 335)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(219, 40)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Enter num 2:"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(223, 395)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(344, 38)
        Me.TextBox2.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Info
        Me.Button1.Font = New System.Drawing.Font("Ebrima", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Button1.Location = New System.Drawing.Point(53, 459)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 62)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Info
        Me.Button2.Font = New System.Drawing.Font("Ebrima", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Button2.Location = New System.Drawing.Point(417, 459)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 62)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "*"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Info
        Me.Button3.Font = New System.Drawing.Font("Ebrima", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Button3.Location = New System.Drawing.Point(236, 459)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 62)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "-"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Info
        Me.Button4.Font = New System.Drawing.Font("Ebrima", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Button4.Location = New System.Drawing.Point(592, 459)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(117, 62)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "/"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.calculator.My.Resources.Resources.calculator
        Me.PictureBox1.Location = New System.Drawing.Point(272, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(246, 183)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 575)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
