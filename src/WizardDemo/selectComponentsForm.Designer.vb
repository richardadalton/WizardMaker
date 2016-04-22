<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class selectComponentsForm
    Inherits WizardStep

    'Form overrides dispose to clean up the component list.
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
        Me.featureDoneCheckBox = New System.Windows.Forms.CheckBox()
        Me.adminDoneCheckBox = New System.Windows.Forms.CheckBox()
        Me.documentationDoneCheckBox = New System.Windows.Forms.CheckBox()
        Me.configureFeatureButton = New System.Windows.Forms.Button()
        Me.configureAdminButton = New System.Windows.Forms.Button()
        Me.configureDocumentationButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.optionalLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'featureDoneCheckBox
        '
        Me.featureDoneCheckBox.AutoCheck = False
        Me.featureDoneCheckBox.AutoSize = True
        Me.featureDoneCheckBox.Location = New System.Drawing.Point(20, 59)
        Me.featureDoneCheckBox.Name = "featureDoneCheckBox"
        Me.featureDoneCheckBox.Size = New System.Drawing.Size(93, 17)
        Me.featureDoneCheckBox.TabIndex = 73
        Me.featureDoneCheckBox.Text = "Super Feature"
        Me.featureDoneCheckBox.UseVisualStyleBackColor = True
        '
        'adminDoneCheckBox
        '
        Me.adminDoneCheckBox.AutoCheck = False
        Me.adminDoneCheckBox.AutoSize = True
        Me.adminDoneCheckBox.Location = New System.Drawing.Point(20, 166)
        Me.adminDoneCheckBox.Name = "adminDoneCheckBox"
        Me.adminDoneCheckBox.Size = New System.Drawing.Size(93, 17)
        Me.adminDoneCheckBox.TabIndex = 74
        Me.adminDoneCheckBox.Text = "Admin Module"
        Me.adminDoneCheckBox.UseVisualStyleBackColor = True
        '
        'documentationDoneCheckBox
        '
        Me.documentationDoneCheckBox.AutoCheck = False
        Me.documentationDoneCheckBox.AutoSize = True
        Me.documentationDoneCheckBox.Location = New System.Drawing.Point(20, 237)
        Me.documentationDoneCheckBox.Name = "documentationDoneCheckBox"
        Me.documentationDoneCheckBox.Size = New System.Drawing.Size(98, 17)
        Me.documentationDoneCheckBox.TabIndex = 75
        Me.documentationDoneCheckBox.Text = "Documentation"
        Me.documentationDoneCheckBox.UseVisualStyleBackColor = True
        '
        'configureFeatureButton
        '
        Me.configureFeatureButton.Location = New System.Drawing.Point(134, 55)
        Me.configureFeatureButton.Name = "configureFeatureButton"
        Me.configureFeatureButton.Size = New System.Drawing.Size(75, 23)
        Me.configureFeatureButton.TabIndex = 76
        Me.configureFeatureButton.Text = "Configure"
        Me.configureFeatureButton.UseVisualStyleBackColor = True
        '
        'configureAdminButton
        '
        Me.configureAdminButton.Location = New System.Drawing.Point(134, 162)
        Me.configureAdminButton.Name = "configureAdminButton"
        Me.configureAdminButton.Size = New System.Drawing.Size(75, 23)
        Me.configureAdminButton.TabIndex = 77
        Me.configureAdminButton.Text = "Configure"
        Me.configureAdminButton.UseVisualStyleBackColor = True
        '
        'configureDocumentationButton
        '
        Me.configureDocumentationButton.Location = New System.Drawing.Point(134, 233)
        Me.configureDocumentationButton.Name = "configureDocumentationButton"
        Me.configureDocumentationButton.Size = New System.Drawing.Size(75, 23)
        Me.configureDocumentationButton.TabIndex = 78
        Me.configureDocumentationButton.Text = "Configure"
        Me.configureDocumentationButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(231, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 26)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "This is the super feature that you really should install." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "It makes everything be" & _
    "tter, faster and more reliable."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(231, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(263, 39)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "This is the Administration module for the Super Feature" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "It allows you to change " & _
    "everything you could possibly" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "want to change."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(231, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(231, 13)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "This is the documentation for the Super Feature"
        '
        'optionalLabel
        '
        Me.optionalLabel.AutoSize = True
        Me.optionalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optionalLabel.Location = New System.Drawing.Point(20, 126)
        Me.optionalLabel.Name = "optionalLabel"
        Me.optionalLabel.Size = New System.Drawing.Size(127, 13)
        Me.optionalLabel.TabIndex = 82
        Me.optionalLabel.Text = "Optional Components"
        '
        'selectComponentsForm
        '
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(520, 330)
        Me.Controls.Add(Me.optionalLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.configureDocumentationButton)
        Me.Controls.Add(Me.configureAdminButton)
        Me.Controls.Add(Me.configureFeatureButton)
        Me.Controls.Add(Me.documentationDoneCheckBox)
        Me.Controls.Add(Me.adminDoneCheckBox)
        Me.Controls.Add(Me.featureDoneCheckBox)
        Me.Name = "selectComponentsForm"
        Me.Controls.SetChildIndex(Me.featureDoneCheckBox, 0)
        Me.Controls.SetChildIndex(Me.uxTitle, 0)
        Me.Controls.SetChildIndex(Me.adminDoneCheckBox, 0)
        Me.Controls.SetChildIndex(Me.documentationDoneCheckBox, 0)
        Me.Controls.SetChildIndex(Me.configureFeatureButton, 0)
        Me.Controls.SetChildIndex(Me.configureAdminButton, 0)
        Me.Controls.SetChildIndex(Me.configureDocumentationButton, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.optionalLabel, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents featureDoneCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents adminDoneCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents documentationDoneCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents configureFeatureButton As System.Windows.Forms.Button
    Friend WithEvents configureAdminButton As System.Windows.Forms.Button
    Friend WithEvents configureDocumentationButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents optionalLabel As System.Windows.Forms.Label

End Class
