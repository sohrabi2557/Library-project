<<<<<<< Updated upstream
<<<<<<< Updated upstream
﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B00643175D514BC280341AD0B4DD5B09827F483C06EFCB0928B08392A46DC731"
=======
﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "02AB2A7525E735AA090A82EFF4554C501BEFC633BD2254DDB823627770067DD3"
>>>>>>> Stashed changes
=======
﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C6C40828077E9050EB9DB8F74EB2C09E89B561CACD800D0484F4CB3D5DF7D515"
>>>>>>> Stashed changes
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
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
<<<<<<< Updated upstream
<<<<<<< Updated upstream
        #line 24 "..\..\MainWindow.xaml"
=======
        #line 34 "..\..\MainWindow.xaml"
=======
        #line 26 "..\..\MainWindow.xaml"
>>>>>>> Stashed changes
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border top;
        
        #line default
        #line hidden
        
        
<<<<<<< Updated upstream
        #line 37 "..\..\MainWindow.xaml"
>>>>>>> Stashed changes
=======
        #line 29 "..\..\MainWindow.xaml"
>>>>>>> Stashed changes
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Close_btn;
        
        #line default
        #line hidden
        
        /// <summary>
        /// mainFrame Name Field
        /// </summary>
        
<<<<<<< Updated upstream
        #line 60 "..\..\MainWindow.xaml"
=======
        #line 52 "..\..\MainWindow.xaml"
>>>>>>> Stashed changes
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.Frame mainFrame;
        
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
            System.Uri resourceLocater = new System.Uri("/Library Manager;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.top = ((System.Windows.Controls.Border)(target));
            
<<<<<<< Updated upstream
            #line 35 "..\..\MainWindow.xaml"
=======
            #line 27 "..\..\MainWindow.xaml"
>>>>>>> Stashed changes
            this.top.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.drag);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Close_btn = ((System.Windows.Controls.Button)(target));
            
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            #line 26 "..\..\MainWindow.xaml"
=======
            #line 40 "..\..\MainWindow.xaml"
>>>>>>> Stashed changes
=======
            #line 32 "..\..\MainWindow.xaml"
>>>>>>> Stashed changes
            this.Close_btn.Click += new System.Windows.RoutedEventHandler(this.Close_btn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.mainFrame = ((System.Windows.Controls.Frame)(target));
            return;
<<<<<<< Updated upstream
=======
            case 4:
            
            #line 61 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.StackPanel)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.drag);
            
            #line default
            #line hidden
            return;
>>>>>>> Stashed changes
            }
            this._contentLoaded = true;
        }
    }
}

