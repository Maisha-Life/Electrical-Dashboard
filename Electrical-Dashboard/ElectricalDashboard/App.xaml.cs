using ElectricalDashboard.ViewModels;
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
