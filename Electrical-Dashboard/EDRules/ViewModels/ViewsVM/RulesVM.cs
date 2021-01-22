using EDDLL.Tickets;
using EDDLL.Utilities;
using EDDLL.ViewModels;
using EDRules.Data;
using EDRules.Utilities;
using EDRules.ViewModels.ModelsVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;

namespace EDRules.ViewModels
{
    public class RulesVM : BaseVM
    {
        public SQL sqlAccess;

        public RulesVM() 
        {
            sqlAccess = new SQL();

            sqlAccess.grabRulesInfo();

            _RuleList = sqlAccess.rulesList;

            countStatus();

            initializeRulesCollection();
        }

        #region Data Binds

        private int _TotalRuleCount;
        public int TotalRuleCount
        {
            get { return _TotalRuleCount; }
            set
            {
                if (this._TotalRuleCount != value)
                {
                    this._TotalRuleCount = value;
                    this.RaisePropertyChangedEvent("TotalRuleCount");
                }
            }
        }

        private int _TotalQuestionCount;
        public int TotalQuestionCount
        {
            get { return _TotalQuestionCount; }
            set
            {
                if (this._TotalQuestionCount != value)
                {
                    this._TotalQuestionCount = value;
                    this.RaisePropertyChangedEvent("TotalQuestionCount");
                }
            }
        }

        private int _TotalAnswerCount;
        public int TotalAnswerCount
        {
            get { return _TotalAnswerCount; }
            set
            {
                if (this._TotalAnswerCount != value)
                {
                    this._TotalAnswerCount = value;
                    this.RaisePropertyChangedEvent("TotalAnswerCount");
                }
            }
        }

        private int _TotalGoodCount;
        public int TotalGoodCount
        {
            get { return _TotalGoodCount; }
            set
            {
                if (this._TotalGoodCount != value)
                {
                    this._TotalGoodCount = value;
                    this.RaisePropertyChangedEvent("TotalGoodCount");
                }
            }
        }

        private int _TotalWarningCount;
        public int TotalWarningCount
        {
            get { return _TotalWarningCount; }
            set
            {
                if (this._TotalWarningCount != value)
                {
                    this._TotalWarningCount = value;
                    this.RaisePropertyChangedEvent("TotalWarningCount");
                }
            }
        }

        private int _TotalErrorCount;
        public int TotalErrorCount
        {
            get { return _TotalErrorCount; }
            set
            {
                if (this._TotalErrorCount != value)
                {
                    this._TotalErrorCount = value;
                    this.RaisePropertyChangedEvent("TotalErrorCount");
                }
            }
        }

        public readonly ObservableCollection<vmRule> _RuleList = new ObservableCollection<vmRule>();
        public ICollectionView RuleList { get; set; }

        private string _SearchString = "";
        public string SearchString
        {
            get { return _SearchString; }
            set
            {
                if (this._SearchString != value)
                {
                    this._SearchString = value;
                    RuleList.Refresh();
                    this.RaisePropertyChangedEvent("SearchString");
                }
            }
        }

        #endregion

        #region Search

        public void initializeRulesCollection()
        {
            RuleList = CollectionViewSource.GetDefaultView(_RuleList);
            RuleList.Filter = new Predicate<object>(SearchFilter);
            RuleList.SortDescriptions.Add(new SortDescription("DesignRule", ListSortDirection.Ascending));
        }
        public bool SearchFilter(object o)
        {
            vmRule item = o as vmRule;

            string itemString = item.DesignRule;

            if (itemString != null && itemString.IndexOf(_SearchString, StringComparison.OrdinalIgnoreCase) >= 0)
                return true;

            return false;
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

            vmRule rule = new vmRule(Models.Rule.CreateRule(), _RuleList);

            App.RulesVM.sqlAccess.populateRuleParameters(rule);

            PopupHelper.TabIndex(2, rule);
            PopupHelper.SetVisibility(true);
        }

        #endregion

        #region Methods

        public void countStatus()
        {
            TotalRuleCount = 0;

            TotalGoodCount = 0;
            TotalWarningCount = 0;
            TotalErrorCount = 0;

            TotalQuestionCount = 0;
            TotalAnswerCount = 0;

            foreach (vmRule ruleBase in _RuleList)
            {
                if (ruleBase.ruleStatus == 0)
                    TotalGoodCount++;
                else if (ruleBase.ruleStatus == 1)
                    TotalWarningCount++;
                else if (ruleBase.ruleStatus == 2)
                    TotalErrorCount++;

                TotalRuleCount++;
            }
        }

        #endregion
    }
}
