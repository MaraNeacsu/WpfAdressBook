
using System.Windows;
using WpfApp1.Mvvm.ViewModels;

namespace WpfApp1
{
   
    public partial class MainWindow : Window
    {
        public MainWindow(MainWiewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}