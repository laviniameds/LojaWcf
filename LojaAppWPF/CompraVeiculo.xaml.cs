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
    /// Interaction logic for CompraVeiculo.xaml
    /// </summary>
    public partial class CompraVeiculo : Window
    {
        public CompraVeiculo()
        {
            InitializeComponent();
            dp.SelectedDate = DateTime.Now;
            Disponiveis();
            PopularCB();
        }

        public void Disponiveis()
        {
            WS.Service1Client ws = new WS.Service1Client();
            dataGrid.ItemsSource = ws.VeiculoSelectDisponiveis();
        }

        public void PopularCB()
        {
            WS.Service1Client ws = new WS.Service1Client();
            cb.ItemsSource = ws.FabricanteSelect();
            cb.SelectedValuePath = "Id";
            cb.DisplayMemberPath = "Descricao";
        }

        private void btnCompra_Click(object sender, RoutedEventArgs e)
        {
            WS.Service1Client ws = new WS.Service1Client();
            ws.VeiculoInsert(int.Parse(txtID.Text), txtModelo.Text, int.Parse(txtAno.Text), 
                int.Parse(cb.SelectedValue.ToString()), Convert.ToDateTime(dp.SelectedDate), 
                Convert.ToDecimal(txtValor.Text));
            MessageBox.Show("Comprado!");
            Disponiveis();
        }
    }
}
