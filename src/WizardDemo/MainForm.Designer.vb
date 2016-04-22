<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.createButton = New System.Windows.Forms.Button()
        Me.WizardHost1 = New WizardManager.WizardHost()
        Me.modifyButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'createButton
        '
        Me.createButton.Location = New System.Drawing.Point(13, 13)
        Me.createButton.Name = "createButton"
        Me.createButton.Size = New System.Drawing.Size(70, 61)
        Me.createButton.TabIndex = 1
        Me.createButton.Text = "Create"
        Me.createButton.UseVisualStyleBackColor = True
        '
        'WizardHost1
        '
        Me.WizardHost1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WizardHost1.Location = New System.Drawing.Point(0, 0)
        Me.WizardHost1.Name = "WizardHost1"
        Me.WizardHost1.Size = New System.Drawing.Size(971, 480)
        Me.WizardHost1.TabIndex = 0
        '
        'modifyButton
        '
        Me.modifyButton.Location = New System.Drawing.Point(12, 80)
        Me.modifyButton.Name = "modifyButton"
        Me.modifyButton.Size = New System.Drawing.Size(70, 61)
        Me.modifyButton.TabIndex = 2
        Me.modifyButton.Text = "Modify"
        Me.modifyButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 480)
        Me.Controls.Add(Me.modifyButton)
        Me.Controls.Add(Me.createButton)
        Me.Controls.Add(Me.WizardHost1)
        Me.Name = "MainForm"
        Me.Text = "Install Profile Wizard"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WizardHost1 As WizardHost
    Friend WithEvents createButton As System.Windows.Forms.Button
    Friend WithEvents modifyButton As System.Windows.Forms.Button

End Class
