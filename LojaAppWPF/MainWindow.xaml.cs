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

namespace LojaAppWPF
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

        private void CRUDFab_Click(object sender, RoutedEventArgs e)
        {
            (new CRUDFabricante()).Show();
        }

        private void Comprar_Click(object sender, RoutedEventArgs e)
        {
            (new CompraVeiculo()).Show();
        }

        private void Vender_Click(object sender, RoutedEventArgs e)
        {
            (new VendaVeiculo()).Show();
        }

        private void Todos_Click(object sender, RoutedEventArgs e)
        {
            (new TodosVeiculos()).Show();
        }

        private void Vendidos_Click(object sender, RoutedEventArgs e)
        {
            (new VeiculosVendidos()).Show();
        }

        private void Deletar_Click(object sender, RoutedEventArgs e)
        {
            (new DeletarVeiculos()).Show();
        }
    }
}
