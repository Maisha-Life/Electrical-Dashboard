using System.Windows.Controls;

using EDTools.Utilities;
using EDTools.ViewModels;

namespace EDTools.Views
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
