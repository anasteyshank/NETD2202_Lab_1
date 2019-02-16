<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsShipped
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
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.txtUserInput = New System.Windows.Forms.TextBox()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.txtDisplayUnitsShipped = New System.Windows.Forms.TextBox()
        Me.lblDisplayAverage = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.AverageUnitsShippedTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblUnits
        '
        Me.lblUnits.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblUnits.Location = New System.Drawing.Point(15, 26)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(61, 29)
        Me.lblUnits.TabIndex = 0
        Me.lblUnits.Text = "&Units:"
        Me.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUserInput
        '
        Me.txtUserInput.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUserInput.Location = New System.Drawing.Point(82, 26)
        Me.txtUserInput.Name = "txtUserInput"
        Me.txtUserInput.Size = New System.Drawing.Size(228, 28)
        Me.txtUserInput.TabIndex = 1
        Me.AverageUnitsShippedTips.SetToolTip(Me.txtUserInput, "Enter the number of units shipped")
        '
        'lblDays
        '
        Me.lblDays.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDays.Location = New System.Drawing.Point(311, 26)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(65, 29)
        Me.lblDays.TabIndex = 2
        Me.lblDays.Text = "Day 1"
        Me.lblDays.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDisplayUnitsShipped
        '
        Me.txtDisplayUnitsShipped.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDisplayUnitsShipped.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtDisplayUnitsShipped.Location = New System.Drawing.Point(19, 73)
        Me.txtDisplayUnitsShipped.Multiline = True
        Me.txtDisplayUnitsShipped.Name = "txtDisplayUnitsShipped"
        Me.txtDisplayUnitsShipped.ReadOnly = True
        Me.txtDisplayUnitsShipped.Size = New System.Drawing.Size(357, 144)
        Me.txtDisplayUnitsShipped.TabIndex = 3
        Me.txtDisplayUnitsShipped.TabStop = False
        Me.AverageUnitsShippedTips.SetToolTip(Me.txtDisplayUnitsShipped, "Displays the number of units shipped per day")
        '
        'lblDisplayAverage
        '
        Me.lblDisplayAverage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDisplayAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplayAverage.Location = New System.Drawing.Point(19, 234)
        Me.lblDisplayAverage.Name = "lblDisplayAverage"
        Me.lblDisplayAverage.Size = New System.Drawing.Size(357, 39)
        Me.lblDisplayAverage.TabIndex = 4
        Me.lblDisplayAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedTips.SetToolTip(Me.lblDisplayAverage, "Displays calculated average")
        '
        'btnEnter
        '
        Me.btnEnter.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEnter.Location = New System.Drawing.Point(19, 295)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(115, 32)
        Me.btnEnter.TabIndex = 2
        Me.btnEnter.Text = "&Enter"
        Me.AverageUnitsShippedTips.SetToolTip(Me.btnEnter, "Click to Enter a value")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(140, 295)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(115, 32)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "&Reset"
        Me.AverageUnitsShippedTips.SetToolTip(Me.btnReset, "Click to Reset the form")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnExit.Location = New System.Drawing.Point(261, 295)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(115, 32)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.AverageUnitsShippedTips.SetToolTip(Me.btnExit, "Click to Exit the form")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmAverageUnitsShipped
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(401, 361)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblDisplayAverage)
        Me.Controls.Add(Me.txtDisplayUnitsShipped)
        Me.Controls.Add(Me.lblDays)
        Me.Controls.Add(Me.txtUserInput)
        Me.Controls.Add(Me.lblUnits)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(419, 408)
        Me.Name = "frmAverageUnitsShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUnits As Label
    Friend WithEvents txtUserInput As TextBox
    Friend WithEvents lblDays As Label
    Friend WithEvents txtDisplayUnitsShipped As TextBox
    Friend WithEvents lblDisplayAverage As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents AverageUnitsShippedTips As ToolTip
End Class
