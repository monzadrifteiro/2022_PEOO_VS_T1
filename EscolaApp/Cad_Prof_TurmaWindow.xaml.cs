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
    /// Lógica interna para Cad_Prof_TurmaWindow.xaml
    /// </summary>
    public partial class Cad_Prof_TurmaWindow : Window
    {
        public Cad_Prof_TurmaWindow()
        {
            InitializeComponent();
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listProfs.ItemsSource = null;
            listProfs.ItemsSource = NProfessor.Listar();
            listTurmas.ItemsSource = null;
            listTurmas.ItemsSource = NTurma.Listar();
        }

        private void CadastrarClick(object sender, RoutedEventArgs e)
        {
            if (listProfs.SelectedItem != null && listTurmas.SelectedItem != null)
            {
                Professor p = (Professor)listProfs.SelectedItem;
                Turma t = (Turma)listTurmas.SelectedItem;
                NTurma.CadastrarProfessor(p, t);
                ListarClick(sender, e);
            }
            else
            {
                MessageBox.Show("É preciso selecionar um professor e uma turma");
            }
        }
    }
}
