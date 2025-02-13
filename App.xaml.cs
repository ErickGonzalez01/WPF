using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.IO;
using System.Windows;
using System_Retail_Operation_POS.Model;
using System_Retail_Operation_POS.View;
using System_Retail_Operation_POS.ViewModel;
using System_Retail_Operation_POS.Command;

namespace System_Retail_Operation_POS
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IServiceProvider _serviceProvider;
        private IConfiguration _configuration;

        public App()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            _configuration = builder.Build();

            var serviceCollection = new ServiceCollection();
            ConfigureService(serviceCollection);
            _serviceProvider = serviceCollection.BuildServiceProvider();
        }
        private void ConfigureService(IServiceCollection services)
        {
            string connectionString = _configuration.GetConnectionString("SqlServer");
            services.AddDbContext<SystemPosContext>(options =>
            options.UseSqlServer(connectionString));

            //MainWindow
            services.AddSingleton<MainWindow>();

            //Model           

            //ViewModel            
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<TenderViewModel>();
            services.AddSingleton<ProductViewModel>();

        }
        protected override void OnStartup(StartupEventArgs e)
        {
            var mainWindows = _serviceProvider.GetRequiredService<MainWindow>();
            mainWindows.Show();
            base.OnStartup(e);
        }
    }

}
