using System;
using System.Windows;
using System.Windows.Controls;

namespace Q279518 {
    public partial class MainPage :UserControl {
        public MainPage() {
            InitializeComponent();
        }

        private void OnShowReportButtonClick(object sender, RoutedEventArgs e) {
            preview.Model.CreateDocument();
        }
    }
}
