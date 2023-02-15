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

namespace EscolaApp
{
    /// <summary>
    /// Lógica interna para ProfessorWindow.xaml
    /// </summary>
    public partial class ProfessorWindow : Window
    {
        public ProfessorWindow()
        {
            InitializeComponent();
        }

        private void InserirClick(object sender, RoutedEventArgs e)
        {
            Professor p = new Professor();
            p.Id = int.Parse(txtId.Text);
            p.Nome = txtNome.Text;
            p.Matricula = txtMatricula.Text;
            p.Area = txtArea.Text;
            NProfessor.Inserir(p);
            ListarClick(sender, e);
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listProfs.ItemsSource = null;
            listProfs.ItemsSource = NProfessor.Listar();
        }

        private void AtualizarClick(object sender, RoutedEventArgs e)
        {
            Professor p = new Professor();
            p.Id = int.Parse(txtId.Text);
            p.Nome = txtNome.Text;
            p.Matricula = txtMatricula.Text;
            p.Area = txtArea.Text;
            NProfessor.Atualizar(p);
            ListarClick(sender, e);
        }

        private void ExcluirClick(object sender, RoutedEventArgs e)
        {
            Professor p = new Professor();
            p.Id = int.Parse(txtId.Text);
            p.Nome = txtNome.Text;
            p.Matricula = txtMatricula.Text;
            p.Area = txtArea.Text;
            NProfessor.Excluir(p);
            ListarClick(sender, e);
        }
        private void listProfs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listProfs.SelectedItem != null)
            {
                Professor obj = (Professor)listProfs.SelectedItem;
                txtId.Text = obj.Id.ToString();
                txtNome.Text = obj.Nome;
                txtMatricula.Text = obj.Matricula;
                txtArea.Text = obj.Area;
            }
        }
    }
}
