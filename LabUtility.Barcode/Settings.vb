Imports LabUtility

Public Class Settings
    Dim UtilityDataSettings As New Connection()

    Public Sub New()
        InitializeComponent()

#Region "Reading Options for settings"

        'load data providers list from settings to combobox
        Dim ListProviders() As String = My.Settings.DataProviderList.Split("|")
        'Add to combobox
        For Each provider In ListProviders
            ComboBoxProvider.Items.Add(provider)
        Next

#End Region

#Region "Read Current Settings"

        UtilityDataSettings.ConnectionString = My.Settings.ConnectionString
        UtilityDataSettings.DataProvider = My.Settings.DataProvider
        UtilityDataSettings.ExtendedProperties = My.Settings.ExtendedProperties
        UtilityDataSettings.FileLocation = My.Settings.FileLocation
        UtilityDataSettings.HDR = My.Settings.HdrFirstRowColumnNames
        UtilityDataSettings.IMEX = My.Settings.ImexReadAllAsText

#End Region

    End Sub

    Private Sub ButtonBrowse_Click(sender As Object, e As EventArgs) Handles ButtonBrowse.Click
        'OPEN DIALOG AND STORES ALL EPIDSODE NUMBERS IN ARRAY
        If OpenFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            TextBoxFileLocation.Text = OpenFileDialog.FileName
        ElseIf DialogResult.Cancel Then

        End If
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click

    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Displaying settings Source, Provider, HDR, IMEX
        TextBoxFileLocation.Text = UtilityDataSettings.FileLocation
        ComboBoxProvider.Text = UtilityDataSettings.DataProvider
        If UtilityDataSettings.HDR = 1 Then CheckBoxIsHDR.CheckState = CheckState.Checked
        If UtilityDataSettings.IMEX = 1 Then CheckBoxIMEX.CheckState = CheckState.Checked

        'Checking connections in use
        If My.Settings.ExcelDataSourceActive = True Then
            CheckBoxIsExcelConnectionInUse.CheckState = CheckState.Checked
        End If
    End Sub

End Class