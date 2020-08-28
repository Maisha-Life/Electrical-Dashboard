using System;
using System.Threading;
using System.Windows.Threading;
using System.Windows;

using EDS.Views;
using EDS.ViewModels.ViewsVM;
using EDS.ViewModels.ModelsVM;

namespace EDS.Utilities
{
    internal class PopupHelper
    {
        public static PopupMainView PopupView { get; set; }

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
                    PopupView.contactEmail.DataContext = context;
                    PopupView.overlay.Command = App.PopupVM.ClearPopup;
                    break;
                case 1:
                    PopupView.fixAllRuleOV.DataContext = context;
                    PopupView.overlay.Command = (context as vmHarnessRule).CancelHarnessFixCommand; //  <<---- not sure what these will be 
                    break;                                                                //      
                case 2:                                                                   //  
                    PopupView.fixAllRulesOV.DataContext = context;                        //  
                    PopupView.overlay.Command = (context as vmHarness).CancelHarnessFixCommand; // <<---- not sure what these will be 
                    break;
                case 3:
                    PopupView.harnessCV.DataContext = context;
                    PopupView.overlay.Command = (context as vmHarness).CancelHarnessCommand;
                    break;
                case 4:
                    PopupView.harnessEV.DataContext = context;
                    PopupView.overlay.Command = (context as vmHarness).CancelHarnessCommand;
                    break;
                case 5:
                    PopupView.programCV.DataContext = context;
                    PopupView.overlay.Command = (context as vmProgram).CancelProgramCommand;
                    break;
                case 6:
                    PopupView.programEV.DataContext = context;
                    PopupView.overlay.Command = (context as vmProgram).CancelProgramCommand;
                    break;
                case 7:
                    PopupView.ruleCV.DataContext = context;
                    PopupView.overlay.Command = (context as vmRuleAll).CancelRuleCommand;
                    break;
                case 8:
                    PopupView.ruleEV.DataContext = context;
                    PopupView.overlay.Command = (context as vmRuleAll).CancelRuleCommand;
                    break;
                case 9:
                    PopupView.ruleOV.DataContext = context;
                    PopupView.overlay.Command = (context as vmRuleAll).CancelRuleCommand;
                    break;
                case 10:
                    PopupView.rulesOV.DataContext = context;
                    PopupView.overlay.Command = (context as vmRuleAll).CancelRuleCommand; // need to change this
                    break;
            }
        }
    }
}
