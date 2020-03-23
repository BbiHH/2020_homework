using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2_ClassLib
{
    public class Student : Bclass
    {
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}