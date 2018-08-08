Imports ClosedXML.Excel

Public Class DataCommunications

    Public Shared Function ReadWorkSheetNames(ByVal sender As Object, e As ConnectionEventArgs) As String
        Dim workSheetNames As String = ""
        Try
            Dim workbook = New XLWorkbook(e.ExcelFileName)

            For Each worksheet As IXLWorksheet In workbook.Worksheets
                If workSheetNames = "" Then
                    workSheetNames = worksheet.Name
                Else
                    workSheetNames = workSheetNames & "|" & (worksheet.Name)
                End If
            Next worksheet

            Return workSheetNames
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return ""
    End Function

End Class