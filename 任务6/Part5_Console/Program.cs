using Part5_ClassLib;
using System;

namespace Part5_Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            User user = (User)SysData.Login("admin", "123");
            user.DisplayInfo();
            SysManager admin = (SysManager)user;
            Teacher teacher = new Teacher("李沙沙", "123", "计算机系", 5000);
            admin.insertTeacher(ref teacher);
            Student student = new Student("张郭郭", "123", "310760", 60);
            admin.insertStudent(ref student);

            user = (User)SysData.Login("李沙沙", "123");
            user.DisplayInfo();

            user = (User)SysData.Login("张郭郭", "123");
            user.DisplayInfo();

            Console.ReadKey();
        }
    }
}