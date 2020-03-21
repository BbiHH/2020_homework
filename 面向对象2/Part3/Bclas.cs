using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    public class Bclas
    {
        protected string name;
        protected string number;
        protected string pub_name;

        public string Name { get => name; set => name = value; }
        public string Number { get => number; set => number = value; }
        public string Pub_name { get => pub_name; set => pub_name = value; }
    }
}