using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Machine
{
    public class Food
    {
        public string Name2;
        public decimal Price2;

        public override string ToString()
        {
            return $"{Name2} - {Price2.ToString("C")}";
        }
    }
}
