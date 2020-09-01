using EDDLL.Utilities;
using EDDLL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EDHarnessScan.ViewModels.ModelsVM
{
    public class vmHarness : vmBase
    {
        #region Data Binds

        #endregion

        #region Commands

        private RelayCommand _CancelAddHarnessCommand;
        public ICommand CancelAddHarnessCommand
        {
            get
            {
                if (_CancelAddHarnessCommand == null) _CancelAddHarnessCommand = new RelayCommand(param => cancelAddHarness(), param => { return (true); });

                return _CancelAddHarnessCommand;
            }
        }
        private void cancelAddHarness()
        {
            
        }

        #endregion
    }
}
