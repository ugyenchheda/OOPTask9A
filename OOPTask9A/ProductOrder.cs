using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask9A
{
    internal class ProductOrder
    {
        public ProductOrder(int placedOrderId, int productId, 
            int quantity, bool shipped, DateTime dateOfShipping)
        {
            PlacedOrderId = placedOrderId;
            ProductId = productId;
            Quantity = quantity;
            Shipped = shipped;
            DateOfShipping = dateOfShipping;
        }

        public int PlacedOrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public bool Shipped { get; set; }
        public DateTime DateOfShipping { get; set; }
    }
}
