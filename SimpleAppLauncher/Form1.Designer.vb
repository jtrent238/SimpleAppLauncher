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
        Me.Button_Chrome = New System.Windows.Forms.Button()
        Me.Button_Word = New System.Windows.Forms.Button()
        Me.Button_PowerPoint = New System.Windows.Forms.Button()
        Me.Button_Excel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button_Internet_Google = New System.Windows.Forms.Button()
        Me.Button_Internet_Facebook = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_Chrome
        '
        Me.Button_Chrome.Location = New System.Drawing.Point(6, 19)
        Me.Button_Chrome.Name = "Button_Chrome"
        Me.Button_Chrome.Size = New System.Drawing.Size(188, 23)
        Me.Button_Chrome.TabIndex = 0
        Me.Button_Chrome.Text = "Google Chrome"
        Me.Button_Chrome.UseVisualStyleBackColor = True
        '
        'Button_Word
        '
        Me.Button_Word.Location = New System.Drawing.Point(6, 48)
        Me.Button_Word.Name = "Button_Word"
        Me.Button_Word.Size = New System.Drawing.Size(188, 23)
        Me.Button_Word.TabIndex = 0
        Me.Button_Word.Text = "Microsoft Word"
        Me.Button_Word.UseVisualStyleBackColor = True
        '
        'Button_PowerPoint
        '
        Me.Button_PowerPoint.Location = New System.Drawing.Point(6, 77)
        Me.Button_PowerPoint.Name = "Button_PowerPoint"
        Me.Button_PowerPoint.Size = New System.Drawing.Size(188, 23)
        Me.Button_PowerPoint.TabIndex = 0
        Me.Button_PowerPoint.Text = "Microsoft Power Point"
        Me.Button_PowerPoint.UseVisualStyleBackColor = True
        '
        'Button_Excel
        '
        Me.Button_Excel.Location = New System.Drawing.Point(6, 106)
        Me.Button_Excel.Name = "Button_Excel"
        Me.Button_Excel.Size = New System.Drawing.Size(188, 23)
        Me.Button_Excel.TabIndex = 0
        Me.Button_Excel.Text = "Microsoft Excel"
        Me.Button_Excel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button_Chrome)
        Me.GroupBox1.Controls.Add(Me.Button_Excel)
        Me.GroupBox1.Controls.Add(Me.Button_Word)
        Me.GroupBox1.Controls.Add(Me.Button_PowerPoint)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 142)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Programs"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button_Internet_Google)
        Me.GroupBox2.Controls.Add(Me.Button_Internet_Facebook)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 160)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 142)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Internet Shortcuts"
        '
        'Button_Internet_Google
        '
        Me.Button_Internet_Google.Location = New System.Drawing.Point(6, 19)
        Me.Button_Internet_Google.Name = "Button_Internet_Google"
        Me.Button_Internet_Google.Size = New System.Drawing.Size(188, 23)
        Me.Button_Internet_Google.TabIndex = 0
        Me.Button_Internet_Google.Text = "Google"
        Me.Button_Internet_Google.UseVisualStyleBackColor = True
        '
        'Button_Internet_Facebook
        '
        Me.Button_Internet_Facebook.Location = New System.Drawing.Point(6, 48)
        Me.Button_Internet_Facebook.Name = "Button_Internet_Facebook"
        Me.Button_Internet_Facebook.Size = New System.Drawing.Size(188, 23)
        Me.Button_Internet_Facebook.TabIndex = 0
        Me.Button_Internet_Facebook.Text = "Facebook"
        Me.Button_Internet_Facebook.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(230, 443)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button_Chrome As System.Windows.Forms.Button
    Friend WithEvents Button_Word As System.Windows.Forms.Button
    Friend WithEvents Button_PowerPoint As System.Windows.Forms.Button
    Friend WithEvents Button_Excel As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button_Internet_Google As System.Windows.Forms.Button
    Friend WithEvents Button_Internet_Facebook As System.Windows.Forms.Button

End Class
