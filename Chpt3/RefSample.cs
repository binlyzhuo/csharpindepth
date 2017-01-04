using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chpt3
{
    public struct RefSample<T>
        where T:class 
    {
    }

    class ValSample<T>
        where T : struct
    {
        
    }
}
