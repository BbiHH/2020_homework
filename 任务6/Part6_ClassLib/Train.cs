using System;

namespace Part6_ClassLib
{
    public class Train : ITrans
    {
        private string number;
        private int sitNumber;

        public Train(string number, int sitNumber)
        {
            this.number = number;
            this.sitNumber = sitNumber;
        }

        public void Run()
        {
            Console.WriteLine("长途火车" + number + "    正在送宁回家!");
        }

        public void DisplayInfo()
        {
            Console.WriteLine("该航程为 长途火车,荷载 " + sitNumber + "人");
        }
    }
}