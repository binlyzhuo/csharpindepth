using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chpt7
{
    partial class PartialMethodDemo
    {
        public PartialMethodDemo()
        {
            MethodStart();
        }

        partial void MethodStart();
    }

    partial class PartialMethodDemo
    {
        partial void MethodStart()
        {
            Console.WriteLine("PartialMethod");
        }
    }
}
