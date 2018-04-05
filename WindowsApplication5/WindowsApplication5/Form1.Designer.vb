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
        Me.txtUserInput = New System.Windows.Forms.TextBox()
        Me.btnFNR = New System.Windows.Forms.Button()
        Me.btnAlpha = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtUserInput
        '
        Me.txtUserInput.Location = New System.Drawing.Point(38, 86)
        Me.txtUserInput.Name = "txtUserInput"
        Me.txtUserInput.Size = New System.Drawing.Size(279, 20)
        Me.txtUserInput.TabIndex = 0
        '
        'btnFNR
        '
        Me.btnFNR.Location = New System.Drawing.Point(38, 138)
        Me.btnFNR.Name = "btnFNR"
        Me.btnFNR.Size = New System.Drawing.Size(110, 64)
        Me.btnFNR.TabIndex = 1
        Me.btnFNR.Text = "Find First Non Repeating Character"
        Me.btnFNR.UseVisualStyleBackColor = True
        '
        'btnAlpha
        '
        Me.btnAlpha.Location = New System.Drawing.Point(207, 142)
        Me.btnAlpha.Name = "btnAlpha"
        Me.btnAlpha.Size = New System.Drawing.Size(110, 60)
        Me.btnAlpha.TabIndex = 2
        Me.btnAlpha.Text = "Sort Alphabetically"
        Me.btnAlpha.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter some text and click a button.  "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 242)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAlpha)
        Me.Controls.Add(Me.btnFNR)
        Me.Controls.Add(Me.txtUserInput)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUserInput As System.Windows.Forms.TextBox
    Friend WithEvents btnFNR As System.Windows.Forms.Button
    Friend WithEvents btnAlpha As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
