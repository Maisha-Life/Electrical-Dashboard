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

namespace EDDLL.Tickets
{
    public class vmTicket : vmBase
    {
        public readonly Ticket _ticket;

        public vmTicket() { }
        //type, if new (true) then all fields are available, if based off of a tool then (false) and some fields will be filled in by default
        public vmTicket(Ticket ticket)
        {
            _ticket = ticket ?? throw new ArgumentNullException("ticket");
        }

        #region Data Binds

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

        private ThreeNOne _SubCategoryProp;
        public ThreeNOne SubCategoryProp
        {
            get
            {
                if (_SubCategoryProp == null)
                    _SubCategoryProp = new ThreeNOne(_ticket.SubCategory);

                return _SubCategoryProp;
            }
            set
            {
                if (_SubCategoryProp != value)
                {
                    _SubCategoryProp = value;
                    _ticket.SubCategory = _SubCategoryProp.Changed;
                    this.RaisePropertyChangedEvent("SubCategoryProp");
                }
            }
        }
        public string SubCategory
        {
            get { return SubCategoryProp.Changed; }
            set
            {
                if (this._SubCategoryProp.Changed != value)
                    this._SubCategoryProp.Changed = value;

                _ticket.SubCategory = value;
                this.RaisePropertyChangedEvent("SubCategory");
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

        #endregion

        #region Methods

        public virtual void save() { }
        public void cancel() { }
        public void remove() { }
        public void revert() { }

        private void saveProperties() { }

        #endregion
    }
}