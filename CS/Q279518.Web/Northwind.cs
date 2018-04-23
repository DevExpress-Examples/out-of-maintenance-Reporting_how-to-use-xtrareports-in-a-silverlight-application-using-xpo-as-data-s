using System;
using DevExpress.Xpo;

namespace Northwind {

    [Persistent("Categories")]
    public class Category :XPLiteObject {
        int fCategoryID;
        [Key(true)]
        public int CategoryID {
            get { return fCategoryID; }
            set { SetPropertyValue<int>("CategoryID", ref fCategoryID, value); }
        }
        string fCategoryName;
        [Size(15)]
        public string CategoryName {
            get { return fCategoryName; }
            set { SetPropertyValue<string>("CategoryName", ref fCategoryName, value); }
        }
        [Association("Category-Products")]
        public XPCollection<Product> Products { get { return GetCollection<Product>("Products"); } }
        public Category(Session session) : base(session) { }
        public Category() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    [Persistent("Products")]
    public class Product :XPLiteObject {
        int fProductID;
        [Key(true)]
        public int ProductID {
            get { return fProductID; }
            set { SetPropertyValue<int>("ProductID", ref fProductID, value); }
        }
        string fProductName;
        [Size(40)]
        public string ProductName {
            get { return fProductName; }
            set { SetPropertyValue<string>("ProductName", ref fProductName, value); }
        }
        Supplier fSupplier;
        [Persistent("SupplierID"), Association("Supplier-Products")]
        public Supplier Supplier {
            get { return fSupplier; }
            set { SetPropertyValue<Supplier>("Supplier", ref fSupplier, value); }
        }
        Category fCategoryID;
        [Persistent("CategoryID"), Association("Category-Products")]
        public Category Category {
            get { return fCategoryID; }
            set { SetPropertyValue<Category>("Category", ref fCategoryID, value); }
        }
        string fQuantityPerUnit;
        [Size(20)]
        public string QuantityPerUnit {
            get { return fQuantityPerUnit; }
            set { SetPropertyValue<string>("QuantityPerUnit", ref fQuantityPerUnit, value); }
        }
        decimal fUnitPrice;
        public decimal UnitPrice {
            get { return fUnitPrice; }
            set { SetPropertyValue<decimal>("UnitPrice", ref fUnitPrice, value); }
        }
        bool fDiscontinued;
        public bool Discontinued {
            get { return fDiscontinued; }
            set { SetPropertyValue<bool>("Discontinued", ref fDiscontinued, value); }
        }
        public Product(Session session) : base(session) { }
        public Product() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    [Persistent("Suppliers")]
    public class Supplier :XPLiteObject {
        int fSupplierID;
        [Key(true)]
        public int SupplierID {
            get { return fSupplierID; }
            set { SetPropertyValue<int>("SupplierID", ref fSupplierID, value); }
        }
        string fCompanyName;
        [Size(40)]
        public string CompanyName {
            get { return fCompanyName; }
            set { SetPropertyValue<string>("CompanyName", ref fCompanyName, value); }
        }
        string fContactName;
        [Size(30)]
        public string ContactName {
            get { return fContactName; }
            set { SetPropertyValue<string>("ContactName", ref fContactName, value); }
        }
        string fContactTitle;
        [Size(30)]
        public string ContactTitle {
            get { return fContactTitle; }
            set { SetPropertyValue<string>("ContactTitle", ref fContactTitle, value); }
        }
        string fAddress;
        [Size(60)]
        public string Address {
            get { return fAddress; }
            set { SetPropertyValue<string>("Address", ref fAddress, value); }
        }
        string fCity;
        [Size(15)]
        public string City {
            get { return fCity; }
            set { SetPropertyValue<string>("City", ref fCity, value); }
        }
        string fRegion;
        [Size(15)]
        public string Region {
            get { return fRegion; }
            set { SetPropertyValue<string>("Region", ref fRegion, value); }
        }
        string fPostalCode;
        [Size(10)]
        public string PostalCode {
            get { return fPostalCode; }
            set { SetPropertyValue<string>("PostalCode", ref fPostalCode, value); }
        }
        string fCountry;
        [Size(15)]
        public string Country {
            get { return fCountry; }
            set { SetPropertyValue<string>("Country", ref fCountry, value); }
        }
        string fPhone;
        [Size(24)]
        public string Phone {
            get { return fPhone; }
            set { SetPropertyValue<string>("Phone", ref fPhone, value); }
        }
        string fFax;
        [Size(24)]
        public string Fax {
            get { return fFax; }
            set { SetPropertyValue<string>("Fax", ref fFax, value); }
        }
        string fHomePage;
        [Size(1073741823)]
        public string HomePage {
            get { return fHomePage; }
            set { SetPropertyValue<string>("HomePage", ref fHomePage, value); }
        }
        [Association("Supplier-Products")]
        public XPCollection<Product> Products { get { return GetCollection<Product>("Products"); } }
        public Supplier(Session session) : base(session) { }
        public Supplier() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
