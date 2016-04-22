Imports System.Collections.Generic

''' <summary>
''' Wrapper for a collection of arguments that can be passed into or out of a Wizard
''' </summary>
''' <remarks></remarks>
''' <author>Richard Dalton</author>
''' <date>12/Jun/2009</date>
Public Class WizardArgs

#Region "Declarations"
    Private _args As New Dictionary(Of String, Object)
#End Region

#Region "Properties"
    ''' <summary>
    ''' Returns a named argument from the collection
    ''' </summary>
    ''' <param name="key">The name of the required argument</param>
    ''' <value></value>
    ''' <remarks>Datatype is Object.  The returned value should be Cast to the correct type.</remarks>
    Default Public ReadOnly Property Item(ByVal key As String) As Object
        Get
            Return _args(key)
        End Get
    End Property

    ''' <summary>
    ''' The number of arguments in the collection.
    ''' </summary>
    ''' <value></value>
    ''' <remarks></remarks>
    Public ReadOnly Property Count() As Integer
        Get
            Return _args.Count
        End Get
    End Property
#End Region

#Region "Methods"
    ''' <summary>
    ''' Add a named argument to the collection
    ''' </summary>
    ''' <param name="key">The name of the argument</param>
    ''' <param name="value">The value of the argument</param>
    ''' <author>Richard Dalton</author>
    ''' <date>12/Jun/2009</date>
    Public Function Add(ByVal key As String, ByVal value As Object) As WizardArgs
        _args.Add(key, value)
        Return Me
    End Function

    ''' <summary>
    ''' Remove a named argument from the collection
    ''' </summary>
    ''' <param name="key">the name of the argument to remove</param>
    ''' <returns>True if argument existed in the collection.
    '''          False if the argument didn't exist</returns>
    ''' <author>Richar Dalton</author>
    ''' <date>12/Jun/2009</date>
    Public Function Remove(ByVal key As String) As Boolean
        Return _args.Remove(key)
    End Function

    ''' <summary>
    ''' Add a named argument to the collection, replacing any existing argument with the same name
    ''' </summary>
    ''' <param name="key">The Name of the argument to replace</param>
    ''' <param name="value">The new value for the argument</param>
    ''' <returns>True if an argument with the same name existed
    '''          False if no argument existed with the same name</returns>
    ''' <author>Richard Dalton</author>
    ''' <date>12/Jun/2009</date>
    Public Function Replace(ByVal key As String, ByVal value As Object) As Boolean
        Dim alreadyExisted As Boolean
        alreadyExisted = Remove(key)
        Add(key, value)
        Return alreadyExisted
    End Function

    ''' <summary>
    ''' Indicates whether a specified argument exists in the collection
    ''' </summary>
    ''' <param name="key">The name of the argument to search for</param>
    ''' <returns>True if the argument exists
    '''          False if no argument exists with the specified name</returns>
    ''' <author>Richard Dalton</author>
    ''' <date>12/Jun/2009</date>
    Public Function Contains(ByVal key As String) As Boolean
        Return _args.ContainsKey(key)
    End Function

#End Region

End Class
