<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LabUtility
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LabUtility))
        Me.ToolStripLabUtility = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonSettings = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabUtility.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripLabUtility
        '
        Me.ToolStripLabUtility.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonSettings})
        Me.ToolStripLabUtility.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripLabUtility.Name = "ToolStripLabUtility"
        Me.ToolStripLabUtility.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStripLabUtility.Size = New System.Drawing.Size(705, 25)
        Me.ToolStripLabUtility.TabIndex = 0
        Me.ToolStripLabUtility.Text = "ToolStrip1"
        '
        'ToolStripButtonSettings
        '
        Me.ToolStripButtonSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonSettings.Image = CType(resources.GetObject("ToolStripButtonSettings.Image"), System.Drawing.Image)
        Me.ToolStripButtonSettings.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonSettings.Name = "ToolStripButtonSettings"
        Me.ToolStripButtonSettings.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonSettings.Text = "ToolStripButton1"
        Me.ToolStripButtonSettings.ToolTipText = "Settings"
        '
        'LabUtility
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 343)
        Me.Controls.Add(Me.ToolStripLabUtility)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "LabUtility"
        Me.Text = "Lab Utility"
        Me.ToolStripLabUtility.ResumeLayout(False)
        Me.ToolStripLabUtility.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStripLabUtility As ToolStrip
    Friend WithEvents ToolStripButtonSettings As ToolStripButton
End Class
