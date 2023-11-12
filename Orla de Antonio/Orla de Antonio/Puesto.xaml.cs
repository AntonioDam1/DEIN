using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Orla_de_Antonio
{
    public partial class Puesto : UserControl
    {
        public Puesto()
        {
            InitializeComponent();
        }

        public static DependencyProperty NombreP = DependencyProperty.Register("Nombre", typeof(string), typeof(Puesto), new PropertyMetadata(string.Empty));
        public static DependencyProperty ApellidosP = DependencyProperty.Register("Apellidos", typeof(string), typeof(Puesto), new PropertyMetadata(string.Empty));
        public static DependencyProperty FotoP = DependencyProperty.Register("Foto", typeof(string), typeof(Puesto), new PropertyMetadata(string.Empty));
        public static DependencyProperty EmailP = DependencyProperty.Register("Email", typeof(string), typeof(Puesto), new PropertyMetadata(string.Empty));

        private void Persona_Click(object sender, RoutedEventArgs e)
        {
            LabelPuesto.Text = Email;
        }

        private void Persona_MouseDobleClick(object sender, MouseButtonEventArgs e)
        {
            Window1 win2 = new Window1(Nombre, Apellidos, Email, Foto);
            win2.Show();
        }

        private void Persona_MouseEnter(object sender, MouseEventArgs e)
        {
            LabelPuesto.Text = Nombre + " " + Apellidos;
        }

        private void Persona_MouseLeave(object sender, MouseEventArgs e)
        {
            LabelPuesto.Text = "";
        }

        public string Nombre
        {
            get { return (string)GetValue(NombreP); }
            set { SetValue(NombreP, value); }
        }

        public string Apellidos
        {
            get { return (string)GetValue(ApellidosP); }
            set { SetValue(ApellidosP, value); }
        }

        public string Email
        {
            get { return (string)GetValue(EmailP); }
            set { SetValue(EmailP, value); }
        }

        public string Foto
        {
            get { return (string)GetValue(FotoP); }
            set { SetValue(FotoP, value); }
        }
    }
}