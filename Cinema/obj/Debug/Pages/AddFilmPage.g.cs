﻿#pragma checksum "..\..\..\Pages\AddFilmPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "62A1F2D224D700B1FA56F5C64594D2C279D606343320030A590F3C6C4F3A505A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Cinema.Pages;
using MaterialDesignThemes.MahApps;
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


namespace Cinema.Pages {
    
    
    /// <summary>
    /// AddFilmPage
    /// </summary>
    public partial class AddFilmPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\Pages\AddFilmPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image posterFilm;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Pages\AddFilmPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameTb;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Pages\AddFilmPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox descriptionTb;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\Pages\AddFilmPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox durationTb;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\Pages\AddFilmPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ageStopTb;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\Pages\AddFilmPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addPostrBtn;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\Pages\AddFilmPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button saveFilmBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/Cinema;component/pages/addfilmpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\AddFilmPage.xaml"
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
            this.posterFilm = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.nameTb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.descriptionTb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.durationTb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ageStopTb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.addPostrBtn = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\..\Pages\AddFilmPage.xaml"
            this.addPostrBtn.Click += new System.Windows.RoutedEventHandler(this.addPostrBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.saveFilmBtn = ((System.Windows.Controls.Button)(target));
            
            #line 90 "..\..\..\Pages\AddFilmPage.xaml"
            this.saveFilmBtn.Click += new System.Windows.RoutedEventHandler(this.saveFilmBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

