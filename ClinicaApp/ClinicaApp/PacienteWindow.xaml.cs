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
    /// Lógica interna para Consulta.xaml
    /// </summary>
    public partial class PacienteWindow : Window
    {
        public PacienteWindow()
        {
            InitializeComponent();
        }

        private void InserirClick(object sender, RoutedEventArgs e)
        {
            Paciente p = new Paciente();
            p.Id = int.Parse(txtId.Text);
            p.Nome = txtNome.Text;
            p.Idade = int.Parse(txtIdade.Text);
            p.Enfermidade = txtEnfermidade.Text;
            NPaciente.Inserir(p);
            ListarClick(sender, e);
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listPacientes.ItemsSource = null;
            listPacientes.ItemsSource = NPaciente.Listar();
        }

        private void AtualizarClick(object sender, RoutedEventArgs e)
        {
            Paciente p = new Paciente();
            p.Id = int.Parse(txtId.Text);
            p.Nome = txtNome.Text;
            p.Idade = int.Parse(txtIdade.Text);
            p.Enfermidade = txtEnfermidade.Text;
            NPaciente.Atualizar(p);
            ListarClick(sender, e);
        }

        private void ExcluirClick(object sender, RoutedEventArgs e)
        {
            Paciente p = new Paciente();
            p.Id = int.Parse(txtId.Text);
            p.Nome = txtNome.Text;
            p.Idade = int.Parse(txtIdade.Text);
            p.Enfermidade = txtEnfermidade.Text;
            NPaciente.Excluir(p);
            ListarClick(sender, e);
        }

        private void listPacientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Paciente obj = (Paciente)listPacientes.SelectedItem;
            txtId.Text = obj.Id.ToString();
            txtNome.Text = obj.Nome;
            txtIdade.Text = obj.Idade.ToString();
            txtEnfermidade.Text = obj.Enfermidade;
        }
    }
}
