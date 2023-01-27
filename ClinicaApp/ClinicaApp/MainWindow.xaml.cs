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

namespace ClinicaApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Medico_Click(object sender, RoutedEventArgs e)
        {
            MedicoWindow m = new MedicoWindow();
            m.ShowDialog();
        }

        private void Consulta_Click(object sender, RoutedEventArgs e)
        {
            ConsultaWindow c = new ConsultaWindow();
            c.ShowDialog();
        }

        private void Paciente_Click(object sender, RoutedEventArgs e)
        {
            PacienteWindow p = new PacienteWindow();
            p.ShowDialog();
        }

        private void Cad_Medico_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Cad_Paciente_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Consultas_Medico_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Consultas_Paciente_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
