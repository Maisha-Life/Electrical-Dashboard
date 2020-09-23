using EDDLL.Tickets;
using EDDLL.Utilities;
using EDDLL.ViewModels;
using EDRules.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EDRules.ViewModels.ModelsVM
{
    public class vmEDRulesTicket : vmTicket
    {
        public readonly vmRule _rule;

        public vmEDRulesTicket(Ticket ticket, int id_ticketRule, int id_rule) : base(ticket) 
        {
            Id_TicketRule = id_ticketRule;
            Id_Rule = id_rule;
        }

        public vmEDRulesTicket(Ticket ticket, vmRule rule) : base(ticket) 
        {
            _rule = rule ?? throw new ArgumentNullException("rule");
        }

        public vmEDRulesTicket(Ticket ticket) : base(ticket) {  }

        #region Properties

        public int Id_TicketRule { get; set; }
        public int Id_Rule { get; set; }

        #endregion

        #region Commands

        private RelayCommand _CreateCommand;
        public ICommand CreateCommand
        {
            get
            {
                if (_CreateCommand == null) _CreateCommand = new RelayCommand(param => createCommand(), param => { return (_ticket.IsValid); });

                return _CreateCommand;
            }
        }
        private void createCommand()
        {
            PopupHelper.SetVisibility(false);

            save();

            EDDLL.Tickets.TicketsVM.TicketsCreated.Add(this);
        }

        private RelayCommand _CancelCreateCommand;
        public ICommand CancelCreateCommand
        {
            get
            {
                if (_CancelCreateCommand == null) _CancelCreateCommand = new RelayCommand(param => cancelCreateCommand(), param => { return (true); });

                return _CancelCreateCommand;
            }
        }
        private void cancelCreateCommand()
        {
            PopupHelper.SetVisibility(false);
            this.Dispose();
        }

        private RelayCommand _SaveCommand;
        public ICommand SaveCommand
        {
            get
            {
                if (_SaveCommand == null) _SaveCommand = new RelayCommand(param => saveCommand(), param => { return (_ticket.IsValid); });

                return _SaveCommand;
            }
        }
        private void saveCommand()
        {
            save();

        }

        private RelayCommand _CancelCommand;
        public ICommand CancelCommand
        {
            get
            {
                if (_CancelCommand == null) _CancelCommand = new RelayCommand(param => cancelCommand(), param => { return (true); });

                return _CancelCommand;
            }
        }
        private void cancelCommand()
        {
            cancel();
        }

        public override void editCommand()
        {
            PopupHelper.TabIndex(1, this);
            PopupHelper.SetVisibility(true);
        }

        public override void removeCommand()
        {

        }

        #endregion

        #region Methods

        public override void save()
        {
            TicketNumber = EDDLL.Tickets.TicketsVM.TicketsCreated.Count + 1;

            ImportanceLevelProp.Save();
            SubCategoryProp.Save();
            CategoryProp.Save();
            AssignerProp.Save();
            AssigneeProp.Save();
            DateAssignedProp.Save();
            DateDueProp.Save();
            DescriptionProp.Save();
        }

        #endregion
    }
}
