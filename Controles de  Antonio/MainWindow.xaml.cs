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
namespace Controles_de__Antonio
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Asignatura
        {
            public string AsignaturaNombre { get; set; }
            public SolidColorBrush Color { get; set; }
            public double Progreso { get; set; }
        }

        public List<Asignatura> Asignaturas { get; set; } = new List<Asignatura>
        {
            new Asignatura { AsignaturaNombre = "Desarrollo de interfaces",Color = Brushes.Green, Progreso = 80 },
            new Asignatura { AsignaturaNombre = "Programacion Multimedia Dispositivos moviles", Color = Brushes.Green, Progreso = 90 },
            new Asignatura { AsignaturaNombre = "Sistema de gestion empresarial", Color = Brushes.Red,Progreso = 30},
        };

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}
