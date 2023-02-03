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
    /// Lógica interna para Cad_Medico_ConsultaWindow.xaml
    /// </summary>
    public partial class Cad_Medico_ConsultaWindow : Window
    {
        public Cad_Medico_ConsultaWindow()
        {
            InitializeComponent();
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listMedicos.ItemsSource = null;
            listMedicos.ItemsSource = NMedico.Listar();
            listConsultas.ItemsSource = null;
            listConsultas.ItemsSource = NConsulta.Listar();
        }

        private void CadastrarClick(object sender, RoutedEventArgs e)
        {
            if (listMedicos.SelectedItem != null && listConsultas.SelectedItem != null)
            {
                Medico m = (Medico)listMedicos.SelectedItem;
                Consulta c = (Consulta)listConsultas.SelectedItem;
                NConsulta.CadastrarMedico(m, c);
                ListarClick(sender, e);
            }
            else
            {
                MessageBox.Show("É preciso selecionar um medico e uma consulta");
            }
        }
    }
}
