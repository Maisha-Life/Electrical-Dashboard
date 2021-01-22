using EDDLL.Utilities;
using EDDLL.ViewModels;
using EDHarnessScan.Models;
using EDHarnessScan.Utilities;
using EDHarnessScan.ViewModels.ModelsVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EDHarnessScan.ViewModels.ViewsVM
{
    public class HarnessSelectVM : BaseVM
    {
        public HarnessSelectVM() 
        { 

        }

        #region Data Binds

        private ObservableCollection<vmProgram> _Programs;
        public ObservableCollection<vmProgram> Programs
        {
            get { return _Programs ?? (_Programs = new ObservableCollection<vmProgram>()); }
            set
            {
                if (this._Programs != value)
                {
                    this._Programs = value;
                    this.RaisePropertyChangedEvent("Programs");
                }
            }
        }

        private vmProgram _SelectedProgram;
        public vmProgram SelectedProgram
        {
            get { return _SelectedProgram; }
            set
            {
                if (this._SelectedProgram != value)
                {
                    this._SelectedProgram = value;
                    this.RaisePropertyChangedEvent("SelectedProgram");
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

        #endregion

        #region Commands

        private RelayCommand _CreateProgramCommand;
        public ICommand CreateProgramCommand
        {
            get
            {
                if (_CreateProgramCommand == null) _CreateProgramCommand = new RelayCommand(param => createProgram(), param => { return (true); });

                return _CreateProgramCommand;
            }
        }
        private void createProgram()
        {
            vmProgram program = new vmProgram(Program.CreateProgram(), Programs);

            PopupHelper.TabIndex(0, program);
            PopupHelper.SetVisibility(true);
        }

        #endregion
    }
}
