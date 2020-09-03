using EDDLL.Tickets;
using EDDLL.Utilities;
using ElectricalDashboard.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ElectricalDashboard.ViewModels.ModelsVM
{
    public class vmElectricalDashboardTicket : vmTicket
    {
        public vmElectricalDashboardTicket(Ticket ticket, bool type) : base(ticket, type) { }
        #region Commands

        private RelayCommand _CreateCommand;
        public ICommand CreateCommand
        {
            get
            {
                if (_CreateCommand == null) _CreateCommand = new RelayCommand(param => createCommand(), param => { return (true); });

                return _CreateCommand;
            }
        }
        private void createCommand()
        {
            PopupHelper.SetVisibility(false);
            App.TicketsVM.TicketsAll.Add(this);
            App.TicketsVM.TicketsCreated.Add(this);
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
                if (_SaveCommand == null) _SaveCommand = new RelayCommand(param => saveCommand(), param => { return (true); });

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

        private RelayCommand _EditCommand;
        public ICommand EditCommand
        {
            get
            {
                if (_EditCommand == null) _EditCommand = new RelayCommand(param => editCommand(), param => { return (true); });

                return _EditCommand;
            }
        }
        private void editCommand()
        {

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
        private void removeCommand()
        {

        }

        #endregion
    }
}
