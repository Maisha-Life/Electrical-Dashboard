﻿#pragma checksum "..\..\..\..\..\Views\RoleViews\Home\Home_Admin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "99EAA506D72E463637DC4804C71560E87E5EC3711F34C4DD8D7ECAB914461C0F"
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
using EDRules.Views.Rule;
using EDTools.Views.SubViews;
using ElectricalDashboard.Views.RoleViews.Home;
using ElectricalDashboard.Views.Tickets;
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


namespace ElectricalDashboard.Views.RoleViews.Home {
    
    
    /// <summary>
    /// Home_Admin
    /// </summary>
    public partial class Home_Admin : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\..\..\Views\RoleViews\Home\Home_Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel ticketsOverview;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\..\Views\RoleViews\Home\Home_Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel toolsOverview;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\..\..\Views\RoleViews\Home\Home_Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ElectricalDashboard.Views.Tickets.TicketStatsView ticketStats;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\..\..\Views\RoleViews\Home\Home_Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal EDTools.Views.SubViews.ToolStatsControl toolStats;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\..\..\Views\RoleViews\Home\Home_Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal EDRules.Views.Rule.RuleStatsControl ruleStats;
        
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
            System.Uri resourceLocater = new System.Uri("/ElectricalDashboard;component/views/roleviews/home/home_admin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\RoleViews\Home\Home_Admin.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
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
            this.ticketsOverview = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.toolsOverview = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.ticketStats = ((ElectricalDashboard.Views.Tickets.TicketStatsView)(target));
            return;
            case 4:
            this.toolStats = ((EDTools.Views.SubViews.ToolStatsControl)(target));
            return;
            case 5:
            this.ruleStats = ((EDRules.Views.Rule.RuleStatsControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

