Public Class LabUtility
    Private WithEvents Config As New Settings
    Public Shared UtilityDataSettings As New Connection()

    Function LoadSettings()

#Region "Read Current Settings"

        UtilityDataSettings.ConnectionString = My.Settings.ConnectionString
        UtilityDataSettings.DataProvider = My.Settings.DataProvider
        UtilityDataSettings.ExtendedProperties = My.Settings.ExtendedProperties
        UtilityDataSettings.FileLocation = My.Settings.FileLocation
        UtilityDataSettings.HDR = My.Settings.HdrFirstRowColumnNames
        UtilityDataSettings.IMEX = My.Settings.ImexReadAllAsText

#End Region

    End Function

    Public Sub OnSettingsChanged(ByVal sender As Object, ByVal newSettings As Connection) Handles Config.SettingsChanged
        MsgBox("Settings Changed Fired!")
        LoadSettings()
        UtilityDataSettings = newSettings
    End Sub

    Private Sub LabUtility_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadSettings()
    End Sub

    Private Sub OpenSettings()
        Config.Show()
    End Sub

    Private Sub ToolStripButtonSettings_Click(sender As Object, e As EventArgs) Handles ToolStripButtonSettings.Click
        OpenSettings()
    End Sub

End Class