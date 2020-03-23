using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part7_ClassLib
{
    public class Basketballman : ISportsman
    {
        public void Jump()
        {
            Console.WriteLine("篮球运动员的跳。");
        }

        public void Run()
        {
            Console.WriteLine("篮球运动员的跑。");
        }
    }
}