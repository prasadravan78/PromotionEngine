namespace PromotionEngine.DomainServices.Tests
{
    using NUnit.Framework;
    using PromotionEngine.DomainServices.ProductService;
    using PromotionEngine.Models;
    using System.Collections.Generic;

    /// <summary>
    /// Tests product related methods.
    /// </summary>
    public class ProductTest
    {
        #region Member Variables

        private IProductService _productService;

        #endregion Member Variables

        #region Constructors

        #endregion Constructors

        #region Public Methods 

        [SetUp]
        public void Setup()
        {
            _productService = new ProductService();
        }

        /// <summary>
        /// Tests total price method for products.
        /// </summary>
        /// <returns></returns>
        [Test]
        public void GetTotalProductPriceTest()
        {
            List<Product> products = new List<Product>();

            products.Add(new Product {
                Id= 1,
                Quantity = 5,
            });

            products.Add(new Product
            {
                Id = 1,
                Quantity = 5,
            });

            products.Add(new Product
            {
                Id = 1,
                Quantity = 5,
            });

            products.Add(new Product
            {
                Id = 1,
                Quantity = 5,
            });

            Assert.AreEqual(100, _productService.GetTotalProductPrice(products));
        }

        #endregion Public Methods
    }
}