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
    public class TicketsVM : EDDLL.Tickets.TicketsVM    
    {
        public TicketsVM() { }

        #region Data Binds

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
            vmTicket ticket = new vmElectricalDashboardTicket(Ticket.createTicket("","",Environment.UserName, DateTime.Today, DateTime.Today), true);

            PopupHelper.TabIndex(0, ticket);
            PopupHelper.SetVisibility(true);
        }

        #endregion
    }
}
