using System.Windows.Controls;

using EDHarnessScan.Utilities;
using EDHarnessScan.ViewModels;

namespace EDHarnessScan.Views
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
