using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    public class Book : Bclas
    {
        public Book(string name, string number, string pub_name)
        {
            this.Name = name;
            this.Number = number;
            this.Pub_name = pub_name;
        }

        public void ShowInfo()
        {
            Console.Write("  书名：" + name);
            Console.Write("  编号:" + number);
            Console.Write("  出版社:" + pub_name);
        }
    }
}