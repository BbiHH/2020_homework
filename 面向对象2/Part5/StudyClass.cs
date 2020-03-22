using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5
{
    public class StudyClass
    {
        private Student[] studentlist = new Student[5];
        private string name;
        private int number = 0;
        private int maxi_SX = 0, maxi_YW = 0, maxi_YY = 0;
        private Sorce sorce = new Sorce(0, 0, 0);

        public StudyClass(string name)
        {
            this.name = name;
        }

        public void AddStudent(ref Student student)
        {
            studentlist[number] = student;
            sorce += student.Sorce;
            if (studentlist[maxi_SX].Sorce.SHUXUE1 < student.Sorce.SHUXUE1)
            {
                maxi_SX = number;
            }
            if (studentlist[maxi_YW].Sorce.YUWEN1 < student.Sorce.YUWEN1)
            {
                maxi_YW = number;
            }
            if (studentlist[maxi_YY].Sorce.SHUXUE1 < student.Sorce.YINGYU1)
            {
                maxi_YY = number;
            }
            number++;
        }

        public void ShowInfo()
        {
            Console.WriteLine(name);
            for (int i = 0; i < number; i++)
            {
                studentlist[i].ShowInfo();
            }
        }

        public void GetMaxSorce()
        {
            Console.WriteLine("数学最高分:" + studentlist[maxi_SX].Sorce.SHUXUE1 + "  " + studentlist[maxi_SX].Name);
            Console.WriteLine("语文最高分:" + studentlist[maxi_YW].Sorce.YUWEN1 + "  " + studentlist[maxi_YW].Name);
            Console.WriteLine("英语最高分:" + studentlist[maxi_YY].Sorce.YINGYU1 + "  " + studentlist[maxi_YY].Name);
        }

        public void GetAgeSorce()
        {
            Console.WriteLine(name + "全班" + number + "人:");
            Console.WriteLine("数学平均分:" + sorce.SHUXUE1 / number);
            Console.WriteLine("语文平均分:" + sorce.YUWEN1 / number);
            Console.WriteLine("英语平均分:" + sorce.YINGYU1 / number);
            Console.WriteLine("平均分:" + sorce.ALL1 / number);
        }

        public void GetBUJIGE()
        {
            Console.WriteLine("不及格名单");
            for (int i = 0; i < number; i++)
            {
                if (studentlist[i].Sorce.SHUXUE1 < 60 || studentlist[i].Sorce.YINGYU1 < 60 || studentlist[i].Sorce.YUWEN1 < 60)
                {
                    studentlist[i].ShowInfo();
                }
            }
        }
    }
}