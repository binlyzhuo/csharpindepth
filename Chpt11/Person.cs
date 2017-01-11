using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chpt11
{
    public class Person
    {
        public string Name { set; get; }
        public int Age { set; get; }

        public static List<Person> Samples()
        {
            return new List<Person>()
            {
                new Person() {Name = "Bin",Age = 20}
            };
        } 
    }
}
