﻿#pragma checksum "..\..\Reg.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1DCDF125DD95989BDBB135736788D7D31D99FE33937997DE6FEB713F642AAE23"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using TicketBuy;


namespace TicketBuy {
    
    
    /// <summary>
    /// Reg
    /// </summary>
    public partial class Reg : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\Reg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox loginText;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Reg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passwordText;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Reg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passwordText2;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Reg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button nextB;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Reg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label prov;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\Reg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RegB;
        
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
            System.Uri resourceLocater = new System.Uri("/TicketBuy;component/reg.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Reg.xaml"
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
            this.loginText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.passwordText = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 25 "..\..\Reg.xaml"
            this.passwordText.KeyUp += new System.Windows.Input.KeyEventHandler(this.passwordText_KeyUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.passwordText2 = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.nextB = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\Reg.xaml"
            this.nextB.Click += new System.Windows.RoutedEventHandler(this.nextB_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.prov = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.RegB = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\Reg.xaml"
            this.RegB.Click += new System.Windows.RoutedEventHandler(this.RegB_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

