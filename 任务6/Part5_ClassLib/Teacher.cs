using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5_ClassLib
{
    public class Teacher : User
    {
        private string department;
        private double salary;

        public Teacher(string username, string password, string department, double salary) : base(username, password)
        {
            this.department = department;
            this.salary = salary;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("姓名：" + Username);
            Console.WriteLine("用户类型：教师");
            Console.WriteLine("部门：" + department);
            Console.WriteLine("工资：" + salary);
            Console.WriteLine("----------------------");
        }

        public void CheckScore()
        {
            Console.WriteLine(Username + "的工资为:" + salary);
        }
    }
}