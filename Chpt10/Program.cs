using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chpt10
{
    class Program
    {
        static void Main(string[] args)
        {
            var collect = Enumerable.Range(0, 10);
            foreach (var i in collect)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
