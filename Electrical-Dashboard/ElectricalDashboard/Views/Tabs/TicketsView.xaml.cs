using System.Windows.Controls;
using System.Windows.Input;

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

        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer scv = (ScrollViewer)sender;
            scv.ScrollToVerticalOffset(scv.VerticalOffset - (e.Delta / 3));
            e.Handled = true;
        }
    }
}
