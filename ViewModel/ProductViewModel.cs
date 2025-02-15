using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System_Retail_Operation_POS.Command;
using System_Retail_Operation_POS.View;
using System_Retail_Operation_POS.Model;
using System_Retail_Operation_POS.Converter;

namespace System_Retail_Operation_POS.ViewModel
{
    public class ProductViewModel : BaseViewModel
    {

        private IServiceProvider _serviceProvider;
        private SystemPosContext _dbContext;

        //Properties
        private Product _product;
        public Product Product
        {
            get
            {
                return _product;
            }
            set
            {
                _product = value;
                OnPropertiChanged(nameof(Product));
            }
        }

        //Convert
        public StringToDoubleConvert StringToDoubleConvert { get; }

        //Command
        public ICommand AddProduct { get; }
        public ICommand SaveProduct { get; }
        public ICommand AddCategory { get; }
        public ICommand AddProvider { get; }
        public ICommand UpdateInventory {  get; }
        
        public ProductViewModel(IServiceProvider services, SystemPosContext dBContext, StringToDoubleConvert convert) 
        {
            _serviceProvider = services;
            _dbContext = dBContext;
            StringToDoubleConvert = convert;
            AddProduct = new RelayCommand<object>(ShowProduct);
            SaveProduct = new RelayCommand<object>(SaveProductCommand);
        }

        private void ShowProduct(object obj)
        {
            AddProduct addProduct = _serviceProvider.GetRequiredService<AddProduct>();
            addProduct.ShowDialog();
        }

        private void SaveProductCommand(object obj)
        {
            MessageBox.Show("SaveProductCommand");

        }


    }
}
