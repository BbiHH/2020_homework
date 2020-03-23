using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2_ClassLib
{
    public class Person : Bclass
    {
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}