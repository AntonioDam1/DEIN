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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Orla_de_Antonio
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void Persona(object sender, MouseButtonEventArgs e)
        {

        }

        private void Persona41_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Window1 win2 = new Window1("Aritz ", "Perez de Ciriza Morrillo", "email_alumno@educacion.navarra.es", "Imagenes/alumno1.jpg");

            win2.Show();

        }


    }
}
