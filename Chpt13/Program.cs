using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chpt13
{
    class Program
    {
        static void Main(string[] args)
        {
            Dump(x:3,y:2,z:1);
            Console.ReadLine();
        }

        static void Dump(int x, int y, int z)
        {
            Console.WriteLine("x={0},y={1},z={2}",x,y,z);
        }
    }
}
