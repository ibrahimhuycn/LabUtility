Imports ClosedXML.Excel
Imports LabUtility.DataCommunications

Public Class LabUtility
    Dim preparedLabels As New Labels

    Dim ReadSettings As New ConnectionEventArgs() With {.ExcelFileName = My.Settings.FileLocation,
        .ExcelColumnHeaders = My.Settings.ExcelMapping}

    Public Event ExcelFileSelected(ByVal sender As Object, ByVal e As ConnectionEventArgs)

    Public Event LabelingDataChanged(ByVal sender As Object, ByVal e As EventArgs)

    Enum DataFields
        AccessionNumber
        PatientName
        CollectedOn
        SampleType
    End Enum

    Public Sub OnSelectingExcelFile(ByVal sender As Object, ByVal e As ConnectionEventArgs) Handles Me.ExcelFileSelected
        ButtonEditExcelFileLocation.Text = e.ExcelFileName

        Dim worksheetNames() As String = ReadWorkSheetNames(Me, e).Split("|")

        ComboBoxEditWorksheets.Text = ""
        ComboBoxEditWorksheets.Properties.Items.Clear()
        For Each sheet In worksheetNames
            ComboBoxEditWorksheets.Properties.Items.Add(sheet)
        Next

        ComboBoxEditWorksheets.SelectedItem = e.WorkSheet
    End Sub

    Private Sub ButtonEdit1_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ButtonEditExcelFileLocation.ButtonClick
        If OpenFileDialog.ShowDialog() = Global.System.Windows.Forms.DialogResult.OK Then
            ReadSettings.ExcelFileName = OpenFileDialog.FileName
            ConnectionEventArgs.CommitChanges(Me, ReadSettings)

            RaiseEvent ExcelFileSelected(Me, ReadSettings)
        ElseIf DialogResult.Cancel Then

        End If
    End Sub

    Private Sub ComboBoxEditWorksheets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEditWorksheets.SelectedIndexChanged
        If Not ComboBoxEditWorksheets.SelectedItem = Nothing Then ReadSettings.WorkSheet = ComboBoxEditWorksheets.SelectedItem
        ConnectionEventArgs.CommitChanges(Me, ReadSettings)
    End Sub

    Private Sub LabUtility_Load(sender As Object, e As EventArgs) Handles Me.Load
        RaiseEvent ExcelFileSelected(Me, ReadSettings)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButtonReadData.Click

#Region "Setup to read data"

        Try
            Dim AccessionNumber As List(Of String) = Nothing
            Dim patientNames As List(Of String) = Nothing
            Dim collectedOn As List(Of String) = Nothing
            Dim sampleType As List(Of String) = Nothing

            Dim wb As New XLWorkbook(ReadSettings.ExcelFileName)
            Dim ws = wb.Worksheet(ReadSettings.WorkSheet)

            Dim firstPossibleAddress = ws.Row(ws.FirstRowUsed().RowUsed.RowNumber()).FirstCell().Address
            Dim lastPossibleAddress = ws.LastCellUsed().Address
            Dim ReadRange = ws.Range(firstPossibleAddress, lastPossibleAddress).RangeUsed()
            Dim DataTable = ReadRange.AsTable()

#End Region

#Region "Read Data"

            Dim FieldRead As DataFields = 0
            For Each field In ReadSettings.ExcelColumnHeaders.Split("|")

                Select Case FieldRead
                    Case DataFields.PatientName
                        patientNames = DataTable.DataRange.Rows().Select(Function(DataRow) DataRow.Field(field).GetString()).ToList
                        FieldRead += 1

                    Case DataFields.AccessionNumber
                        AccessionNumber = DataTable.DataRange.Rows().Select(Function(DataRow) DataRow.Field(field).GetString()).ToList
                        FieldRead += 1

                    Case DataFields.CollectedOn
                        collectedOn = DataTable.DataRange.Rows().Select(Function(DataRow) DataRow.Field(field).GetString()).ToList
                        FieldRead += 1

                    Case DataFields.SampleType
                        sampleType = DataTable.DataRange.Rows().Select(Function(DataRow) DataRow.Field(field).GetString()).ToList
                        FieldRead += 1
                End Select
            Next

#End Region

#Region "Create Labels"

            preparedLabels.Labels.Clear()
            Dim LabelNumber As Integer = 0
            If Not AccessionNumber Is Nothing Then

                For Each value In AccessionNumber
                    Dim LabelsInfo As New LabelingInformation With {.AccessionNumber = AccessionNumber(LabelNumber),
                        .PatientName = patientNames(LabelNumber),
                        .SampleCollectionDate = collectedOn(LabelNumber),
                        .SampleType = sampleType(LabelNumber)}

                    preparedLabels.Labels.Add(LabelsInfo)
                    If LabelNumber = AccessionNumber.Count - 1 Then Exit For
                    LabelNumber += 1
                Next

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

#End Region

    End Sub

End Class