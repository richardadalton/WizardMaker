Imports System.Windows.Forms
Imports System.Collections.Generic

''' <summary>
''' Controller object for managing Wizards
''' </summary>
''' <remarks></remarks>
''' <author>Richard Dalton</author>
''' <date>12-Jun-2009</date>
Public Class Wizard

#Region "Declarations"

    Private _hostControl As WizardHost
    Private _id As String
    Private _steps As New List(Of WizardStep)
    Private _currentStep As Integer

    Private _entryArgs As New WizardArgs
    Private _exitArgs As New WizardArgs

#End Region

    Public Event LeavingStep()
    Public Event StepChanged()

#Region "Properties"

    ''' <summary>
    ''' A string which identifies the Wizard within an application
    ''' </summary>
    ''' <value></value>
    ''' <remarks>This allows a calling form to identify which subwizard has completed</remarks>
    Public ReadOnly Property Id() As String
        Get
            Return _id
        End Get
    End Property

    ''' <summary>
    ''' The collection of steps in the wizard
    ''' </summary>
    ''' <param name="index">The number of the requried step</param>
    ''' <value></value>
    ''' <remarks>This is a 1 based collecgtion.  The first step is 1.</remarks>
    Public ReadOnly Property Item(ByVal index As Integer) As WizardStep
        Get
            Return _steps(index - 1)
        End Get
    End Property

    ''' <summary>
    ''' The currently active step in the wizard.
    ''' </summary>
    ''' <value></value>
    ''' <remarks></remarks>
    Public ReadOnly Property CurrentItem() As WizardStep
        Get
            Return Item(_currentStep)
        End Get
    End Property

    ''' <summary>
    ''' The position of the currently active step in the wizard.
    ''' </summary>
    ''' <value></value>
    ''' <remarks></remarks>
    Public ReadOnly Property CurrentItemPosition() As Integer
        Get
            Return _currentStep
        End Get
    End Property

    ''' <summary>
    ''' The Number of steps in the Wizard
    ''' </summary>
    ''' <value></value>
    ''' <remarks></remarks>
    Public ReadOnly Property Count() As Integer
        Get
            Return _steps.Count
        End Get
    End Property

    ''' <summary>
    ''' Indicates if the Wizard is currently in progress
    ''' </summary>
    ''' <value></value>
    ''' <remarks>Returns True if the Wizard is active, False if it has terminated or not yet started.</remarks>
    Public ReadOnly Property IsInProgress() As Boolean
        Get
            Return _currentStep > 0 And Not IsFinished
        End Get
    End Property

    ''' <summary>
    ''' Indicates whether the current step is the first step in the wizard
    ''' </summary>
    ''' <value></value>
    ''' <remarks></remarks>
    Public ReadOnly Property IsFirstStep() As Boolean
        Get
            Return _currentStep = 1
        End Get
    End Property

    ''' <summary>
    ''' Indicates whether the current step is the last step in the wizard
    ''' </summary>
    ''' <value></value>
    ''' <remarks></remarks>
    Public ReadOnly Property IsLastStep() As Boolean
        Get
            Return _currentStep = _steps.Count
        End Get
    End Property

    ''' <summary>
    ''' Indicates whether the final step of the wizard has been passed
    ''' </summary>
    ''' <value></value>
    ''' <remarks></remarks>
    Public ReadOnly Property IsFinished() As Boolean
        Get
            Return _currentStep > _steps.Count
        End Get
    End Property

    ''' <summary>
    ''' A collection of Arguments that are passed into the wizard
    ''' </summary>
    ''' <value></value>
    ''' <remarks>Can be accessed and updated by any step within the wizard</remarks>
    Public ReadOnly Property EntryArgs() As WizardArgs
        Get
            Return _entryArgs
        End Get
    End Property

    ''' <summary>
    ''' A collection of Arguments that are passed from the wizard to it's parent
    ''' </summary>
    ''' <value></value>
    ''' <remarks>Can be accessed and updated by any step within the wizard</remarks>
    Public ReadOnly Property ExitArgs() As WizardArgs
        Get
            Return _exitArgs
        End Get
    End Property

#End Region

