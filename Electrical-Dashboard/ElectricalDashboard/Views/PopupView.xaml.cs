using System.Windows.Controls;

using ElectricalDashboard.Utilities;
using ElectricalDashboard.ViewModels;

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
