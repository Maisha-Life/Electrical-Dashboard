using EDDLL.Utilities;
using EDDLL.ViewModels;
using EDRules.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDRules.ViewModels.ModelsVM
{
    public class vmParameter : vmBase
    {
        public readonly Parameter _parameter;
        public readonly vmRule _rule;

        public vmParameter(Parameter parameter) { _parameter = parameter ?? throw new ArgumentNullException("parameter"); }
        public vmParameter(Parameter parameter, vmRule rule)
        {
            _parameter = parameter ?? throw new ArgumentNullException("parameter");
            _rule = rule ?? throw new ArgumentNullException("rule");
        }

        #region Data Binds

        private string _Type;
        public string Type
        {
            get
            {
                if (_Type == null)
                    _Type = _parameter.Type;

                return _Type;
            }
            set
            {
                _Type = value;
                _parameter.Type = _Type;
                this.RaisePropertyChangedEvent("Type");
            }
        }

        private string _Group;
        public string Group
        {
            get
            {
                if (_Group == null)
                    _Group = _parameter.Group;

                return _Group;
            }
            set
            {
                _Group = value;
                _parameter.Group = _Group;
                this.RaisePropertyChangedEvent("Group");
            }
        }

        private string _Description;
        public string Description
        {
            get
            {
                if (_Description == null)
                    _Description = _parameter.Description;

                return _Description;
            }
            set
            {
                _Description = value;
                _parameter.Description = _Description;
                this.RaisePropertyChangedEvent("Description");
            }
        }

        public bool selectedBool { get; set; }
        private ThreeNOne _SelectedBoolProp;
        public ThreeNOne SelectedBoolProp
        {
            get
            {
                if (_SelectedBoolProp == null)
                    _SelectedBoolProp = new ThreeNOne(selectedBool.ToString());

                return _SelectedBoolProp;
            }
            set
            {
                if (_SelectedBoolProp != value)
                {
                    _SelectedBoolProp = value;
                    this.RaisePropertyChangedEvent("SelectedBoolProp");
                }
            }
        }
        public string SelectedBool
        {
            get { return SelectedBoolProp.Changed; }
            set
            {
                if (this._SelectedBoolProp.Changed != value)
                    this._SelectedBoolProp.Changed = value;

                selectedBool = (value.ToUpper() == "TRUE" ? true : false);
                this.RaisePropertyChangedEvent("SelectedBool");
            }
        }

        #endregion

        #region Methods

        public void save() { SelectedBoolProp.Save(); saveProperties(); }
        public void cancel() { SelectedBoolProp.Cancel(); saveProperties(); }
        public void remove() { SelectedBool = "true"; SelectedBoolProp.Save(); saveProperties(); }
        public void revert() { SelectedBoolProp.Default(); saveProperties(); }

        private void saveProperties()
        {
            SelectedBool = SelectedBoolProp.Saved;

            EditBool = false;
        }

        #endregion
    }
}
