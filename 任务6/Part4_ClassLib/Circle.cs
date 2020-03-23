using System;

namespace Part4_ClassLib
{
    public class Circle : Shape
    {
        private double radius;

        public override void area()
        {
            Console.WriteLine("圆形的半径:");
            radius = double.Parse(Console.ReadLine());
            Console.WriteLine("圆形的面积:{0}", Math.PI * Math.Pow(radius, 2));
        }
    }
}