using System;
using DevExpress.Xpo;

namespace Q279518.Web {
    public partial class SuppliersReport :DevExpress.XtraReports.UI.XtraReport {
        public SuppliersReport() {
            InitializeComponent();
        }
        private void OnSuppliersCollectionResolveSession(object sender, ResolveSessionEventArgs e) {
            e.Session = XpoHelper.GetNewSession();
        }

    }
}
