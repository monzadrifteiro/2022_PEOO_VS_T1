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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AbastecimentoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Abastecimento a = new Abastecimento();
            a.SetKmRodados(double.Parse(txtKM.Text));
            a.SetValorPago(double.Parse(txtValor.Text));
            a.SetValorLitro(double.Parse(txtValorLitro.Text));
            txtKMLitro.Text = a.MediaKmLitro().ToString("0.00");
            txtRSKM.Text = a.MediaReaisKm().ToString("0.00");
        }
    }
}