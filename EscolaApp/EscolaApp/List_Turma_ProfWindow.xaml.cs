﻿using System;
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
    /// Lógica interna para List_Turma_ProfWindow.xaml
    /// </summary>
    public partial class List_Turma_ProfWindow : Window
    {
        public List_Turma_ProfWindow()
        {
            InitializeComponent();
            listProfs.ItemsSource = NProfessor.Listar();
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            if (listProfs.SelectedItem != null)
            {
                Professor p = (Professor)listProfs.SelectedItem;
                listTurmas.ItemsSource = null;
                listTurmas.ItemsSource = NTurma.Listar(p);
            }
            else
            {
                MessageBox.Show("É preciso selecionar uma turma");
            }
        }
    }
}
