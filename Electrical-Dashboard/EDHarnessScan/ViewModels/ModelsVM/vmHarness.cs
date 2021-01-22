using EDDLL.Data.SQL;
using EDDLL.Utilities;
using EDDLL.ViewModels;
using EDHarnessScan.Models;
using EDRules.ViewModels.ModelsVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace EDHarnessScan.ViewModels.ModelsVM
{
    public class vmHarness : vmBase
    {
        public readonly Harness _harness;
        public readonly ObservableCollection<vmHarness> _harnesses;
        public readonly vmProgram _program;

        public vmHarness(Harness harness, ObservableCollection<vmHarness> harnesses, vmProgram program)
        {
            _harnesses = new ObservableCollection<vmHarness>();

            _harness = harness ?? throw new ArgumentNullException("harness");
            _harnesses = harnesses ?? throw new ArgumentNullException("harnesses");
            _program = program ?? throw new ArgumentNullException("program");

            foreach (vmRule rule in EDRules.App.RulesVM.RuleList)
                HarnessRules.Add(new vmHarnessRule(this, rule));

            checkToolBools();

        }

        #region Data Binds

        private Visibility _Visibility;
        public Visibility Visibility
        {
            get { return _Visibility; }
            set
            {
                if (this._Visibility != value)
                {
                    this._Visibility = value;
                    this.RaisePropertyChangedEvent("Visibility");
                }
            }
        }

        private ObservableCollection<vmHarnessRule> _HarnessRules;
        public ObservableCollection<vmHarnessRule> HarnessRules
        {
            get { return _HarnessRules ?? (_HarnessRules = new ObservableCollection<vmHarnessRule>()); }
            set
            {
                if (this._HarnessRules != value)
                {
                    this._HarnessRules = value;
                    this.RaisePropertyChangedEvent("HarnessRules");
                }
            }
        }

        private bool _startScanPromptBool;
        public bool startScanPromptBool
        {
            get { return _startScanPromptBool; }
            set
            {
                this._startScanPromptBool = value;
                this.RaisePropertyChangedEvent("startScanPromptBool");

            }
        }

        public string harnessType { get; set; }

        private string _ProgramPrefix;
        public string ProgramPrefix
        {
            get
            {
                if (_ProgramPrefix == null)
                    _ProgramPrefix = _harness.ProgramPrefix;

                return _ProgramPrefix;
            }
            set
            {
                _ProgramPrefix = value;
                _harness.ProgramPrefix = _ProgramPrefix;
                this.RaisePropertyChangedEvent("ProgramPrefix");
            }
        }

        private ThreeNOne _HarnessBaseProp;
        public ThreeNOne HarnessBaseProp
        {
            get
            {
                if (_HarnessBaseProp == null)
                    _HarnessBaseProp = new ThreeNOne(_harness.HarnessBase);

                return _HarnessBaseProp;
            }
            set
            {
                if (_HarnessBaseProp != value)
                {
                    _HarnessBaseProp = value;
                    _harness.HarnessBase = _HarnessBaseProp.Changed;
                    this.RaisePropertyChangedEvent("HarnessBaseProp");
                }
            }
        }
        public string HarnessBase
        {
            get { return HarnessBaseProp.Changed; }
            set
            {
                if (this._HarnessBaseProp.Changed != value)
                    this._HarnessBaseProp.Changed = value;

                _harness.HarnessBase = value;
                this.RaisePropertyChangedEvent("HarnessBase");
            }
        }

        private ThreeNOne _HarnessSuffixProp;
        public ThreeNOne HarnessSuffixProp
        {
            get
            {
                if (_HarnessSuffixProp == null)
                    _HarnessSuffixProp = new ThreeNOne(_harness.HarnessSuffix);

                return _HarnessSuffixProp;
            }
            set
            {
                if (_HarnessSuffixProp != value)
                {
                    _HarnessSuffixProp = value;
                    _harness.HarnessSuffix = _HarnessSuffixProp.Changed;
                    this.RaisePropertyChangedEvent("HarnessSuffixProp");
                }
            }
        }
        public string HarnessSuffix
        {
            get { return HarnessSuffixProp.Changed; }
            set
            {
                if (this._HarnessSuffixProp.Changed != value)
                    this._HarnessSuffixProp.Changed = value;

                _harness.HarnessSuffix = value;
                this.RaisePropertyChangedEvent("HarnessSuffix");
            }
        }

        private ThreeNOne _OwnerProp;
        public ThreeNOne OwnerProp
        {
            get
            {
                if (_OwnerProp == null)
                    _OwnerProp = new ThreeNOne(_harness.Owner);

                return _OwnerProp;
            }
            set
            {
                if (_OwnerProp != value)
                {
                    _OwnerProp = value;
                    _harness.Owner = _OwnerProp.Changed;
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

                _harness.Owner = value;
                this.RaisePropertyChangedEvent("Owner");
            }
        }

        private bool _ToolsScanBool;
        public bool ToolsScanBool
        {
            get
            {
                _ToolsScanBool = _harness.ToolsScanBool;

                return _ToolsScanBool;
            }
            set
            {
                _ToolsScanBool = value;
                _harness.ToolsScanBool = _ToolsScanBool;
                this.RaisePropertyChangedEvent("ToolsScanBool");
            }
        }

        private bool _PMIBool;
        public bool PMIBool
        {
            get
            {
                _PMIBool = _harness.PMIBool;

                return _PMIBool;
            }
            set
            {
                _PMIBool = value;
                _harness.PMIBool = _PMIBool;
                checkToolBools();
                this.RaisePropertyChangedEvent("PMIBool");
            }
        }     
        private bool _DTSyncBool;
        public bool DTSyncBool
        {
            get
            {
                _DTSyncBool = _harness.DTSyncBool;

                return _DTSyncBool;
            }
            set
            {
                _DTSyncBool = value;
                _harness.DTSyncBool = _DTSyncBool;
                checkToolBools();
                this.RaisePropertyChangedEvent("DTSyncBool");
            }
        }
        private bool _FFA2Bool;
        public bool FFA2Bool
        {
            get
            {
                _FFA2Bool = _harness.FFA2Bool;

                return _FFA2Bool;
            }
            set
            {
                _FFA2Bool = value;
                _harness.FFA2Bool = _FFA2Bool;
                checkToolBools();
                this.RaisePropertyChangedEvent("FFA2Bool");
            }
        }
        private bool _RenamingBool;
        public bool RenamingBool
        {
            get
            {
                _RenamingBool = _harness.RenamingBool;

                return _RenamingBool;
            }
            set
            {
                _RenamingBool = value;
                _harness.RenamingBool = _RenamingBool;
                checkToolBools();
                this.RaisePropertyChangedEvent("RenamingBool");
            }
        }
        private bool _CouponBool;
        public bool CouponBool
        {
            get { return _CouponBool; }
            set
            {
                if (this._CouponBool != value)
                {
                    this._CouponBool = value;
                    checkToolBools();
                    this.RaisePropertyChangedEvent("CouponBool");
                }
            }
        }

        private bool _HarnessCheckBool;
        public bool HarnessCheckBool
        {
            get
            {
                _HarnessCheckBool = _harness.HarnessCheckBool;

                return _HarnessCheckBool;
            }
            set
            {
                _HarnessCheckBool = value;
                _harness.HarnessCheckBool = _HarnessCheckBool;
                this.RaisePropertyChangedEvent("HarnessCheckBool");
            }
        }

        private int _SelectedRuleCount;
        public int SelectedRuleCount
        {
            get { return _SelectedRuleCount; }
            set
            {
                if (this._SelectedRuleCount != value)
                {
                    this._SelectedRuleCount = value;
                    this.RaisePropertyChangedEvent("SelectedRuleCount");
                }
            }
        }

        private bool _toolsScanReadyBool;
        public bool toolsScanReadyBool
        {
            get { return _toolsScanReadyBool; }
            set
            {
                if (this._toolsScanReadyBool != value)
                {
                    this._toolsScanReadyBool = value;

                    if (!value)
                        resetToolBools();

                    this.RaisePropertyChangedEvent("toolsScanReadyBool");
                }
            }
        }

        private bool _toolsMethodBool;
        public bool toolsMethodBool
        {
            get { return _toolsMethodBool; }
            set
            {
                if (this._toolsMethodBool != value)
                {
                    this._toolsMethodBool = value;
                    resetToolBools();
                    this.RaisePropertyChangedEvent("toolsMethodBool");
                }
            }
        }

        private int _toolsScanCompleteTerniary;
        public int toolsScanCompleteTerniary
        {
            get { return _toolsScanCompleteTerniary; }
            set
            {
                if (this._toolsScanCompleteTerniary != value)
                {
                    this._toolsScanCompleteTerniary = value;
                    this.RaisePropertyChangedEvent("toolsScanCompleteTerniary");
                }
            }
        }

        private bool _harnessScanSelectionReadyBool;
        public bool harnessScanSelectionReadyBool
        {
            get { return _harnessScanSelectionReadyBool; }
            set
            {
                if (this._harnessScanSelectionReadyBool != value)
                {
                    this._harnessScanSelectionReadyBool = value;
                    this.RaisePropertyChangedEvent("harnessScanSelectionReadyBool");
                }
            }
        }
        private bool _harnessScanReadyBool;
        public bool harnessScanReadyBool
        {
            get { return _harnessScanReadyBool; }
            set
            {
                if (this._harnessScanReadyBool != value)
                {
                    this._harnessScanReadyBool = value;
                    this.RaisePropertyChangedEvent("harnessScanReadyBool");
                }
            }
        }

        #endregion

        #region Commands

        private RelayCommand _SaveHarnessCommand;
        public ICommand SaveHarnessCommand
        {
            get
            {
                if (_SaveHarnessCommand == null) _SaveHarnessCommand = new RelayCommand(param => saveHarness(), param => { return (true); });

                return _SaveHarnessCommand;
            }
        }
        private void saveHarness()
        {
            save();
        }

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
            cancel();
        }

        private RelayCommand _RemoveHarnessCommand;
        public ICommand RemoveHarnessCommand
        {
            get
            {
                if (_RemoveHarnessCommand == null) _RemoveHarnessCommand = new RelayCommand(param => removeHarness(), param => { return (true); });

                return _RemoveHarnessCommand;
            }
        }
        private void removeHarness()
        {
            remove();
        }

        private RelayCommand _SelectHarness;
        public ICommand SelectHarness
        {
            get
            {
                if (_SelectHarness == null) _SelectHarness = new RelayCommand(param => selectHarness(), param => { return (true); });

                return _SelectHarness;
            }
        }
        private void selectHarness()
        {
            App.HarnessScanVM.SelectedHarness = this;
            App.HarnessScanVM.HarnessVisibility = Visibility.Visible;
        }

        private RelayCommand _ContinueRuleSelectionCommand;
        public ICommand ContinueRuleSelectionCommand
        {
            get
            {
                if (_ContinueRuleSelectionCommand == null) _ContinueRuleSelectionCommand = new RelayCommand(param => continueRuleSelection(), param => { return (true); });

                return _ContinueRuleSelectionCommand;
            }
        }
        private async void continueRuleSelection()
        {
            harnessScanSelectionReadyBool = true;
            ToolsScanBool = true;
        }

        #endregion

        #region Methods

        public override void save()
        {
            App.HarnessScanVM.HarnessesList.Add(this);
            App.HarnessSelectVM.HarnessesList.Add(this);

            HarnessBaseProp.Save();
            HarnessSuffixProp.Save();

            OwnerProp.Save();

            saveProperties();
        }
        public override void cancel()
        {
            HarnessBaseProp.Save();
            HarnessSuffixProp.Save();

            OwnerProp.Save();

            saveProperties();
        }
        public override void remove()
        {
            _harnesses.Remove(this);
        }
        public override void revert()
        {
            HarnessBaseProp.Save();
            HarnessSuffixProp.Save();

            OwnerProp.Save();

            saveProperties();
        }

        private void saveProperties()
        {
            HarnessBase = HarnessBaseProp.Saved;
            HarnessSuffix = HarnessSuffixProp.Saved;

            Owner = OwnerProp.Saved;

            EditBool = false;
        }

        public void checkTools(string toolString)
        {
            string[] tools = toolString.Split(',');

            foreach (string tool in tools)
            {
                string[] toolInfo = tool.Split(':');

                switch (toolInfo[0])
                {
                    case "PMI":
                        PMIBool = true;
                        break;
                    case "DTSync":
                        DTSyncBool = true;
                        break;
                    case "FFA2":
                        FFA2Bool = true;
                        break;
                    case "Renaming":
                        RenamingBool = true;
                        break;
                    case "Coupon":
                        CouponBool = true;
                        break;
                    default:
                        break;
                }
            }
        }
        private void checkToolBools()
        {
            if (PMIBool && DTSyncBool && FFA2Bool && RenamingBool && CouponBool)
                toolsScanCompleteTerniary = 0;
            else if (PMIBool || DTSyncBool || FFA2Bool || RenamingBool || CouponBool)
                toolsScanCompleteTerniary = 1;
            else
                toolsScanCompleteTerniary = 2;
        }
        public void resetToolBools()
        {
            PMIBool = false;
            DTSyncBool = false;
            FFA2Bool = false;
            RenamingBool = false;
            CouponBool = false;
        }

        public void GetSelected()
        {
            SelectedRuleCount = 0;

            foreach (vmHarnessRule rule in _HarnessRules)
                if (rule.SelectedRuleBool)
                    SelectedRuleCount++;
        }

        #endregion
    }
}
