using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    public class Person
    {
        protected string name;
        protected string sex;
        protected int age;

        public string Name { get => name; set => name = value; }
        public string Sex { get => sex; set => sex = value; }
        public int Age { get => age; set => age = value; }

        #region 人类的方法  eat、sleep、work

        public void eat()
        {
            Console.WriteLine(name + "正在吃饭");
        }

        public void sleep()
        {
            Console.WriteLine(name + "正在睡觉");
        }

        public void work()
        {
            Console.WriteLine(name + "正在工作");
        }

        #endregion 人类的方法  eat、sleep、work
    }
}