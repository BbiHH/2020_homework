using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented2_Client
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("---------------Part1---------------------------------");
            Console.WriteLine("定义一个人类(Person)，包括属性：姓名(name)、性别(sex)、年龄(age)；包括方法：吃饭(eat)、睡觉(sleep)、工作(work)。");
            Console.WriteLine("（1）根据人类，派生一个学生类(Student)，增加属性：学校(school)、学号(s_number)；重写工作方法（学生的工作是学习）。");
            Console.WriteLine("（2）根据人类，派生一个工人类(Worker)，增加属性：单位，工龄；重写工作方法（工人的工作是……自己想想吧）。");
            Console.WriteLine("（3）根据学生类，派生一个学生干部类(StudentLeading)，增加属性：职务(job)；增加方法：开会(meeting)。");
            Console.WriteLine("（4）编写主类分别对上述3类具体人物进行测试。");

            Part1.Person person1 = new Part1.Person();
            Part1.Student student1 = new Part1.Student();
            Part1.StudentLeading studentleadinbg1 = new Part1.StudentLeading();
            Part1.Worker worker1 = new Part1.Worker();

            person1.Name = "人";
            student1.Name = "学生";
            studentleadinbg1.Name = "学生干部";
            worker1.Name = "工人";

            person1.sleep(); person1.work();
            studentleadinbg1.eat(); studentleadinbg1.meeting();
            worker1.work();
            student1.work();

            Console.WriteLine("-------------Part2------------");
            Part2.Student zs = new Part2.Student("张三", "1001", "男", 80);
            zs.print();

            Console.ReadKey();
        }
    }
}