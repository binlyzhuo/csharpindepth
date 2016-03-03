using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnCSharp
{
    public class Product
    {
        private readonly string name;

        public string Name
        {
            get { return name; }
        }

        private readonly decimal price;

        public decimal Price
        {
            get { return price; }
        }

        public Product(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public static List<Product> GetSampleProduct()
        {
            var list = new List<Product>();
            list.Add(new Product("book", 100));
            return list;
        }

        public override string ToString()
        {
            //return base.ToString();
            return string.Format("{0}:{1}",name,price);
        }
    }
}
