﻿using EDRules.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace EDRules
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static RulesVM _RulesVM;
        public static RulesVM RulesVM { get { return _RulesVM ?? (_RulesVM = new RulesVM()); } }

        private static PopupVM _PopupVM;
        public static PopupVM PopupVM { get { return _PopupVM ?? (_PopupVM = new PopupVM()); } }
    }
}
