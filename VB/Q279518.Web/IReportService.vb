Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.ServiceModel
Imports System.Text
Imports DevExpress.XtraReports.Service

Namespace Q279518.Web
	' NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IReportService" in both code and config file together.
	<ServiceContract> _
	Public Interface IReportService
	Inherits DevExpress.XtraReports.Service.IReportService
		' Uncomment this method if you need to extent the base interface.
		' [OperationContract]
		' void DoWork();
	End Interface
End Namespace
