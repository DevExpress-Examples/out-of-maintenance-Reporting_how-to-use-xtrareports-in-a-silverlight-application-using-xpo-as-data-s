Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo

Namespace Northwind

	<Persistent("Categories")> _
	Public Class Category
		Inherits XPLiteObject
		Private fCategoryID As Integer
		<Key(True)> _
		Public Property CategoryID() As Integer
			Get
				Return fCategoryID
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue(Of Integer)("CategoryID", fCategoryID, value)
			End Set
		End Property
		Private fCategoryName As String
		<Size(15)> _
		Public Property CategoryName() As String
			Get
				Return fCategoryName
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("CategoryName", fCategoryName, value)
			End Set
		End Property
		<Association("Category-Products")> _
		Public ReadOnly Property Products() As XPCollection(Of Product)
			Get
				Return GetCollection(Of Product)("Products")
			End Get
		End Property
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Public Sub New()
			MyBase.New(Session.DefaultSession)
		End Sub
		Public Overrides Sub AfterConstruction()
			MyBase.AfterConstruction()
		End Sub
	End Class

	<Persistent("Products")> _
	Public Class Product
		Inherits XPLiteObject
		Private fProductID As Integer
		<Key(True)> _
		Public Property ProductID() As Integer
			Get
				Return fProductID
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue(Of Integer)("ProductID", fProductID, value)
			End Set
		End Property
		Private fProductName As String
		<Size(40)> _
		Public Property ProductName() As String
			Get
				Return fProductName
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("ProductName", fProductName, value)
			End Set
		End Property
		Private fSupplier As Supplier
		<Persistent("SupplierID"), Association("Supplier-Products")> _
		Public Property Supplier() As Supplier
			Get
				Return fSupplier
			End Get
			Set(ByVal value As Supplier)
				SetPropertyValue(Of Supplier)("Supplier", fSupplier, value)
			End Set
		End Property
		Private fCategoryID As Category
		<Persistent("CategoryID"), Association("Category-Products")> _
		Public Property Category() As Category
			Get
				Return fCategoryID
			End Get
			Set(ByVal value As Category)
				SetPropertyValue(Of Category)("Category", fCategoryID, value)
			End Set
		End Property
		Private fQuantityPerUnit As String
		<Size(20)> _
		Public Property QuantityPerUnit() As String
			Get
				Return fQuantityPerUnit
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("QuantityPerUnit", fQuantityPerUnit, value)
			End Set
		End Property
		Private fUnitPrice As Decimal
		Public Property UnitPrice() As Decimal
			Get
				Return fUnitPrice
			End Get
			Set(ByVal value As Decimal)
				SetPropertyValue(Of Decimal)("UnitPrice", fUnitPrice, value)
			End Set
		End Property
		Private fDiscontinued As Boolean
		Public Property Discontinued() As Boolean
			Get
				Return fDiscontinued
			End Get
			Set(ByVal value As Boolean)
				SetPropertyValue(Of Boolean)("Discontinued", fDiscontinued, value)
			End Set
		End Property
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Public Sub New()
			MyBase.New(Session.DefaultSession)
		End Sub
		Public Overrides Sub AfterConstruction()
			MyBase.AfterConstruction()
		End Sub
	End Class

	<Persistent("Suppliers")> _
	Public Class Supplier
		Inherits XPLiteObject
		Private fSupplierID As Integer
		<Key(True)> _
		Public Property SupplierID() As Integer
			Get
				Return fSupplierID
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue(Of Integer)("SupplierID", fSupplierID, value)
			End Set
		End Property
		Private fCompanyName As String
		<Size(40)> _
		Public Property CompanyName() As String
			Get
				Return fCompanyName
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("CompanyName", fCompanyName, value)
			End Set
		End Property
		Private fContactName As String
		<Size(30)> _
		Public Property ContactName() As String
			Get
				Return fContactName
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("ContactName", fContactName, value)
			End Set
		End Property
		Private fContactTitle As String
		<Size(30)> _
		Public Property ContactTitle() As String
			Get
				Return fContactTitle
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("ContactTitle", fContactTitle, value)
			End Set
		End Property
		Private fAddress As String
		<Size(60)> _
		Public Property Address() As String
			Get
				Return fAddress
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("Address", fAddress, value)
			End Set
		End Property
		Private fCity As String
		<Size(15)> _
		Public Property City() As String
			Get
				Return fCity
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("City", fCity, value)
			End Set
		End Property
		Private fRegion As String
		<Size(15)> _
		Public Property Region() As String
			Get
				Return fRegion
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("Region", fRegion, value)
			End Set
		End Property
		Private fPostalCode As String
		<Size(10)> _
		Public Property PostalCode() As String
			Get
				Return fPostalCode
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("PostalCode", fPostalCode, value)
			End Set
		End Property
		Private fCountry As String
		<Size(15)> _
		Public Property Country() As String
			Get
				Return fCountry
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("Country", fCountry, value)
			End Set
		End Property
		Private fPhone As String
		<Size(24)> _
		Public Property Phone() As String
			Get
				Return fPhone
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("Phone", fPhone, value)
			End Set
		End Property
		Private fFax As String
		<Size(24)> _
		Public Property Fax() As String
			Get
				Return fFax
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("Fax", fFax, value)
			End Set
		End Property
		Private fHomePage As String
		<Size(1073741823)> _
		Public Property HomePage() As String
			Get
				Return fHomePage
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("HomePage", fHomePage, value)
			End Set
		End Property
		<Association("Supplier-Products")> _
		Public ReadOnly Property Products() As XPCollection(Of Product)
			Get
				Return GetCollection(Of Product)("Products")
			End Get
		End Property
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Public Sub New()
			MyBase.New(Session.DefaultSession)
		End Sub
		Public Overrides Sub AfterConstruction()
			MyBase.AfterConstruction()
		End Sub
	End Class

End Namespace
