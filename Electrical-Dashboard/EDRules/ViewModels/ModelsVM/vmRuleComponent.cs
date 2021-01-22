using EDRules.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDRules.ViewModels.ModelsVM
{
    public class vmRuleComponent : vmParameter
    {
        public readonly Component _component;
        public vmRuleComponent(vmRule rule, Component component) : base(rule)
        {
            _component = component ?? throw new ArgumentNullException("component");
        }

        #region Data Binds

        private string _Description;
        public string Description
        {
            get
            {
                if (_Description == null)
                    _Description = _component.Description;

                return _Description;
            }
            set
            {
                _Description = value;
                _component.Description = _Description;
                this.RaisePropertyChangedEvent("Description");
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
