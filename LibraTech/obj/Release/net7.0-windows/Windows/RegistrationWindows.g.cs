﻿#pragma checksum "..\..\..\..\Windows\RegistrationWindows.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FF4B999749CE00FB0D66165767C10D5CC0037D1A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using LibraTech.Windows;
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


namespace LibraTech.Windows {
    
    
    /// <summary>
    /// RegistrationWindows
    /// </summary>
    public partial class RegistrationWindows : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\..\..\Windows\RegistrationWindows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FIOTextBox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Windows\RegistrationWindows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LoginTextBox;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Windows\RegistrationWindows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswordBox;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Windows\RegistrationWindows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RegButton;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Windows\RegistrationWindows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image OffButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/LibraTech;component/windows/registrationwindows.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\RegistrationWindows.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 23 "..\..\..\..\Windows\RegistrationWindows.xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.BackButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.FIOTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.LoginTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.PasswordBox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 5:
            this.RegButton = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\..\Windows\RegistrationWindows.xaml"
            this.RegButton.Click += new System.Windows.RoutedEventHandler(this.RegButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.OffButton = ((System.Windows.Controls.Image)(target));
            
            #line 46 "..\..\..\..\Windows\RegistrationWindows.xaml"
            this.OffButton.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.OffButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

