﻿#pragma checksum "..\..\..\..\Views\Popups\ToolTicketCV.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0383644582E48B562E769AF3A384FCBB4D2ABC6CADAB8BB48177386122E20C52"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using EDTools.Views.Popups;
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


namespace EDTools.Views.Popups {
    
    
    /// <summary>
    /// ToolTicketCV
    /// </summary>
    public partial class ToolTicketCV : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\..\Views\Popups\ToolTicketCV.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox assigneeCB;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Views\Popups\ToolTicketCV.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox toolCB;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Views\Popups\ToolTicketCV.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox categoryCB;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Views\Popups\ToolTicketCV.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox priorityCB;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Views\Popups\ToolTicketCV.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dateCreated;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\Views\Popups\ToolTicketCV.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dateDueDP;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\Views\Popups\ToolTicketCV.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox descriptionTB;
        
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
            System.Uri resourceLocater = new System.Uri("/EDTools;component/views/popups/toolticketcv.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Popups\ToolTicketCV.xaml"
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
            this.assigneeCB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.toolCB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.categoryCB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.priorityCB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.dateCreated = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.dateDueDP = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.descriptionTB = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
