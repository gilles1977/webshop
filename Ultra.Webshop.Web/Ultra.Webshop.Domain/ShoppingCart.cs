using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Ultra.Webshop.Domain
{
    public class ShoppingCart
    {
        #region Members

        #endregion

        #region Constructors
        public ShoppingCart()
        {
            Products = new List<OrderedProduct>();
        }

        public ShoppingCart(Product product)
        {
            Products = new List<OrderedProduct>(new [] { new OrderedProduct(product) });
        }
        #endregion

        #region Properties
        /// <summary>
        /// Total price of product contained in the cart plus total subscriptions if any.
        /// </summary>
        [DisplayFormat(DataFormatString = "{0:0.000}")]
        public decimal Total => Math.Round(Products.Sum(p => p.Product.Price), 3);

        /// <summary>
        /// Number of items in the cart.
        /// </summary>
        public int ItemCount => Products.Count;

        /// <summary>
        /// List of products in the cart.
        /// </summary>
        public IList<OrderedProduct> Products { get; }

       
        /// <summary>
        /// Returns product for the selected cart product id.
        /// </summary>
        /// <param name="cartProductId">The cart id of the selected product.</param>
        /// <returns></returns>
        public OrderedProduct this[string cartProductId] => Products.FirstOrDefault(p => p.Product.ProductId == cartProductId);

        #endregion

        #region Methods

        /// <summary>
        /// Add a product to the cart.
        /// </summary>
        /// <param name="orderedProduct">The product to add.</param>
        public void Add(OrderedProduct orderedProduct)
        {
            orderedProduct.Product.ProductId = Guid.NewGuid().ToString();
            Products.Add(orderedProduct);
        }

        /// <summary>
        /// Remove the cart with the selected product id.
        /// </summary>
        /// <param name="productId">The id of the product to remove.</param>
        /// <returns></returns>
        public bool Remove(string productId)
        {
            var product = Products.FirstOrDefault(p => p.Product.ProductId == productId);
            if (product != null)
            {
                return Products.Remove(product);
            }
            return false;
        }

        /// <summary>
        /// Clear products in the cart.
        /// </summary>
        public void Clear()
        {
            Products.Clear();
        }

        #endregion
    }
}
