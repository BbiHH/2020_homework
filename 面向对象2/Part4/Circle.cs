using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4
{
    public class Circle : Shape
    {
        public Circle(int x)
        {
            this.X = x;
            this.arce = x * x;
        }
    }
}