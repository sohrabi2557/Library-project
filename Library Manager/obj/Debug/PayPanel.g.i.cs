﻿#pragma checksum "..\..\PayPanel.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "44C2D17981E3A505A75AF9B95C758CAEF111B6F6FBE849ECFDEAC5CCDD4CC4BF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Library_Manager;
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


namespace Library_Manager {
    
    
    /// <summary>
    /// PayPanel
    /// </summary>
    public partial class PayPanel : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\PayPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox num1;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\PayPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox num2;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\PayPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox num3;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\PayPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox num4;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\PayPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox password;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\PayPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox cvv2;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\PayPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox year;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\PayPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox month;
        
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
            System.Uri resourceLocater = new System.Uri("/Library Manager;component/paypanel.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PayPanel.xaml"
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
            this.num1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.num2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.num3 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.num4 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.password = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.cvv2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.year = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.month = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 82 "..\..\PayPanel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.PayButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

