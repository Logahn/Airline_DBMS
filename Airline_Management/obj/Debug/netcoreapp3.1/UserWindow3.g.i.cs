﻿#pragma checksum "..\..\..\UserWindow3.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0B0C09FBA6EA25478F123FA824108039B612B192"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Airline_Management;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Airline_Management {
    
    
    /// <summary>
    /// UserWindow3
    /// </summary>
    public partial class UserWindow3 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 66 "..\..\..\UserWindow3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button main_window;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\UserWindow3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid search_data_grid;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\UserWindow3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox1;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\UserWindow3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button query;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\UserWindow3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combobox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.15.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Airline_Management;component/userwindow3.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserWindow3.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.15.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 12 "..\..\..\UserWindow3.xaml"
            ((Airline_Management.UserWindow3)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.dragMe);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 38 "..\..\..\UserWindow3.xaml"
            ((System.Windows.Shapes.Ellipse)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.closeApp);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 50 "..\..\..\UserWindow3.xaml"
            ((System.Windows.Shapes.Ellipse)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.minimizeApp);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 62 "..\..\..\UserWindow3.xaml"
            ((System.Windows.Shapes.Ellipse)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.resizeApp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.main_window = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\..\UserWindow3.xaml"
            this.main_window.Click += new System.Windows.RoutedEventHandler(this.main_window_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.search_data_grid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.textbox1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.query = ((System.Windows.Controls.Button)(target));
            
            #line 117 "..\..\..\UserWindow3.xaml"
            this.query.Click += new System.Windows.RoutedEventHandler(this.query_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.combobox = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
