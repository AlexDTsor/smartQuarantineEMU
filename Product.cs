using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Machine
{
    public class Product
    {
        public string Name;
        public decimal Price;

        public override string ToString()
        {
            return $"{Name} - {Price.ToString("C")}";
        }
    }
}
