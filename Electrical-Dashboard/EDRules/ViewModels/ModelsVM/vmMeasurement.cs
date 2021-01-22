using EDDLL.Utilities;
using EDDLL.ViewModels;
using EDRules.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EDRules.ViewModels.ModelsVM
{
    public class vmMeasurement : vmBase
    {
        public readonly Measurement _measurement;
        private readonly ObservableCollection<vmMeasurement> _measurements;

        public vmMeasurement(Measurement measurement, ObservableCollection<vmMeasurement> measurements)
        {
            _measurement = measurement ?? throw new ArgumentNullException("measurement");
            _measurements = measurements ?? throw new ArgumentNullException("measurements");
        }

        #region Data Binds

        private ThreeNOne _MeasurementDescProp;
        public ThreeNOne MeasurementDescProp
        {
            get
            {
                if (_MeasurementDescProp == null)
                    _MeasurementDescProp = new ThreeNOne(_measurement.MeasurementDesc);

                return _MeasurementDescProp;
            }
            set
            {
                if (_MeasurementDescProp != value)
                {
                    _MeasurementDescProp = value;
                    _measurement.MeasurementDesc = _MeasurementDescProp.Changed;
                    this.RaisePropertyChangedEvent("MeasurementDescProp");
                }
            }
        }
        public string MeasurementDesc
        {
            get { return MeasurementDescProp.Changed; }
            set
            {
                if (this._MeasurementDescProp.Changed != value)
                    this._MeasurementDescProp.Changed = value;

                _measurement.MeasurementDesc = value;
                this.RaisePropertyChangedEvent("MeasurementDesc");
            }
        }

        #endregion

        #region Commands

        private RelayCommand _SaveMeasurementCommand;
        public ICommand SaveMeasurementCommand
        {
            get
            {
                if (_SaveMeasurementCommand == null) _SaveMeasurementCommand = new RelayCommand(param => saveMeasurement(), param => { return (true); });

                return _SaveMeasurementCommand;
            }
        }
        private void saveMeasurement()
        {
            MeasurementDescProp.Save();

            saveProperties();
        }

        private RelayCommand _CancelMeasurementCommand;
        public ICommand CancelMeasurementCommand
        {
            get
            {
                if (_CancelMeasurementCommand == null) _CancelMeasurementCommand = new RelayCommand(param => cancelMeasurement(), param => { return (true); });

                return _CancelMeasurementCommand;
            }
        }
        private void cancelMeasurement()
        {
            cancel();
        }

        private RelayCommand _RemoveMeasurementCommand;
        public ICommand RemoveMeasurementCommand
        {
            get
            {
                if (_RemoveMeasurementCommand == null) _RemoveMeasurementCommand = new RelayCommand(param => removeMeasurement(), param => { return (true); });

                return _RemoveMeasurementCommand;
            }
        }
        private void removeMeasurement()
        {
            remove();
        }

        #endregion

        #region Methods

        public override void save() 
        { 
            MeasurementDescProp.Save();            

            saveProperties();
        }
        public void checkMeasurement()
        {
            if (MeasurementDescProp.ChangedBool)
            {
                if (this._measurement.Id_Measurement == -1)
                    App.RulesVM.sqlAccess.addRuleMeasurement(this);
                else
                    App.RulesVM.sqlAccess.editRuleMeasurement(this);
            }
        }
        public override void cancel() 
        { 
            MeasurementDescProp.Cancel();
            
            saveProperties();

            if (this._measurement.Id_Measurement == -1)
                _measurements.Remove(this);
        }
        public override void remove() 
        {
            App.RulesVM.sqlAccess.removeRuleMeasurement(this);

            _measurements.Remove(this);  
        }
        public override void revert() { MeasurementDescProp.Default(); saveProperties(); }

        private void saveProperties() 
        {
            MeasurementDesc = MeasurementDescProp.Saved;

            EditBool = false;
        }

        #endregion
    }
}
