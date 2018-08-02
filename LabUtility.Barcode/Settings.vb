Public Class Settings

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

    End Sub

    Public Event SettingsChanged(ByVal sender As Object, newSettings As Connection)

    Enum ActiveConnection
        Excel
        Access
    End Enum

    Enum StateHDR
        No
        Yes
    End Enum

    Public Sub SettingChangeDetection(sender As Object, e As EventArgs) Handles TextBoxFileLocation.Validated, ComboBoxProvider.SelectedIndexChanged, CheckBoxIsHDR.CheckStateChanged, CheckBoxIsExcelConnectionInUse.CheckStateChanged, CheckBoxIMEX.CheckStateChanged, Me.VisibleChanged

        Dim SettingsChanged As Boolean = False
        If Not TextBoxFileLocation.Text = LabUtility.UtilityDataSettings.FileLocation Then SettingsChanged = True
        If Not ComboBoxProvider.Text = LabUtility.UtilityDataSettings.DataProvider Then SettingsChanged = True
        If Not CheckBoxIsHDR.CheckState = LabUtility.UtilityDataSettings.HDR Then SettingsChanged = True
        If Not CheckBoxIMEX.CheckState = LabUtility.UtilityDataSettings.IMEX Then SettingsChanged = True

        Select Case True
            Case CheckBoxIsExcelConnectionInUse.CheckState = CheckState.Checked
                If Not My.Settings.ConnectionInUse = ActiveConnection.Excel Then SettingsChanged = True

            Case CheckBoxIsExcelConnectionInUse.CheckState = CheckState.Unchecked
                If My.Settings.ConnectionInUse = ActiveConnection.Excel Then SettingsChanged = True
            Case Else
                SettingsChanged = True
        End Select

        If SettingsChanged = True Then
            ButtonSave.Enabled = True
        ElseIf SettingsChanged = False Then
            ButtonSave.Enabled = False
        End If
    End Sub

    Private Sub ButtonBrowse_Click(sender As Object, e As EventArgs) Handles ButtonBrowse.Click
        'OPEN DIALOG AND STORES ALL EPIDSODE NUMBERS IN ARRAY
        If OpenFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            TextBoxFileLocation.Text = OpenFileDialog.FileName
            TextBoxFileLocation.Focus()
        ElseIf DialogResult.Cancel Then

        End If
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click

        'Save Changes to Settings XML

#Region "Preparing for changes to be Saved"

        Dim ConnectionInUse As Integer = -1
        Dim Hdr As Integer = StateHDR.No
        Dim Imex As Integer = -1

        If CheckBoxIsExcelConnectionInUse.CheckState = CheckState.Checked Then ConnectionInUse = ActiveConnection.Excel
        If CheckBoxIsHDR.CheckState = CheckState.Checked Then Hdr = StateHDR.Yes
        If CheckBoxIMEX.CheckState = CheckState.Checked Then Imex = 1

#End Region

#Region "Save Changes"

        Dim SaveSettings As New Connection(ComboBoxProvider.Text, TextBoxFileLocation.Text, ConnectionInUse, Hdr, Imex)
        If Connection.CommitChanges(SaveSettings) = 0 Then
            RaiseEvent SettingsChanged(Me, SaveSettings)
            Me.Hide()
        End If

#End Region

    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Displaying settings Source, Provider, HDR, IMEX
        TextBoxFileLocation.Text = LabUtility.UtilityDataSettings.FileLocation
        ComboBoxProvider.Text = LabUtility.UtilityDataSettings.DataProvider
        If LabUtility.UtilityDataSettings.HDR = 1 Then CheckBoxIsHDR.CheckState = CheckState.Checked
        If LabUtility.UtilityDataSettings.IMEX = 1 Then CheckBoxIMEX.CheckState = CheckState.Checked

        'Checking connections in use
        If My.Settings.ConnectionInUse = ActiveConnection.Excel Then
            CheckBoxIsExcelConnectionInUse.CheckState = CheckState.Checked
        End If

        'Disabling save button. Button will be enabled when change is detected.
        ButtonSave.Enabled = False
    End Sub

End Class