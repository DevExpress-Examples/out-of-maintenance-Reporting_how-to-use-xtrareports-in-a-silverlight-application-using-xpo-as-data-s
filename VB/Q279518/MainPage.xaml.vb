Imports Microsoft.VisualBasic
Imports System
Imports System.Windows
Imports System.Windows.Controls

Namespace Q279518
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub OnShowReportButtonClick(ByVal sender As Object, ByVal e As RoutedEventArgs)
			preview.Model.CreateDocument()
		End Sub
	End Class
End Namespace
