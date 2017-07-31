using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultra.Webshop.Domain
{
    public class Order
    {
        public int Id { get; set; }

        public IList<OrderedProduct> OrderedProducts { get; set; }

        public decimal Amount { get; set; }

        public string UserId { get; set; }

        public string Status { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime DeliveryDate { get; set; }
    }
}
