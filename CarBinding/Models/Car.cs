using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBinding.Models
{
    public class Car
    {
        public string Name { get; set; }

        public string Brand { get; set; }

        public TireRange TireRange { get; set; }
    }
}
