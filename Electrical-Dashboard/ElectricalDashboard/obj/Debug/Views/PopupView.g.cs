﻿#pragma checksum "..\..\..\Views\PopupView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4349DD972B6A13E97A47F86DF73BCE75B49207DEFE49C9F21E2E2B819C5A1552"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using EDDLL.Views;
using ElectricalDashboard.Views.TicketViews;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace ElectricalDashboard.Views {
    
    
    /// <summary>
    /// PopupView
    /// </summary>
    public partial class PopupView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\..\Views\PopupView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton overlay;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Views\PopupView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ElectricalDashboard.Views.TicketViews.TicketCVMain ticketCV;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Views\PopupView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ElectricalDashboard.Views.TicketViews.TicketEV ticketEV;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Views\PopupView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ElectricalDashboard.Views.TicketViews.TicketOV ticketOV;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ElectricalDashboard;component/views/popupview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\PopupView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.overlay = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 2:
            this.ticketCV = ((ElectricalDashboard.Views.TicketViews.TicketCVMain)(target));
            return;
            case 3:
            this.ticketEV = ((ElectricalDashboard.Views.TicketViews.TicketEV)(target));
            return;
            case 4:
            this.ticketOV = ((ElectricalDashboard.Views.TicketViews.TicketOV)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

