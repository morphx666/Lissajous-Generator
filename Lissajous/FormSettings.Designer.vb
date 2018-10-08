<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSettings
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
        Me.TextBoxAngleStep = New System.Windows.Forms.TextBox()
        Me.TextBoxHPhase = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxVPhase = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonApply = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Angle Step"
        '
        'TextBoxAngleStep
        '
        Me.TextBoxAngleStep.BackColor = System.Drawing.Color.Gainsboro
        Me.TextBoxAngleStep.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAngleStep.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.TextBoxAngleStep.Location = New System.Drawing.Point(125, 12)
        Me.TextBoxAngleStep.Name = "TextBoxAngleStep"
        Me.TextBoxAngleStep.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxAngleStep.TabIndex = 1
        Me.TextBoxAngleStep.Text = "0.001"
        Me.TextBoxAngleStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxHPhase
        '
        Me.TextBoxHPhase.BackColor = System.Drawing.Color.Gainsboro
        Me.TextBoxHPhase.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxHPhase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.TextBoxHPhase.Location = New System.Drawing.Point(125, 40)
        Me.TextBoxHPhase.Name = "TextBoxHPhase"
        Me.TextBoxHPhase.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxHPhase.TabIndex = 3
        Me.TextBoxHPhase.Text = "0.001"
        Me.TextBoxHPhase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Horizontal Phase"
        '
        'TextBoxVPhase
        '
        Me.TextBoxVPhase.BackColor = System.Drawing.Color.Gainsboro
        Me.TextBoxVPhase.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxVPhase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.TextBoxVPhase.Location = New System.Drawing.Point(125, 68)
        Me.TextBoxVPhase.Name = "TextBoxVPhase"
        Me.TextBoxVPhase.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxVPhase.TabIndex = 5
        Me.TextBoxVPhase.Text = "0.001"
        Me.TextBoxVPhase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(12, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Vertical Phase"
        '
        'ButtonApply
        '
        Me.ButtonApply.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonApply.Location = New System.Drawing.Point(135, 119)
        Me.ButtonApply.Name = "ButtonApply"
        Me.ButtonApply.Size = New System.Drawing.Size(75, 27)
        Me.ButtonApply.TabIndex = 6
        Me.ButtonApply.Text = "Apply"
        Me.ButtonApply.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClose.Location = New System.Drawing.Point(216, 119)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(75, 27)
        Me.ButtonClose.TabIndex = 6
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'FormSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(303, 158)
        Me.ControlBox = False
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonApply)
        Me.Controls.Add(Me.TextBoxVPhase)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxHPhase)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxAngleStep)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxAngleStep As TextBox
    Friend WithEvents TextBoxHPhase As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxVPhase As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonApply As Button
    Friend WithEvents ButtonClose As Button
End Class
