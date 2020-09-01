using EDDLL.Utilities;
using EDDLL.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;

namespace EDTools.ViewModels
{
    public class ToolsVM : BaseVM
    {
        public ToolsVM()
        {
            //foreach (vmTool tool in App.ProgramsVM.EDSData.tools)
            //    _ToolsList.Add(tool);

            ToolsCount = 0;
            ToolsCompletedCount = 0;
            ToolsDevelopingCount = 0;

            initializeToolsCollection();
        }

        #region Data Binds      

        private readonly ObservableCollection<vmTool> _ToolsList = new ObservableCollection<vmTool>();
        public ICollectionView ToolsList { get; set; }

        private string _SearchString = "";
        public string SearchString
        {
            get { return _SearchString; }
            set
            {
                if (this._SearchString != value)
                {
                    this._SearchString = value;
                    ToolsList.Refresh();
                    this.RaisePropertyChangedEvent("SearchString");
                }
            }
        }

        private int _TabIndex;
        public int TabIndex
        {
            get { return _TabIndex; }
            set
            {
                if (this._TabIndex != value)
                {
                    this._TabIndex = value;
                    this.RaisePropertyChangedEvent("TabIndex");
                }
            }
        }

        private int _ToolsCount;
        public int ToolsCount
        {
            get { return _ToolsCount; }
            set
            {
                if (this._ToolsCount != value)
                {
                    this._ToolsCount = value;
                    this.RaisePropertyChangedEvent("ToolsCount");
                }
            }
        }

        private int _ToolsCompletedCount;
        public int ToolsCompletedCount
        {
            get { return _ToolsCompletedCount; }
            set
            {
                if (this._ToolsCompletedCount != value)
                {
                    this._ToolsCompletedCount = value;
                    this.RaisePropertyChangedEvent("ToolsCompletedCount");
                }
            }
        }


        private int _ToolsDevelopingCount;
        public int ToolsDevelopingCount
        {
            get { return _ToolsDevelopingCount; }
            set
            {
                if (this._ToolsDevelopingCount != value)
                {
                    this._ToolsDevelopingCount = value;
                    this.RaisePropertyChangedEvent("ToolsDevelopingCount");
                }
            }
        }


        #endregion

        #region Search

        public void initializeToolsCollection()
        {
            ToolsList = CollectionViewSource.GetDefaultView(_ToolsList);
            ToolsList.Filter = new Predicate<object>(SearchFilter);
            ToolsList.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));
        }
        public bool SearchFilter(object o)
        {
            vmTool item = o as vmTool;

            string itemString = item.Name;

            if (itemString != null && itemString.IndexOf(_SearchString, StringComparison.OrdinalIgnoreCase) >= 0)
                return true;

            return false;
        }

        #endregion

        #region Commands

        private RelayCommand _ListViewCommand;
        public ICommand ListViewCommand
        {
            get
            {
                if (_ListViewCommand == null) _ListViewCommand = new RelayCommand(param => listViewCommand(), param => { return (TabIndex != 1); });

                return _ListViewCommand;
            }
        }
        private void listViewCommand()
        {
            TabIndex = 1;
        }

        private RelayCommand _GridViewCommand;
        public ICommand GridViewCommand
        {
            get
            {
                if (_GridViewCommand == null) _GridViewCommand = new RelayCommand(param => gridViewCommand(), param => { return (TabIndex != 0); });

                return _GridViewCommand;
            }
        }
        private void gridViewCommand()
        {
            TabIndex = 0;
        }

        #endregion
    }
}
