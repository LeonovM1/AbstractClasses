﻿#pragma checksum "..\..\..\Reg.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9B5515770912984EC9D1D652C8E8D74577629E30"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using AbstractClasses;
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


namespace AbstractClasses {
    
    
    /// <summary>
    /// Reg
    /// </summary>
    public partial class Reg : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Reg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label RegLoginLabel;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Reg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RegLoginText;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Reg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label RegPassLabel;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Reg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RegBtnReg;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Reg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RegBtnBack;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Reg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label RegPass_CopyLabel;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Reg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox RegPassBox;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Reg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox RegPassBoxCopy;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.13.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AbstractClasses;component/reg.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Reg.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.13.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.RegLoginLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.RegLoginText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.RegPassLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.RegBtnReg = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\Reg.xaml"
            this.RegBtnReg.Click += new System.Windows.RoutedEventHandler(this.RegBtnReg_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.RegBtnBack = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\Reg.xaml"
            this.RegBtnBack.Click += new System.Windows.RoutedEventHandler(this.Go_BackClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.RegPass_CopyLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.RegPassBox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 8:
            this.RegPassBoxCopy = ((System.Windows.Controls.PasswordBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
