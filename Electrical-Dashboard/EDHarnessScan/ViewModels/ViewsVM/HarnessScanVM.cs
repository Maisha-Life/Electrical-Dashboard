using EDDLL.Utilities;
using EDDLL.ViewModels;
using EDHarnessScan.Utilities;
using EDHarnessScan.ViewModels.ModelsVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace EDHarnessScan.ViewModels.ViewsVM
{
    public class HarnessScanVM : BaseVM
    {
        public HarnessScanVM()
        {
            HarnessVisibility = Visibility.Hidden;
        }

        #region Data Binds

        private ObservableCollection<vmProgram> _ProgramsList;
        public ObservableCollection<vmProgram> ProgramsList
        {
            get { return _ProgramsList; }
            set
            {
                if (this._ProgramsList != value)
                {
                    this._ProgramsList = value;
                    this.RaisePropertyChangedEvent("ProgramsList");
                }
            }
        }

        private ObservableCollection<vmHarness> _HarnessesList;
        public ObservableCollection<vmHarness> HarnessesList
        {
            get { return _HarnessesList ?? (_HarnessesList = new ObservableCollection<vmHarness>()); }
            set
            {
                if (this._HarnessesList != value)
                {
                    this._HarnessesList = value;
                    this.RaisePropertyChangedEvent("HarnessesList");
                }
            }
        }

        private vmHarness _SelectedHarness;
        public vmHarness SelectedHarness
        {
            get { return _SelectedHarness; }
            set
            {
                if (this._SelectedHarness != value)
                {
                    this._SelectedHarness = value;
                    this.RaisePropertyChangedEvent("SelectedHarness");
                }
            }
        }

        private Visibility _HarnessVisibility;
        public Visibility HarnessVisibility
        {
            get { return _HarnessVisibility; }
            set
            {
                if (this._HarnessVisibility != value)
                {
                    this._HarnessVisibility = value;
                    this.RaisePropertyChangedEvent("HarnessVisibility");
                }
            }
        }

        #endregion

        #region Commands

        private RelayCommand _CreateHarnessScanTicketCommand;
        public ICommand CreateHarnessScanTicketCommand
        {
            get
            {
                if (_CreateHarnessScanTicketCommand == null) _CreateHarnessScanTicketCommand = new RelayCommand(param => createHarenessScanTicket(), param => { return (true); });

                return _CreateHarnessScanTicketCommand;
            }
        }
        private void createHarenessScanTicket()
        {

        }

        #endregion

        #region Methods

        #endregion
    }
}
