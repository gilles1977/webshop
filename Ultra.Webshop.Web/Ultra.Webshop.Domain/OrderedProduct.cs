namespace Ultra.Webshop.Domain
{
    public class OrderedProduct
    {
        public OrderedProduct(Product product, int amount = 1)
        {
            Product = product;
            Amount = amount;
        }

        public Product Product { get; set; }

        public int Amount { get; set; }
    }
}