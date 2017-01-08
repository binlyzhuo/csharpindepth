using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
            AnonymousDelegate();
            PredicateFun();

            SortAndShowFiles("Sort by name:", delegate(FileInfo f1, FileInfo f2)
            {
                return f1.Name.CompareTo(f2.Name);
            });

            Func<string> print = delegate()
            {
                return "";
            };
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

        static void AnonymousDelegate()
        {
            Action<string> printReverse = delegate(string text)
            {
                char[] chars = text.ToCharArray();
                Array.Reverse(chars);
                Console.WriteLine(new string(chars));
            };

            Action<int> printRoot = delegate(int num)
            {
                Console.WriteLine(Math.Sqrt(num));
            };

            Action<IList<double>> printMean = delegate(IList<double> numbers)
            {
                double total = 0d;
                total = numbers.Sum();
                Console.WriteLine(total / numbers.Count);
            };

            //===========
            // EXECUTING...
            printReverse("Hello World");
            printRoot(2);
            printMean(new List<double>() {1,2,3,45,5,9});

            //======================
            List<int> numInts = new List<int>();
            numInts.Add(1);
            numInts.Add(2);

            numInts.ForEach(delegate(int num)
            {
                Console.WriteLine(num);
            });

            //
        }

        static void PredicateFun()
        {
            Predicate<int> isEven = delegate(int x)
            {
                return x%2 == 0;
            };

            Console.WriteLine(isEven(1));
            Console.WriteLine(isEven(2));
        }

        static void SortAndShowFiles(string title, Comparison<FileInfo> sortOrder)
        {
            FileInfo[] files = new DirectoryInfo(@"D:\download").GetFiles();
            Array.Sort(files,sortOrder);
            Console.WriteLine(title);
            foreach (var file in files)
            {
                Console.WriteLine("{0} ({1} bytes)",file.Name,file.Length);
            }
        }

        static void EnclosingMethod()
        {
            int outVariable = 5;
            string capturedVariable = "captured";
            if (DateTime.Now.Hour == 23)
            {
                int normalLocalVariable = DateTime.Now.Minute;
            }

            //MethodInvoker
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
