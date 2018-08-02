<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.TabControlConnectionSettings = New System.Windows.Forms.TabControl()
        Me.TabPageExcel = New System.Windows.Forms.TabPage()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.PictureBoxExcelLogo = New System.Windows.Forms.PictureBox()
        Me.CheckBoxIsExcelConnectionInUse = New System.Windows.Forms.CheckBox()
        Me.CheckBoxIMEX = New System.Windows.Forms.CheckBox()
        Me.CheckBoxIsHDR = New System.Windows.Forms.CheckBox()
        Me.ButtonBrowse = New System.Windows.Forms.Button()
        Me.LabelProvider = New System.Windows.Forms.Label()
        Me.ComboBoxProvider = New System.Windows.Forms.ComboBox()
        Me.LabelFileLocation = New System.Windows.Forms.Label()
        Me.TextBoxFileLocation = New System.Windows.Forms.TextBox()
        Me.TabPageMsAccessConnection = New System.Windows.Forms.TabPage()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.TabControlConnectionSettings.SuspendLayout()
        Me.TabPageExcel.SuspendLayout()
        CType(Me.PictureBoxExcelLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControlConnectionSettings
        '
        Me.TabControlConnectionSettings.Controls.Add(Me.TabPageExcel)
        Me.TabControlConnectionSettings.Controls.Add(Me.TabPageMsAccessConnection)
        Me.TabControlConnectionSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlConnectionSettings.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlConnectionSettings.Location = New System.Drawing.Point(0, 0)
        Me.TabControlConnectionSettings.Name = "TabControlConnectionSettings"
        Me.TabControlConnectionSettings.SelectedIndex = 0
        Me.TabControlConnectionSettings.Size = New System.Drawing.Size(407, 139)
        Me.TabControlConnectionSettings.TabIndex = 8
        '
        'TabPageExcel
        '
        Me.TabPageExcel.Controls.Add(Me.ButtonSave)
        Me.TabPageExcel.Controls.Add(Me.PictureBoxExcelLogo)
        Me.TabPageExcel.Controls.Add(Me.CheckBoxIsExcelConnectionInUse)
        Me.TabPageExcel.Controls.Add(Me.CheckBoxIMEX)
        Me.TabPageExcel.Controls.Add(Me.CheckBoxIsHDR)
        Me.TabPageExcel.Controls.Add(Me.ButtonBrowse)
        Me.TabPageExcel.Controls.Add(Me.LabelProvider)
        Me.TabPageExcel.Controls.Add(Me.ComboBoxProvider)
        Me.TabPageExcel.Controls.Add(Me.LabelFileLocation)
        Me.TabPageExcel.Controls.Add(Me.TextBoxFileLocation)
        Me.TabPageExcel.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageExcel.Location = New System.Drawing.Point(4, 23)
        Me.TabPageExcel.Name = "TabPageExcel"
        Me.TabPageExcel.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageExcel.Size = New System.Drawing.Size(399, 112)
        Me.TabPageExcel.TabIndex = 0
        Me.TabPageExcel.Text = "Excel Connection"
        Me.TabPageExcel.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.White
        Me.ButtonSave.Image = CType(resources.GetObject("ButtonSave.Image"), System.Drawing.Image)
        Me.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSave.Location = New System.Drawing.Point(318, 80)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(69, 24)
        Me.ButtonSave.TabIndex = 17
        Me.ButtonSave.Text = "Save   "
        Me.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonSave.UseVisualStyleBackColor = False
        '
        'PictureBoxExcelLogo
        '
        Me.PictureBoxExcelLogo.Image = CType(resources.GetObject("PictureBoxExcelLogo.Image"), System.Drawing.Image)
        Me.PictureBoxExcelLogo.Location = New System.Drawing.Point(6, 52)
        Me.PictureBoxExcelLogo.Name = "PictureBoxExcelLogo"
        Me.PictureBoxExcelLogo.Size = New System.Drawing.Size(55, 55)
        Me.PictureBoxExcelLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxExcelLogo.TabIndex = 16
        Me.PictureBoxExcelLogo.TabStop = False
        '
        'CheckBoxIsExcelConnectionInUse
        '
        Me.CheckBoxIsExcelConnectionInUse.AutoSize = True
        Me.CheckBoxIsExcelConnectionInUse.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxIsExcelConnectionInUse.Location = New System.Drawing.Point(318, 59)
        Me.CheckBoxIsExcelConnectionInUse.Name = "CheckBoxIsExcelConnectionInUse"
        Me.CheckBoxIsExcelConnectionInUse.Size = New System.Drawing.Size(69, 18)
        Me.CheckBoxIsExcelConnectionInUse.TabIndex = 15
        Me.CheckBoxIsExcelConnectionInUse.Text = "Is Active"
        Me.CheckBoxIsExcelConnectionInUse.UseVisualStyleBackColor = True
        '
        'CheckBoxIMEX
        '
        Me.CheckBoxIMEX.AutoSize = True
        Me.CheckBoxIMEX.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxIMEX.Location = New System.Drawing.Point(85, 83)
        Me.CheckBoxIMEX.Name = "CheckBoxIMEX"
        Me.CheckBoxIMEX.Size = New System.Drawing.Size(193, 18)
        Me.CheckBoxIMEX.TabIndex = 14
        Me.CheckBoxIMEX.Text = "Is IMEX (Read all data as string)"
        Me.CheckBoxIMEX.UseVisualStyleBackColor = True
        '
        'CheckBoxIsHDR
        '
        Me.CheckBoxIsHDR.AutoSize = True
        Me.CheckBoxIsHDR.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxIsHDR.Location = New System.Drawing.Point(85, 59)
        Me.CheckBoxIsHDR.Name = "CheckBoxIsHDR"
        Me.CheckBoxIsHDR.Size = New System.Drawing.Size(220, 18)
        Me.CheckBoxIsHDR.TabIndex = 13
        Me.CheckBoxIsHDR.Text = "Is HDR (Excel first row has Headings)"
        Me.CheckBoxIsHDR.UseVisualStyleBackColor = True
        '
        'ButtonBrowse
        '
        Me.ButtonBrowse.BackColor = System.Drawing.Color.White
        Me.ButtonBrowse.Image = CType(resources.GetObject("ButtonBrowse.Image"), System.Drawing.Image)
        Me.ButtonBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonBrowse.Location = New System.Drawing.Point(321, 4)
        Me.ButtonBrowse.Name = "ButtonBrowse"
        Me.ButtonBrowse.Size = New System.Drawing.Size(66, 24)
        Me.ButtonBrowse.TabIndex = 12
        Me.ButtonBrowse.Text = "Browse"
        Me.ButtonBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonBrowse.UseVisualStyleBackColor = False
        '
        'LabelProvider
        '
        Me.LabelProvider.AutoSize = True
        Me.LabelProvider.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProvider.Location = New System.Drawing.Point(24, 35)
        Me.LabelProvider.Name = "LabelProvider"
        Me.LabelProvider.Size = New System.Drawing.Size(55, 14)
        Me.LabelProvider.TabIndex = 11
        Me.LabelProvider.Text = "Provider:"
        '
        'ComboBoxProvider
        '
        Me.ComboBoxProvider.FormattingEnabled = True
        Me.ComboBoxProvider.Location = New System.Drawing.Point(85, 32)
        Me.ComboBoxProvider.Name = "ComboBoxProvider"
        Me.ComboBoxProvider.Size = New System.Drawing.Size(302, 22)
        Me.ComboBoxProvider.TabIndex = 10
        '
        'LabelFileLocation
        '
        Me.LabelFileLocation.AutoSize = True
        Me.LabelFileLocation.Font = New System.Drawing.Font("Cambria", 9.0!)
        Me.LabelFileLocation.Location = New System.Drawing.Point(5, 9)
        Me.LabelFileLocation.Name = "LabelFileLocation"
        Me.LabelFileLocation.Size = New System.Drawing.Size(74, 14)
        Me.LabelFileLocation.TabIndex = 9
        Me.LabelFileLocation.Text = "File Location:"
        '
        'TextBoxFileLocation
        '
        Me.TextBoxFileLocation.Location = New System.Drawing.Point(85, 6)
        Me.TextBoxFileLocation.Name = "TextBoxFileLocation"
        Me.TextBoxFileLocation.Size = New System.Drawing.Size(230, 22)
        Me.TextBoxFileLocation.TabIndex = 8
        '
        'TabPageMsAccessConnection
        '
        Me.TabPageMsAccessConnection.Location = New System.Drawing.Point(4, 23)
        Me.TabPageMsAccessConnection.Name = "TabPageMsAccessConnection"
        Me.TabPageMsAccessConnection.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageMsAccessConnection.Size = New System.Drawing.Size(399, 112)
        Me.TabPageMsAccessConnection.TabIndex = 1
        Me.TabPageMsAccessConnection.Text = "MS Access Connection"
        Me.TabPageMsAccessConnection.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 139)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControlConnectionSettings)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.TabControlConnectionSettings.ResumeLayout(False)
        Me.TabPageExcel.ResumeLayout(False)
        Me.TabPageExcel.PerformLayout()
        CType(Me.PictureBoxExcelLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControlConnectionSettings As TabControl
    Friend WithEvents TabPageExcel As TabPage
    Friend WithEvents PictureBoxExcelLogo As PictureBox
    Friend WithEvents CheckBoxIsExcelConnectionInUse As CheckBox
    Friend WithEvents CheckBoxIMEX As CheckBox
    Friend WithEvents CheckBoxIsHDR As CheckBox
    Friend WithEvents ButtonBrowse As Button
    Friend WithEvents LabelProvider As Label
    Friend WithEvents ComboBoxProvider As ComboBox
    Friend WithEvents LabelFileLocation As Label
    Friend WithEvents TextBoxFileLocation As TextBox
    Friend WithEvents TabPageMsAccessConnection As TabPage
    Friend WithEvents ButtonSave As Button
    Friend WithEvents OpenFileDialog As OpenFileDialog
End Class
