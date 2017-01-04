using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chpt4
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> num = 100;
            bool isHasValue = num.HasValue;
            int? num2 = null;
            int v = num.GetValueOrDefault();
            Console.ReadLine();
        }
    }
}
