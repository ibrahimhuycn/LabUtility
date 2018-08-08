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
        Me.TabControlConnectionSettings = New System.Windows.Forms.TabControl()
        Me.TabPageClosedXML = New System.Windows.Forms.TabPage()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.TabControlConnectionSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlConnectionSettings
        '
        Me.TabControlConnectionSettings.Controls.Add(Me.TabPageClosedXML)
        Me.TabControlConnectionSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlConnectionSettings.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlConnectionSettings.Location = New System.Drawing.Point(0, 0)
        Me.TabControlConnectionSettings.Name = "TabControlConnectionSettings"
        Me.TabControlConnectionSettings.SelectedIndex = 0
        Me.TabControlConnectionSettings.Size = New System.Drawing.Size(407, 139)
        Me.TabControlConnectionSettings.TabIndex = 8
        '
        'TabPageClosedXML
        '
        Me.TabPageClosedXML.Location = New System.Drawing.Point(4, 23)
        Me.TabPageClosedXML.Name = "TabPageClosedXML"
        Me.TabPageClosedXML.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageClosedXML.Size = New System.Drawing.Size(399, 112)
        Me.TabPageClosedXML.TabIndex = 1
        Me.TabPageClosedXML.Text = "ClosedXML"
        Me.TabPageClosedXML.UseVisualStyleBackColor = True
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControlConnectionSettings As TabControl
    Friend WithEvents TabPageClosedXML As TabPage
    Friend WithEvents OpenFileDialog As OpenFileDialog
End Class
