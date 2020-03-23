using System;

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