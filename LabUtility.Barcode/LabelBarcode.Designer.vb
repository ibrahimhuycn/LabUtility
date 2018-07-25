<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class LabelBarcode
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Code128Generator1 As DevExpress.XtraPrinting.BarCode.Code128Generator = New DevExpress.XtraPrinting.BarCode.Code128Generator()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrPanelPage = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabelCollectionDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelSampleType = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelPatientName = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrBarCode = New DevExpress.XtraReports.UI.XRBarCode()
        Me.AccessionNumber = New DevExpress.XtraReports.Parameters.Parameter()
        Me.CollectionDate = New DevExpress.XtraReports.Parameters.Parameter()
        Me.PatientName = New DevExpress.XtraReports.Parameters.Parameter()
        Me.SampleType = New DevExpress.XtraReports.Parameters.Parameter()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Expanded = False
        Me.Detail.HeightF = 100.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPanelPage})
        Me.BottomMargin.HeightF = 100.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPanelPage
        '
        Me.XrPanelPage.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabelCollectionDate, Me.XrLabelSampleType, Me.XrLabelPatientName, Me.XrBarCode})
        Me.XrPanelPage.LocationFloat = New DevExpress.Utils.PointFloat(50.0!, 0!)
        Me.XrPanelPage.Name = "XrPanelPage"
        Me.XrPanelPage.SizeF = New System.Drawing.SizeF(202.0833!, 100.0!)
        '
        'XrLabelCollectionDate
        '
        Me.XrLabelCollectionDate.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[CollectionDate]")})
        Me.XrLabelCollectionDate.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelCollectionDate.LocationFloat = New DevExpress.Utils.PointFloat(0!, 83.25!)
        Me.XrLabelCollectionDate.Name = "XrLabelCollectionDate"
        Me.XrLabelCollectionDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelCollectionDate.SizeF = New System.Drawing.SizeF(202.0833!, 16.75!)
        Me.XrLabelCollectionDate.StylePriority.UseFont = False
        Me.XrLabelCollectionDate.Text = "CollectionDate"
        Me.XrLabelCollectionDate.TextFormatString = "{0:dddd, MMMM d, yyyy}"
        '
        'XrLabelSampleType
        '
        Me.XrLabelSampleType.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[SampleType]")})
        Me.XrLabelSampleType.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelSampleType.LocationFloat = New DevExpress.Utils.PointFloat(0!, 66.5!)
        Me.XrLabelSampleType.Name = "XrLabelSampleType"
        Me.XrLabelSampleType.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelSampleType.SizeF = New System.Drawing.SizeF(202.0833!, 16.75!)
        Me.XrLabelSampleType.StylePriority.UseFont = False
        Me.XrLabelSampleType.Text = "SampleType"
        '
        'XrLabelPatientName
        '
        Me.XrLabelPatientName.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[PatientName]")})
        Me.XrLabelPatientName.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelPatientName.LocationFloat = New DevExpress.Utils.PointFloat(0!, 49.75!)
        Me.XrLabelPatientName.Name = "XrLabelPatientName"
        Me.XrLabelPatientName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelPatientName.SizeF = New System.Drawing.SizeF(202.0833!, 16.75!)
        Me.XrLabelPatientName.StylePriority.UseFont = False
        Me.XrLabelPatientName.StylePriority.UsePadding = False
        Me.XrLabelPatientName.Text = "PatientName"
        '
        'XrBarCode
        '
        Me.XrBarCode.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[AccessionNumber]")})
        Me.XrBarCode.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrBarCode.LocationFloat = New DevExpress.Utils.PointFloat(0!, 4.75!)
        Me.XrBarCode.Module = 1.0!
        Me.XrBarCode.Name = "XrBarCode"
        Me.XrBarCode.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100.0!)
        Me.XrBarCode.SizeF = New System.Drawing.SizeF(202.0833!, 45.0!)
        Me.XrBarCode.StylePriority.UseFont = False
        Me.XrBarCode.StylePriority.UseTextAlignment = False
        Code128Generator1.CharacterSet = DevExpress.XtraPrinting.BarCode.Code128Charset.CharsetAuto
        Me.XrBarCode.Symbology = Code128Generator1
        Me.XrBarCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'AccessionNumber
        '
        Me.AccessionNumber.Description = "The sample number to be encoded in the barcode"
        Me.AccessionNumber.Name = "AccessionNumber"
        '
        'CollectionDate
        '
        Me.CollectionDate.Description = "Sampled date"
        Me.CollectionDate.Name = "CollectionDate"
        Me.CollectionDate.Type = GetType(Date)
        '
        'PatientName
        '
        Me.PatientName.Description = "Name of the patient"
        Me.PatientName.Name = "PatientName"
        '
        'SampleType
        '
        Me.SampleType.Description = "Type of sample"
        Me.SampleType.Name = "SampleType"
        '
        'LabelBarcode
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 100)
        Me.PageHeight = 100
        Me.PageWidth = 300
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.AccessionNumber, Me.CollectionDate, Me.PatientName, Me.SampleType})
        Me.Version = "17.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrPanelPage As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrBarCode As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents AccessionNumber As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents CollectionDate As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents PatientName As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents SampleType As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabelCollectionDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelSampleType As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelPatientName As DevExpress.XtraReports.UI.XRLabel
End Class
