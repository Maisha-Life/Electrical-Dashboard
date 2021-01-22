using EDDLL.Utilities;
using EDDLL.ViewModels;
using EDRules.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDRules.ViewModels.ModelsVM
{
    public class vmParameter : vmBase
    {
        public readonly vmRule _rule;

        public vmParameter() { }
        public vmParameter(vmRule rule)
        {
            _rule = rule ?? throw new ArgumentNullException("rule");
        }

        #region Data Binds

        public bool selectedBool { get; set; }

        private ThreeNOne _SelectedBoolProp;
        public ThreeNOne SelectedBoolProp
        {
            get
            {
                if (_SelectedBoolProp == null)
                    _SelectedBoolProp = new ThreeNOne(selectedBool.ToString());

                return _SelectedBoolProp;
            }
            set
            {
                if (_SelectedBoolProp != value)
                {
                    _SelectedBoolProp = value;
                    this.RaisePropertyChangedEvent("SelectedBoolProp");
                }
            }
        }
        public string SelectedBool
        {
            get { return SelectedBoolProp.Changed; }
            set
            {
                if (this._SelectedBoolProp.Changed != value)
                    this._SelectedBoolProp.Changed = value;

                selectedBool = (value.ToUpper() == "TRUE" ? true : false);
                this.RaisePropertyChangedEvent("SelectedBool");
            }
        }

        #endregion        
    }
}
