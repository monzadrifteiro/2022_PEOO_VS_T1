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

namespace ClinicaApp
{
    /// <summary>
    /// Lógica interna para Cad_Paciente_ConsultaWindow.xaml
    /// </summary>
    public partial class Cad_Paciente_ConsultaWindow : Window
    {
        public Cad_Paciente_ConsultaWindow()
        {
            InitializeComponent();
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listPacientes.ItemsSource = null;
            listPacientes.ItemsSource = NPaciente.Listar();
            listConsultas.ItemsSource = null;
            listConsultas.ItemsSource = NConsulta.Listar();
        }

        private void CadastrarClick(object sender, RoutedEventArgs e)
        {
            if (listPacientes.SelectedItem != null && listConsultas.SelectedItem != null)
            {
                Paciente p = (Paciente)listPacientes.SelectedItem;
                Consulta c = (Consulta)listConsultas.SelectedItem;
                NConsulta.CadastrarPaciente(p, c);
                ListarClick(sender, e);
            }
            else
            {
                MessageBox.Show("É preciso selecionar um paciente e uma consulta");
            }
        }
    }
}
