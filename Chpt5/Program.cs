using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chpt5
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void LoadPlainEvent(object sender, EventArgs e)
        {
            Console.WriteLine("LogPlain");
        }

        static void KeyPressEvent(object sender, KeyPressEvent e)
        {
            Console.WriteLine("Key Press!!");
        }
    }

    public class KeyPressEvent : EventArgs
    {
        
    }
}
