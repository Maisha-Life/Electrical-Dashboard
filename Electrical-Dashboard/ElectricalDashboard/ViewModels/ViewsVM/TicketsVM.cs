using EDDLL.Tickets;
using EDDLL.Utilities;
using EDDLL.ViewModels;
using ElectricalDashboard.Utilities;
using ElectricalDashboard.ViewModels.ModelsVM;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace ElectricalDashboard.ViewModels.ViewsVM
{
    public class TicketsVM : BaseVM
    {
        public TicketsVM() { }

        #region Data Binds

        private ObservableCollection<vmTicket> _TicketsCreated;
        public ObservableCollection<vmTicket> TicketsCreated
        {
            get { return _TicketsCreated ?? (_TicketsCreated = new ObservableCollection<vmTicket>()); }
            set
            {
                if (this._TicketsCreated != value)
                {
                    this._TicketsCreated = value;
                    this.RaisePropertyChangedEvent("TicketsCreated");
                }
            }
        }

        private ObservableCollection<vmTicket> _TicketsAssigned;
        public ObservableCollection<vmTicket> TicketsAssigned
        {
            get { return _TicketsAssigned ?? (_TicketsAssigned = new ObservableCollection<vmTicket>()); }
            set
            {
                if (this._TicketsAssigned != value)
                {
                    this._TicketsAssigned = value;
                    this.RaisePropertyChangedEvent("TicketsAssigned");
                }
            }
        }

        private ObservableCollection<vmTicket> _TicketsAll;
        public ObservableCollection<vmTicket> TicketsAll
        {
            get { return _TicketsAll ?? (_TicketsAll = new ObservableCollection<vmTicket>()); }
            set
            {
                if (this._TicketsAll != value)
                {
                    this._TicketsAll = value;
                    this.RaisePropertyChangedEvent("TicketsAll");
                }
            }
        }

        #endregion

        #region Commands

        private RelayCommand _TicketCreateCommand;
        public ICommand TicketCreateCommand
        {
            get
            {
                if (_TicketCreateCommand == null) _TicketCreateCommand = new RelayCommand(param => ticketCreate(), param => { return (true); });

                return _TicketCreateCommand;
            }
        }
        private void ticketCreate()
        {
            vmTicket ticket = new vmElectricalDashboardTicket(Ticket.createTicket("","",Environment.UserName, DateTime.Today, DateTime.Today));

            PopupHelper.TabIndex(0, ticket);
            PopupHelper.SetVisibility(true);
        }

        #endregion
    }
}
