using EDDLL.Tickets;
using EDDLL.Utilities;
using EDDLL.ViewModels;
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

        private ObservableCollection<vmTicket> _AssignedRuleTickets;
        public ObservableCollection<vmTicket> AssignedRuleTickets
        {
            get { return _AssignedRuleTickets ?? (_AssignedRuleTickets = new ObservableCollection<vmTicket>()); }
            set
            {
                if (this._AssignedRuleTickets != value)
                {
                    this._AssignedRuleTickets = value;
                    this.RaisePropertyChangedEvent("AssignedRuleTickets");
                }
            }
        }

        private ObservableCollection<vmTicket> _CreatedRuleTickets;
        public ObservableCollection<vmTicket> CreatedRuleTickets
        {
            get { return _CreatedRuleTickets ?? (_CreatedRuleTickets = new ObservableCollection<vmTicket>()); }
            set
            {
                if (this._CreatedRuleTickets != value)
                {
                    this._CreatedRuleTickets = value;
                    this.RaisePropertyChangedEvent("CreatedRuleTickets");
                }
            }
        }

        #endregion

        #region Commands

        private RelayCommand _AddRuleCommand;
        public ICommand AddRuleCommand
        {
            get
            {
                if (_AddRuleCommand == null) _AddRuleCommand = new RelayCommand(param => addRule(), param => { return (true); });

                return _AddRuleCommand;
            }
        }
        private void addRule()
        {

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

        }

        #endregion
    }
}
