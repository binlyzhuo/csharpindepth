using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chpt6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }

        static readonly string Padding = new string(' ',30);
        static IEnumerable<int> CreateEnumerable()
        {
            Console.WriteLine("{0} Start Of CreateEnumerable()",Padding);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("{0} About to yield {1}",Padding,1);
                yield return i;
            }
        } 
    }
}
