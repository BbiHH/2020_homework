using System;

namespace Part1_ClassLib
{
    public class Student
    {
        private string name;
        private int age;

        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Show()
        {
            Console.WriteLine("姓名：" + name);
            Console.WriteLine("年龄：" + age);
            Console.WriteLine("---------------");
        }
    }
}