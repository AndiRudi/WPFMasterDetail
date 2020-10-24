using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBinding.Models
{
    public class TireRange
    {
        public int Min { get; set; }

        public int Max { get; set; }

        public override string ToString()
        {
            return $"{Min}-{Max}";
        }
    }
}
