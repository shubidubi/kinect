﻿#pragma checksum "..\..\KinectSettings.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "04C9A635525FD42F36C820A2EA407B86"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
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


namespace Microsoft.Samples.Kinect.WpfViewers {
    
    
    internal partial class KinectSettings : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\KinectSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Samples.Kinect.WpfViewers.KinectSettings Root;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\KinectSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ColorStreamEnable;
        
        #line default
        #line hidden
        
        /// <summary>
        /// colorFormats Name Field
        /// </summary>
        
        #line 29 "..\..\KinectSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.ComboBox colorFormats;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\KinectSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox DepthStreamEnable;
        
        #line default
        #line hidden
        
        /// <summary>
        /// depthFormats Name Field
        /// </summary>
        
        #line 39 "..\..\KinectSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.ComboBox depthFormats;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\KinectSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox depthRanges;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\KinectSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox SkeletonStreamEnable;
        
        #line default
        #line hidden
        
        /// <summary>
        /// trackingModes Name Field
        /// </summary>
        
        #line 53 "..\..\KinectSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.ComboBox trackingModes;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\KinectSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider ElevationAngle;
        
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
            System.Uri resourceLocater = new System.Uri("/Microsoft.Samples.Kinect.WpfViewers;component/kinectsettings.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\KinectSettings.xaml"
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
            this.Root = ((Microsoft.Samples.Kinect.WpfViewers.KinectSettings)(target));
            return;
            case 2:
            this.ColorStreamEnable = ((System.Windows.Controls.CheckBox)(target));
            
            #line 26 "..\..\KinectSettings.xaml"
            this.ColorStreamEnable.Checked += new System.Windows.RoutedEventHandler(this.ColorStreamEnabled);
            
            #line default
            #line hidden
            
            #line 27 "..\..\KinectSettings.xaml"
            this.ColorStreamEnable.Unchecked += new System.Windows.RoutedEventHandler(this.ColorStreamEnabled);
            
            #line default
            #line hidden
            return;
            case 3:
            this.colorFormats = ((System.Windows.Controls.ComboBox)(target));
            
            #line 29 "..\..\KinectSettings.xaml"
            this.colorFormats.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ColorFormatsSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DepthStreamEnable = ((System.Windows.Controls.CheckBox)(target));
            
            #line 36 "..\..\KinectSettings.xaml"
            this.DepthStreamEnable.Checked += new System.Windows.RoutedEventHandler(this.DepthStreamEnabled);
            
            #line default
            #line hidden
            
            #line 37 "..\..\KinectSettings.xaml"
            this.DepthStreamEnable.Unchecked += new System.Windows.RoutedEventHandler(this.DepthStreamEnabled);
            
            #line default
            #line hidden
            return;
            case 5:
            this.depthFormats = ((System.Windows.Controls.ComboBox)(target));
            
            #line 39 "..\..\KinectSettings.xaml"
            this.depthFormats.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DepthFormatsSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.depthRanges = ((System.Windows.Controls.ComboBox)(target));
            
            #line 42 "..\..\KinectSettings.xaml"
            this.depthRanges.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DepthRangesSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.SkeletonStreamEnable = ((System.Windows.Controls.CheckBox)(target));
            
            #line 49 "..\..\KinectSettings.xaml"
            this.SkeletonStreamEnable.Checked += new System.Windows.RoutedEventHandler(this.SkeletonsChecked);
            
            #line default
            #line hidden
            
            #line 50 "..\..\KinectSettings.xaml"
            this.SkeletonStreamEnable.Unchecked += new System.Windows.RoutedEventHandler(this.SkeletonsChecked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.trackingModes = ((System.Windows.Controls.ComboBox)(target));
            
            #line 53 "..\..\KinectSettings.xaml"
            this.trackingModes.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.TrackingModesSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ElevationAngle = ((System.Windows.Controls.Slider)(target));
            
            #line 63 "..\..\KinectSettings.xaml"
            this.ElevationAngle.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.ElevationAngleChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

