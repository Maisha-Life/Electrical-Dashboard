using EDDLL.Utilities;
using EDDLL.ViewModels;
using EDHarnessScan.Models;
using EDHarnessScan.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace EDHarnessScan.ViewModels.ModelsVM
{
    public class vmProgram : vmBase
    {
        public readonly Program _program;
        public readonly ObservableCollection<vmProgram> _programs;

        public vmProgram(Program program, ObservableCollection<vmProgram> programs)
        {
            _program = program ?? throw new ArgumentNullException("program");
            _programs = programs ?? throw new ArgumentNullException("programs");
        }

        #region Data Binds

        private Visibility _Visibility;
        public Visibility Visibility
        {
            get { return _Visibility; }
            set
            {
                if (this._Visibility != value)
                {
                    this._Visibility = value;
                    this.RaisePropertyChangedEvent("Visibility");
                }
            }
        }

        private string _ProgramPrefix;
        public string ProgramPrefix
        {
            get { return _ProgramPrefix; }
            set
            {
                if (this._ProgramPrefix != value)
                {
                    this._ProgramPrefix = value;
                    this.RaisePropertyChangedEvent("ProgramPrefix");
                }
            }
        }

        private ThreeNOne _ProgramDescProp;
        public ThreeNOne ProgramDescProp
        {
            get
            {
                if (_ProgramDescProp == null)
                    _ProgramDescProp = new ThreeNOne(_program.ProgramDesc);

                return _ProgramDescProp;
            }
            set
            {
                if (_ProgramDescProp != value)
                {
                    _ProgramDescProp = value;
                    _program.ProgramDesc = _ProgramDescProp.Changed;
                    this.RaisePropertyChangedEvent("ProgramDescProp");
                }
            }
        }
        public string ProgramDesc
        {
            get { return ProgramDescProp.Changed; }
            set
            {
                if (this._ProgramDescProp.Changed != value)
                    this._ProgramDescProp.Changed = value;

                _program.ProgramDesc = value;
                this.RaisePropertyChangedEvent("ProgramDesc");
            }
        }

        private ThreeNOne _OwnerProp;
        public ThreeNOne OwnerProp
        {
            get
            {
                if (_OwnerProp == null)
                    _OwnerProp = new ThreeNOne(_program.Owner);

                return _OwnerProp;
            }
            set
            {
                if (_OwnerProp != value)
                {
                    _OwnerProp = value;
                    _program.Owner = _OwnerProp.Changed;
                    this.RaisePropertyChangedEvent("OwnerProp");
                }
            }
        }
        public string Owner
        {
            get { return OwnerProp.Changed; }
            set
            {
                if (this._OwnerProp.Changed != value)
                    this._OwnerProp.Changed = value;

                _program.Owner = value;
                this.RaisePropertyChangedEvent("Owner");
            }
        }

        private ThreeNOne _MilestoneProp;
        public ThreeNOne MilestoneProp
        {
            get
            {
                if (_MilestoneProp == null)
                    _MilestoneProp = new ThreeNOne(_program.Milestone);

                return _MilestoneProp;
            }
            set
            {
                if (_MilestoneProp != value)
                {
                    _MilestoneProp = value;
                    _program.Milestone = _MilestoneProp.Changed;
                    this.RaisePropertyChangedEvent("MilestoneProp");
                }
            }
        }
        public string Milestone
        {
            get { return MilestoneProp.Changed; }
            set
            {
                if (this._MilestoneProp.Changed != value)
                    this._MilestoneProp.Changed = value;

                _program.Milestone = value;
                this.RaisePropertyChangedEvent("Milestone");
            }
        }

        private ObservableCollection<vmHarness> _HarnessList;
        public ObservableCollection<vmHarness> HarnessList
        {
            get { return _HarnessList ?? (_HarnessList = new ObservableCollection<vmHarness>()); }
            set
            {
                if (this._HarnessList != value)
                {
                    this._HarnessList = value;
                    this.RaisePropertyChangedEvent("HarnessList");
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
            _programs.Add(this);

            save();

            PopupHelper.SetVisibility(false);
        }

        private RelayCommand _CancelCreateProgramCommand;
        public ICommand CancelCreateProgramCommand
        {
            get
            {
                if (_CancelCreateProgramCommand == null) _CancelCreateProgramCommand = new RelayCommand(param => cancelCreateProgram(), param => { return (true); });

                return _CancelCreateProgramCommand;
            }
        }
        private void cancelCreateProgram()
        {

        }

        private RelayCommand _SaveProgramCommand;
        public ICommand SaveProgramCommand
        {
            get
            {
                if (_SaveProgramCommand == null) _SaveProgramCommand = new RelayCommand(param => saveProgram(), param => { return (true); });

                return _SaveProgramCommand;
            }
        }
        private void saveProgram()
        {
            save();
        }

        private RelayCommand _CancelProgramCommand;
        public ICommand CancelProgramCommand
        {
            get
            {
                if (_CancelProgramCommand == null) _CancelProgramCommand = new RelayCommand(param => cancelProgram(), param => { return (true); });

                return _CancelProgramCommand;
            }
        }
        private void cancelProgram()
        {
            cancel();
        }

        private RelayCommand _EditProgramCommand;
        public ICommand EditProgramCommand
        {
            get
            {
                if (_EditProgramCommand == null) _EditProgramCommand = new RelayCommand(param => editProgram(), param => { return (true); });

                return _EditProgramCommand;
            }
        }
        private void editProgram()
        {
            PopupHelper.TabIndex(1, this);
            PopupHelper.SetVisibility(true);
        }

        private RelayCommand _RemoveProgramCommand;
        public ICommand RemoveProgramCommand
        {
            get
            {
                if (_RemoveProgramCommand == null) _RemoveProgramCommand = new RelayCommand(param => removeProgram(), param => { return (true); });

                return _RemoveProgramCommand;
            }
        }
        private void removeProgram()
        {
            remove();
        }

        private RelayCommand _AddHarnessCommand;
        public ICommand AddHarnessCommand
        {
            get
            {
                if (_AddHarnessCommand == null) _AddHarnessCommand = new RelayCommand(param => addHarness(), param => { return (true); });

                return _AddHarnessCommand;
            }
        }
        private void addHarness()
        {
            vmHarness harness = new vmHarness(Harness.CreateHarness(ProgramPrefix), HarnessList, this);
            harness.EditBool = true;

            HarnessList.Add(harness);
        }

        #endregion

        #region Methods

        public override void save() 
        {
            ProgramDescProp.Save();
            OwnerProp.Save();
            MilestoneProp.Save();

            saveProperties();

            foreach (vmHarness harness in HarnessList)
                harness.save();
        }
        public override void cancel() { }
        public override void remove() { }
        public override void revert() { }

        private void saveProperties() 
        {
            ProgramDesc = ProgramDescProp.Saved;
            Owner = OwnerProp.Saved;
            Milestone = MilestoneProp.Saved;
        }

        #endregion
    }
}
