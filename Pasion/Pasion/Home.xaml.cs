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
    /// Lógica de interacción para Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        private bool isLeftMouseButtonDown;
        private Point lastMousePosition;

        public List<string> Botones { get; set; }
        public Home()
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

        private void ScrollViewer_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            isLeftMouseButtonDown = true;
            lastMousePosition = e.GetPosition(horizontalScrollViewer);
        }

        private void ScrollViewer_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (isLeftMouseButtonDown)
            {
                Point currentMousePosition = e.GetPosition(horizontalScrollViewer);
                double horizontalOffset = horizontalScrollViewer.HorizontalOffset + (lastMousePosition.X - currentMousePosition.X);
                horizontalScrollViewer.ScrollToHorizontalOffset(horizontalOffset);
                lastMousePosition = currentMousePosition;
            }
        }

        private void ScrollViewer_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            isLeftMouseButtonDown = false;
        }


    }
}
