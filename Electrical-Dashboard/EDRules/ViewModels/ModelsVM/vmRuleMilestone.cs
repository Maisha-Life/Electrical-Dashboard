using EDRules.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDRules.ViewModels.ModelsVM
{
    public class vmRuleMilestone : vmParameter
    {
        public readonly Milestone _milestone;
        public vmRuleMilestone(vmRule rule, Milestone milestone) : base(rule)
        {
            _milestone = milestone ?? throw new ArgumentNullException("milestone");
        }

        #region Data Binds

        private string _Abbreviation;
        public string Abbreviation
        {
            get
            {
                if (_Abbreviation == null)
                    _Abbreviation = _milestone.Abbreviation;

                return _Abbreviation;
            }
            set
            {
                _Abbreviation = value;
                _milestone.Abbreviation = _Abbreviation;
                this.RaisePropertyChangedEvent("Abbreviation");
            }
        }

        private string _Description;
        public string Description
        {
            get
            {
                if (_Description == null)
                    _Description = _milestone.Description;

                return _Description;
            }
            set
            {
                _Description = value;
                _milestone.Description = _Description;
                this.RaisePropertyChangedEvent("Description");
            }
        }

        private string _Group;
        public string Group
        {
            get
            {
                if (_Group == null)
                    _Group = _milestone.Group;

                return _Group;
            }
            set
            {
                _Group = value;
                _milestone.Group = _Group;
                this.RaisePropertyChangedEvent("Group");
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
