﻿#pragma checksum "..\..\ItemDetails.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E9B374BA09DE785306E747F448C4EE43BD9787B98B11C69E0AD52BF8B73B3B9E"
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
using camera_store;


namespace camera_store {
    
    
    /// <summary>
    /// ItemDetails
    /// </summary>
    public partial class ItemDetails : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\ItemDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtboxId;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\ItemDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblId;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\ItemDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblName;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\ItemDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblUnitPrice;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\ItemDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblQty;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\ItemDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtboxName;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\ItemDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtboxUnitPrice;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\ItemDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtboxQty;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\ItemDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button saveItem;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\ItemDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button updateItem;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\ItemDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteItem;
        
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
            System.Uri resourceLocater = new System.Uri("/camera_store;component/itemdetails.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ItemDetails.xaml"
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
            this.txtboxId = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\ItemDetails.xaml"
            this.txtboxId.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtboxId_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblId = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lblName = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.lblUnitPrice = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.lblQty = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.txtboxName = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\ItemDetails.xaml"
            this.txtboxName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtboxUnitPrice = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\ItemDetails.xaml"
            this.txtboxUnitPrice.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtboxUnitPrice_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txtboxQty = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\ItemDetails.xaml"
            this.txtboxQty.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtboxQty_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.saveItem = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\ItemDetails.xaml"
            this.saveItem.Click += new System.Windows.RoutedEventHandler(this.btnSaveItem);
            
            #line default
            #line hidden
            return;
            case 10:
            this.updateItem = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\ItemDetails.xaml"
            this.updateItem.Click += new System.Windows.RoutedEventHandler(this.btnUpdateItem);
            
            #line default
            #line hidden
            return;
            case 11:
            this.deleteItem = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\ItemDetails.xaml"
            this.deleteItem.Click += new System.Windows.RoutedEventHandler(this.btnDeleteItem);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
