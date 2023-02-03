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
    /// Lógica interna para ConsultaWindow.xaml
    /// </summary>
    public partial class ConsultaWindow : Window
    {
        public ConsultaWindow()
        {
            InitializeComponent();
        }

        private void InserirClick(object sender, RoutedEventArgs e)
        {
            Consulta c = new Consulta();
            c.Id = int.Parse(txtId.Text);
            c.IdMedico = int.Parse(txtIdMedico.Text);
            c.IdPaciente = int.Parse(txtIdPaciente.Text);
            c.Data = txtData.Text;
            c.Horario = txtHorario.Text;
            NConsulta.Inserir(c);
            ListarClick(sender, e);
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listConsultas.ItemsSource = null;
            listConsultas.ItemsSource = NConsulta.Listar();
        }

        private void AtualizarClick(object sender, RoutedEventArgs e)
        {
            Consulta c = new Consulta();
            c.Id = int.Parse(txtId.Text);
            c.IdMedico = int.Parse(txtIdMedico.Text);
            c.IdPaciente = int.Parse(txtIdPaciente.Text);
            c.Data = txtData.Text;
            c.Horario = txtHorario.Text;
            NConsulta.Atualizar(c);
            ListarClick(sender, e);
        }

        private void ExcluirClick(object sender, RoutedEventArgs e)
        {
            Consulta c = new Consulta();
            c.Id = int.Parse(txtId.Text);
            c.IdMedico = int.Parse(txtIdMedico.Text);
            c.IdPaciente = int.Parse(txtIdPaciente.Text);
            c.Data = txtData.Text;
            c.Horario = txtHorario.Text;
            NConsulta.Excluir(c);
            ListarClick(sender, e);
        }

        private void listConsultas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listConsultas.SelectedItem != null)
            {
                Consulta obj = (Consulta)listConsultas.SelectedItem;
                txtId.Text = obj.Id.ToString();
                txtIdMedico.Text = obj.IdMedico.ToString();
                txtIdPaciente.Text = obj.IdPaciente.ToString();
                txtData.Text = obj.Data;
                txtHorario.Text = obj.Horario;
            }
        }
    }
}
