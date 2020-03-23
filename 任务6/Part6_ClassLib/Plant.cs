using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part6_ClassLib
{
    public class Plant : ITrans
    {
        private string number;
        private int sitNumber;

        public Plant(string number, int sitNumber)
        {
            this.number = number;
            this.sitNumber = sitNumber;
        }

        public void Run()
        {
            Console.WriteLine("长途飞机" + number + "    正在送宁回家!");
        }

        public void DisplayInfo()
        {
            Console.WriteLine("该航程为 长途飞机,荷载 " + sitNumber + "人");
        }
    }
}