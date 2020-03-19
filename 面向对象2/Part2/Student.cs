using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    public class Student : Person
    {
        private int score;

        public Student(string name, string number, string sex, int score) : base(name, number, sex)
        {
            this.score = score;
        }

        public int Score { get => score; set => score = value; }

        public void print()
        {
            Console.WriteLine("学生姓名:" + name);
            Console.WriteLine("编号;" + number);
            Console.WriteLine("性别:" + sex);
            Console.WriteLine("成绩:" + score);
        }
    }
}