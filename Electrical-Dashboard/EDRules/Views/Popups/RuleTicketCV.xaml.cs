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

namespace EDRules.Views.Popups
{
    /// <summary>
    /// Interaction logic for ToolTicket.xaml
    /// </summary>
    public partial class RuleTicketCV : UserControl
    {
        public RuleTicketCV()
        {
            InitializeComponent();

            toolCB.ItemsSource = EDDLL.Tickets.TicketsVM.ToolList;
            categoryCB.ItemsSource = EDDLL.Tickets.TicketsVM.CategoryList;

            assigneeCB.ItemsSource = EDDLL.Tickets.TicketsVM.UserList;
            priorityCB.ItemsSource = EDDLL.Tickets.TicketsVM.PriorityList;
        }
    }
}
