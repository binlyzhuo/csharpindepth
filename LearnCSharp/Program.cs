using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnCSharp
{
    class Program
    {
        private delegate void StringProcessor(string input);
        static void Main(string[] args)
        {
            Console.WriteLine("Learn C# in depth!!");
            var products = Product.GetSampleProducts();

            Print(products);
            //products.Sort(new ProductNameComparer());
            //products.Sort(delegate(Product x, Product y)
            //{
            //    return x.Name.CompareTo(y.Name);
            //});
            Console.WriteLine("*****************");

            foreach (var p in products.OrderBy(u=>u.Name))
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("*****************");
            foreach (var p in products.Where(p=>p.Price>=10))
            {
                Console.WriteLine(p);
            }

            int? num = 123;
            int relNum = num.Value;


            // THINKING!!
            WordCountHelper.TestCount();

            //Print(products);
            Console.ReadKey();
        }

        private static void Print(List<Product> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }
    }
}
