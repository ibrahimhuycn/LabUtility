Public Class Connection

    Public Sub New(provider As String, fileLocation As String, Optional hdr As Boolean = True, Optional imex As Boolean = True)

    End Sub

    Public Property ConnectionString As String
    Public Property DataProvider As String  'Driver Name
    Public Property ExtendedProperties As String
    Public Property FileLocation As String  'Data Source
    Public Property HDR As Boolean
    Public Property IMEX As Boolean

End Class