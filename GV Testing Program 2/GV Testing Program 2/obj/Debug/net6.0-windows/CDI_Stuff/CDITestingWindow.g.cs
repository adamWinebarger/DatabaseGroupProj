﻿#pragma checksum "..\..\..\..\CDI_Stuff\CDITestingWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71992D62395F68B2DBCD6EDD486DC7DCBFBEACC6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GV_Testing_Program_2;
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


namespace GV_Testing_Program_2 {
    
    
    /// <summary>
    /// CDITestingWindow
    /// </summary>
    public partial class CDITestingWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\CDI_Stuff\CDITestingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock questionLabel;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\CDI_Stuff\CDITestingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton topRadioButton;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\CDI_Stuff\CDITestingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton middleRadioButton;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\CDI_Stuff\CDITestingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton bottomRadioButton;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\CDI_Stuff\CDITestingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button nextButton;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\CDI_Stuff\CDITestingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backButton;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\CDI_Stuff\CDITestingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button submitButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GV Testing Program 2;component/cdi_stuff/cditestingwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\CDI_Stuff\CDITestingWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.questionLabel = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.topRadioButton = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 3:
            this.middleRadioButton = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 4:
            this.bottomRadioButton = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.nextButton = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\..\CDI_Stuff\CDITestingWindow.xaml"
            this.nextButton.Click += new System.Windows.RoutedEventHandler(this.nextButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.backButton = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\..\CDI_Stuff\CDITestingWindow.xaml"
            this.backButton.Click += new System.Windows.RoutedEventHandler(this.backButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.submitButton = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\..\CDI_Stuff\CDITestingWindow.xaml"
            this.submitButton.Click += new System.Windows.RoutedEventHandler(this.submitButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
