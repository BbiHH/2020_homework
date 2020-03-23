using Part6_ClassLib;
using System;

namespace Part6_Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ITrans[] trans = new ITrans[3];
            trans[0] = new Coach("21903910", 30);
            trans[1] = new Train("21944951", 500);
            trans[2] = new Plant("00411234", 100);

            for (int i = 0; i < 3; i++)
            {
                trans[i].Run();
                trans[i].DisplayInfo();
                Console.WriteLine("-------------------");
            }
        }
    }
}