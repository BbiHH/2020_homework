using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    public class Student : Person
    {
        protected string school;
        protected string s_number;

        public string School { get => school; set => school = value; }
        public string S_Number { get => s_number; set => s_number = value; }

        public new void work()
        {
            Console.WriteLine(this.name + "正在学习");
        }
    }
}