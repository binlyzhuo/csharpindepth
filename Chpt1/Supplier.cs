using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chpt1
{
    public class Supplier
    {
        public int SupplierID { get; private set; }
        public string Name { get; private set; }

        Supplier()
        { }

        public Supplier(int id, string name)
        {
            SupplierID = id;
            Name = name;
        }

        public static List<Supplier> GetSampleSuppliers()
        {
            return new List<Supplier>()
            {
                new Supplier() {SupplierID = 10,Name = "TAOBAO"}
            };
        } 
    }
}
