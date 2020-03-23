using Part7_ClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part7_Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ISportsman bas = new Basketballman();
            ISportsman foo = new Footballman();

            bas.Jump();
            foo.Jump();
            bas.Run();
            foo.Run();
        }
    }
}