using EDDLL.Utilities;
using EDDLL.ViewModels;
using EDRules.Models;
using EDRules.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EDRules.ViewModels.ModelsVM
{
    public class vmRule : vmBase
    {
        public readonly Rule _rule;
        private readonly ObservableCollection<vmRule> _rules;

        public vmRule(Rule rule, ObservableCollection<vmRule> rules)
        {
            _rule = rule ?? throw new ArgumentNullException("rule");
            _rules = rules ?? throw new ArgumentNullException("rules");
        }

        #region Data Binds

        private ThreeNOne _DesignRuleProp;
        public ThreeNOne DesignRuleProp
        {
            get
            {
                if (_DesignRuleProp == null)
                    _DesignRuleProp = new ThreeNOne(_rule.DesignRule);

                return _DesignRuleProp;
            }
            set
            {
                if (_DesignRuleProp != value)
                {
                    _DesignRuleProp = value;
                    _rule.DesignRule = _DesignRuleProp.Changed;
                    this.RaisePropertyChangedEvent("DesignRuleProp");
                }
            }
        }
        public string DesignRule
        {
            get { return DesignRuleProp.Changed; }
            set
            {
                if (this._DesignRuleProp.Changed != value)
                    this._DesignRuleProp.Changed = value;

                _rule.DesignRule = value;
                this.RaisePropertyChangedEvent("DesignRule");
            }
        }

        private ThreeNOne _LegacyIDDescProp;
        public ThreeNOne LegacyIDDescProp
        {
            get
            {
                if (_LegacyIDDescProp == null)
                    _LegacyIDDescProp = new ThreeNOne(_rule.LegacyIDDesc);

                return _LegacyIDDescProp;
            }
            set
            {
                if (_LegacyIDDescProp != value)
                {
                    _LegacyIDDescProp = value;
                    _rule.LegacyIDDesc = _LegacyIDDescProp.Changed;
                    this.RaisePropertyChangedEvent("LegacyIDDescProp");
                }
            }
        }
        public string LegacyIDDesc
        {
            get { return LegacyIDDescProp.Changed; }
            set
            {
                if (this._LegacyIDDescProp.Changed != value)
                    this._LegacyIDDescProp.Changed = value;

                _rule.LegacyIDDesc = value;
                this.RaisePropertyChangedEvent("LegacyIDDesc");
            }
        }

        private ThreeNOne _RuleNameProp;
        public ThreeNOne RuleNameProp
        {
            get
            {
                if (_RuleNameProp == null)
                    _RuleNameProp = new ThreeNOne(_rule.RuleName);

                return _RuleNameProp;
            }
            set
            {
                if (_RuleNameProp != value)
                {
                    _RuleNameProp = value;
                    _rule.RuleName = _RuleNameProp.Changed;
                    this.RaisePropertyChangedEvent("RuleNameProp");
                }
            }
        }
        public string RuleName
        {
            get { return RuleNameProp.Changed; }
            set
            {
                if (this._RuleNameProp.Changed != value)
                    this._RuleNameProp.Changed = value;

                _rule.RuleName = value;
                this.RaisePropertyChangedEvent("RuleName");
            }
        }

        private ThreeNOne _RuleDescProp;
        public ThreeNOne RuleDescProp
        {
            get
            {
                if (_RuleDescProp == null)
                    _RuleDescProp = new ThreeNOne(_rule.RuleDesc);

                return _RuleDescProp;
            }
            set
            {
                if (_RuleDescProp != value)
                {
                    _RuleDescProp = value;
                    _rule.RuleDesc = _RuleDescProp.Changed;
                    this.RaisePropertyChangedEvent("RuleDescProp");
                }
            }
        }
        public string RuleDesc
        {
            get { return RuleDescProp.Changed; }
            set
            {
                if (this._RuleDescProp.Changed != value)
                    this._RuleDescProp.Changed = value;

                _rule.RuleDesc = value;
                this.RaisePropertyChangedEvent("RuleDesc");
            }
        }

        private ThreeNOne _OwnerProp;
        public ThreeNOne OwnerProp
        {
            get
            {
                if (_OwnerProp == null)
                    _OwnerProp = new ThreeNOne(_rule.Owner);

                return _OwnerProp;
            }
            set
            {
                if (_OwnerProp != value)
                {
                    _OwnerProp = value;
                    _rule.Owner = _OwnerProp.Changed;
                    this.RaisePropertyChangedEvent("OwnerProp");
                }
            }
        }
        public string Owner
        {
            get { return OwnerProp.Changed; }
            set
            {
                if (this._OwnerProp.Changed != value)
                    this._OwnerProp.Changed = value;

                _rule.Owner = value;
                this.RaisePropertyChangedEvent("Owner");
            }
        }

        private ThreeNOne _RuleCheckDescProp;
        public ThreeNOne RuleCheckDescProp
        {
            get
            {
                if (_RuleCheckDescProp == null)
                    _RuleCheckDescProp = new ThreeNOne(_rule.RuleCheckDesc);

                return _RuleCheckDescProp;
            }
            set
            {
                if (_RuleCheckDescProp != value)
                {
                    _RuleCheckDescProp = value;
                    _rule.RuleCheckDesc = _RuleCheckDescProp.Changed;
                    this.RaisePropertyChangedEvent("RuleCheckDescProp");
                }
            }
        }
        public string RuleCheckDesc
        {
            get { return RuleCheckDescProp.Changed; }
            set
            {
                if (this._RuleCheckDescProp.Changed != value)
                    this._RuleCheckDescProp.Changed = value;

                _rule.RuleCheckDesc = value;
                this.RaisePropertyChangedEvent("RuleCheckDesc");
            }
        }

        private ThreeNOne _RuleRepairDescProp;
        public ThreeNOne RuleRepairDescProp
        {
            get
            {
                if (_RuleRepairDescProp == null)
                    _RuleRepairDescProp = new ThreeNOne(_rule.RuleRepairDesc);

                return _RuleRepairDescProp;
            }
            set
            {
                if (_RuleRepairDescProp != value)
                {
                    _RuleRepairDescProp = value;
                    _rule.RuleRepairDesc = _RuleRepairDescProp.Changed;
                    this.RaisePropertyChangedEvent("RuleRepairDescProp");
                }
            }
        }
        public string RuleRepairDesc
        {
            get { return RuleRepairDescProp.Changed; }
            set
            {
                if (this._RuleRepairDescProp.Changed != value)
                    this._RuleRepairDescProp.Changed = value;

                _rule.RuleRepairDesc = value;
                this.RaisePropertyChangedEvent("RuleRepairDesc");
            }
        }

        private ObservableCollection<vmMeasurement> _RuleMeasurements;
        public ObservableCollection<vmMeasurement> RuleMeasurements
        {
            get { return _RuleMeasurements; }
            set
            {
                if (this._RuleMeasurements != value)
                {
                    this._RuleMeasurements = value;
                    this.RaisePropertyChangedEvent("RuleMeasurements");
                }
            }
        }

        private ObservableCollection<vmParameter> _SpecificHarnessComponentParameters;
        public ObservableCollection<vmParameter> SpecificHarnessComponentParameters
        {
            get { return _SpecificHarnessComponentParameters; }
            set
            {
                if (this._SpecificHarnessComponentParameters != value)
                {
                    this._SpecificHarnessComponentParameters = value;
                    this.RaisePropertyChangedEvent("SpecificHarnessComponentParameters");
                }
            }
        }

        private ObservableCollection<vmParameter> _HarnessParameters;
        public ObservableCollection<vmParameter> HarnessParameters
        {
            get { return _HarnessParameters; }
            set
            {
                if (this._HarnessParameters != value)
                {
                    this._HarnessParameters = value;
                    this.RaisePropertyChangedEvent("HarnessParameters");
                }
            }
        }

        private ObservableCollection<vmParameter> _MilestoneParameters;
        public ObservableCollection<vmParameter> MilestoneParameters
        {
            get { return _MilestoneParameters; }
            set
            {
                if (this._MilestoneParameters != value)
                {
                    this._MilestoneParameters = value;
                    this.RaisePropertyChangedEvent("MilestoneParameters");
                }
            }
        }

        #endregion

        #region Commands

        private RelayCommand _CreateRuleCommand;
        public ICommand CreateRuleCommand
        {
            get
            {
                if (_CreateRuleCommand == null) _CreateRuleCommand = new RelayCommand(param => createRule(), param => { return (true); });

                return _CreateRuleCommand;
            }
        }
        private void createRule()
        {
            save();

            _rules.Add(this);

            PopupHelper.SetVisibility(false);
        }

        private RelayCommand _CancelCreateRuleCommand;
        public ICommand CancelCreateRuleCommand
        {
            get
            {
                if (_CancelCreateRuleCommand == null) _CancelCreateRuleCommand = new RelayCommand(param => cancelCreateRule(), param => { return (true); });

                return _CancelCreateRuleCommand;
            }
        }
        private void cancelCreateRule()
        {
            PopupHelper.SetVisibility(false);
            this.Dispose();
        }

        private RelayCommand _SaveRuleCommand;
        public ICommand SaveRuleCommand
        {
            get
            {
                if (_SaveRuleCommand == null) _SaveRuleCommand = new RelayCommand(param => saveRule(), param => { return (true); });

                return _SaveRuleCommand;
            }
        }
        private void saveRule()
        {
            save();
            PopupHelper.SetVisibility(false);
        }

        private RelayCommand _CancelRuleCommand;
        public ICommand CancelRuleCommand
        {
            get
            {
                if (_CancelRuleCommand == null) _CancelRuleCommand = new RelayCommand(param => cancelRule(), param => { return (true); });

                return _CancelRuleCommand;
            }
        }
        private void cancelRule()
        {
            PopupHelper.SetVisibility(false);
        }

        private RelayCommand _EditCommand;
        public ICommand EditCommand
        {
            get
            {
                if (_EditCommand == null) _EditCommand = new RelayCommand(param => editCommand(), param => { return (true); });

                return _EditCommand;
            }
        }
        public void editCommand() 
        {
            PopupHelper.TabIndex(3, this);
            PopupHelper.SetVisibility(true);
        }

        private RelayCommand _RemoveCommand;
        public ICommand RemoveCommand
        {
            get
            {
                if (_RemoveCommand == null) _RemoveCommand = new RelayCommand(param => removeCommand(), param => { return (true); });

                return _RemoveCommand;
            }
        }
        public void removeCommand() 
        {
            _rules.Remove(this);
            this.Dispose();
        }

        #endregion

        #region Methods

        public void save() { }
        public void cancel() { }
        public void remove() { }
        public void revert() { }

        private void saveProperties() { }

        #endregion
    }
}
