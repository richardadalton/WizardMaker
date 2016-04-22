Public Class selectComponentsForm
    Private Const SUBWIZ_CONFIGURE_FEATURE As String = "ConfigureFeature"
    Private Const SUBWIZ_CONFIGURE_ADMIN As String = "ConfigureAdmin"
    Private Const SUBWIZ_CONFIGURE_DOCUMENTATION As String = "ConfigureDocumentation"

    Protected Overrides Sub EveryTimeShown()
        MyBase.EveryTimeShown()

        If Me.ParentWizard.ExitArgs.Contains("SelectedItemKey") Then
            Dim selectedItem As ListEntry = CType(Me.ParentWizard.ExitArgs("SelectedItemKey"), ListEntry)
            Me.uxTitle.Text = selectedItem.Description
        Else
            Me.uxTitle.Text = "[New Profile]"
        End If
    End Sub

    Private Sub configureFeatureButton_Click(sender As System.Object, e As System.EventArgs) Handles configureFeatureButton.Click
        Dim wizard As New Wizard(Host, SUBWIZ_CONFIGURE_FEATURE)
        wizard.AddStep(New PageTwo) _
              .AddStep(New PageThree)
        Host.StartWizard(wizard)
    End Sub

    Private Sub configureAdminButton_Click(sender As System.Object, e As System.EventArgs) Handles configureAdminButton.Click
        Dim wizard As New Wizard(Host, SUBWIZ_CONFIGURE_ADMIN)
        wizard.AddStep(New PageTwo)
        Host.StartWizard(wizard)
    End Sub

    Private Sub configureDocumentationButton_Click(sender As System.Object, e As System.EventArgs) Handles configureDocumentationButton.Click
        Dim wizard As New Wizard(Host, SUBWIZ_CONFIGURE_DOCUMENTATION)
        wizard.AddStep(New PageTwo)
        Host.StartWizard(wizard)
    End Sub

    Protected Overrides Sub ResumeFrom(ByVal subWizardId As String, ByVal args As WizardArgs)
        Select Case subWizardId
            Case SUBWIZ_CONFIGURE_FEATURE
                featureDoneCheckBox.Checked = True
            Case SUBWIZ_CONFIGURE_ADMIN
                adminDoneCheckBox.Checked = True
            Case SUBWIZ_CONFIGURE_DOCUMENTATION
                documentationDoneCheckBox.Checked = True
        End Select
    End Sub

End Class
