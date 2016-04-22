<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WizardHost
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WizardHost))
        Me.uxSidebar = New System.Windows.Forms.Panel()
        Me.uxWorkspace = New System.Windows.Forms.Panel()
        Me.HelpProvider = New System.Windows.Forms.HelpProvider()
        Me.uxStatusLabel = New System.Windows.Forms.Label()
        Me.uxNavButtonsPanel = New System.Windows.Forms.GroupBox()
        Me.uxExitButton = New System.Windows.Forms.Button()
        Me.uxHelpButton = New System.Windows.Forms.Button()
        Me.uxCancelButton = New System.Windows.Forms.Button()
        Me.uxNextButton = New System.Windows.Forms.Button()
        Me.uxPreviousButton = New System.Windows.Forms.Button()
        Me.uxNavButtonsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'uxSidebar
        '
        Me.uxSidebar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.uxSidebar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.uxSidebar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.uxSidebar.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.uxSidebar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.uxSidebar.Location = New System.Drawing.Point(8, 8)
        Me.uxSidebar.Name = "uxSidebar"
        Me.uxSidebar.Size = New System.Drawing.Size(79, 379)
        Me.uxSidebar.TabIndex = 15
        '
        'uxWorkspace
        '
        Me.uxWorkspace.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uxWorkspace.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.uxWorkspace.Location = New System.Drawing.Point(93, 8)
        Me.uxWorkspace.Name = "uxWorkspace"
        Me.uxWorkspace.Size = New System.Drawing.Size(681, 379)
        Me.uxWorkspace.TabIndex = 19
        '
        'uxStatusLabel
        '
        Me.uxStatusLabel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.uxStatusLabel.Location = New System.Drawing.Point(0, 437)
        Me.uxStatusLabel.Name = "uxStatusLabel"
        Me.uxStatusLabel.Size = New System.Drawing.Size(780, 16)
        Me.uxStatusLabel.TabIndex = 20
        Me.uxStatusLabel.Text = "No Option Selected ...."
        '
        'uxNavButtonsPanel
        '
        Me.uxNavButtonsPanel.Controls.Add(Me.uxExitButton)
        Me.uxNavButtonsPanel.Controls.Add(Me.uxHelpButton)
        Me.uxNavButtonsPanel.Controls.Add(Me.uxCancelButton)
        Me.uxNavButtonsPanel.Controls.Add(Me.uxNextButton)
        Me.uxNavButtonsPanel.Controls.Add(Me.uxPreviousButton)
        Me.uxNavButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.uxNavButtonsPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.uxNavButtonsPanel.Location = New System.Drawing.Point(0, 389)
        Me.uxNavButtonsPanel.Name = "uxNavButtonsPanel"
        Me.uxNavButtonsPanel.Size = New System.Drawing.Size(780, 48)
        Me.uxNavButtonsPanel.TabIndex = 21
        Me.uxNavButtonsPanel.TabStop = False
        '
        'uxExitButton
        '
        Me.uxExitButton.Image = CType(resources.GetObject("uxExitButton.Image"), System.Drawing.Image)
        Me.uxExitButton.Location = New System.Drawing.Point(8, 16)
        Me.uxExitButton.Name = "uxExitButton"
        Me.uxExitButton.Size = New System.Drawing.Size(24, 23)
        Me.uxExitButton.TabIndex = 4
        '
        'uxHelpButton
        '
        Me.uxHelpButton.Image = CType(resources.GetObject("uxHelpButton.Image"), System.Drawing.Image)
        Me.uxHelpButton.Location = New System.Drawing.Point(38, 16)
        Me.uxHelpButton.Name = "uxHelpButton"
        Me.uxHelpButton.Size = New System.Drawing.Size(24, 23)
        Me.uxHelpButton.TabIndex = 5
        '
        'uxCancelButton
        '
        Me.uxCancelButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uxCancelButton.CausesValidation = False
        Me.uxCancelButton.Enabled = False
        Me.uxCancelButton.Location = New System.Drawing.Point(699, 16)
        Me.uxCancelButton.Name = "uxCancelButton"
        Me.uxCancelButton.Size = New System.Drawing.Size(75, 23)
        Me.uxCancelButton.TabIndex = 9
        Me.uxCancelButton.Text = "Cancel"
        '
        'uxNextButton
        '
        Me.uxNextButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uxNextButton.Enabled = False
        Me.uxNextButton.Location = New System.Drawing.Point(618, 16)
        Me.uxNextButton.Name = "uxNextButton"
        Me.uxNextButton.Size = New System.Drawing.Size(75, 23)
        Me.uxNextButton.TabIndex = 8
        Me.uxNextButton.Text = "Next >"
        '
        'uxPreviousButton
        '
        Me.uxPreviousButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uxPreviousButton.Enabled = False
        Me.uxPreviousButton.Location = New System.Drawing.Point(537, 16)
        Me.uxPreviousButton.Name = "uxPreviousButton"
        Me.uxPreviousButton.Size = New System.Drawing.Size(75, 23)
        Me.uxPreviousButton.TabIndex = 7
        Me.uxPreviousButton.Text = "< Back"
        '
        'WizardHost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.uxNavButtonsPanel)
        Me.Controls.Add(Me.uxStatusLabel)
        Me.Controls.Add(Me.uxWorkspace)
        Me.Controls.Add(Me.uxSidebar)
        Me.Name = "WizardHost"
        Me.Size = New System.Drawing.Size(780, 453)
        Me.uxNavButtonsPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Protected WithEvents uxSidebar As System.Windows.Forms.Panel
    Public WithEvents uxWorkspace As System.Windows.Forms.Panel
    Protected WithEvents HelpProvider As System.Windows.Forms.HelpProvider
    Protected WithEvents uxStatusLabel As System.Windows.Forms.Label
    Protected WithEvents uxNavButtonsPanel As System.Windows.Forms.GroupBox
    Protected WithEvents uxExitButton As System.Windows.Forms.Button
    Protected WithEvents uxHelpButton As System.Windows.Forms.Button
    Protected WithEvents uxCancelButton As System.Windows.Forms.Button
    Protected WithEvents uxNextButton As System.Windows.Forms.Button
    Protected WithEvents uxPreviousButton As System.Windows.Forms.Button

End Class
