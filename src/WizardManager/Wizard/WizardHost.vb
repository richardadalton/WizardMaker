Option Strict Off
Imports System
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports System.ComponentModel
<Assembly: CLSCompliant(True)> 

''' <summary>
''' A base UserControl that Wizard UserControls should be inherited from 
''' </summary>
''' <remarks></remarks>
''' <author>Richard Dalton</author>
''' <date>12/Jun/2009</date>
Public Class WizardHost

#Region "Declarations "
    ' Private Member Variables    
    Private WithEvents _activeWizard As Wizard
    Private _wizardStack As New Stack(Of Wizard)
#End Region

#Region "Public Methods"

    ''' <summary>
    ''' Start the provided wizard.
    ''' </summary>
    ''' <param name="wizard"></param>
    ''' <remarks>If we are in an existing wizard, push it onto the stack, to be resumed later.</remarks>
    Public Sub StartWizard(ByVal wizard As Wizard)
        ' Starting while in an existing wizard, so push the existing wizard onto the stack
        If WizardInProcess() Then
            _activeWizard.HideAll()
            _wizardStack.Push(_activeWizard)
        End If

        ' Make the new wizard active
        _activeWizard = wizard
        _activeWizard.MoveNext()
        ShowWizard()
    End Sub

#End Region

#Region "Event Handlers "

    Private Sub _activeWizard_LeavingStep() Handles _activeWizard.LeavingStep
        HideStep()
    End Sub

    Private Sub _activeWizard_StepChanged() Handles _activeWizard.StepChanged
        If _activeWizard.Count = 0 Then
            CancelActiveWizard()
        Else
            ShowWizard()
        End If
    End Sub

    ''' <summary>
    ''' User Clicks the Move Next Button
    ''' </summary>
    ''' <author>Richard Dalton</author>
    ''' <date>12/Jun/2009</date>
    Private Sub uxNextButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uxNextButton.Click
        MoveNext()
    End Sub

    ''' <summary>
    ''' User Clicks the Move Next Button
    ''' </summary>
    ''' <author>Richard Dalton</author>
    ''' <date>12/Jun/2009</date>
    Private Sub uxPreviousButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uxPreviousButton.Click
        MovePrevious()
    End Sub

    ''' <summary>
    ''' User Clicks the Cancel Button
    ''' </summary>
    ''' <author>Richard Dalton</author>
    ''' <date>12/Jun/2009</date>
    Private Sub uxCancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uxCancelButton.Click
        CancelActiveWizard()
    End Sub

    ''' <summary>
    ''' User Clicks the Exit Button
    ''' </summary>
    ''' <author>Richard Dalton</author>
    ''' <date>12/Jun/2009</date>
    Private Sub uxExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uxExitButton.Click
        ExitAllWizards()
    End Sub

    ''' <summary>
    ''' User clicks the help button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Relies on the inherited user control to set the HelpProvider.NelpNamespace property</remarks>
    ''' <author>Richard Dalton</author>
    ''' <date>25/Jun/2009</date>
    Private Sub uxHelpButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uxHelpButton.Click
        If Me.HelpProvider.HelpNamespace <> String.Empty Then
            Help.ShowHelp(Me, Me.HelpProvider.HelpNamespace, HelpNavigator.Topic)
        End If
    End Sub

#End Region

#Region "Private Methods"

#Region "Navigation Methods"

    ''' <summary>
    ''' Hides the existing form, moves to the next step, displays the new form.
    ''' </summary>
    ''' <remarks>If MoveNext Finishes a wizard, attempt to restore any previous wizard (this may be a sub wizard)</remarks>
    ''' <author>Richard Dalton</author>
    ''' <date>12/Jun/2009</date>
    Private Sub MoveNext()

        ' Run any 'Move Next' validation for the form. 
        If Not _activeWizard.CurrentItem.ValidateNext Then
            Exit Sub
        End If

        ' Allow the Wizard Step to deal with the data it captured
        _activeWizard.CurrentItem.SaveChanges()

        HideStep()

        _activeWizard.MoveNext()
        If _activeWizard.IsFinished Then
            _activeWizard = ResumePreviousWizard(True)
        End If

        ShowWizard()

    End Sub

    ''' <summary>
    ''' Hides the existing form, moves to the previous step, displays the new form.
    ''' </summary>
    ''' <author>Richard Dalton</author>
    ''' <date>12/Jun/2009</date>
    Private Sub MovePrevious()

        ' Run any 'Move Previous' validation for the form. 
        If Not _activeWizard.CurrentItem.ValidatePrevious Then
            Exit Sub
        End If

        ' Allow the Wizard Step to deal with the data it captured
        _activeWizard.CurrentItem.SaveChanges()

        HideStep()
        _activeWizard.MovePrevious()
        ShowWizard()

    End Sub

    ''' <summary>
    ''' Cancel out of the current wizard, if there's a parent wizard, resume it.
    ''' </summary>
    ''' <author>Richard Dalton</author>
    ''' <date>12/Jun/2005</date>
    Private Sub CancelActiveWizard()
        _activeWizard.HideAll()
        _activeWizard = ResumePreviousWizard(False)
        ShowWizard()
    End Sub

    ''' <summary>
    ''' Cancel out of all wizards.
    ''' </summary>
    ''' <author>Richard Dalton</author>
    ''' <date>12/Jun/2005</date>
    Private Sub CancelAllWizards()
        _activeWizard.HideAll()
        _activeWizard = Nothing
        _wizardStack = New Stack(Of Wizard)
        ShowWizard()
    End Sub

    ''' <summary>
    ''' Completely exit the Control Log Utility.
    ''' </summary>
    ''' <remarks>Can only happen if there's no active wizard.</remarks>
    ''' <author>Richard Dalton</author>
    ''' <date>12/Jun/2009</date>
    Private Sub ExitAllWizards()
        If Not WizardInProcess() Then
            Me.Visible = False
            Dim objParent As Object = Me.Parent
            objParent.ShowMainForm()
        End If
    End Sub

    ''' <summary>
    ''' Resume a parent wizard after leaving a sub wizard
    ''' </summary>
    ''' <param name="sendExitParamsToParent">Indicates whether the ExitParams of the sub wizard should be sent to the parent wizard</param>
    ''' <returns>The wizard being resumed.  If there is no previous wizard, return nothing</returns>
    ''' <remarks>When cancelling a wizard, sendExitParamsToParent should be false</remarks>
    ''' <author>Richard Dalton</author>
    ''' <date>12/Jun/2009</date>
    Private Function ResumePreviousWizard(ByVal sendExitParamsToParent As Boolean) As Wizard
        If NothingToResume() Then
            Return Nothing
        End If

        Dim wizard As Wizard = _wizardStack.Pop

        If sendExitParamsToParent Then
            wizard.CurrentItem.ResumeFrom(_activeWizard.Id, _activeWizard.ExitArgs)
        End If

        Return wizard
    End Function

    Private Function NothingToResume() As Boolean
        return _wizardStack Is Nothing OrElse _wizardStack.Count = 0 
    End Function

