Public Class LabUtility

    Private Sub OpenSettings()
        Dim UtilitySettings As New Settings
        UtilitySettings.Show()
    End Sub

    Private Sub ToolStripButtonSettings_Click(sender As Object, e As EventArgs) Handles ToolStripButtonSettings.Click
        OpenSettings()
    End Sub

End Class