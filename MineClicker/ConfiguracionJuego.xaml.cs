using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MineClicker
{
    /// <summary>
    /// Lógica de interacción para ConfiguracionJuego.xaml
    /// </summary>
    public partial class ConfiguracionJuego : Window
    {
        public ConfiguracionJuego()
        {
            InitializeComponent();
        }

        private void BotonRegresar(object sender, RoutedEventArgs e)
        {
            PantallaPrincipal newinicioJuego = new PantallaPrincipal();
            this.Close();
            newinicioJuego.ShowDialog();
        }
    }
}
