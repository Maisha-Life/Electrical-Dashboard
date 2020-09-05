using System;
using System.Threading;
using System.Windows.Threading;
using System.Windows;
using EDRules.Views;
using EDRules.ViewModels;
using EDDLL;

namespace EDRules.Utilities
{
    internal class PopupHelper
    {
        public static PopupView PopupView { get; set; }

        public static void SetVisibility(bool status)
        {
            if (PopupView == null) return;

            if (!PopupView.Dispatcher.CheckAccess())
            {
                Thread thread = new Thread(
                    new System.Threading.ThreadStart(
                        delegate ()
                        {
                            PopupView.Dispatcher.Invoke(
                                DispatcherPriority.Normal,

                                new Action(delegate ()
                                {
                                    if (status)
                                    {
                                        ((PopupVM)PopupView.DataContext).OverlayBool = true;
                                        ((PopupVM)PopupView.DataContext).PopupVisibility = Visibility.Visible;
                                    }
                                    else
                                    {
                                        ((PopupVM)PopupView.DataContext).OverlayBool = false;
                                        ((PopupVM)PopupView.DataContext).PopupVisibility = Visibility.Hidden;
                                    }
                                }
                            ));
                            PopupView.Dispatcher.Invoke(DispatcherPriority.ApplicationIdle, new Action(() => { }));
                        }
                ));
                thread.SetApartmentState(ApartmentState.STA);
                thread.IsBackground = true;
                thread.Start();
            }
            else
            {
                if (status)
                {
                    ((PopupVM)PopupView.DataContext).OverlayBool = true;
                    ((PopupVM)PopupView.DataContext).PopupVisibility = Visibility.Visible;
                }
                else
                {
                    ((PopupVM)PopupView.DataContext).OverlayBool = false;
                    ((PopupVM)PopupView.DataContext).PopupVisibility = Visibility.Hidden;
                }
            }
        }

        public static void TabIndex(int tabIndex, object context)
        {
            if (PopupView == null) return;

            if (!PopupView.Dispatcher.CheckAccess())
            {
                Thread thread = new Thread(
                    new System.Threading.ThreadStart(
                        delegate ()
                        {
                            PopupView.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate () { changeTabs(tabIndex, context); }));
                            PopupView.Dispatcher.Invoke(DispatcherPriority.ApplicationIdle, new Action(() => { }));
                        }
                ));
                thread.SetApartmentState(ApartmentState.STA);
                thread.IsBackground = true;
                thread.Start();
            }
            else
                changeTabs(tabIndex, context);
        }

        private static void changeTabs(int tabIndex, object context)
        {
            ((PopupVM)PopupView.DataContext).SelectedPopupIndex = tabIndex;

            switch (tabIndex)
            {
                case 0:
                    PopupView.ticketCV.DataContext = context;
                    PopupView.overlay.Command = App.PopupVM.ClearPopup;
                break;
                case 1:
                    PopupView.ticketEV.DataContext = context;
                    PopupView.overlay.Command = App.PopupVM.ClearPopup;
                break;
                case 2:
                    PopupView.ruleCV.DataContext = context;
                    PopupView.overlay.Command = App.PopupVM.ClearPopup;
                break;
                case 3:
                    PopupView.ruleEV.DataContext = context;
                    PopupView.overlay.Command = App.PopupVM.ClearPopup;
                break;
            }
        }
    }
}
