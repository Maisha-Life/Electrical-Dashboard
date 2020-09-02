using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ElectricalDashboard.Views.RoleViews.Home
{
    /// <summary>
    /// Interaction logic for Home_Admin.xaml
    /// </summary>
    public partial class Home_Admin : UserControl
    {
        public Home_Admin()
        {            
            InitializeComponent();

            ticketsOverview.DataContext = App.TicketsVM;
        }
    }
}
