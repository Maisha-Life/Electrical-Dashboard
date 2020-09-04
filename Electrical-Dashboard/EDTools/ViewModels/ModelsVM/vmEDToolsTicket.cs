using EDDLL.Tickets;
using EDDLL.Utilities;
using EDTools.Utilities;
using System.Windows.Input;

namespace EDTools.ViewModels.ModelsVM
{
    public class vmEDToolsTicket : vmTicket
    {
        public vmEDToolsTicket(Ticket ticket, bool type) : base(ticket, type) { }

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
            TicketNumber = 0001;

            ImportanceLevelProp.Save();
            ToolProp.Save();
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
