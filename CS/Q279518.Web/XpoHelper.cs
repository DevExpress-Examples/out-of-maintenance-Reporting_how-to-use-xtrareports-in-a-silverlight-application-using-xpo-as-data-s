using System;
using Northwind;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.Xpo.Metadata;

/// <summary>
/// Summary description for XpoHelper
/// </summary>
public static class XpoHelper {
    public static Session GetNewSession() {
        return new Session(DataLayer);
    }

    public static UnitOfWork GetNewUnitOfWork() {
        return new UnitOfWork(DataLayer);
    }

    private readonly static object lockObject = new object();

    static volatile IDataLayer fDataLayer;
    static IDataLayer DataLayer {
        get {
            if (fDataLayer == null) {
                lock (lockObject) {
                    if (fDataLayer == null) {
                        fDataLayer = GetDataLayer();
                    }
                }
            }
            return fDataLayer;
        }
    }

    private static IDataLayer GetDataLayer() {
        XpoDefault.Session = null;
        XPDictionary dict = new ReflectionDictionary();
        dict.GetDataStoreSchema(typeof(Category).Assembly);
        return new ThreadSafeDataLayer(dict, 
            XpoDefault.GetConnectionProvider(MSSqlConnectionProvider.GetConnectionString("(local)", "Northwind"),
            AutoCreateOption.None));
    }
}
