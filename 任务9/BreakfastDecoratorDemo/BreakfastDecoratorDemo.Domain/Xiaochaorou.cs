using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BreakfastDecoratorDemo.Domain
{
    public class Xiaochaorou : BkDecorator
    {
        public Xiaochaorou(Breakfast breakfast) : base(breakfast)
        {
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 1.5;
        }
    }
}