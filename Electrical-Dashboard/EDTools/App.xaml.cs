using EDTools.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace EDTools
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static ToolsVM _ToolsVM;
        public static ToolsVM ToolsVM { get { return _ToolsVM ?? (_ToolsVM = new ToolsVM()); } }
    }
}
