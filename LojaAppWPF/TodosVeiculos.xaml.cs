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
    /// Interaction logic for TodosVeiculos.xaml
    /// </summary>
    public partial class TodosVeiculos : Window
    {
        public TodosVeiculos()
        {
            InitializeComponent();
            Select();
        }

        public void Select()
        {
            WS.Service1Client ws = new WS.Service1Client();
            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = ws.VeiculoSelect();
        }
    }
}
