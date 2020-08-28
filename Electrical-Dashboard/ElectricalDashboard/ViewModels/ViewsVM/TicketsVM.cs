using EDDLL.Tickets;
using EDDLL.Utilities;
using EDS.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ElectricalDashboard.ViewModels.ViewsVM
{
    public class TicketsVM : BaseVM    
    {
        public TicketsVM() { }

        #region Data Binds

        private ObservableCollection<vmTicket> _AssignedTickets;
        public ObservableCollection<vmTicket> AssignedTickets
        {
            get { return _AssignedTickets ?? (_AssignedTickets = new ObservableCollection<vmTicket>()); }
            set
            {
                if (this._AssignedTickets != value)
                {
                    this._AssignedTickets = value;
                    this.RaisePropertyChangedEvent("AssignedTickets");
                }
            }
        }

        private ObservableCollection<vmTicket> _CreatedTickets;
        public ObservableCollection<vmTicket> CreatedTickets
        {
            get { return _CreatedTickets ?? (_CreatedTickets = new ObservableCollection<vmTicket>()); }
            set
            {
                if (this._CreatedTickets != value)
                {
                    this._CreatedTickets = value;
                    this.RaisePropertyChangedEvent("CreatedTickets");
                }
            }
        }

        private ObservableCollection<vmTicket> _AllTickets;
        public ObservableCollection<vmTicket> AllTickets
        {
            get { return _AllTickets; }
            set
            {
                if (this._AllTickets != value)
                {
                    this._AllTickets = value;
                    this.RaisePropertyChangedEvent("AllTickets");
                }
            }
        }

        #endregion

        #region Commands

        private RelayCommand _CreateTicket;
        public ICommand CreateTicket
        {
            get
            {
                if (_CreateTicket == null) _CreateTicket = new RelayCommand(param => createTicket(), param => { return (true); });

                return _CreateTicket;
            }
        }
        private void createTicket()
        {

        }

        #endregion
    }
}
