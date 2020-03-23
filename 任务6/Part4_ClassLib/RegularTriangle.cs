using System;

namespace Part4_ClassLib
{
    public class RegularTriangle : Shape
    {
        private double edge;

        public override void area()
        {
            Console.WriteLine("正三角形的边长:");
            edge = double.Parse(Console.ReadLine());
            Console.WriteLine("正三角形的面积:{0}", Math.Sqrt(3) * Math.Pow(edge, 2) / 4);
        }
    }
}