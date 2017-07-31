using System;
using System.Collections.Generic;

namespace Ultra.Webshop.Domain
{
    public class Product
    {
        public string ProductId { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public IList<Picture> Pictures { get; set; }

        public string Reference { get; set; }

        public string Description { get; set; }

        public Brand Brand { get; set; }

        public IList<Product> RelatedProducts { get; set; }

        public ProductSize Size { get; set; }

        public decimal Weigth { get; set; }
    }
}
