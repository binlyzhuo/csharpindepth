using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Chpt1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Search();
            Console.ReadLine();
        }

        static void Sort()
        {
            var products = Product.GetSampleProducts();
            products.Sort(new ProductNameComparer());

            products.Sort(delegate (Product x, Product y)
            {
                return x.Name.CompareTo(y.Name);
            });

            products.Sort((x, y) => x.Name.CompareTo(y.Name));

            foreach (var product in products.OrderBy(p => p.Name))
            {
                Console.WriteLine(product);
            }

            Console.WriteLine("------------------");

            foreach (var p in products)
            {
                Console.WriteLine(p);
            }
        }

        static void Search()
        {
            List<Product> products = Product.GetSampleProducts();
            Predicate<Product> test = delegate(Product p)
            {
                return p.Price > 10m;
            };

            var mathes = products.FindAll(test);
            Action<Product> print = Console.WriteLine;
            mathes.ForEach(print);

            products.FindAll(delegate(Product p) { return p.Price > 10m; }).ForEach(print);

            foreach (var product in products.Where(p=>p.Price>10m))
            {
                Console.WriteLine(product);
            }
        }
    }
}
