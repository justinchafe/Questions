<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuestionForm
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
        Me.components = New System.ComponentModel.Container()
        Me.TrueRadio = New System.Windows.Forms.RadioButton()
        Me.FalseRadio = New System.Windows.Forms.RadioButton()
        Me.Finish = New System.Windows.Forms.Button()
        Me.QuesLabel = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Component11 = New WindowsApplication1.Component1(Me.components)
        Me.Title = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TrueRadio
        '
        Me.TrueRadio.AutoSize = True
        Me.TrueRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrueRadio.Location = New System.Drawing.Point(59, 408)
        Me.TrueRadio.Name = "TrueRadio"
        Me.TrueRadio.Size = New System.Drawing.Size(59, 24)
        Me.TrueRadio.TabIndex = 1
        Me.TrueRadio.Text = "True"
        Me.TrueRadio.UseVisualStyleBackColor = True
        '
        'FalseRadio
        '
        Me.FalseRadio.AutoSize = True
        Me.FalseRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FalseRadio.Location = New System.Drawing.Point(122, 408)
        Me.FalseRadio.Name = "FalseRadio"
        Me.FalseRadio.Size = New System.Drawing.Size(66, 24)
        Me.FalseRadio.TabIndex = 2
        Me.FalseRadio.Text = "False"
        Me.FalseRadio.UseVisualStyleBackColor = True
        '
        'Finish
        '
        Me.Finish.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Finish.Location = New System.Drawing.Point(59, 436)
        Me.Finish.Name = "Finish"
        Me.Finish.Size = New System.Drawing.Size(84, 30)
        Me.Finish.TabIndex = 4
        Me.Finish.Text = "Next"
        Me.Finish.UseVisualStyleBackColor = True
        '
        'QuesLabel
        '
        Me.QuesLabel.BackColor = System.Drawing.SystemColors.MenuBar
        Me.QuesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.QuesLabel.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.QuesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuesLabel.Location = New System.Drawing.Point(59, 158)
        Me.QuesLabel.Multiline = True
        Me.QuesLabel.Name = "QuesLabel"
        Me.QuesLabel.ReadOnly = True
        Me.QuesLabel.Size = New System.Drawing.Size(674, 245)
        Me.QuesLabel.TabIndex = 6
        Me.QuesLabel.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.dept_psych2
        Me.PictureBox1.Location = New System.Drawing.Point(59, 14)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(194, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.Location = New System.Drawing.Point(56, 92)
        Me.Title.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(83, 26)
        Me.Title.TabIndex = 8
        Me.Title.Text = "Label1"
        '
        'QuestionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(972, 500)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.QuesLabel)
        Me.Controls.Add(Me.Finish)
        Me.Controls.Add(Me.FalseRadio)
        Me.Controls.Add(Me.TrueRadio)
        Me.Name = "QuestionForm"
        Me.Text = "Sex "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TrueRadio As System.Windows.Forms.RadioButton
    Friend WithEvents FalseRadio As System.Windows.Forms.RadioButton
    Friend WithEvents Finish As System.Windows.Forms.Button
    Friend WithEvents QuesLabel As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Component11 As Component1
    Friend WithEvents Title As Label
End Class
