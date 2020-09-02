using EDDLL.Tickets;
using EDDLL.Utilities;
using EDDLL.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace EDDLL.Tickets
{
    public class TicketsVM : BaseVM    
    {
        public TicketsVM() { }

        #region Data Binds

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

        private int _TicketsCompleteCount;
        public int TicketsCompleteCount
        {
            get { return _TicketsCompleteCount; }
            set
            {
                if (this._TicketsCompleteCount != value)
                {
                    this._TicketsCompleteCount = value;
                    this.RaisePropertyChangedEvent("TicketsCompleteCount");
                }
            }
        }

        #endregion
    }
}
