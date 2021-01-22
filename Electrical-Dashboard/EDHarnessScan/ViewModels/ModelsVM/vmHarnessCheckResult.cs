using EDDLL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDHarnessScan.ViewModels.ModelsVM
{
    public class vmHarnessCheckResult : vmBase
    {
        #region Data Binds

        private string _Component;
        public string Component
        {
            get { return _Component; }
            set
            {
                if (this._Component != value)
                {
                    this._Component = value;
                    this.RaisePropertyChangedEvent("Component");
                }
            }
        }

        private string _Description;
        public string Description
        {
            get { return _Description; }
            set
            {
                if (this._Description != value)
                {
                    this._Description = value;
                    this.RaisePropertyChangedEvent("Description");
                }
            }
        }

        private string _Assigned;
        public string Assigned
        {
            get { return _Assigned; }
            set
            {
                if (this._Assigned != value)
                {
                    this._Assigned = value;
                    this.RaisePropertyChangedEvent("Assigned");
                }
            }
        }

        private string _Id_Status;
        public string Id_Status
        {
            get { return _Id_Status; }
            set
            {
                if (this._Id_Status != value)
                {
                    this._Id_Status = value;
                    this.RaisePropertyChangedEvent("Id_Status");
                }
            }
        }

        #endregion
    }
}
