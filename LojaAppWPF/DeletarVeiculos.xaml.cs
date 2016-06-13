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

namespace LojaAppWPF
{
    /// <summary>
    /// Interaction logic for DeletarVeiculos.xaml
    /// </summary>
    public partial class DeletarVeiculos : Window
    {
        public DeletarVeiculos()
        {
            InitializeComponent();
            Disponiveis();
        }

        public void Disponiveis()
        {
            WS.Service1Client ws = new WS.Service1Client();
            dataGrid.ItemsSource = ws.VeiculoSelect();
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            WS.Service1Client ws = new WS.Service1Client();
            ws.VeiculoDelete(int.Parse(txtID.Text));
            MessageBox.Show("Deletado com sucesso!");
            Disponiveis();
        }
    }
}
