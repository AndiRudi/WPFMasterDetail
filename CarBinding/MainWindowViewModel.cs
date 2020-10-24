using CarBinding.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBinding
{
    public class MainWindowViewModel
    {
        public ObservableCollection<Car> Cars { get; set; } = new ObservableCollection<Car>();

    }
}
