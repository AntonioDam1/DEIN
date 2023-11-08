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

namespace Introduccion_de_Datos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void txt_GotFocus(Object sender, RoutedEventArgs e)
        {
            if(sender is TextBox textBox)
            {
                if(textBox.Text == "Direccion" || textBox.Text == "Ciudad" || textBox.Text == "Provincia" || textBox.Text == "Codigo Postal" || textBox.Text == "Pais")
                {
                    textBox.Text = "";
                }
            }
        }

        private void txt_LostFocus(Object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox) 
            { 
                if(String.IsNullOrWhiteSpace(textBox.Text))
                {
                    if (textBox.Name == "txtDireccion")
                    {
                        textBox.Text = "Direccion";
                    }
                    else if (textBox.Name == "txtCiudad")
                    {
                        textBox.Text = "Ciudad";
                    }
                    else if (textBox.Name == "txtProvincia")
                    {
                        textBox.Text = "Provincia";
                    }
                    else if (textBox.Text == "txtPostal")
                    {
                        textBox.Text = "Codigo Postal";
                    }
                    else if (textBox.Text == "txtPais")
                    {
                        textBox.Text = "Pais";
                    }
                }
            }
        }
    }
}
