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

namespace ElectricalDashboard.Views.TicketViews
{
    /// <summary>
    /// Interaction logic for TicketCV.xaml
    /// </summary>
    public partial class TicketCV : UserControl
    {
        public TicketCV()
        {
            InitializeComponent();

            toolCB.ItemsSource = App.TicketsVM.ToolList;
            categoryCB.ItemsSource = App.TicketsVM.CategoryList;

            assigneeCB.ItemsSource = App.TicketsVM.UserList;
            priorityCB.ItemsSource = App.TicketsVM.PriorityList;
        }
    }
}
