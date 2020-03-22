using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5
{
    internal class Sorce
    {
        private int YUWEN;
        private int SHUXUE;
        private int YINGYU;
        private int ALL;

        public Sorce(int YUWEN, int SHUXUE, int YINGYU)
        {
            this.YINGYU = YINGYU;
            this.YUWEN = YUWEN;
            this.SHUXUE = SHUXUE;
            this.ALL = SHUXUE + YINGYU + YUWEN;
        }

        public int YUWEN1 { get => YUWEN; }
        public int SHUXUE1 { get => SHUXUE; }
        public int YINGYU1 { get => YINGYU; }
        public int ALL1 { get => ALL; }

        public void ShowInfo()
        {
            Console.WriteLine(YUWEN1 + "   " + SHUXUE1 + "    " + YINGYU1 + "    " + ALL1);
        }

        public static Sorce operator +(Sorce sorce1, Sorce sorce2)
        {
            return new Sorce(sorce1.YUWEN1 + sorce2.YUWEN1, sorce1.SHUXUE1 + sorce2.SHUXUE1, sorce1.YINGYU1 + sorce2.YINGYU1);
        }
    }
}