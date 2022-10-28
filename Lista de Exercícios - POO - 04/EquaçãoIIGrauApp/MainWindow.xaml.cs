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

namespace EquaçãoIIGrauApp
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
            Equacao linda = new Equacao();
            linda.SetABC(double.Parse(txtValora.Text), double.Parse(txtValorb.Text), double.Parse(txtValorc.Text));
            txtDelta.Text = linda.Delta().ToString();
            double g, h;
            if (linda.X1(out g)) txtX1.Text = g.ToString();
            if (linda.X2(out h)) txtX2.Text = h.ToString();
        }
    }
}