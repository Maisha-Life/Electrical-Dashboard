using EDDLL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalDashboard.ViewModels
{
    public class MainVM : BaseVM
    {
        public MainVM() 
        {
            SelectedTabIndex = 0;
            UserName = Environment.UserName;
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

        private string _UserName;
        public string UserName
        {
            get { return _UserName; }
            set
            {
                if (this._UserName != value)
                {
                    this._UserName = value;
                    this.RaisePropertyChangedEvent("UserName");
                }
            }
        }

        #endregion

        #region Commands

        #endregion

        #region Methods

        #endregion
    }
}
