using EDDLL.Tickets;
using EDDLL.Utilities;
using EDDLL.ViewModels;
using EDRules.Utilities;
using EDRules.ViewModels.ModelsVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EDRules.ViewModels
{
    public class RulesVM : BaseVM
    {
        public RulesVM() { }

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

            PopupHelper.TabIndex(2, rule);
            PopupHelper.SetVisibility(true);
        }


        private RelayCommand _CreateRuleTicketCommand;
        public ICommand CreateRuleTicketCommand
        {
            get
            {
                if (_CreateRuleTicketCommand == null) _CreateRuleTicketCommand = new RelayCommand(param => createRuleTicket(), param => { return (true); });

                return _CreateRuleTicketCommand;
            }
        }
        private void createRuleTicket()
        {
            vmEDRulesTicket ticket = new vmEDRulesTicket(Ticket.createTicket("", "", Environment.UserName, DateTime.Today, DateTime.Today), true);

            PopupHelper.TabIndex(0, ticket);
            PopupHelper.SetVisibility(true);
        }

        #endregion
    }
}
