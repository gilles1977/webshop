using System.Collections.Generic;

namespace Ultra.Webshop.Domain
{
    public class ProductSize
    {
        public SizeType SizeType { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Value { get; set; }
    }

    public enum SizeType
    {
        None,
        Garment,
        Shoe
    }
}