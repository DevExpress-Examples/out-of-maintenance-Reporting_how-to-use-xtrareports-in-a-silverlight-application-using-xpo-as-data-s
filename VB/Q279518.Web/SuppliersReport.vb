Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo

Namespace Q279518.Web
	Partial Public Class SuppliersReport
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub OnSuppliersCollectionResolveSession(ByVal sender As Object, ByVal e As ResolveSessionEventArgs) Handles suppliersCollection.ResolveSession
			e.Session = XpoHelper.GetNewSession()
		End Sub

	End Class
End Namespace
