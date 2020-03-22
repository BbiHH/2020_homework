using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5
{
    public class Student
    {
        private string name;
        private string number;
        private Sorce sorce;

        public Student(string number, string name, int YUWEN, int SHUXUE, int YINGYU)
        {
            this.sorce = new Sorce(YUWEN, SHUXUE, YINGYU);
            this.name = name;
            this.number = number;
        }

        public string Name { get => name; }
        public string Number { get => number; }
        internal Sorce Sorce { get => sorce; }

        public void ShowInfo()
        {
            Console.Write(Number + " " + Name + " ");
            sorce.ShowInfo();
        }
    }
}