using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chpt9
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> getLen = u => u.Length;
            int len = getLen("get");
            Console.WriteLine(len);
            Console.ReadLine();
        }
    }
}
