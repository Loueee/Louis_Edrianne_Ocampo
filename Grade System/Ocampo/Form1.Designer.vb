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
        Me.Mathtextbox = New System.Windows.Forms.TextBox()
        Me.Sciencetextbox = New System.Windows.Forms.TextBox()
        Me.Englishtextbox = New System.Windows.Forms.TextBox()
        Me.Math_Label = New System.Windows.Forms.Label()
        Me.Science_Label = New System.Windows.Forms.Label()
        Me.English_Label = New System.Windows.Forms.Label()
        Me.GradeFOrm_label = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Mathtextbox
        '
        Me.Mathtextbox.Location = New System.Drawing.Point(31, 41)
        Me.Mathtextbox.Multiline = True
        Me.Mathtextbox.Name = "Mathtextbox"
        Me.Mathtextbox.Size = New System.Drawing.Size(244, 45)
        Me.Mathtextbox.TabIndex = 0
        '
        'Sciencetextbox
        '
        Me.Sciencetextbox.Location = New System.Drawing.Point(31, 120)
        Me.Sciencetextbox.Multiline = True
        Me.Sciencetextbox.Name = "Sciencetextbox"
        Me.Sciencetextbox.Size = New System.Drawing.Size(244, 45)
        Me.Sciencetextbox.TabIndex = 1
        '
        'Englishtextbox
        '
        Me.Englishtextbox.Location = New System.Drawing.Point(31, 199)
        Me.Englishtextbox.Multiline = True
        Me.Englishtextbox.Name = "Englishtextbox"
        Me.Englishtextbox.Size = New System.Drawing.Size(244, 45)
        Me.Englishtextbox.TabIndex = 2
        '
        'Math_Label
        '
        Me.Math_Label.AutoSize = True
        Me.Math_Label.Location = New System.Drawing.Point(28, 25)
        Me.Math_Label.Name = "Math_Label"
        Me.Math_Label.Size = New System.Drawing.Size(31, 13)
        Me.Math_Label.TabIndex = 3
        Me.Math_Label.Text = "Math"
        '
        'Science_Label
        '
        Me.Science_Label.AutoSize = True
        Me.Science_Label.Location = New System.Drawing.Point(28, 104)
        Me.Science_Label.Name = "Science_Label"
        Me.Science_Label.Size = New System.Drawing.Size(46, 13)
        Me.Science_Label.TabIndex = 4
        Me.Science_Label.Text = "Science"
        '
        'English_Label
        '
        Me.English_Label.AutoSize = True
        Me.English_Label.Location = New System.Drawing.Point(28, 183)
        Me.English_Label.Name = "English_Label"
        Me.English_Label.Size = New System.Drawing.Size(41, 13)
        Me.English_Label.TabIndex = 6
        Me.English_Label.Text = "English"
        '
        'GradeFOrm_label
        '
        Me.GradeFOrm_label.AutoSize = True
        Me.GradeFOrm_label.Location = New System.Drawing.Point(124, 9)
        Me.GradeFOrm_label.Name = "GradeFOrm_label"
        Me.GradeFOrm_label.Size = New System.Drawing.Size(62, 13)
        Me.GradeFOrm_label.TabIndex = 7
        Me.GradeFOrm_label.Text = "Grade Form"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(111, 272)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 39)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Evaluate"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 346)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GradeFOrm_label)
        Me.Controls.Add(Me.English_Label)
        Me.Controls.Add(Me.Science_Label)
        Me.Controls.Add(Me.Math_Label)
        Me.Controls.Add(Me.Englishtextbox)
        Me.Controls.Add(Me.Sciencetextbox)
        Me.Controls.Add(Me.Mathtextbox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Mathtextbox As System.Windows.Forms.TextBox
    Friend WithEvents Sciencetextbox As System.Windows.Forms.TextBox
    Friend WithEvents Englishtextbox As System.Windows.Forms.TextBox
    Friend WithEvents Math_Label As System.Windows.Forms.Label
    Friend WithEvents Science_Label As System.Windows.Forms.Label
    Friend WithEvents English_Label As System.Windows.Forms.Label
    Friend WithEvents GradeFOrm_label As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
