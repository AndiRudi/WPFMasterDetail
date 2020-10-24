using CarBinding.Models;
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

namespace CarBinding
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindowViewModel MainWindowViewModel { get; set; } = new MainWindowViewModel();

        public MainWindow()
        {
            InitializeComponent();

            MainWindowViewModel.Cars.Add(new Car { Brand = "BMW", Name = "1", TireRange = new TireRange { Min = 55, Max = 100 } });
            MainWindowViewModel.Cars.Add(new Car { Brand = "VW", Name = "Lupo", TireRange = new TireRange { Min = 50, Max = 80 } });

            this.DataContext = MainWindowViewModel;
        }
    }
}
