using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part6_ClassLib
{
    public class Coach : ITrans
    {
        private string number;
        private int sitNumber;

        public Coach(string number, int sitNumber)
        {
            this.number = number;
            this.sitNumber = sitNumber;
        }

        public void Run()
        {
            Console.WriteLine("长途巴士" + number + "    正在送宁回家!");
        }

        public void DisplayInfo()
        {
            Console.WriteLine("该航程为 长途巴士,荷载 " + sitNumber + "人");
        }
    }
}