using System;

namespace Part2_ClassLib
{
    public class Bclass
    {
        protected string name;
        protected int age;

        public void Show()
        {
            Console.WriteLine("姓名：" + name);
            Console.WriteLine("年龄：" + age);
            Console.WriteLine("---------------");
        }
    }
}