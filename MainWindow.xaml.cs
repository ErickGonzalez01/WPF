using Microsoft.Extensions.DependencyInjection;
using System.Text;
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

namespace System_Retail_Operation_POS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IServiceProvider _serviceProvider;
        public MainWindow(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            DataContext = _serviceProvider.GetRequiredService<MainViewModel>();
        }

        public void Navigated(object sender, SelectionChangedEventArgs e)
        {
            var itemselected = ((ListBoxItem)((ListBox)sender).SelectedItem).Tag;
            var mainViewModel = (MainViewModel)DataContext;
            mainViewModel.NavigateCommand.Execute(itemselected);
            //MessageBox.Show("A tocado un item"+itemselected);

        }

    }
}