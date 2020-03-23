using Part1_ClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student student = new Student("cgf", 10);
            Person person = new Person("fgc", 11);

            student.Show();
            person.Show();
        }
    }
}