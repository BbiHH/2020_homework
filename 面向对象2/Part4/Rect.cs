using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4
{
    public class Rect : Shape
    {
        public Rect(int x, int y)
        {
            this.X = x;
            this.Y = y;
            this.arce = x * y;
        }
    }
}