<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WinFormExampleForm
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
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ExampleTextBox = New System.Windows.Forms.TextBox()
        Me.ExampleLabel = New System.Windows.Forms.Label()
        Me.ActionButton = New System.Windows.Forms.Button()
        Me.StringReverseCheckBox = New System.Windows.Forms.CheckBox()
        Me.ExampleListBox = New System.Windows.Forms.ListBox()
        Me.RemoveButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(418, 376)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(195, 62)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ExampleTextBox
        '
        Me.ExampleTextBox.Location = New System.Drawing.Point(112, 38)
        Me.ExampleTextBox.Name = "ExampleTextBox"
        Me.ExampleTextBox.Size = New System.Drawing.Size(346, 22)
        Me.ExampleTextBox.TabIndex = 1
        '
        'ExampleLabel
        '
        Me.ExampleLabel.AutoSize = True
        Me.ExampleLabel.Location = New System.Drawing.Point(44, 38)
        Me.ExampleLabel.Name = "ExampleLabel"
        Me.ExampleLabel.Size = New System.Drawing.Size(61, 17)
        Me.ExampleLabel.TabIndex = 2
        Me.ExampleLabel.Text = "Example"
        '
        'ActionButton
        '
        Me.ActionButton.Location = New System.Drawing.Point(217, 376)
        Me.ActionButton.Name = "ActionButton"
        Me.ActionButton.Size = New System.Drawing.Size(195, 62)
        Me.ActionButton.TabIndex = 3
        Me.ActionButton.Text = "&Do The Thing"
        Me.ActionButton.UseVisualStyleBackColor = True
        '
        'StringReverseCheckBox
        '
        Me.StringReverseCheckBox.AutoSize = True
        Me.StringReverseCheckBox.ForeColor = System.Drawing.Color.Blue
        Me.StringReverseCheckBox.Location = New System.Drawing.Point(112, 83)
        Me.StringReverseCheckBox.Name = "StringReverseCheckBox"
        Me.StringReverseCheckBox.Size = New System.Drawing.Size(83, 21)
        Me.StringReverseCheckBox.TabIndex = 4
        Me.StringReverseCheckBox.Text = "&Reverse"
        Me.StringReverseCheckBox.UseVisualStyleBackColor = True
        '
        'ExampleListBox
        '
        Me.ExampleListBox.FormattingEnabled = True
        Me.ExampleListBox.ItemHeight = 16
        Me.ExampleListBox.Location = New System.Drawing.Point(112, 122)
        Me.ExampleListBox.Name = "ExampleListBox"
        Me.ExampleListBox.Size = New System.Drawing.Size(342, 212)
        Me.ExampleListBox.TabIndex = 5
        '
        'RemoveButton
        '
        Me.RemoveButton.Location = New System.Drawing.Point(16, 376)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(195, 62)
        Me.RemoveButton.TabIndex = 6
        Me.RemoveButton.Text = "&Remove"
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'WinFormExampleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 450)
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.ExampleListBox)
        Me.Controls.Add(Me.StringReverseCheckBox)
        Me.Controls.Add(Me.ActionButton)
        Me.Controls.Add(Me.ExampleLabel)
        Me.Controls.Add(Me.ExampleTextBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Name = "WinFormExampleForm"
        Me.Text = "Example Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents ExampleTextBox As TextBox
    Friend WithEvents ExampleLabel As Label
    Friend WithEvents ActionButton As Button
    Friend WithEvents StringReverseCheckBox As CheckBox
    Friend WithEvents ExampleListBox As ListBox
    Friend WithEvents RemoveButton As Button
End Class
