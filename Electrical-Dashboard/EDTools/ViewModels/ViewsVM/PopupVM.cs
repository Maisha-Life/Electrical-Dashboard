using EDDLL.Utilities;
using EDDLL.ViewModels;
using EDTools.Utilities;
using System.Windows;
using System.Windows.Input;

namespace EDTools.ViewModels
{
    public class PopupVM : BaseVM
    {
        #region Data Binds

        private int m_SelectedPopupIndex;
        public int SelectedPopupIndex
        {
            get { return m_SelectedPopupIndex; }
            set
            {
                this.m_SelectedPopupIndex = value;
                this.RaisePropertyChangedEvent("SelectedPopupIndex");

            }
        }

        private bool m_OverlayBool = false;
        public bool OverlayBool
        {
            get { return m_OverlayBool; }
            set
            {
                if (this.m_OverlayBool != value)
                {
                    this.m_OverlayBool = value;
                    this.RaisePropertyChangedEvent("OverlayBool");
                }
            }
        }

        private Visibility m_PopupVisibility = Visibility.Hidden;
        public Visibility PopupVisibility
        {
            get { return m_PopupVisibility; }
            set
            {
                if (this.m_PopupVisibility != value)
                {
                    this.m_PopupVisibility = value;
                    this.RaisePropertyChangedEvent("PopupVisibility");
                }
            }
        }

        #endregion

        #region Commands

        private RelayCommand _ClearPopup;
        public ICommand ClearPopup
        {
            get
            {
                if (_ClearPopup == null) _ClearPopup = new RelayCommand(param => clearPopup(), param => { return (true); });

                return _ClearPopup;
            }
        }
        public void clearPopup()
        {
            PopupHelper.SetVisibility(false);
        }

        #endregion
    }
}
