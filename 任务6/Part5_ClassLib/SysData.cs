using System.Collections;

namespace Part5_ClassLib
{
    public static class SysData
    {
        public static string SysName = "学校教务系统";

        private static SysManager sys = new SysManager("admin", "123");
        internal static ArrayList stu = new ArrayList();
        internal static ArrayList ter = new ArrayList();

        public static object Login(string username, string password)
        {
            object user = null;
            if (sys.Login(username, password))
            {
                user = sys;
            }
            else
            {
                for (int i = 0; i < stu.Count; i++)
                {
                    Student student = stu[i] as Student;
                    if (student.Login(username, password))
                    {
                        user = student;
                    }
                }
                for (int i = 0; i < ter.Count; i++)
                {
                    Teacher teacher = ter[i] as Teacher;
                    if (teacher.Login(username, password))
                    {
                        user = teacher;
                    }
                }
            }
            return user;
        }
    }
}