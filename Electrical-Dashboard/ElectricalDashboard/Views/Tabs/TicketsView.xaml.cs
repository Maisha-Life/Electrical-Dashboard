using System.Windows.Controls;

namespace ElectricalDashboard.Views.Tabs
{
    /// <summary>
    /// Interaction logic for TicketsView.xaml
    /// </summary>
    public partial class TicketsView : UserControl
    {
        public TicketsView()
        {
            DataContext = App.TicketsVM;

            InitializeComponent();
        }
    }
}
