﻿#pragma checksum "..\..\..\..\ColorPicker\(Components)\AlphaSlider.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "073777713592FB027B87707D95136FD0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Imagin.Controls.Common;
using Imagin.Controls.Extended;
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


namespace Imagin.Controls.Extended {
    
    
    /// <summary>
    /// AlphaSlider
    /// </summary>
    public partial class AlphaSlider : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\..\ColorPicker\(Components)\AlphaSlider.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image PART_Image;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\ColorPicker\(Components)\AlphaSlider.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider PART_Slider;
        
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
            System.Uri resourceLocater = new System.Uri("/Imagin.Controls.Extended;component/colorpicker/(components)/alphaslider.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\ColorPicker\(Components)\AlphaSlider.xaml"
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
            this.PART_Image = ((System.Windows.Controls.Image)(target));
            
            #line 36 "..\..\..\..\ColorPicker\(Components)\AlphaSlider.xaml"
            this.PART_Image.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnImageMouseDown);
            
            #line default
            #line hidden
            
            #line 37 "..\..\..\..\ColorPicker\(Components)\AlphaSlider.xaml"
            this.PART_Image.MouseMove += new System.Windows.Input.MouseEventHandler(this.OnImageMouseMove);
            
            #line default
            #line hidden
            
            #line 38 "..\..\..\..\ColorPicker\(Components)\AlphaSlider.xaml"
            this.PART_Image.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.OnImageMouseUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PART_Slider = ((System.Windows.Controls.Slider)(target));
            
            #line 52 "..\..\..\..\ColorPicker\(Components)\AlphaSlider.xaml"
            this.PART_Slider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.OnSliderValueChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

