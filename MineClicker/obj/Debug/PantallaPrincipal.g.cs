#pragma checksum "..\..\PantallaPrincipal.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0162FE2E506251DB3ABE9BC235AA5E70ED1C764F2E23C179A769CB7C3840E43A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using MineClicker;
using MineClicker.Properties;
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


namespace MineClicker {
    
    
    /// <summary>
    /// PantallaPrincipal
    /// </summary>
    public partial class PantallaPrincipal : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 98 "..\..\PantallaPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImagenChange;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\PantallaPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ClicsPorSegundo;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\PantallaPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DineroObtenido;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\PantallaPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox bloquesdestruidos;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\PantallaPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle CuadroDeCambioPico;
        
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
            System.Uri resourceLocater = new System.Uri("/MineClicker;component/pantallaprincipal.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PantallaPrincipal.xaml"
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
            
            #line 15 "..\..\PantallaPrincipal.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BotonEstadisticas);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 28 "..\..\PantallaPrincipal.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BotonTiendaPico);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 41 "..\..\PantallaPrincipal.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BotonIniciarMultijugador);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 54 "..\..\PantallaPrincipal.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BotonMandarInvitacion);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 67 "..\..\PantallaPrincipal.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BotonIniciarChat);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 80 "..\..\PantallaPrincipal.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BotonConfiguracion);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 97 "..\..\PantallaPrincipal.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BotonRomperBloque);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ImagenChange = ((System.Windows.Controls.Image)(target));
            return;
            case 9:
            this.ClicsPorSegundo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.DineroObtenido = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.bloquesdestruidos = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.CuadroDeCambioPico = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 13:
            
            #line 104 "..\..\PantallaPrincipal.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BotonCambioIzquierda);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 105 "..\..\PantallaPrincipal.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BotonCambioDerecha);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

