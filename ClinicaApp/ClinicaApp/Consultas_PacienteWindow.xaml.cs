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
    /// Lógica interna para Consultas_PacienteWindow.xaml
    /// </summary>
    public partial class Consultas_PacienteWindow : Window
    {
        public Consultas_PacienteWindow()
        {
            InitializeComponent();
            listPacientes.ItemsSource = NPaciente.Listar();
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            if (listPacientes.SelectedItem != null)
            {
                Paciente p = (Paciente)listPacientes.SelectedItem;
                listConsultas.ItemsSource = null;
                listConsultas.ItemsSource = NConsulta.Listar(p);
            }
            else
            {
                MessageBox.Show("É preciso selecionar um paciente e uma consulta");
            }
        }
        }
    }

