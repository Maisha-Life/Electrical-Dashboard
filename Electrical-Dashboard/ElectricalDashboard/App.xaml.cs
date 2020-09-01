using ElectricalDashboard.ViewModels;
using ElectricalDashboard.ViewModels.ViewsVM;

using Microsoft.Shell;

using System;
using System.Collections.Generic;
using System.Windows;


namespace ElectricalDashboard
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : ISingleInstanceApp
    {
        private const string Unique = "ElectricalDashboard";

        private static MainVM _MainVM;
        public static MainVM MainVM { get { return _MainVM ?? (_MainVM = new MainVM()); } }

        private static TicketsVM _TicketsVM;
        public static TicketsVM TicketsVM { get { return _TicketsVM ?? (_TicketsVM = new TicketsVM()); } }

        private static PopupVM _PopupVM;
        public static PopupVM PopupVM { get { return _PopupVM ?? (_PopupVM = new PopupVM()); } }

        [STAThread]
        public static void Main()
        {
            if (SingleInstance<App>.InitializeAsFirstInstance(Unique))
            {
                var application = new App();

                application.InitializeComponent();

                application.Run();

                // Allow single instance code to perform cleanup operations
                SingleInstance<App>.Cleanup();
            }
        }

        public bool SignalExternalCommandLineArgs(IList<string> args)
        {
            return true;
        }

        private void Application_Exit(object sender, ExitEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
