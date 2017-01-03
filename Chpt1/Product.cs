using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chpt1
{
    public class Product
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public int SupplierID { set; get; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        /// <summary>
        /// 私有构造函数
        /// </summary>
        Product()
        { }

        public static List<Product> GetSampleProducts()
        {
            return new List<Product>()
            {
                new Product() { Name = "West Side Story",Price = 9.99m, SupplierID = 10},
                new Product() {Name = "Assassins",Price = 14.9m, SupplierID =10},
                new Product() {Name = "Frogs",Price = 13.9m},
                new Product() { Name = "Sweeney",Price = 10.9m}
            };
        }

        public override string ToString()
        {
            //return base.ToString();
            return string.Format("{0}:{1}",Name,Price);
        }
    }
}
