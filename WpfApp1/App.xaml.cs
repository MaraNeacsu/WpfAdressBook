using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;
using WpfApp1.Mvvm.ViewModels;

namespace WpfApp1
{
    public partial class App : Application
    {
        private static IHost? builder;

        public App()
        {
            builder = Host.CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    services.AddSingleton<MainWiewModel>(); // Fix typo here
                    services.AddSingleton<MainWindow>();
                })
                .Build();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            builder!.Start();

            var mainWindow = builder.Services.GetRequiredService<MainWindow>(); // Fix typo here
            mainWindow.Show();
        }
    }
}


