﻿#pragma checksum "..\..\MMBox.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A37FFE1286E5EA9C3895994DEEA061BC52AF89C72747928AA096AEDA47333379"
//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

using CusomMessageBox;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace CusomMessageBox {
    
    
    /// <summary>
    /// MMBox
    /// </summary>
    public partial class MMBox : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\MMBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.PackIcon BoxIcon;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\MMBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Content;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\MMBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button2;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\MMBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button1;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\MMBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button0;
        
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
            System.Uri resourceLocater = new System.Uri("/CusomMessageBox;component/mmbox.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MMBox.xaml"
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
            
            #line 16 "..\..\MMBox.xaml"
            ((CusomMessageBox.MMBox)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.setDefault);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BoxIcon = ((MaterialDesignThemes.Wpf.PackIcon)(target));
            return;
            case 3:
            this.Content = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.button2 = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\MMBox.xaml"
            this.button2.Click += new System.Windows.RoutedEventHandler(this.setresult);
            
            #line default
            #line hidden
            return;
            case 5:
            this.button1 = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\MMBox.xaml"
            this.button1.Click += new System.Windows.RoutedEventHandler(this.setresult);
            
            #line default
            #line hidden
            return;
            case 6:
            this.button0 = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\MMBox.xaml"
            this.button0.Click += new System.Windows.RoutedEventHandler(this.setresult);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

