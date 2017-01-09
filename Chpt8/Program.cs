using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chpt8
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new {Name = "Bin",Age = 10};
            Console.WriteLine(person.GetType());
            Console.ReadLine();
        }
    }
}
