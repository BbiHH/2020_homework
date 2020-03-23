using System;

namespace Part5_ClassLib
{
    public class Student : User
    {
        private string classID;
        private double score;

        public Student(string username, string password, string classID, double score) : base(username, password)
        {
            this.classID = classID;
            this.score = score;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("姓名：" + Username);
            Console.WriteLine("用户类型：学生");
            Console.WriteLine("班级：" + classID);
            Console.WriteLine("成绩：" + score);
            Console.WriteLine("----------------------");
        }

        public void CheckScore()
        {
            Console.WriteLine(Username + "的成绩为:" + score);
        }
    }
}