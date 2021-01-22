using EDRules.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDRules.ViewModels.ModelsVM
{
    public class vmRuleCPSC : vmParameter
    {
        public readonly CPSC _cpsc;
        public vmRuleCPSC(vmRule rule, CPSC cpsc) : base(rule)
        {
            _cpsc = cpsc ?? throw new ArgumentNullException("cpsc");
        }

        #region Data Binds       

        private string _Description;
        public string Description
        {
            get
            {
                if (_Description == null)
                    _Description = _cpsc.Description;

                return _Description;
            }
            set
            {
                _Description = value;
                _cpsc.Description = _Description;
                this.RaisePropertyChangedEvent("Description");
            }
        }

        private string _Number;
        public string Number
        {
            get
            {
                if (_Number == null)
                    _Number = _cpsc.Number;

                return _Number;
            }
            set
            {
                _Number = value;
                _cpsc.Number = _Number;
                this.RaisePropertyChangedEvent("Number");
            }
        }

        #endregion

        #region Methods

        public override void save()
        {
            SelectedBoolProp.Save();

            saveProperties();

            if (SelectedBoolProp.ChangedBool)
            {
                if (SelectedBool.ToUpper() == "TRUE")
                    App.RulesVM.sqlAccess.addRuleParameter(this);
                else
                    App.RulesVM.sqlAccess.removeRuleParameter(this);
            }
        }
        public override void cancel() { SelectedBoolProp.Cancel(); saveProperties(); }
        public override void remove() { SelectedBool = "false"; SelectedBoolProp.Save(); saveProperties(); }
        public override void revert() { SelectedBoolProp.Default(); saveProperties(); }

        private void saveProperties()
        {
            SelectedBool = SelectedBoolProp.Saved;

            EditBool = false;
        }

        #endregion
    }
}
