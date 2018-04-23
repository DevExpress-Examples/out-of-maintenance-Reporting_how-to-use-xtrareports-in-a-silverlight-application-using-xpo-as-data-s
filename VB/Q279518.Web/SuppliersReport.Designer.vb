Imports Microsoft.VisualBasic
Imports System
Namespace Q279518.Web
	Partial Public Class SuppliersReport
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
			Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
			Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
			Me.formattingRule1 = New DevExpress.XtraReports.UI.FormattingRule()
			Me.xrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.suppliersCollection = New DevExpress.Xpo.XPCollection()
			CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.suppliersCollection, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel20, Me.xrLabel19, Me.xrLabel18, Me.xrLabel17, Me.xrLabel16, Me.xrLabel15, Me.xrLabel14, Me.xrLabel13, Me.xrLabel12, Me.xrLabel11, Me.xrLabel10, Me.xrLabel9, Me.xrLabel8, Me.xrLabel7, Me.xrLabel6, Me.xrLabel4, Me.xrLabel3, Me.xrLabel2, Me.xrLabel1, Me.xrLabel5})
			Me.Detail.HeightF = 162F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' TopMargin
			' 
			Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel21})
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLabel1
			' 
			Me.xrLabel1.BackColor = System.Drawing.Color.Blue
			Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold)
			Me.xrLabel1.ForeColor = System.Drawing.Color.White
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel1.StylePriority.UseBackColor = False
			Me.xrLabel1.StylePriority.UseFont = False
			Me.xrLabel1.StylePriority.UseForeColor = False
			Me.xrLabel1.Text = "Contact Name:"
			' 
			' xrLabel2
			' 
			Me.xrLabel2.BackColor = System.Drawing.Color.Blue
			Me.xrLabel2.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold)
			Me.xrLabel2.ForeColor = System.Drawing.Color.White
			Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 33.00002F)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel2.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel2.StylePriority.UseBackColor = False
			Me.xrLabel2.StylePriority.UseFont = False
			Me.xrLabel2.StylePriority.UseForeColor = False
			Me.xrLabel2.Text = "Contact Title:"
			' 
			' xrLabel3
			' 
			Me.xrLabel3.BackColor = System.Drawing.Color.Blue
			Me.xrLabel3.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold)
			Me.xrLabel3.ForeColor = System.Drawing.Color.White
			Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 56.00001F)
			Me.xrLabel3.Name = "xrLabel3"
			Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel3.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel3.StylePriority.UseBackColor = False
			Me.xrLabel3.StylePriority.UseFont = False
			Me.xrLabel3.StylePriority.UseForeColor = False
			Me.xrLabel3.Text = "Phone:"
			' 
			' xrLabel4
			' 
			Me.xrLabel4.BackColor = System.Drawing.Color.Blue
			Me.xrLabel4.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold)
			Me.xrLabel4.ForeColor = System.Drawing.Color.White
			Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 79.00003F)
			Me.xrLabel4.Name = "xrLabel4"
			Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel4.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel4.StylePriority.UseBackColor = False
			Me.xrLabel4.StylePriority.UseFont = False
			Me.xrLabel4.StylePriority.UseForeColor = False
			Me.xrLabel4.Text = "Fax:"
			' 
			' xrLabel5
			' 
			Me.xrLabel5.BackColor = System.Drawing.Color.Blue
			Me.xrLabel5.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold)
			Me.xrLabel5.ForeColor = System.Drawing.Color.White
			Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 102F)
			Me.xrLabel5.Name = "xrLabel5"
			Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel5.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel5.StylePriority.UseBackColor = False
			Me.xrLabel5.StylePriority.UseFont = False
			Me.xrLabel5.StylePriority.UseForeColor = False
			Me.xrLabel5.Text = "Home Page:"
			' 
			' xrLabel6
			' 
			Me.xrLabel6.BackColor = System.Drawing.Color.Blue
			Me.xrLabel6.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold)
			Me.xrLabel6.ForeColor = System.Drawing.Color.White
			Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 125F)
			Me.xrLabel6.Name = "xrLabel6"
			Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel6.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel6.StylePriority.UseBackColor = False
			Me.xrLabel6.StylePriority.UseFont = False
			Me.xrLabel6.StylePriority.UseForeColor = False
			Me.xrLabel6.Text = "Address:"
			' 
			' xrLabel7
			' 
			Me.xrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ContactName")})
			Me.xrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(110F, 10.00001F)
			Me.xrLabel7.Name = "xrLabel7"
			Me.xrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel7.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel7.Text = "xrLabel7"
			' 
			' xrLabel8
			' 
			Me.xrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ContactTitle")})
			Me.xrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(110F, 33.00002F)
			Me.xrLabel8.Name = "xrLabel8"
			Me.xrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel8.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel8.Text = "xrLabel8"
			' 
			' xrLabel9
			' 
			Me.xrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Phone")})
			Me.xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(110F, 56.00001F)
			Me.xrLabel9.Name = "xrLabel9"
			Me.xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel9.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel9.Text = "xrLabel9"
			' 
			' xrLabel10
			' 
			Me.xrLabel10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Fax")})
			Me.xrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(110F, 79F)
			Me.xrLabel10.Name = "xrLabel10"
			Me.xrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel10.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel10.Text = "xrLabel10"
			' 
			' xrLabel11
			' 
			Me.xrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "HomePage")})
			Me.xrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(110F, 102F)
			Me.xrLabel11.Name = "xrLabel11"
			Me.xrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel11.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel11.Text = "xrLabel11"
			' 
			' xrLabel12
			' 
			Me.xrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Address")})
			Me.xrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(110F, 125F)
			Me.xrLabel12.Name = "xrLabel12"
			Me.xrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel12.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel12.Text = "xrLabel12"
			' 
			' xrLabel13
			' 
			Me.xrLabel13.BackColor = System.Drawing.Color.Blue
			Me.xrLabel13.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold)
			Me.xrLabel13.ForeColor = System.Drawing.Color.White
			Me.xrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(251.0417F, 10.00001F)
			Me.xrLabel13.Name = "xrLabel13"
			Me.xrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel13.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel13.StylePriority.UseBackColor = False
			Me.xrLabel13.StylePriority.UseFont = False
			Me.xrLabel13.StylePriority.UseForeColor = False
			Me.xrLabel13.Text = "Country:"
			' 
			' xrLabel14
			' 
			Me.xrLabel14.BackColor = System.Drawing.Color.Blue
			Me.xrLabel14.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold)
			Me.xrLabel14.ForeColor = System.Drawing.Color.White
			Me.xrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(251.0417F, 79.00003F)
			Me.xrLabel14.Name = "xrLabel14"
			Me.xrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel14.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel14.StylePriority.UseBackColor = False
			Me.xrLabel14.StylePriority.UseFont = False
			Me.xrLabel14.StylePriority.UseForeColor = False
			Me.xrLabel14.Text = "Postal Code:"
			' 
			' xrLabel15
			' 
			Me.xrLabel15.BackColor = System.Drawing.Color.Blue
			Me.xrLabel15.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold)
			Me.xrLabel15.ForeColor = System.Drawing.Color.White
			Me.xrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(251.0417F, 56.00001F)
			Me.xrLabel15.Name = "xrLabel15"
			Me.xrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel15.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel15.StylePriority.UseBackColor = False
			Me.xrLabel15.StylePriority.UseFont = False
			Me.xrLabel15.StylePriority.UseForeColor = False
			Me.xrLabel15.Text = "City:"
			' 
			' xrLabel16
			' 
			Me.xrLabel16.BackColor = System.Drawing.Color.Blue
			Me.xrLabel16.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold)
			Me.xrLabel16.ForeColor = System.Drawing.Color.White
			Me.xrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(251.0417F, 33.00002F)
			Me.xrLabel16.Name = "xrLabel16"
			Me.xrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel16.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel16.StylePriority.UseBackColor = False
			Me.xrLabel16.StylePriority.UseFont = False
			Me.xrLabel16.StylePriority.UseForeColor = False
			Me.xrLabel16.Text = "Region:"
			' 
			' xrLabel17
			' 
			Me.xrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Country")})
			Me.xrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(351.0417F, 10.00001F)
			Me.xrLabel17.Name = "xrLabel17"
			Me.xrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel17.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel17.Text = "xrLabel17"
			' 
			' xrLabel18
			' 
			Me.xrLabel18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Region")})
			Me.xrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(351.0417F, 33.00002F)
			Me.xrLabel18.Name = "xrLabel18"
			Me.xrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel18.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel18.Text = "xrLabel18"
			' 
			' xrLabel19
			' 
			Me.xrLabel19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "City")})
			Me.xrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(351.0417F, 56.00001F)
			Me.xrLabel19.Name = "xrLabel19"
			Me.xrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel19.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel19.Text = "xrLabel19"
			' 
			' xrLabel20
			' 
			Me.xrLabel20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PostalCode")})
			Me.xrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(351.0417F, 79.00003F)
			Me.xrLabel20.Name = "xrLabel20"
			Me.xrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel20.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel20.Text = "xrLabel20"
			' 
			' DetailReport
			' 
			Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail1, Me.ReportHeader})
			Me.DetailReport.DataMember = "Products"
			Me.DetailReport.DataSource = Me.suppliersCollection
			Me.DetailReport.Level = 0
			Me.DetailReport.Name = "DetailReport"
			' 
			' Detail1
			' 
			Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable2})
			Me.Detail1.HeightF = 23F
			Me.Detail1.Name = "Detail1"
			' 
			' formattingRule1
			' 
			Me.formattingRule1.DataSource = Me.suppliersCollection
			Me.formattingRule1.Name = "formattingRule1"
			' 
			' xrLabel21
			' 
			Me.xrLabel21.Font = New System.Drawing.Font("Times New Roman", 50F)
			Me.xrLabel21.ForeColor = System.Drawing.Color.LightBlue
			Me.xrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
			Me.xrLabel21.Name = "xrLabel21"
			Me.xrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel21.SizeF = New System.Drawing.SizeF(630F, 79.99998F)
			Me.xrLabel21.StylePriority.UseFont = False
			Me.xrLabel21.StylePriority.UseForeColor = False
			Me.xrLabel21.StylePriority.UseTextAlignment = False
			Me.xrLabel21.Text = "Suppliers"
			Me.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
			Me.ReportHeader.HeightF = 23F
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' xrTable1
			' 
			Me.xrTable1.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
			Me.xrTable1.BackColor = System.Drawing.Color.Blue
			Me.xrTable1.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTable1.ForeColor = System.Drawing.Color.White
			Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 0F)
			Me.xrTable1.Name = "xrTable1"
			Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
			Me.xrTable1.SizeF = New System.Drawing.SizeF(490F, 19.79168F)
			Me.xrTable1.StylePriority.UseBackColor = False
			Me.xrTable1.StylePriority.UseBorders = False
			Me.xrTable1.StylePriority.UseForeColor = False
			' 
			' xrTableRow1
			' 
			Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3, Me.xrTableCell9, Me.xrTableCell10})
			Me.xrTableRow1.Name = "xrTableRow1"
			Me.xrTableRow1.Weight = 1R
			' 
			' xrTableCell1
			' 
			Me.xrTableCell1.CanGrow = False
			Me.xrTableCell1.Name = "xrTableCell1"
			Me.xrTableCell1.Text = "Product Name"
			Me.xrTableCell1.Weight = 0.58657396691717989R
			' 
			' xrTableCell2
			' 
			Me.xrTableCell2.CanGrow = False
			Me.xrTableCell2.Name = "xrTableCell2"
			Me.xrTableCell2.Text = "Category"
			Me.xrTableCell2.Weight = 0.66990776366561977R
			' 
			' xrTableCell3
			' 
			Me.xrTableCell3.CanGrow = False
			Me.xrTableCell3.Name = "xrTableCell3"
			Me.xrTableCell3.Text = "Quantity per Unit"
			Me.xrTableCell3.Weight = 0.67175932459576593R
			' 
			' xrTable2
			' 
			Me.xrTable2.BackColor = System.Drawing.Color.LightBlue
			Me.xrTable2.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(8.958308F, 0F)
			Me.xrTable2.Name = "xrTable2"
			Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow2})
			Me.xrTable2.SizeF = New System.Drawing.SizeF(491.0417F, 18.75F)
			Me.xrTable2.StylePriority.UseBackColor = False
			Me.xrTable2.StylePriority.UseBorders = False
			' 
			' xrTableRow2
			' 
			Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell4, Me.xrTableCell5, Me.xrTableCell7, Me.xrTableCell6, Me.xrTableCell8})
			Me.xrTableRow2.Name = "xrTableRow2"
			Me.xrTableRow2.Weight = 1R
			' 
			' xrTableCell4
			' 
			Me.xrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.ProductName")})
			Me.xrTableCell4.Name = "xrTableCell4"
			Me.xrTableCell4.Text = "xrTableCell4"
			Me.xrTableCell4.Weight = 0.60414707472711759R
			' 
			' xrTableCell5
			' 
			Me.xrTableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.Category.CategoryName")})
			Me.xrTableCell5.Name = "xrTableCell5"
			Me.xrTableCell5.Text = "xrTableCell5"
			Me.xrTableCell5.Weight = 0.68190392337196815R
			' 
			' xrTableCell6
			' 
			Me.xrTableCell6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.UnitPrice")})
			Me.xrTableCell6.Name = "xrTableCell6"
			Me.xrTableCell6.Text = "xrTableCell6"
			Me.xrTableCell6.Weight = 0.70240326181071666R
			' 
			' xrTableCell7
			' 
			Me.xrTableCell7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.QuantityPerUnit")})
			Me.xrTableCell7.Name = "xrTableCell7"
			Me.xrTableCell7.Text = "xrTableCell7"
			Me.xrTableCell7.Weight = 0.68378889144534716R
			' 
			' xrTableCell8
			' 
			Me.xrTableCell8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.Discontinued")})
			Me.xrTableCell8.Name = "xrTableCell8"
			Me.xrTableCell8.Text = "xrTableCell8"
			Me.xrTableCell8.Weight = 0.65999065178435146R
			' 
			' xrTableCell9
			' 
			Me.xrTableCell9.CanGrow = False
			Me.xrTableCell9.Name = "xrTableCell9"
			Me.xrTableCell9.Text = "Unit Price"
			Me.xrTableCell9.Weight = 0.69004604780721357R
			' 
			' xrTableCell10
			' 
			Me.xrTableCell10.CanGrow = False
			Me.xrTableCell10.Name = "xrTableCell10"
			Me.xrTableCell10.Text = "Discontinued"
			Me.xrTableCell10.Weight = 0.64837958176537969R
			' 
			' suppliersCollection
			' 
			Me.suppliersCollection.DisplayableProperties = "CompanyName;ContactName;ContactTitle;Address;City;Region;PostalCode;Country;Phone" & ";Fax;HomePage;Products"
			Me.suppliersCollection.ObjectType = GetType(Northwind.Supplier)
'			Me.suppliersCollection.ResolveSession += New DevExpress.Xpo.ResolveSessionEventHandler(Me.OnSuppliersCollectionResolveSession);
			' 
			' SuppliersReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.DetailReport})
			Me.DataSource = Me.suppliersCollection
			Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() { Me.formattingRule1})
			Me.Version = "10.1"
			CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.suppliersCollection, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private xrLabel6 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel5 As DevExpress.XtraReports.UI.XRLabel
		Private WithEvents suppliersCollection As DevExpress.Xpo.XPCollection
		Private xrLabel12 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel11 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel10 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel9 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel8 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel7 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel20 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel19 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel18 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel17 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel16 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel15 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel14 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel13 As DevExpress.XtraReports.UI.XRLabel
		Private DetailReport As DevExpress.XtraReports.UI.DetailReportBand
		Private Detail1 As DevExpress.XtraReports.UI.DetailBand
		Private formattingRule1 As DevExpress.XtraReports.UI.FormattingRule
		Private xrLabel21 As DevExpress.XtraReports.UI.XRLabel
		Private xrTable2 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private xrTable1 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
	End Class
End Namespace
