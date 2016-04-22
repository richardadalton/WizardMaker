Imports System.Globalization

''' <summary>
''' Represents Int/String Key/Value items in Lists, Dropdowns etc.
''' </summary>
''' <remarks></remarks>
''' <author>Richard Dalton</author>
''' <date>12-Jun-2009</date>
Public Class ListEntry

#Region "Declarations"
    Private _id As Long
    Private _description As String
#End Region

#Region "Properties"
    ''' <summary>
    ''' The unique Id of the Item.
    ''' </summary>
    ''' <value></value>
    ''' <remarks></remarks>
    Public ReadOnly Property Id() As Long
        Get
            Return _id
        End Get
    End Property

    ''' <summary>
    ''' The Description of the Item
    ''' </summary>
    ''' <value></value>
    ''' <remarks></remarks>
    Public ReadOnly Property Description() As String
        Get
            Return _description
        End Get
    End Property

    Public Overridable ReadOnly Property IsNull() As Boolean
        Get
            Return False
        End Get
    End Property

#End Region

#Region "Public Methods"
    ''' <summary>
    ''' ToString is used when displaying list entries
    ''' </summary>
    ''' <returns>String representation of the Entry, showing both Id and Description</returns>
    ''' <remarks></remarks>
    ''' <author>Richard Dalton</author>
    ''' <date>12-Jun-2009</date>
    Public Overrides Function ToString() As String
        Return String.Format(CultureInfo.CurrentCulture, "{0}, {1}", Id, Description)
    End Function
#End Region

#Region "Constructors"
    ''' <summary>
    ''' Constructor for List Entry
    ''' </summary>
    ''' <param name="id">The Id of the entry</param>
    ''' <param name="description">The Description of the Entry</param>
    ''' <author>Richard Dalton</author>
    ''' <date>12-Jun-2009</date>
    Public Sub New(ByVal id As Long, ByVal description As String)
        _id = id
        _description = description
    End Sub

    ''' <summary>
    ''' Constructor for List Entry
    ''' </summary>
    ''' <author>Richard Dalton</author>
    ''' <date>12-Jun-2009</date>
    Public Sub New()
    End Sub

#End Region

End Class
