using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chpt5
{
    class Program
    {
        private delegate void SampleDelegate(string x);
        static void Main(string[] args)
        {
            Dervied d = new Dervied();
            SampleDelegate fac = new SampleDelegate(d.Method);
            fac("TEST");
            Console.ReadLine();
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

    public class Snippet
    {
        public void Method(string x)
        {
            Console.WriteLine("Method in Snippet!");
        }
    }

    public class Dervied : Snippet
    {
        public new void Method(string x)
        {
            Console.WriteLine("Method in Dervied!");
        }
    }
}
