using System.Collections.Generic;

namespace LearnCSharp
{
    public class ProductNameComparer:IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}