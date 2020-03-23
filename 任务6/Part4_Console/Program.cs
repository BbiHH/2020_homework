using Part4_ClassLib;

namespace Part4_Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Shape[] shapes = new Shape[3];
            shapes[0] = new Square();
            shapes[1] = new RegularTriangle();
            shapes[2] = new Circle();
            for (int i = 0; i < 3; i++)
            {
                shapes[i].area();
            }
        }
    }
}