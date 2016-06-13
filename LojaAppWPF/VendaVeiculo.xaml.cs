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
    /// Interaction logic for VendaVeiculo.xaml
    /// </summary>
    public partial class VendaVeiculo : Window
    {
        public VendaVeiculo()
        {
            InitializeComponent();
            dp.SelectedDate = DateTime.Now;
            Disponiveis();
        }

        public void Disponiveis()
        {
            WS.Service1Client ws = new WS.Service1Client();
            dataGrid.ItemsSource = ws.VeiculoSelectDisponiveis();
        }

        private void btnVenda_Click(object sender, RoutedEventArgs e)
        {
            WS.Service1Client ws = new WS.Service1Client();
            ws.VeiculoUpdate(int.Parse(txtID.Text), decimal.Parse(txtValor.Text),
                DateTime.Parse(dp.SelectedDate.ToString()), decimal.Parse(txtPreco.Text));
            MessageBox.Show("Vendido!");
            Disponiveis();
        }
    }
}
