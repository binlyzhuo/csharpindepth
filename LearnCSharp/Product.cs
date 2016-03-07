namespace LearnCSharp
{
    using System;
    using System.Collections;
    public class Product
    {
        public Product(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }
        private string name;

        public string Name
        {
            get { return name; }
        }

        private decimal price;

        public decimal Price
        {
            get { return this.price; }
        }

        public static ArrayList GetSampleProducts()
        {
            ArrayList list = new ArrayList();
            list.Add(new Product("West side story", 9.9m));
            list.Add(new Product("Assassins", 14.9m));
            list.Add(new Product("Frogs", 13.99m));
            list.Add(new Product("Sweeey", 10.99m));
            return list;
        }

        public override string ToString()
        {
            //return base.ToString();
            return string.Format("{0}:{1}",name,price);
        }
    }
}