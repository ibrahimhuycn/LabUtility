Public Class ConnectionEventArgs
    Inherits EventArgs

    Public Sub New()
    End Sub

    Public Property ExcelColumnHeaders() As String
    Public Property ExcelFileName As String
    Public Property WorkSheet As String

    Public Shared Function CommitChanges(ByVal sender As Object, e As ConnectionEventArgs)
        Dim returns As Integer = 0
        Try
            My.Settings.FileLocation = e.ExcelFileName
        Catch ex As Exception
            MsgBox(ex.Message)
            returns += 1
        End Try

        Return returns
    End Function

End Class