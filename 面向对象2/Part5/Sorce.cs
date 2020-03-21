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

        public Sorce(int YUWEN, int SHUXUE, int YINGYU)
        {
            this.YINGYU = YINGYU;
            this.YUWEN = YUWEN;
            this.SHUXUE = SHUXUE;
        }

        private int YUWEN1 { get => YUWEN; set => YUWEN = value; }
        private int SHUXUE1 { get => SHUXUE; set => SHUXUE = value; }
        private int YINGYU1 { get => YINGYU; set => YINGYU = value; }
    }
}