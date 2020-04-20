using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BreakfastDecoratorDemo.Domain
{
    public class Mifen : Breakfast
    {
        public override double GetPrice()
        {
            return 3.5;
        }
    }
}