using System.Windows.Controls;

namespace ElectricalDashboard.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : UserControl
    {
        public MainView()
        {
            DataContext = App.MainVM;

            InitializeComponent();
        }
    }
}
