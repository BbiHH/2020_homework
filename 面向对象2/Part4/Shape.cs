using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4
{
    public abstract class Shape
    {
        private int x;
        private int y;
        protected int arce;
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Arce { get => arce; }
    }
}