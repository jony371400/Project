﻿#pragma checksum "..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B492C14CFDDCE0115610670219BE296A"
//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

using MG100;
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


namespace MG100 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Sensor;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbkStatus;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combobox;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnConnect;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CobFrom;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CobTo;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnStart;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnStop;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUP;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDN;
        
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
            System.Uri resourceLocater = new System.Uri("/MG100;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            
            #line 7 "..\..\MainWindow.xaml"
            ((MG100.MainWindow)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            
            #line 7 "..\..\MainWindow.xaml"
            ((MG100.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Sensor = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            this.tbkStatus = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.combobox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.btnConnect = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\MainWindow.xaml"
            this.btnConnect.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CobFrom = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.CobTo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.btnStart = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\MainWindow.xaml"
            this.btnStart.Click += new System.Windows.RoutedEventHandler(this.CmdBtnClick);
            
            #line default
            #line hidden
            
            #line 81 "..\..\MainWindow.xaml"
            this.btnStart.MouseMove += new System.Windows.Input.MouseEventHandler(this.btnMouseMoveIn);
            
            #line default
            #line hidden
            
            #line 81 "..\..\MainWindow.xaml"
            this.btnStart.MouseLeave += new System.Windows.Input.MouseEventHandler(this.btnMouseMoveOut);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnStop = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\MainWindow.xaml"
            this.btnStop.Click += new System.Windows.RoutedEventHandler(this.CmdBtnClick);
            
            #line default
            #line hidden
            
            #line 82 "..\..\MainWindow.xaml"
            this.btnStop.MouseMove += new System.Windows.Input.MouseEventHandler(this.btnMouseMoveIn);
            
            #line default
            #line hidden
            
            #line 82 "..\..\MainWindow.xaml"
            this.btnStop.MouseLeave += new System.Windows.Input.MouseEventHandler(this.btnMouseMoveOut);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnUP = ((System.Windows.Controls.Button)(target));
            
            #line 98 "..\..\MainWindow.xaml"
            this.btnUP.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.btnClickDN);
            
            #line default
            #line hidden
            
            #line 98 "..\..\MainWindow.xaml"
            this.btnUP.PreviewMouseUp += new System.Windows.Input.MouseButtonEventHandler(this.btnClickUP);
            
            #line default
            #line hidden
            
            #line 98 "..\..\MainWindow.xaml"
            this.btnUP.MouseMove += new System.Windows.Input.MouseEventHandler(this.btnMouseMoveIn);
            
            #line default
            #line hidden
            
            #line 98 "..\..\MainWindow.xaml"
            this.btnUP.MouseLeave += new System.Windows.Input.MouseEventHandler(this.btnMouseMoveOut);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnDN = ((System.Windows.Controls.Button)(target));
            
            #line 99 "..\..\MainWindow.xaml"
            this.btnDN.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.btnClickDN);
            
            #line default
            #line hidden
            
            #line 99 "..\..\MainWindow.xaml"
            this.btnDN.PreviewMouseUp += new System.Windows.Input.MouseButtonEventHandler(this.btnClickUP);
            
            #line default
            #line hidden
            
            #line 99 "..\..\MainWindow.xaml"
            this.btnDN.MouseMove += new System.Windows.Input.MouseEventHandler(this.btnMouseMoveIn);
            
            #line default
            #line hidden
            
            #line 99 "..\..\MainWindow.xaml"
            this.btnDN.MouseLeave += new System.Windows.Input.MouseEventHandler(this.btnMouseMoveOut);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

