using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System_Retail_Operation_POS.Command;

namespace System_Retail_Operation_POS.ViewModel;

internal class MainViewModel : BaseViewModel
{
    private object _currentViewModel;
    private IServiceProvider _serviceProvider;
    public readonly ICommand NavigateCommand;

    public object CurrentViewModel
    {
        get
        {
            return _currentViewModel;
        }
        set
        {
            _currentViewModel = value;
            OnPropertiChanged(nameof(CurrentViewModel));
        }
    }

    public MainViewModel(IServiceProvider service)
    {
        _serviceProvider = service;
        _currentViewModel = _serviceProvider.GetService<TenderViewModel>();
        NavigateCommand = new RelayCommand<string>(Navigate);
    }

    public void Navigate(string viewName)
    {
        switch(viewName)
        {
            case "Tenter":
                CurrentViewModel = _serviceProvider.GetService<TenderViewModel>();
                break;
            case "Product":
                CurrentViewModel = _serviceProvider.GetService<ProductViewModel>();
                break;
        }
    }
}

