using System.Windows.Controls;

using EDRules.Utilities;
using EDRules.ViewModels;

namespace EDRules.Views
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
