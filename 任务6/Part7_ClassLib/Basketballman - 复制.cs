using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part7_ClassLib
{
    public class Footballman : ISportsman
    {
        public void Jump()
        {
            Console.WriteLine("足球运动员的跳。");
        }

        public void Run()
        {
            Console.WriteLine("足球运动员的跑。");
        }
    }
}