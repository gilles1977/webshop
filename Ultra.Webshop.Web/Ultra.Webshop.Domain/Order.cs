using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultra.Webshop.Domain
{
    public class Order
    {
        public IList<OrderItem> Items { get; set; }
    }

    public class OrderItem
    {
        public Product Product { get; set; }

        public decimal Discount { get; set; }

        public int Quantity { get; set; }

        public decimal Price
        {
            get { return Product.Price * Quantity * Discount; }
        }
    }
}
