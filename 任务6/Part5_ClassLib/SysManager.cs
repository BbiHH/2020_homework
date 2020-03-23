using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5_ClassLib
{
    public class SysManager : User
    {
        public SysManager(string v1, string v2) : base(v1, v2)
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("姓名：" + Username);
            Console.WriteLine("用户类型：管理员");
            Console.WriteLine("----------------------");
        }

        public void insertTeacher(ref Teacher teacher, object p)
        {
            throw new NotImplementedException();
        }

        public void insertStudent(ref Student student)
        {
            SysData.stu.Add(student);
        }

        public void insertTeacher(ref Teacher teacher)
        {
            SysData.ter.Add(teacher);
        }
    }
}