using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    public class StudentLeading : Student
    {
        protected string job;

        public string Job { get => job; set => job = value; }

        public void meeting()
        {
            Console.WriteLine(this.name + "正在开会");
        }
    }
}