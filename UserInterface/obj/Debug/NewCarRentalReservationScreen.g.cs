﻿#pragma checksum "..\..\NewCarRentalReservationScreen.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4EAA1ED1F9C260E9A640FFB3B7F15D44E91F7B61C330DB2BB22AB602098C5ACC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using UserInterface;


namespace UserInterface {
    
    
    /// <summary>
    /// NewCarRentalReservationScreen
    /// </summary>
    public partial class NewCarRentalReservationScreen : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 44 "..\..\NewCarRentalReservationScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox uxCarRentalID;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\NewCarRentalReservationScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox uxCarRentalAgencyName;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\NewCarRentalReservationScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox uxCarModel;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\NewCarRentalReservationScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox uxRentalPrice;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\NewCarRentalReservationScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Calendar uxRentalDate;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\NewCarRentalReservationScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox uxCountry;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\NewCarRentalReservationScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox uxRegion;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\NewCarRentalReservationScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox uxCity;
        
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
            System.Uri resourceLocater = new System.Uri("/UserInterface;component/newcarrentalreservationscreen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\NewCarRentalReservationScreen.xaml"
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
            this.uxCarRentalID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            
            #line 45 "..\..\NewCarRentalReservationScreen.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Autofill_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.uxCarRentalAgencyName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.uxCarModel = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.uxRentalPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.uxRentalDate = ((System.Windows.Controls.Calendar)(target));
            return;
            case 7:
            this.uxCountry = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.uxRegion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.uxCity = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            
            #line 86 "..\..\NewCarRentalReservationScreen.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddReservation_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 87 "..\..\NewCarRentalReservationScreen.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Done_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

