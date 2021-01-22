using EDHarnessScan.ViewModels;
using EDHarnessScan.ViewModels.ViewsVM;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace EDHarnessScan
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static MainVM _MainVM;
        public static MainVM MainVM { get { return _MainVM ?? (_MainVM = new MainVM()); } }

        private static PopupVM _PopupVM;
        public static PopupVM PopupVM { get { return _PopupVM ?? (_PopupVM = new PopupVM()); } }

        private static HarnessScanVM _HarnessScanVM;
        public static HarnessScanVM HarnessScanVM { get { return _HarnessScanVM ?? (_HarnessScanVM = new HarnessScanVM()); } }

        private static HarnessSelectVM _HarnessSelectVM;
        public static HarnessSelectVM HarnessSelectVM { get { return _HarnessSelectVM ?? (_HarnessSelectVM = new HarnessSelectVM()); } }

        private static GenerateReportVM _GenerateReportVM;
        public static GenerateReportVM GenerateReportVM { get { return _GenerateReportVM ?? (_GenerateReportVM = new GenerateReportVM()); } }
    }
}
