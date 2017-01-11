using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chpt11
{
    public class Dummy<T>
    {
        public Dummy<U> Select<U>(Func<U, T> selector)
        {
            Console.WriteLine("Selector called!!");
            return new Dummy<U>();
        } 
    }

    public static class Extensions
    {
        public static Dummy<T> Where<T>(this Dummy<T> dummy, Func<T, bool> predicate)
        {
            Console.WriteLine("Where Called!!");
            return dummy;
        } 
    }
}
