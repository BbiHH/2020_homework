using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BreakfastDecoratorDemo.Domain
{
    public class Beef : BkDecorator
    {
        public Beef(Breakfast breakfast) : base(breakfast)
        {
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 2.0;
        }
    }
}