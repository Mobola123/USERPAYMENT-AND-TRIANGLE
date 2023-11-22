using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wema.BIT.Models
{
    internal class Triangle
    {
        public decimal SideA;
        public decimal SideB;
        public decimal SideC;

        public Triangle(decimal _a, decimal _b, decimal _c)
        {
            SideA = _a;
            SideB = _b;
            SideC = _c;
        }

        public decimal calcArea()
        {
            return SideA * SideB * SideC;   
        }


    }
}
