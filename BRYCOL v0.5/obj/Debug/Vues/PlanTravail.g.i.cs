<<<<<<< HEAD
﻿#pragma checksum "..\..\..\Vues\PlanTravail.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A19CB831AB7CF4CFAD93197ABC904C7692FCC7E898F1EE4FC0E67C82E6B7D649"
=======
﻿#pragma checksum "..\..\..\Vues\PlanTravail.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8EFB698C1EE19F278E751AC98418BC72EA1D8F5FE9A23F0EB0DB37A35BABA8C5"
>>>>>>> 335967c830840fbeb0c0f503f3d8029150b0fffc
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using BRYCOL_v0._5.Vues;
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


namespace BRYCOL_v0._5.Vues {
    
    
    /// <summary>
    /// PlanTravail
    /// </summary>
    public partial class PlanTravail : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 48 "..\..\..\Vues\PlanTravail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel panelPieces;
        
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
            System.Uri resourceLocater = new System.Uri("/BRYCOL_v0.5;component/vues/plantravail.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Vues\PlanTravail.xaml"
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
            
            #line 32 "..\..\..\Vues\PlanTravail.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.clkAide);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 41 "..\..\..\Vues\PlanTravail.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.clkAjouterMeuble);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 44 "..\..\..\Vues\PlanTravail.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.clkAjouterPiece);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 45 "..\..\..\Vues\PlanTravail.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.clkModifierPiece);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 46 "..\..\..\Vues\PlanTravail.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.clkEnregistrer);
            
            #line default
            #line hidden
            return;
            case 6:
            this.panelPieces = ((System.Windows.Controls.StackPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

