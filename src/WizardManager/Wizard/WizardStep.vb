Imports System.Windows.Forms
Imports System.Collections.Generic
Imports System.ComponentModel

''' <summary>
''' Base class for Wizard Steps
''' </summary>
''' <remarks>Use Form Inheritance to create steps based on this Class/Form</remarks>
''' <author>Richard Dalton</author>
''' <date>12/Jun/2009</date>
Public Class WizardStep
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Public WithEvents uxTitle As System.Windows.Forms.Label

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.uxTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'uxTitle
        '
        Me.uxTitle.BackColor = System.Drawing.SystemColors.Control
        Me.uxTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.uxTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.uxTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uxTitle.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.uxTitle.Location = New System.Drawing.Point(0, 0)
        Me.uxTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.uxTitle.Name = "uxTitle"
        Me.uxTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.uxTitle.Size = New System.Drawing.Size(520, 20)
        Me.uxTitle.TabIndex = 71
        Me.uxTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'WizardStep
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(520, 330)
        Me.Controls.Add(Me.uxTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "WizardStep"
        Me.Text = "frmWizardStep"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Declarations"
    Private _InitialSetupDone As Boolean
    Private _ParentWizard As Wizard
    Private _args As WizardArgs
#End Region

#Region "Properties"

    ''' <summary>
    ''' A reference to the Wizard that contains the step
    ''' </summary>
    ''' <value></value>
    ''' <remarks></remarks>
    <Browsable(False)> _
    Public Property ParentWizard() As Wizard
        Get
            Return _ParentWizard
        End Get
        Set(ByVal value As Wizard)
            _ParentWizard = value
        End Set
    End Property

    Public ReadOnly Property Host As WizardHost
        Get
            Return DirectCast(Me.Parent, WizardHost)
        End Get
    End Property

    Public Property Args As WizardArgs
        Get
            Return _args
        End Get
        Set(ByVal value As WizardArgs)
            _args = value
        End Set
    End Property

#End Region

#Region "Navigation Methods"

    ''' <summary>
    ''' Optionally override this method to provide validation on Move Next
    ''' </summary>
    ''' <returns>True if it's ok to move next, False to cancel move next</returns>
    ''' <author>Richard Dalton</author>
    ''' <date>12/Jun/2009</date>
    Protected Friend Overridable Function ValidateNext() As Boolean
        Return True
    End Function

    ''' <summary>
    ''' Optionally override this method to provide validation on Move Back
    ''' </summary>
    ''' <returns>True if it's ok to move back, False to cancel move back</returns>
    ''' <author>Richard Dalton</author>
    ''' <date>12/Jun/2009</date>
    Protected Friend Overridable Function ValidatePrevious() As Boolean
        Return True
    End Function

    ''' <summary>
    ''' If a step calls a sub wizard, you should override this method to catch the return of the sub wizard
    ''' </summary>
    ''' <param name="subWizardId">The Id string given to the Sub Wizard when it was created</param>
    ''' <param name="args">The Exit args of the sub wizard</param>
    ''' <author>Richard Dalton</author>
    ''' <date>12/Jun/2009</date>
    Protected Friend Overridable Sub ResumeFrom(ByVal subWizardId As String, ByVal args As WizardArgs)
    End Sub

    ''' <summary>
    ''' Optionally Override this method to write changes to the Database or modify in memory objects such as ExitArgs
    ''' </summary>
    ''' <remarks>Only gets called after ValidateNext or ValidatePrevious return True</remarks>
    ''' <author>Richard Dalton</author>
    ''' <date>12/Jun/2009</date>
    Protected Friend Overridable Sub SaveChanges()
    End Sub

#End Region

#Region "Setup & Display Methods"

    ''' <summary>
    ''' Handles the display of a step and provides initialisation hooks that can be overridden
    ''' </summary>
    ''' <author>Richard Dalton</author>
    ''' <date>12/Jun/2009</date>
    Friend Sub DisplayStep()
        If Not _InitialSetupDone Then
            FirstTimeShown()
            _InitialSetupDone = True
        End If
        EveryTimeShown()
        Me.Show()
    End Sub

    ''' <summary>
    ''' Optionally Override this method to perform initialisation when the step is first displayed
    ''' </summary>
    ''' <author>Richard Dalton</author>
    ''' <date>12/Jun/2009</date>
    Protected Overridable Sub FirstTimeShown()
    End Sub

    ''' <summary>
    ''' Optionally Override this method to perform initialisation every time a step is displayed
    ''' </summary>
    ''' <author>Richard Dalton</author>
    ''' <date>12/Jun/2009</date>
    Protected Overridable Sub EveryTimeShown()
    End Sub

#End Region

End Class
