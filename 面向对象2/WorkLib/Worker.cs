using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    public class Worker : Person
    {
        protected string job_place;
        protected int job_age;

        public string Job_Place { get => job_place; set => job_place = value; }
        public int Job_Age { get => job_age; set => Job_Age = value; }

        public new void work()
        {
            Console.WriteLine(this.name + "正在上班");
        }
    }
}