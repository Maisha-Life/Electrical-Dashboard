using ElectricalDashboard.ViewModels.ViewsVM;
using ElectricalDashboard.Utilities;
using System.Windows.Controls;

namespace ElectricalDashboard.Views
{
    /// <summary>
    /// Interaction logic for PopupView.xaml
    /// </summary>
    public partial class PopupView : UserControl
    {
        PopupVM mpvm = new PopupVM();

        public PopupView()
        {
            PopupHelper.PopupView = this;
            InitializeComponent();
            DataContext = mpvm;
        }
    }
}
