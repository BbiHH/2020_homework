using System;

namespace Part4_ClassLib
{
    public class Square : Shape
    {
        private double edge;

        public override void area()
        {
            Console.WriteLine("正方形的边长:");
            edge = double.Parse(Console.ReadLine());
            Console.WriteLine("正方形的面积:{0}", Math.Pow(edge, 2));
        }
    }
}