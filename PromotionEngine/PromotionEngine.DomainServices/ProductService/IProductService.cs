namespace PromotionEngine.DomainServices.ProductService
{
    using PromotionEngine.Models;
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Exposes members to manage product data entities.
    /// </summary>
    public interface IProductService : IDisposable
    {
        /// <summary>
        /// Gets list of products.
        /// </summary>
        /// <returns>List of products</returns>
        List<Product> GetProducts();

        /// <summary>
        /// Gets total price for the products.
        /// </summary>
        /// <param name="products">List of Products</param>
        /// <returns>Total price of products</returns>
        double GetTotalProductPrice(List<Product> products);
    }
}
