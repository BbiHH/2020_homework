using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BreakfastDecoratorDemo.Domain
{
    public class Jiaozi : Breakfast
    {
        public override double GetPrice()
        {
            return 5.0;
        }
    }
}