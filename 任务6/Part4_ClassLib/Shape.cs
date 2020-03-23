using System;

namespace Part4_ClassLib
{
    public abstract class Shape
    {
        public virtual void area()
        {
            Console.WriteLine("计算面积。");
        }
    }
}