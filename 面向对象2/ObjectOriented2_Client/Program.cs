using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented2_Client
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-------------Part1------------");

            #region Part1

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

            #endregion Part1

            Console.WriteLine();

            Console.WriteLine("-------------Part2------------");

            #region Part2

            Part2.Student zs = new Part2.Student("张三", "1001", "男", 80);
            zs.print();

            #endregion Part2

            Console.WriteLine();

            Console.WriteLine("-------------Part3------------");

            #region Part3

            Part3.Book book1 = new Part3.Book("平凡的世界", "001", "新华社");
            Part3.Book book2 = new Part3.Book("小王子", "002", "新华社");
            Part3.Book book3 = new Part3.Book("战争与和平", "003", "外研社");
            Part3.Reader reader1 = new Part3.Reader("The Shy", "4488");
            Part3.Reader reader2 = new Part3.Reader("小枣", "4401");
            Part3.Reader reader3 = new Part3.Reader("阿水", "4188");

            reader1.BorrBook(ref book1);
            reader1.BorrBook(ref book2);
            reader2.BorrBook(ref book3);
            reader3.BorrBook(ref book2);

            reader1.ShowInfo();
            reader2.ShowInfo();
            reader3.ShowInfo();

            #endregion Part3

            Console.WriteLine();

            Console.WriteLine("-------------Part4------------");

            #region Part4

            Part4.Shape rect = new Part4.Rect(3, 4);
            Part4.Shape circle = new Part4.Circle(5);
            Console.WriteLine("矩形 长:" + rect.X + "  宽；" + rect.Y + " 面积：" + rect.Arce);
            Console.WriteLine("圆形 边长:" + circle.X + "  面积：" + circle.Arce);

            #endregion Part4

            Console.WriteLine();

            Console.WriteLine("-------------Part5------------");

            #region Part5

            Part5.StudyClass studyClass = new Part5.StudyClass("宇宙班");
            Part5.Student st1 = new Part5.Student("001", "鲁迅", 100, 70, 59);
            Part5.Student st2 = new Part5.Student("002", "华罗庚", 71, 99, 60);
            Part5.Student st3 = new Part5.Student("003", "伯克利多", 20, 85, 91);
            Part5.Student st4 = new Part5.Student("004", "倒霉蛋", 20, 33, 11);

            studyClass.AddStudent(ref st1);
            studyClass.AddStudent(ref st2);
            studyClass.AddStudent(ref st3);
            studyClass.AddStudent(ref st4);

            studyClass.ShowInfo();
            Console.WriteLine();
            studyClass.GetMaxSorce();
            Console.WriteLine();
            studyClass.GetBUJIGE();
            Console.WriteLine();
            studyClass.GetAgeSorce();

            #endregion Part5

            Console.ReadKey();
        }
    }
}