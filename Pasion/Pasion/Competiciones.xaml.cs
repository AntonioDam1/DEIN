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
    /// Lógica de interacción para Competiciones.xaml
    /// </summary>
    public partial class Competiciones : Window
    {
        public Competiciones()
        {
            InitializeComponent();
        }

        private void Clic_Partidos(object sender, RoutedEventArgs e)
        {
            Partidos partidosWindow = new Partidos();
            partidosWindow.Show();

            Close();
        }

        private void Clic_Equipos(object sender, RoutedEventArgs e)
        {
            Equipos equiposWindow = new Equipos();
            equiposWindow.Show();

            Close();
        }

        private void Clic_Competicion(object sender, RoutedEventArgs e)
        {
            Competiciones competicionesWindow = new Competiciones();
            competicionesWindow.Show();

            Close();
        }

        private void IrAHome(object sender, RoutedEventArgs e)
        {
            Home homeWindow = new Home();
            homeWindow.Show();

            Close();
        }

        private void Formulario(object sender, RoutedEventArgs e)
        {
            FormularioUsuario formularioWindow = new FormularioUsuario();
            formularioWindow.Show();

            this.Close();
        }

    }
}
