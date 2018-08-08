<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LabUtility
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LabUtility))
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.SimpleButtonReadData = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.ButtonEditExcelFileLocation = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.ComboBoxEditWorksheets = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButtonPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButtonNext = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButtonBack = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.ButtonEditExcelFileLocation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEditWorksheets.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(399, 159)
        Me.XtraTabControl1.TabIndex = 2
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.SimpleButtonReadData)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage1.Controls.Add(Me.ButtonEditExcelFileLocation)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage1.Controls.Add(Me.ComboBoxEditWorksheets)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(393, 131)
        Me.XtraTabPage1.Text = "STEP 1: Settings"
        '
        'SimpleButtonReadData
        '
        Me.SimpleButtonReadData.ImageOptions.Image = CType(resources.GetObject("SimpleButtonReadData.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButtonReadData.Location = New System.Drawing.Point(261, 81)
        Me.SimpleButtonReadData.Name = "SimpleButtonReadData"
        Me.SimpleButtonReadData.Size = New System.Drawing.Size(92, 23)
        Me.SimpleButtonReadData.TabIndex = 9
        Me.SimpleButtonReadData.Text = "Read Data"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(11, 63)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "Worksheets"
        '
        'ButtonEditExcelFileLocation
        '
        Me.ButtonEditExcelFileLocation.Location = New System.Drawing.Point(11, 32)
        Me.ButtonEditExcelFileLocation.Name = "ButtonEditExcelFileLocation"
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.ButtonEditExcelFileLocation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.ButtonEditExcelFileLocation.Size = New System.Drawing.Size(342, 22)
        Me.ButtonEditExcelFileLocation.TabIndex = 5
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(11, 13)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Excel file location"
        '
        'ComboBoxEditWorksheets
        '
        Me.ComboBoxEditWorksheets.Location = New System.Drawing.Point(11, 82)
        Me.ComboBoxEditWorksheets.Name = "ComboBoxEditWorksheets"
        Me.ComboBoxEditWorksheets.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEditWorksheets.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ComboBoxEditWorksheets.Size = New System.Drawing.Size(231, 20)
        Me.ComboBoxEditWorksheets.TabIndex = 3
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.SimpleButtonBack)
        Me.XtraTabPage2.Controls.Add(Me.SimpleButtonNext)
        Me.XtraTabPage2.Controls.Add(Me.SimpleButtonPrint)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl6)
        Me.XtraTabPage2.Controls.Add(Me.TextEdit4)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl5)
        Me.XtraTabPage2.Controls.Add(Me.TextEdit3)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl4)
        Me.XtraTabPage2.Controls.Add(Me.TextEdit2)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage2.Controls.Add(Me.TextEdit1)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(393, 131)
        Me.XtraTabPage2.Text = "STEP 2: Print Labels"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.Filter = "Excel File|*.xlsx"
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(15, 29)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(100, 20)
        Me.TextEdit1.TabIndex = 0
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(18, 13)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(87, 13)
        Me.LabelControl3.TabIndex = 1
        Me.LabelControl3.Text = "Accession Number"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(124, 13)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Patient Name"
        '
        'TextEdit2
        '
        Me.TextEdit2.Location = New System.Drawing.Point(121, 29)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Size = New System.Drawing.Size(242, 20)
        Me.TextEdit2.TabIndex = 2
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(124, 55)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl5.TabIndex = 5
        Me.LabelControl5.Text = "Collection Date"
        '
        'TextEdit3
        '
        Me.TextEdit3.Location = New System.Drawing.Point(121, 71)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Size = New System.Drawing.Size(145, 20)
        Me.TextEdit3.TabIndex = 4
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(18, 56)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl6.TabIndex = 7
        Me.LabelControl6.Text = "Sample Type"
        '
        'TextEdit4
        '
        Me.TextEdit4.Location = New System.Drawing.Point(15, 71)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Size = New System.Drawing.Size(100, 20)
        Me.TextEdit4.TabIndex = 6
        '
        'SimpleButtonPrint
        '
        Me.SimpleButtonPrint.ImageOptions.Image = CType(resources.GetObject("SimpleButtonPrint.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButtonPrint.Location = New System.Drawing.Point(272, 98)
        Me.SimpleButtonPrint.Name = "SimpleButtonPrint"
        Me.SimpleButtonPrint.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButtonPrint.TabIndex = 8
        Me.SimpleButtonPrint.Text = "Print"
        '
        'SimpleButtonNext
        '
        Me.SimpleButtonNext.ImageOptions.Image = CType(resources.GetObject("SimpleButtonNext.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButtonNext.Location = New System.Drawing.Point(272, 69)
        Me.SimpleButtonNext.Name = "SimpleButtonNext"
        Me.SimpleButtonNext.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButtonNext.TabIndex = 9
        Me.SimpleButtonNext.Text = "Next"
        '
        'SimpleButtonBack
        '
        Me.SimpleButtonBack.ImageOptions.Image = CType(resources.GetObject("SimpleButtonBack.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButtonBack.Location = New System.Drawing.Point(191, 98)
        Me.SimpleButtonBack.Name = "SimpleButtonBack"
        Me.SimpleButtonBack.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButtonBack.TabIndex = 10
        Me.SimpleButtonBack.Text = "Back"
        '
        'LabUtility
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 159)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "LabUtility"
        Me.Text = "Lab Utility"
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.ButtonEditExcelFileLocation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEditWorksheets.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ButtonEditExcelFileLocation As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ComboBoxEditWorksheets As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents SimpleButtonReadData As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButtonBack As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButtonNext As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButtonPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
End Class
