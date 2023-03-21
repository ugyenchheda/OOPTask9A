using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask9A
{
    internal class Product
    {
        public Product(int id, string productName)
        {
            Id = id;
            ProductName = productName;
        }

        public int Id { get; set; }
        public string ProductName { get; set; }
    }
}
