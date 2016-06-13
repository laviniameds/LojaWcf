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
    /// Interaction logic for CRUDFabricante.xaml
    /// </summary>
    public partial class CRUDFabricante : Window
    {
        public CRUDFabricante()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            WS.Service1Client ws = new WS.Service1Client();
            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = ws.FabricanteSelect();
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            WS.Service1Client ws = new WS.Service1Client();
            ws.FabricanteInsert(int.Parse(txtId.Text), txtDesc.Text);
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            WS.Service1Client ws = new WS.Service1Client();
            ws.FabricanteUpdate(int.Parse(txtId.Text), txtDesc.Text);
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            WS.Service1Client ws = new WS.Service1Client();
            ws.FabricanteDelete(int.Parse(txtId.Text));
        }
    }
}
