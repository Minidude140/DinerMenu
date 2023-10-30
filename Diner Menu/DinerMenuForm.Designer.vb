<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DinerMenuForm
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
        Me.SoupButton = New System.Windows.Forms.Button()
        Me.SaladButton = New System.Windows.Forms.Button()
        Me.FishButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.DinerNameLabel = New System.Windows.Forms.Label()
        Me.DailySpecialsLabel = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'SoupButton
        '
        Me.SoupButton.Location = New System.Drawing.Point(17, 311)
        Me.SoupButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SoupButton.Name = "SoupButton"
        Me.SoupButton.Size = New System.Drawing.Size(115, 47)
        Me.SoupButton.TabIndex = 0
        Me.SoupButton.Text = "&Soup"
        Me.ToolTip1.SetToolTip(Me.SoupButton, "View Dex's Soup of the Day")
        Me.SoupButton.UseVisualStyleBackColor = True
        '
        'SaladButton
        '
        Me.SaladButton.Location = New System.Drawing.Point(136, 311)
        Me.SaladButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SaladButton.Name = "SaladButton"
        Me.SaladButton.Size = New System.Drawing.Size(115, 47)
        Me.SaladButton.TabIndex = 1
        Me.SaladButton.Text = "S&alad"
        Me.ToolTip1.SetToolTip(Me.SaladButton, "View Dex's Salad of the Day")
        Me.SaladButton.UseVisualStyleBackColor = True
        '
        'FishButton
        '
        Me.FishButton.Location = New System.Drawing.Point(256, 311)
        Me.FishButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.FishButton.Name = "FishButton"
        Me.FishButton.Size = New System.Drawing.Size(115, 47)
        Me.FishButton.TabIndex = 2
        Me.FishButton.Text = "&Fish"
        Me.ToolTip1.SetToolTip(Me.FishButton, "View Dex's Fish Options")
        Me.FishButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(482, 311)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(115, 47)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Leave the Diner")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'DinerNameLabel
        '
        Me.DinerNameLabel.AutoSize = True
        Me.DinerNameLabel.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 20.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DinerNameLabel.Location = New System.Drawing.Point(222, 7)
        Me.DinerNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DinerNameLabel.Name = "DinerNameLabel"
        Me.DinerNameLabel.Size = New System.Drawing.Size(188, 46)
        Me.DinerNameLabel.TabIndex = 4
        Me.DinerNameLabel.Text = "Dex's Diner"
        '
        'DailySpecialsLabel
        '
        Me.DailySpecialsLabel.Font = New System.Drawing.Font("MV Boli", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DailySpecialsLabel.Location = New System.Drawing.Point(70, 69)
        Me.DailySpecialsLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DailySpecialsLabel.Name = "DailySpecialsLabel"
        Me.DailySpecialsLabel.Size = New System.Drawing.Size(434, 222)
        Me.DailySpecialsLabel.TabIndex = 5
        Me.DailySpecialsLabel.Text = "Menu Item"
        Me.DailySpecialsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DinerMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 368)
        Me.Controls.Add(Me.DailySpecialsLabel)
        Me.Controls.Add(Me.DinerNameLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.FishButton)
        Me.Controls.Add(Me.SaladButton)
        Me.Controls.Add(Me.SoupButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "DinerMenuForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dex's Diner Daily Special Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SoupButton As Button
    Friend WithEvents SaladButton As Button
    Friend WithEvents FishButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents DinerNameLabel As Label
    Friend WithEvents DailySpecialsLabel As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
