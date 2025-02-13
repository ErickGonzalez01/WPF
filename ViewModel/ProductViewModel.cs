using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System_Retail_Operation_POS.Command;
using System_Retail_Operation_POS.View;

namespace System_Retail_Operation_POS.ViewModel
{
    internal class ProductViewModel : BaseViewModel
    {
        public ICommand AddProduct;
        public ICommand AddCategory;
        public ICommand AddProvider;
        public ICommand UpdateInventory;
        public ProductViewModel() 
        {
            AddProduct = new RelayCommand<object>(ShowProduct);
        }

        private void ShowProduct(object obj)
        {
            var addProductView = new AddProduct();
            addProductView.ShowDialog();
        }
    }
}
