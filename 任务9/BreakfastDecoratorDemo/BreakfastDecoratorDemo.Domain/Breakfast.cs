using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BreakfastDecoratorDemo.Domain
{
    public abstract class Breakfast
    {
        /// <summary>
        /// 获得价格
        /// </summary>
        abstract public double GetPrice();
    }
}