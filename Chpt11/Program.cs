using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chpt11
{
    class Program
    {
        static void Main(string[] args)
        {
            var adultNames = from p in Person.Samples()
                where p.Age >= 18
                select p.Name;

            Console.WriteLine(adultNames.Count());

            var query = SampleData.AddUsers().Select(user => user);
            foreach (var user in query)
            {
                Console.WriteLine(user);
            }


            Console.ReadLine();
        }
    }
}
