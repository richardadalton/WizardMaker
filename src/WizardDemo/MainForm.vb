
Public Class MainForm

    Private Sub createButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles createButton.Click
        Dim wizard As New Wizard(Me.WizardHost1, "CreateInstall")
        wizard.AddStep(New selectComponentsForm)
        WizardHost1.StartWizard(wizard)
    End Sub

    Private Sub modifyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modifyButton.Click
        Dim args As New WizardArgs()
        args.Add("ItemType", "Profile") _
            .Add("ListEntries", GetListEntries)

        Dim wizard As New Wizard(Me.WizardHost1, "ModifyInstall")
        wizard.AddStep(New SelectItemForm, args) _
              .AddStep(New selectComponentsForm)
        WizardHost1.StartWizard(wizard)
    End Sub

    Private Function GetListEntries() As List(Of ListEntry)
        Dim listEntries As New List(Of ListEntry)
        listEntries.Add(New ListEntry(1, "Richard"))
        listEntries.Add(New ListEntry(2, "Sandra"))
        listEntries.Add(New ListEntry(3, "Oisin"))
        listEntries.Add(New ListEntry(4, "Sample"))
        Return listEntries
    End Function

End Class
