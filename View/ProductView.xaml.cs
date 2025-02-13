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
using System_Retail_Operation_POS.ViewModel;

namespace System_Retail_Operation_POS.View
{
    /// <summary>
    /// Lógica de interacción para Product.xaml
    /// </summary>
    public partial class ProductView : UserControl
    {
        public ProductView()
        {
            InitializeComponent();            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hola");
            AddProduct product = new AddProduct();
            product.ShowDialog();
        }
    }
}
