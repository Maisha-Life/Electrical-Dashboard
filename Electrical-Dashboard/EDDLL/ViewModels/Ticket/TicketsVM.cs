using EDDLL.Tickets;
using EDDLL.Utilities;
using EDDLL.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Documents;
using System.Windows.Input;

namespace EDDLL.Tickets
{
    public static class TicketsVM
    {
        static TicketsVM()
        {
            TicketsCreated = new ObservableCollection<vmTicket>();
            TicketsAssigned = new ObservableCollection<vmTicket>();

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
            PriorityList.Add("High"); 
        }

        #region Data Binds

        private static ObservableCollection<vmTicket> _TicketsCreated;
        public static ObservableCollection<vmTicket> TicketsCreated
        {
            get { return _TicketsCreated; }
            set
            {
                _TicketsCreated = value;
                NotifyStaticPropertyChanged("TicketCreated");
            }
        }

        private static ObservableCollection<vmTicket> _TicketsAssigned;
        public static ObservableCollection<vmTicket> TicketsAssigned
        {
            get { return _TicketsAssigned; }
            set
            {
                _TicketsAssigned = value;
                NotifyStaticPropertyChanged("TicketsAssigned");
            }
        }

        public static int TicketsCompleted;

        public static List<string> UserList { get; set; }
        public static List<string> ToolList { get; set; }
        public static List<string> CategoryList { get; set; }
        public static List<string> PriorityList { get; set; }
        public static List<string> StatusList { get; set; }

        #endregion

        public static event EventHandler<PropertyChangedEventArgs> StaticPropertyChanged = delegate { };
        private static void NotifyStaticPropertyChanged(string propertyName)
        {
            StaticPropertyChanged(null, new PropertyChangedEventArgs(propertyName));
        }

    }
}

