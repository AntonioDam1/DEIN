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

namespace Pasion
{
    /// <summary>
    /// Lógica de interacción para Partidos.xaml
    /// </summary>
    public partial class Partidos : Window
    {
        public Partidos()
        {
            InitializeComponent();
        }

        private void Clic_Partidos(object sender, RoutedEventArgs e)
        {
            Partidos partidosWindow = new Partidos();
            partidosWindow.Show();

            this.Close();
        }

        private void Clic_Equipos(object sender, RoutedEventArgs e)
        {
            Equipos equiposWindow = new Equipos();
            equiposWindow.Show();

            this.Close();
        }

        private void Clic_Competicion(object sender, RoutedEventArgs e)
        {
            Competiciones competicionesWindow = new Competiciones();
            competicionesWindow.Show();

            this.Close();
        }

        private void IrAHome(object sender, RoutedEventArgs e)
        {
            Home homeWindow = new Home();
            homeWindow.Show();

            this.Close();
        }
    }
}
