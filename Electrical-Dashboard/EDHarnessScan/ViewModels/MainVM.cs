using EDDLL.Utilities;
using EDDLL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EDHarnessScan.ViewModels
{
    public class MainVM : BaseVM
    {
        public MainVM()
        {
            SelectedTabIndex = 0;
        }

        #region Data Binds

        private int _SelectedTabIndex;
        public int SelectedTabIndex
        {
            get { return _SelectedTabIndex; }
            set
            {
                if (this._SelectedTabIndex != value)
                {
                    this._SelectedTabIndex = value;
                    this.RaisePropertyChangedEvent("SelectedTabIndex");
                }
            }
        }

        #endregion

        #region Commands

        public ICommand SelectTabIndex { get { return new RelayCommand<string>(selectTabIndex); } }
        private void selectTabIndex(string tabIndex)
        {
            SelectedTabIndex = Convert.ToInt32(tabIndex);
        }

        #endregion

        #region Methods

        #endregion
    }
}

