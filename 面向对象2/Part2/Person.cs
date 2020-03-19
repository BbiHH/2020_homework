using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    public class Person
    {
        protected string name;
        protected string number;
        protected string sex;

        public Person(string name, string number, string sex)
        {
            this.name = name;
            this.number = number;
            this.sex = sex;
        }

        public string Name { get => name; set => name = value; }
        public string Number { get => number; set => number = value; }
        public string Sex { get => sex; set => sex = value; }
    }
}