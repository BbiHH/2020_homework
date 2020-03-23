using System;

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