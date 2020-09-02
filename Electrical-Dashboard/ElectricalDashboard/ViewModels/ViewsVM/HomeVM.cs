using EDDLL.ViewModels;
using EDTools.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalDashboard.ViewModels.ViewsVM
{
    public class HomeVM : BaseVM
    {
        public HomeVM()
        {
            for (int i = 0; i < 5; i++)
            {
                if (i < 3)
                    TopToolsList.Add(new vmTool(i + " - name", i.ToString(), i.ToString(), "exe", @"\EDTools;component\Resources\Images\fillerImage.png", "a test description", "complete", null));
            }
        }

        #region Data Binds

        private ObservableCollection<vmTool> _TopToolsList;
        public ObservableCollection<vmTool> TopToolsList
        {
            get { return _TopToolsList ?? (_TopToolsList = new ObservableCollection<vmTool>()); }
            set
            {
                if (this._TopToolsList != value)
                {
                    this._TopToolsList = value;
                    this.RaisePropertyChangedEvent("TopToolsList");
                }
            }
        }

        #endregion
    }
}
