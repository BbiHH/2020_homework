using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part6_ClassLib
{
    public interface ITrans
    {
        void Run();

        void DisplayInfo();
    }
}