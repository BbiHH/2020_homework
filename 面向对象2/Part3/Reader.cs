using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    public sealed class Reader : Bclas
    {
        private int BookNumber = 0;
        private Book[] booklist = new Book[5];

        public Reader(string name, string number)
        {
            this.name = name;
            this.number = number;
        }

        public void BorrBook(ref Book book)
        {
            if (BookNumber < 5)
            {
                booklist[BookNumber] = book;
                BookNumber += 1;
                Console.WriteLine(name + "借书：");
                book.ShowInfo();
                Console.WriteLine();
                Console.WriteLine("借书成功!");
            }
            else
            {
                Console.WriteLine(name + "借书：");
                book.ShowInfo();
                Console.WriteLine();
                Console.WriteLine("借书失败!");
            }
        }

        public void ShowBook()
        {
            // 这里如果使用foreach遍历 需要迭代器
            for (int i = 0; i < BookNumber; i++)
            {
                booklist[i].ShowInfo();
                Console.WriteLine();
            }
        }

        public void ShowInfo()
        {
            Console.Write("  借书人：" + name);
            Console.Write("  借书证：" + number);
            Console.WriteLine();
            ShowBook();
        }
    }
}