using EDDLL.Tickets;
using EDDLL.Utilities;
using EDDLL.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Documents;
using System.Windows.Input;

namespace EDDLL.Tickets
{
    public class TicketsVM : BaseVM    
    {
        public TicketsVM() 
        {
            UserList = new List<string>();
            ToolList = new List<string>();
            CategoryList = new List<string>();
            PriorityList = new List<string>();

            UserList.Add("jmill592");
            UserList.Add("ayu12");

            ToolList.Add("IPS");
            ToolList.Add("Catia");
            ToolList.Add("WGO");

            CategoryList.Add("Add Feature");
            CategoryList.Add("Remove Feature");
            CategoryList.Add("Edit Feature");

            PriorityList.Add("Low");
            PriorityList.Add("Normal");
            PriorityList.Add("High");;
        }

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

        public List<string> UserList { get; set; }
        public List<string> ToolList { get; set; }
        public List<string> CategoryList { get; set; }
        public List<string> PriorityList { get; set; }
        public List<string> StatusList { get; set; }

        #endregion
    }
}
