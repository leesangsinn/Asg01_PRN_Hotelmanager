﻿#pragma checksum "..\..\..\..\..\View\Dialog\AddRoom.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DF7F7F296B502F83AF57C5C36FC08D13DE40366C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DinhQuocSangWPF.View.Dialog;
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


namespace DinhQuocSangWPF.View.Dialog {
    
    
    /// <summary>
    /// AddRoom
    /// </summary>
    public partial class AddRoom : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\..\View\Dialog\AddRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RoomNumberTextBox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\..\View\Dialog\AddRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RoomDetailDescriptionTextBox;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\..\View\Dialog\AddRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RoomMaxCapacityTextBox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\..\View\Dialog\AddRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RoomPricePerDayTextBox;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\View\Dialog\AddRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox RoomStatusComboBox;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\..\View\Dialog\AddRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RoomTypeIDTextBox;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\..\View\Dialog\AddRoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddRoomButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DinhQuocSangWPF;V1.0.0.0;component/view/dialog/addroom.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\Dialog\AddRoom.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.RoomNumberTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.RoomDetailDescriptionTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.RoomMaxCapacityTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.RoomPricePerDayTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.RoomStatusComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.RoomTypeIDTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.AddRoomButton = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\..\..\View\Dialog\AddRoom.xaml"
            this.AddRoomButton.Click += new System.Windows.RoutedEventHandler(this.AddRoomButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

