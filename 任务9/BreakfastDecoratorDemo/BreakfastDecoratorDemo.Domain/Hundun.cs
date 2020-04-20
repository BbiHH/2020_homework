using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BreakfastDecoratorDemo.Domain
{
    public class Hundun : Breakfast
    {
        public override double GetPrice()
        {
            return 6.0;
        }
    }
}