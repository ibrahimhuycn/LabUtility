Public Class Connection

    Public Sub New()

    End Sub

    Public Sub New(provider As String, fileLocation As String, Optional hdr As StateHDR = 1, Optional imex As Integer = 1)
        DataProvider = provider
        Me.FileLocation = fileLocation
        Me.HDR = hdr
        Me.IMEX = imex

        'Generate string for Extended Properties
        GenerateExtendedPropertiesString()

        'Generate Connection String
        GenerateConnectionString()
    End Sub

    Enum StateHDR
        No
        Yes
    End Enum

    Public Property ConnectionString As String

    Public Property DataProvider As String

    Public Property ExtendedProperties As String

    Public Property FileLocation As String

    Public Property HDR As StateHDR

    Public Property IMEX As Integer

    Public Shared Function Save(ByVal settings As Connection)
        'Return 0 if successful
        Dim ReturnValue As Integer = 0
        Try
            My.Settings.ConnectionString = settings.ConnectionString
            My.Settings.DataProvider = settings.DataProvider
            My.Settings.ExtendedProperties = settings.ExtendedProperties
            My.Settings.FileLocation = settings.FileLocation
            My.Settings.HdrFirstRowColumnNames = settings.HDR
            My.Settings.ImexReadAllAsText = settings.IMEX
        Catch ex As Exception
            ReturnValue = 1
            MsgBox(ex.Message)
        End Try
        Return ReturnValue
    End Function

    Private Sub GenerateConnectionString()
        'Provider = Microsoft.ACE.OLEDB.12.0;Data Source=c:\myFolder\myExcel2007file.xlsx;Extended Properties="Excel 12.0 Xml;HDR=YES;IMEX=1"
        Me.ConnectionString = String.Format("Provider={0};Data Source={1};Extended Properties={2}{3}{2}", Me.DataProvider, Me.FileLocation, ControlChars.Quote, ExtendedProperties)
    End Sub

    Private Sub GenerateExtendedPropertiesString()
        'Example: Excel 12.0 Xml;HDR=YES;IMEX=1
        ExtendedProperties = String.Format("Excel 12.0 Xml;HDR={0};IMEX={1}", HDR.ToString, IMEX)
    End Sub

End Class