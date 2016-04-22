<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectItemForm
    Inherits WizardManager.WizardStep

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
        Me.components = New System.ComponentModel.Container()
        Me.ItemList = New System.Windows.Forms.ListBox()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ItemList
        '
        Me.ItemList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemList.FormattingEnabled = True
        Me.ItemList.Location = New System.Drawing.Point(23, 36)
        Me.ItemList.Name = "ItemList"
        Me.ItemList.Size = New System.Drawing.Size(472, 264)
        Me.ItemList.TabIndex = 72
        '
        'ErrorProvider
        '
        Me.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider.ContainerControl = Me
        '
        'SelectItemForm
        '
        Me.ClientSize = New System.Drawing.Size(520, 330)
        Me.Controls.Add(Me.ItemList)
        Me.Name = "SelectItemForm"
        Me.Controls.SetChildIndex(Me.ItemList, 0)
        Me.Controls.SetChildIndex(Me.uxTitle, 0)
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ItemList As System.Windows.Forms.ListBox
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider

End Class
