﻿#pragma checksum "..\..\Bestellungen.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1F2A8267AC2BD82B3580AAA179AA07A40F4676BB2BAABB62D9AEE8ED8CFAFC09"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

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
using UI_Warenbestand;


namespace UI_Warenbestand {
    
    
    /// <summary>
    /// Bestellungen
    /// </summary>
    public partial class Bestellungen : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 78 "..\..\Bestellungen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel stkpnl_Bestellungen;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\Bestellungen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtg_Bestellungen;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\Bestellungen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid top_panel;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\Bestellungen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button home;
        
        #line default
        #line hidden
        
        
        #line 171 "..\..\Bestellungen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button warenbestand;
        
        #line default
        #line hidden
        
        
        #line 208 "..\..\Bestellungen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bestellungen;
        
        #line default
        #line hidden
        
        
        #line 281 "..\..\Bestellungen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton Tg_btn;
        
        #line default
        #line hidden
        
        
        #line 295 "..\..\Bestellungen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Animation.Storyboard HideStackPanel;
        
        #line default
        #line hidden
        
        
        #line 309 "..\..\Bestellungen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Animation.Storyboard ShowStackPanel;
        
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
            System.Uri resourceLocater = new System.Uri("/UI_Warenbestand;component/bestellungen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Bestellungen.xaml"
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
            
            #line 13 "..\..\Bestellungen.xaml"
            ((UI_Warenbestand.Bestellungen)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.stkpnl_Bestellungen = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.dtg_Bestellungen = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.top_panel = ((System.Windows.Controls.Grid)(target));
            
            #line 111 "..\..\Bestellungen.xaml"
            this.top_panel.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.top_panel_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.home = ((System.Windows.Controls.Button)(target));
            
            #line 138 "..\..\Bestellungen.xaml"
            this.home.Click += new System.Windows.RoutedEventHandler(this.home_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.warenbestand = ((System.Windows.Controls.Button)(target));
            
            #line 172 "..\..\Bestellungen.xaml"
            this.warenbestand.Click += new System.Windows.RoutedEventHandler(this.warenbestand_Click_1);
            
            #line default
            #line hidden
            return;
            case 7:
            this.bestellungen = ((System.Windows.Controls.Button)(target));
            
            #line 209 "..\..\Bestellungen.xaml"
            this.bestellungen.Click += new System.Windows.RoutedEventHandler(this.bestellungen_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 246 "..\..\Bestellungen.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Tg_btn = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 10:
            this.HideStackPanel = ((System.Windows.Media.Animation.Storyboard)(target));
            return;
            case 11:
            this.ShowStackPanel = ((System.Windows.Media.Animation.Storyboard)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

