using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chpt7
{
    class Program
    {
        static void Main(string[] args)
        {
            PartialMethodDemo m = new PartialMethodDemo();

#pragma warning disable 0219
            int num = 10;
#pragma warning restore 0219
            Console.ReadLine();
        }
    }
}
