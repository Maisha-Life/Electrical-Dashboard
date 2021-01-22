using EDDLL.ViewModels;
using EDDLL.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace EDDLL.Tickets
{
    public class vmTicket : vmBase
    {
        public readonly Ticket _ticket;

        public vmTicket()
        {
            TypeSelectBool = false;
            CategorySelectedBool = false;
        }
        //type, if new (true) then all fields are available, if based off of a tool then (false) and some fields will be filled in by default
        public vmTicket(Ticket ticket)
        {
            _ticket = ticket ?? throw new ArgumentNullException("ticket");
        }

        #region Data Binds

        #region Model

        private int _Id_Item;
        public int Id_Item
        {
            get
            {
                if (_Id_Item == null)
                    _Id_Item = _ticket.Id_Item;

                return _Id_Item;
            }
            set
            {
                _Id_Item = value;
                _ticket.Id_Item = _Id_Item;
                this.RaisePropertyChangedEvent("Id_Item");
            }
        }

        private int _TicketNumber;
        public int TicketNumber
        {
            get
            {
                _TicketNumber = _ticket.TicketNumber;

                return _TicketNumber;
            }
            set
            {
                _TicketNumber = value;
                _ticket.TicketNumber = _TicketNumber;
                this.RaisePropertyChangedEvent("TicketNumber");
            }
        }

        private string _TicketType;
        public string TicketType
        {
            get
            {
                if (_TicketType == null)
                    _TicketType = _ticket.TicketType;

                return _TicketType;
            }
            set
            {
                _TicketType = value;
                _ticket.TicketType = _TicketType;
                this.RaisePropertyChangedEvent("TicketType");
            }
        }

        private ThreeNOne _ImportanceLevelProp;
        public ThreeNOne ImportanceLevelProp
        {
            get
            {
                if (_ImportanceLevelProp == null)
                    _ImportanceLevelProp = new ThreeNOne(_ticket.ImportanceLevel);

                return _ImportanceLevelProp;
            }
            set
            {
                if (_ImportanceLevelProp != value)
                {
                    _ImportanceLevelProp = value;
                    _ticket.ImportanceLevel = _ImportanceLevelProp.Changed;
                    this.RaisePropertyChangedEvent("ImportanceLevelProp");
                }
            }
        }
        public string ImportanceLevel
        {
            get { return ImportanceLevelProp.Changed; }
            set
            {
                if (this._ImportanceLevelProp.Changed != value)
                    this._ImportanceLevelProp.Changed = value;

                _ticket.ImportanceLevel = value;
                this.RaisePropertyChangedEvent("ImportanceLevel");
            }
        }

        private ThreeNOne _ItemProp;
        public ThreeNOne ItemProp
        {
            get
            {
                if (_ItemProp == null)
                    _ItemProp = new ThreeNOne(_ticket.Item);

                return _ItemProp;
            }
            set
            {
                if (_ItemProp != value)
                {
                    _ItemProp = value;
                    _ticket.Item = _ItemProp.Changed;
                    this.RaisePropertyChangedEvent("ItemProp");
                }
            }
        }
        public string Item
        {
            get { return ItemProp.Changed; }
            set
            {
                if (this._ItemProp.Changed != value)
                    this._ItemProp.Changed = value;

                _ticket.Item = value;
                this.RaisePropertyChangedEvent("Item");
            }
        }

        private ThreeNOne _CategoryProp;
        public ThreeNOne CategoryProp
        {
            get
            {
                if (_CategoryProp == null)
                    _CategoryProp = new ThreeNOne(_ticket.Category);

                return _CategoryProp;
            }
            set
            {
                if (_CategoryProp != value)
                {
                    _CategoryProp = value;
                    _ticket.Category = _CategoryProp.Changed;
                    this.RaisePropertyChangedEvent("CategoryProp");
                }
            }
        }
        public string Category
        {
            get { return CategoryProp.Changed; }
            set
            {
                if (this._CategoryProp.Changed != value)
                    this._CategoryProp.Changed = value;

                _ticket.Category = value;
                this.RaisePropertyChangedEvent("Category");
            }
        }

        private ThreeNOne _AssignerProp;
        public ThreeNOne AssignerProp
        {
            get
            {
                if (_AssignerProp == null)
                    _AssignerProp = new ThreeNOne(_ticket.Assigner);

                return _AssignerProp;
            }
            set
            {
                if (_AssignerProp != value)
                {
                    _AssignerProp = value;
                    _ticket.Assigner = _AssignerProp.Changed;
                    this.RaisePropertyChangedEvent("AssignerProp");
                }
            }
        }
        public string Assigner
        {
            get { return AssignerProp.Changed; }
            set
            {
                if (this._AssignerProp.Changed != value)
                    this._AssignerProp.Changed = value;

                _ticket.Assigner = value;
                this.RaisePropertyChangedEvent("Assigner");
            }
        }

        private ThreeNOne _AssigneeProp;
        public ThreeNOne AssigneeProp
        {
            get
            {
                if (_AssigneeProp == null)
                    _AssigneeProp = new ThreeNOne(_ticket.Assignee);

                return _AssigneeProp;
            }
            set
            {
                if (_AssigneeProp != value)
                {
                    _AssigneeProp = value;
                    _ticket.Assignee = _AssigneeProp.Changed;
                    this.RaisePropertyChangedEvent("AssigneeProp");
                }
            }
        }
        public string Assignee
        {
            get { return AssigneeProp.Changed; }
            set
            {
                if (this._AssigneeProp.Changed != value)
                    this._AssigneeProp.Changed = value;

                _ticket.Assignee = value;
                this.RaisePropertyChangedEvent("Assignee");
            }
        }

        private ThreeNOne _DateAssignedProp;
        public ThreeNOne DateAssignedProp
        {
            get
            {
                if (_DateAssignedProp == null)
                    _DateAssignedProp = new ThreeNOne(_ticket.DateAssigned.ToShortDateString());

                return _DateAssignedProp;
            }
            set
            {
                if (_DateAssignedProp != value)
                {
                    _DateAssignedProp = value;
                    _ticket.DateAssigned = Convert.ToDateTime(_DateAssignedProp.Changed);
                    this.RaisePropertyChangedEvent("DateAssignedProp");
                }
            }
        }
        public string DateAssigned
        {
            get { return DateAssignedProp.Changed; }
            set
            {
                if (this._DateAssignedProp.Changed != value)
                    this._DateAssignedProp.Changed = value;

                _ticket.DateAssigned = Convert.ToDateTime(value);
                this.RaisePropertyChangedEvent("DateAssigned");
            }
        }

        private ThreeNOne _DateDueProp;
        public ThreeNOne DateDueProp
        {
            get
            {
                if (_DateDueProp == null)
                    _DateDueProp = new ThreeNOne(_ticket.DateDue.ToShortDateString());

                return _DateDueProp;
            }
            set
            {
                if (_DateDueProp != value)
                {
                    _DateDueProp = value;
                    _ticket.DateDue = Convert.ToDateTime(_DateDueProp.Changed);
                    this.RaisePropertyChangedEvent("DateDueProp");
                }
            }
        }
        public string DateDue
        {
            get { return DateDueProp.Changed; }
            set
            {
                if (this._DateDueProp.Changed != value)
                    this._DateDueProp.Changed = value;

                _ticket.DateDue = Convert.ToDateTime(value);
                this.RaisePropertyChangedEvent("DateDue");
            }
        }

        private ThreeNOne _TitleProp;
        public ThreeNOne TitleProp
        {
            get
            {
                if (_TitleProp == null)
                    _TitleProp = new ThreeNOne(_ticket.Title);

                return _TitleProp;
            }
            set
            {
                if (_TitleProp != value)
                {
                    _TitleProp = value;
                    _ticket.Title = _TitleProp.Changed;
                    this.RaisePropertyChangedEvent("TitleProp");
                }
            }
        }
        public string Title
        {
            get { return TitleProp.Changed; }
            set
            {
                if (this._TitleProp.Changed != value)
                    this._TitleProp.Changed = value;

                _ticket.Title = value;
                this.RaisePropertyChangedEvent("Title");
            }
        }

        private ThreeNOne _DescriptionProp;
        public ThreeNOne DescriptionProp
        {
            get
            {
                if (_DescriptionProp == null)
                    _DescriptionProp = new ThreeNOne(_ticket.Description);

                return _DescriptionProp;
            }
            set
            {
                if (_DescriptionProp != value)
                {
                    _DescriptionProp = value;
                    _ticket.Description = _DescriptionProp.Changed;
                    this.RaisePropertyChangedEvent("DescriptionProp");
                }
            }
        }
        public string Description
        {
            get { return DescriptionProp.Changed; }
            set
            {
                if (this._DescriptionProp.Changed != value)
                    this._DescriptionProp.Changed = value;

                _ticket.Description = value;
                this.RaisePropertyChangedEvent("Description");
            }
        }

        private ThreeNOne _StatusProp;
        public ThreeNOne StatusProp
        {
            get
            {
                if (_StatusProp == null)
                    _StatusProp = new ThreeNOne(_ticket.Status);

                return _StatusProp;
            }
            set
            {
                if (_StatusProp != value)
                {
                    _StatusProp = value;
                    _ticket.Status = _StatusProp.Changed;
                    this.RaisePropertyChangedEvent("StatusProp");
                }
            }
        }
        public string Status
        {
            get { return StatusProp.Changed; }
            set
            {
                if (this._StatusProp.Changed != value)
                    this._StatusProp.Changed = value;

                _ticket.Status = value;
                this.RaisePropertyChangedEvent("Status");
            }
        }

        #endregion

        #region Views

        private bool _TypeSelectBool;
        public bool TypeSelectBool
        {
            get { return _TypeSelectBool; }
            set
            {
                if (this._TypeSelectBool != value)
                {
                    this._TypeSelectBool = value;
                    this.RaisePropertyChangedEvent("TypeSelectBool");
                }
            }
        }

        private bool _CategorySelectedBool;
        public bool CategorySelectedBool
        {
            get { return _CategorySelectedBool; }
            set
            {
                if (this._CategorySelectedBool != value)
                {
                    this._CategorySelectedBool = value;
                    this.RaisePropertyChangedEvent("CategorySelectedBool");
                }
            }
        }

        #endregion

        private ObservableCollection<string> _TicketNotes;
        public ObservableCollection<string> TicketNotes
        {
            get { return _TicketNotes; }
            set
            {
                if (this._TicketNotes != value)
                {
                    this._TicketNotes = value;
                    this.RaisePropertyChangedEvent("TicketNotes");
                }
            }
        }

        #endregion

        #region Commands

        private RelayCommand _EditCommand;
        public ICommand EditCommand
        {
            get
            {
                if (_EditCommand == null) _EditCommand = new RelayCommand(param => editCommand(), param => { return (true); });

                return _EditCommand;
            }
        }
        public virtual void editCommand() { }

        private RelayCommand _RemoveCommand;
        public ICommand RemoveCommand
        {
            get
            {
                if (_RemoveCommand == null) _RemoveCommand = new RelayCommand(param => removeCommand(), param => { return (true); });

                return _RemoveCommand;
            }
        }
        public virtual void removeCommand() { }

        public ICommand SelectTicketTypeCommand { get { return new RelayCommand<string>(selectTicketType); } }
        private void selectTicketType(string ticketType)
        {
            TicketType = ticketType;

            TypeSelectBool = true;
        }

        private RelayCommand _RevertTicketCommand;
        public ICommand RevertTicketCommand
        {
            get
            {
                if (_RevertTicketCommand == null) _RevertTicketCommand = new RelayCommand(param => revertTicket(), param => { return (true); });

                return _RevertTicketCommand;
            }
        }
        private void revertTicket()
        {
            cancel();

            Id_Item = -1;
            TicketType = "";
            
            TypeSelectBool = false;
            CategorySelectedBool = false;
        }

        #endregion

        #region Methods

        public virtual void saveProperties() { }
        public void cancel() 
        {
                
        }
        #endregion
    }
}