#End Region

#Region "Display Methods"

    ''' <summary>
    ''' If there is a visible step, hide it
    ''' </summary>
    ''' <author>Richard Dalton</author>
    ''' <date>12/Jun/2009</date>
    Private Sub HideStep()
        If _activeWizard.IsInProgress Then
            _activeWizard.CurrentItem.Hide()
        End If
    End Sub

    ''' <summary>
    ''' Determine whether to show a form for a wizard step, or the Welcome Screen.
    ''' </summary>
    ''' <remarks>If not in any wizard, show the Control Log Welcome screen.</remarks>
    ''' <author>Richard Dalton</author>
    ''' <date>12/Jun/2009</date>
    Private Sub ShowWizard()

        ' No Wizard Active
        If _activeWizard Is Nothing Then
            ShowWelcomeScreen()
            Exit Sub
        End If

        ' Step Selected
        If _activeWizard.IsInProgress Then
            ShowStep()
        End If

    End Sub

    ''' <summary>
    ''' Show the Welcome Screen
    ''' </summary>
    ''' <author>Richard Dalton</author>
    ''' <date>12/Jun/2009</date>
    Private Sub ShowWelcomeScreen()
        uxWorkspace.Visible = True
        EnableActionButtons()
        DisableNavigationButtons()
    End Sub

    ''' <summary>
    ''' Show the current wizard step
    ''' </summary>
    ''' <author>Richard Dalton</author>
    ''' <date>12/Jun/2009</date>
    Private Sub ShowStep()
        uxWorkspace.Visible = False
        _activeWizard.CurrentItem.DisplayStep()

        DisableActionButtons()
        EnableNavigationButtons()
    End Sub

#End Region

#Region "Enable/Disable Buttons"

    ''' <summary>
    ''' Enable the Navigations Buttons
    ''' </summary>
    ''' <author>Richard Dalton</author>
    ''' <date>12/Jun/2009</date>
    Private Sub EnableNavigationButtons()

        ' Previous Button
        uxPreviousButton.Enabled = Not _activeWizard.IsFirstStep

        ' Next Button
        uxNextButton.Enabled = True
        If _activeWizard.IsLastStep Then
            SetNextButtonText(NextButtonState.Finish)
        Else
            SetNextButtonText(NextButtonState.MoveNext)
        End If

        ' Cancel Button
        uxCancelButton.Enabled = True

    End Sub

    ''' <summary>
    ''' Disable the Navigations Buttons
    ''' </summary>
    ''' <author>Richard Dalton</author>
    ''' <date>12/Jun/2009</date>
    Private Sub DisableNavigationButtons()
        uxPreviousButton.Enabled = False
        uxNextButton.Enabled = False
        uxCancelButton.Enabled = False
        SetNextButtonText(NextButtonState.MoveNext)
    End Sub

#End Region

#Region "Wizard Status Methods"

    ''' <summary>
    ''' Indicates whether there is a wizard is in process
    ''' </summary>
    ''' <remarks>Saves having to check "If _activeWizard Is Nothing" throughout code.</remarks>
    ''' <author>Richard Dalton</author>
    ''' <date>12/Jun/2009</date>
    Private Function WizardInProcess() As Boolean
        If _activeWizard Is Nothing Then
            Return False
        End If

        Return _activeWizard.IsInProgress
    End Function

#End Region

#End Region

#Region "Protected Methods"
    ''' <summary>
    ''' Override this method to enable the wizard action buttons on the welcome screen
    ''' </summary>
    ''' <author>Richard Dalton</author>
    ''' <date>12/Jun/2009</date>
    Protected Overridable Sub EnableActionButtons()
    End Sub

    ''' <summary>
    ''' Override this method to disable the wizard action buttons on the welcome screen
    ''' </summary>
    ''' <author>Richard Dalton</author>
    ''' <date>12/Jun/2009</date>
    Protected Overridable Sub DisableActionButtons()
    End Sub

    ''' <summary>
    ''' Override this method to Initialise the Inherited Wizard User Control
    ''' </summary>
    ''' <author>Richard Dalton</author>
    ''' <date>23/Jun/2009</date>
    Protected Overridable Sub InitialiseHostControl()
    End Sub

    Protected Enum NextButtonState
        MoveNext = 1
        Finish = 2
    End Enum

    ''' <summary>
    ''' Override this method to set the Caption of the Next button
    ''' </summary>
    ''' <param name="buttonState">Indicates whether the Button should say Next or Finish</param>
    ''' <remarks>Needs to be overridden of the inherited user control provides localisation
    ''' The Next Button changes caption, so this even notifies the user control when to change.</remarks>
    ''' <author>Richard Dalton</author>
    ''' <date>25/Jun/2009</date>
    Protected Overridable Sub SetNextButtonText(ByVal buttonState As NextButtonState)
        If buttonState = NextButtonState.MoveNext Then
            uxNextButton.Text = "Next >"
        Else
            uxNextButton.Text = "Finish >"
        End If
    End Sub

#End Region

#Region "Constructor "
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub
#End Region

End Class
