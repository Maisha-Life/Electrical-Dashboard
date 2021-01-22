using EDDLL.Utilities;
using EDDLL.ViewModels;
using EDRules.ViewModels.ModelsVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EDHarnessScan.ViewModels.ModelsVM
{
    public class vmHarnessRule : vmBase
    {
        public readonly vmHarness _harness;

        public vmHarnessRule(vmHarness harness, vmRule rule)
        {
            _harness = harness ?? throw new ArgumentNullException("harness");
            HarnessRule = rule;
            _SelectedRuleBool = true;

            GetStatistics();
        }

        #region Data Binds

        private int _Id_Status;
        public int Id_Status
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

        private vmRule _HarnessRule;
        public vmRule HarnessRule
        {
            get { return _HarnessRule; }
            set
            {
                if (this._HarnessRule != value)
                {
                    this._HarnessRule = value;
                    this.RaisePropertyChangedEvent("HarnessRule");
                }
            }
        }

        private bool _SelectedRuleBool;
        public bool SelectedRuleBool
        {
            get { return _SelectedRuleBool; }
            set
            {
                if (this._SelectedRuleBool != value)
                {
                    this._SelectedRuleBool = value;
                    _harness.GetSelected();
                    this.RaisePropertyChangedEvent("SelectedRuleBool");
                }
            }
        }

        private int _GoodCount;
        public int GoodCount
        {
            get { return _GoodCount; }
            set
            {
                if (this._GoodCount != value)
                {
                    this._GoodCount = value;
                    this.RaisePropertyChangedEvent("GoodCount");
                }
            }
        }

        private int _WarningCount;
        public int WarningCount
        {
            get { return _WarningCount; }
            set
            {
                if (this._WarningCount != value)
                {
                    this._WarningCount = value;
                    this.RaisePropertyChangedEvent("WarningCount");
                }
            }
        }

        private int _ErrorCount;
        public int ErrorCount
        {
            get { return _ErrorCount; }
            set
            {
                if (this._ErrorCount != value)
                {
                    this._ErrorCount = value;
                    this.RaisePropertyChangedEvent("ErrorCount");
                }
            }
        }

        public int TotalCount { get; set; }

        private ObservableCollection<vmHarnessCheckResult> _HarnessRuleChecks;
        public ObservableCollection<vmHarnessCheckResult> HarnessRuleChecks
        {
            get { return _HarnessRuleChecks ?? (_HarnessRuleChecks = new ObservableCollection<vmHarnessCheckResult>()); }
            set
            {
                if (this._HarnessRuleChecks != value)
                {
                    this._HarnessRuleChecks = value;
                    GetStatistics();
                    this.RaisePropertyChangedEvent("HarnessRuleChecks");
                }
            }
        }

        #endregion

        #region Commands

        private RelayCommand _AddHarnessRuleCheckCommand;
        public ICommand AddHarnessRuleCheckCommand
        {
            get
            {
                if (_AddHarnessRuleCheckCommand == null) _AddHarnessRuleCheckCommand = new RelayCommand(param => addHarnessRuleCheck(), param => { return (true); });

                return _AddHarnessRuleCheckCommand;
            }
        }
        private void addHarnessRuleCheck()
        {
            vmHarnessCheckResult harnessCheck = new vmHarnessCheckResult();
            harnessCheck.EditBool = true;

            HarnessRuleChecks.Add(harnessCheck);
        }


        #endregion

        #region Methods

        public void GetStatistics()
        {
            if (TotalCount != 1)
            {
                GoodCount = 0;
                WarningCount = 0;
                ErrorCount = 0;
                TotalCount = 0;

                foreach (vmHarnessCheckResult harnessCheckResult in HarnessRuleChecks)
                {
                    if (harnessCheckResult.Id_Status == "0")
                        GoodCount++;
                    else if (harnessCheckResult.Id_Status == "1")
                        WarningCount++;
                    else
                        ErrorCount++;

                    TotalCount++;
                }

                if (TotalCount == 0)
                {
                    ErrorCount = 1;
                    TotalCount = 1;
                }
            }
        }

        #endregion
    }
}
