Public Class NullListEntry
    Inherits ListEntry


    Public Overrides ReadOnly Property IsNull() As Boolean
        Get
            Return True
        End Get
    End Property


    ''' <summary>
    ''' ToString for NullListEntries simply returns "None"
    ''' </summary>
    ''' <returns>"None"</returns>
    ''' <remarks></remarks>
    ''' <author>Richard Dalton</author>
    ''' <date>12-Jun-2009</date>
    Public Overrides Function ToString() As String
        Return "None"
    End Function


    Public Sub New()
    End Sub

End Class
