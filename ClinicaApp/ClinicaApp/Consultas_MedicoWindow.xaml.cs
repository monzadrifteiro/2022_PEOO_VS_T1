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
    /// Lógica interna para Consultas_MedicoWindow.xaml
    /// </summary>
    public partial class Consultas_MedicoWindow : Window
    {
        public Consultas_MedicoWindow()
        {
            InitializeComponent();
            listMedicos.ItemsSource = NMedico.Listar();
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            if (listMedicos.SelectedItem != null)
            {
                Medico m = (Medico)listMedicos.SelectedItem;
                listConsultas.ItemsSource = null;
                listConsultas.ItemsSource = NConsulta.Listar(m);
            }
            else
            {
                MessageBox.Show("É preciso selecionar um médico e uma consulta");
            }
        }
    }
}
