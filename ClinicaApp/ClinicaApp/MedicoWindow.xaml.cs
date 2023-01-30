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
    /// Lógica interna para MedicoWindow.xaml
    /// </summary>
    public partial class MedicoWindow : Window
    {
        public MedicoWindow()
        {
            InitializeComponent();
        }

        private void InserirClick(object sender, RoutedEventArgs e)
        {
            Medico m = new Medico();
            m.Id = int.Parse(txtId.Text);
            m.Nome = txtNome.Text;
            m.Area = txtArea.Text;
            m.Telefone = txtTelefone.Text;
            NMedico.Inserir(m);
            ListarClick(sender, e);
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listMedicos.ItemsSource = null;
            listMedicos.ItemsSource = NMedico.Listar();
        }

        private void AtualizarClick(object sender, RoutedEventArgs e)
        {
            Medico m = new Medico();
            m.Id = int.Parse(txtId.Text);
            m.Nome = txtNome.Text;
            m.Area = txtArea.Text;
            m.Telefone = txtTelefone.Text;
            NMedico.Atualizar(m);
            ListarClick(sender, e);
        }

        private void ExcluirClick(object sender, RoutedEventArgs e)
        {
            Medico m = new Medico();
            m.Id = int.Parse(txtId.Text);
            m.Nome = txtNome.Text;
            m.Area = txtArea.Text;
            m.Telefone = txtTelefone.Text;
            NMedico.Excluir(m);
            ListarClick(sender, e);
        }

        private void listMedicos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(listMedicos.SelectedItem != null)
            {
                Medico obj = (Medico)listMedicos.SelectedItem;
                txtId.Text = obj.Id.ToString();
                txtNome.Text = obj.Nome;
                txtArea.Text = obj.Area;
                txtTelefone.Text = obj.Telefone;
            }
        }
    }
}
