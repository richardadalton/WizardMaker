Imports System.Collections.Generic
Imports System.Globalization

''' <summary>
''' Generic Form which can be used to provide a way of selecting an item for Modify or Delete
''' </summary>
''' <remarks>Use as the first step in a wizard
'''          Set EntryArgs to a list of ListEntry objects</remarks>
''' <author>Richard Dalton</author>
''' <date>12/Jun/2009</date>
Public Class SelectItemForm

#Region "Overridden Methods"

    ''' <summary>
    ''' Form initialisation that is run when the form is first shown
    ''' </summary>
    ''' <author>Richard Dalton</author>
    ''' <date>12/Jun/2009</date>
    Protected Overrides Sub FirstTimeShown()
        Dim itemType As String = DirectCast(Me.Args("ItemType"), String)
        uxTitle.Text = String.Format(CultureInfo.CurrentCulture, "Select {0}", itemType)
    End Sub

    ''' <summary>
    ''' Form initialisation that is run every time the form is shown
    ''' </summary>
    ''' <author>Richard Dalton</author>
    ''' <date>12/Jun/2009</date>
    Protected Overrides Sub EveryTimeShown()
        Me.ItemList.Items.Clear()

        Dim itemsList As List(Of ListEntry)
        itemsList = DirectCast(Me.Args("ListEntries"), List(Of ListEntry))
        For Each item As ListEntry In itemsList
            Me.ItemList.Items.Add(item)
        Next

        Me.ItemList.ValueMember = "ID"
        Me.ItemList.DisplayMember = "DisplayAs"
    End Sub

    ''' <summary>
    ''' Validation Method called when the user click Next
    ''' </summary>
    ''' <returns>True to allow Move Next, False to Cancel Move Next</returns>
    ''' <remarks></remarks>
    ''' <author>Richard Dalton</author>
    ''' <date>12/Jun/2009</date>
    Protected Friend Overrides Function ValidateNext() As Boolean
        Dim itemType As String = DirectCast(Me.Args("ItemType"), String)

        If Me.ItemList.SelectedItems.Count = 0 Then
            ErrorProvider.SetError(Me.ItemList, String.Format(CultureInfo.CurrentCulture, "You must select a {0}", itemType))
            Return False
        Else
            ErrorProvider.SetError(Me.ItemList, "")
            Return True
        End If

    End Function

    ''' <summary>
    ''' Opportunity to Save Changes when the user leaves a form
    ''' </summary>
    ''' <remarks>Only runs if ValidateNext or ValidatePrevious return True when called</remarks>
    ''' <author>Richard Dalton</author>
    ''' <date>12/Jun/2009</date>
    Protected Friend Overrides Sub SaveChanges()
        Me.ParentWizard.ExitArgs.Replace("SelectedItemKey", DirectCast(Me.ItemList.SelectedItem, ListEntry))
    End Sub

#End Region

End Class
