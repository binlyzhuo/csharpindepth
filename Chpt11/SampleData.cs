using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chpt11
{
    public class SampleData
    {
        public static List<User> AddUsers()
        {
            return new List<User>()
            {
               new User() {Name = "Bin"}
            };
        } 
    }

    public class User
    {
        public string Name { set; get; }
    }
}