#Region "Public Methods"

    ''' <summary>
    ''' Add a wizard step to this Wizard.
    ''' </summary>
    ''' <param name="form">The form to add, this must inherit from WizardStep</param>
    ''' <returns>A reference to this wizard with the new step added</returns>
    ''' <remarks>Steps must be added in order</remarks>
    Public Function AddStep(ByVal form As WizardStep) As Wizard
        ConfigureForm(form)
        _steps.Add(form)
        Return Me
    End Function

    Public Function AddStep(ByVal form As WizardStep, ByVal args As WizardArgs) As Wizard
        ConfigureForm(form)
        form.Args = args
        _steps.Add(form)
        Return Me
    End Function

    Public Function AddStep(ByVal form As WizardStep, ByVal args As WizardArgs, ByVal title As String) As Wizard
        ConfigureForm(form)
        form.Args = args
        form.uxTitle.Text = title
        _steps.Add(form)
        Return Me
    End Function

    Public Function ReplaceCurrentStep(ByVal form As WizardStep) As Wizard
        ConfigureForm(form)

        RaiseEvent LeavingStep()
        _steps.Item(_currentStep - 1) = form
        RaiseEvent StepChanged()

        Return Me
    End Function

    Public Function InsertStepAfterCurrent(ByVal form As WizardStep) As Wizard
        ConfigureForm(form)

        RaiseEvent LeavingStep()
        _steps.Insert(_currentStep, form)
        RaiseEvent StepChanged()

        Return Me
    End Function

    Public Function DeleteCurrentStep() As Wizard
        RaiseEvent LeavingStep()
        _steps.RemoveAt(_currentStep - 1)
        If _currentStep > _steps.Count Then
            _currentStep = _steps.Count
        End If
        RaiseEvent StepChanged()

        Return Me
    End Function

    Public Function SwapSteps(ByVal fromIndex As Integer, ByVal toIndex As Integer)

        Dim stepToMove As WizardStep = _steps(fromIndex - 1)
        _steps.RemoveAt(fromIndex - 1)

        RaiseEvent LeavingStep()
        _steps.Insert(toIndex - 1, stepToMove)
        _currentStep = toIndex
        RaiseEvent StepChanged()
        Return Me
    End Function

    ''' <summary>
    ''' Increment the Current Step
    ''' </summary>
    ''' <returns>A reference to this Wizard</returns>
    ''' <remarks></remarks>
    Public Function MoveNext() As Wizard
        _currentStep = _currentStep + 1
        Return Me
    End Function

    ''' <summary>
    ''' Decrement the Current Step
    ''' </summary>
    ''' <returns>A reference to this Wizard</returns>
    ''' <remarks></remarks>
    Public Function MovePrevious() As Wizard
        _currentStep = _currentStep - 1
        Return Me
    End Function

    ''' <summary>
    ''' Set the Current Step back to 0 (Start of the Wizard)
    ''' </summary>
    ''' <returns>A reference to this Wizard</returns>
    ''' <remarks></remarks>
    Public Function Reset() As Wizard
        _currentStep = 0
        Return Me
    End Function

    ''' <summary>
    ''' Make a specific step the current step
    ''' </summary>
    ''' <returns>A reference to this Wizard</returns>
    ''' <remarks></remarks>
    Public Function SetCurrentStep(ByVal stepNumber As Integer) As Wizard
        If stepNumber > _steps.Count Then
            Throw New System.ArgumentOutOfRangeException
        End If
        RaiseEvent LeavingStep()
        _currentStep = stepNumber
        RaiseEvent StepChanged()
        Return Me
    End Function

    ''' <summary>
    ''' Hide all forms in this Wizard
    ''' </summary>
    ''' <remarks>Used when launching a SubWizard or when ending or cancelling this Wizard</remarks>
    Public Sub HideAll()
        For Each form As WizardStep In _steps
            form.Hide()
        Next form
    End Sub

#End Region

    Private Sub ConfigureForm(ByVal form As WizardStep)
        form.TopLevel = False ' set top level to false (otherwise we wouldnt be able to put the form inside the host control
        form.Parent = _hostControl ' put our loaded form inside this control
        form.ParentWizard = Me

        form.Left = _hostControl.uxWorkspace.Left
        form.Top = _hostControl.uxWorkspace.Top
        form.Size = _hostControl.uxWorkspace.Size
        form.Anchor = AnchorStyles.Top + AnchorStyles.Bottom + AnchorStyles.Left + AnchorStyles.Right
    End Sub

#Region "Constructors"

    ''' <summary>
    ''' Constructor that allows EntryArgs to be specified
    ''' </summary>
    ''' <param name="hostControl">The WizardHost UserControl that will contain the WizardSteps</param>
    ''' <param name="id">The internal Name of the Wizard</param>
    ''' <param name="entryArgs">Any arguments that can be pssed to the Wizard.</param>
    ''' <remarks>This version of the constructor is used when we wish to pass parameters to a SubWizard</remarks>
    Public Sub New(ByVal hostControl As WizardHost, ByVal id As String, ByVal entryArgs As WizardArgs)
        _hostControl = hostControl
        _id = id
        _entryArgs = entryArgs
        _exitArgs = New WizardArgs
    End Sub

    ''' <summary>
    ''' Constructor that doesn't allow EntryArgs to be specified
    ''' </summary>
    ''' <param name="hostControl">The WizardHost UserControl that will contain the WizardSteps (Forms)</param>
    ''' <param name="id">The internal Name of the Wizard</param>
    ''' <remarks>This version of the constructor is used when a wizard requires no parameters, e.g. for creating the root Wizard</remarks>
    Public Sub New(ByVal hostControl As WizardHost, ByVal id As String)
        _hostControl = hostControl
        _id = id
        _exitArgs = New WizardArgs
    End Sub

#End Region

End Class
