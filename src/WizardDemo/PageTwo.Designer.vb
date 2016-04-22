<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PageTwo
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
        Me.SuspendLayout()
        '
        'uxTitle
        '
        Me.uxTitle.Text = "Configure Feature Page One"
        '
        'PageTwo
        '
        Me.ClientSize = New System.Drawing.Size(520, 330)
        Me.Name = "PageTwo"
        Me.ResumeLayout(False)

    End Sub

End Class
