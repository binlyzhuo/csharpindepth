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
            
            //Search();
            Linq();
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


        static void Linq()
        {
            var products = Product.GetSampleProducts();
            var suppliers = Supplier.GetSampleSuppliers();
            var filtered = from p in products
                where p.Price > 10m
                select p;
            foreach (var product in filtered)
            {
                Console.WriteLine(product);
            }

            var filtered2 = from p in products
                join s in suppliers
                    on p.SupplierID equals s.SupplierID
                where p.Price > 10m
                orderby s.Name, p.Name
                select new {SupplierName = s.Name, ProductName = p.Name};

            foreach (var f in filtered2)
            {
                Console.WriteLine("Supplier={0},ProductName={1}",f.SupplierName,f.ProductName);
            }
        }
    }
}
