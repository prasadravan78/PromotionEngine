namespace PromotionEngine.DomainServices.ProductService
{
    using PromotionEngine.Common;
    using PromotionEngine.Models;
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    ///  Provides members to manage product data entities.
    /// </summary>
    public class ProductService : IProductService
    {
        #region Member Variables

        private bool isDisposed = false;

        #endregion Member Variables

        #region Constructors

        /// <summary>
        /// Initializes service with dependencies.
        /// </summary>
        public ProductService()
        {

        }

        #endregion Constructors

        #region Public Methods 

        /// <summary>
        /// Gets list of products.
        /// </summary>
        /// <returns>List of products</returns>
        public List<Product> GetProducts()
        {
            List<Product> products = GetListOfProducts();

            return products;
        }

        /// <summary>
        /// Gets total price for products.
        /// </summary>
        /// <param name="products">List of Products</param>
        /// <returns>Total price of products</returns>
        public double GetTotalProductPrice(List<Product> products)
        {
            double totalPrice = 0.0;

            return totalPrice;
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// Gets list of products.
        /// </summary>
        /// <returns>List of products</returns>
        private List<Product> GetListOfProducts()
        {
            List<Product> products = new List<Product>();

            products.Add(new Product
            {
                Id = 1,
                Name = "A",
                Price = 50
            });

            products.Add(new Product
            {
                Id = 1,
                Name = "B",
                Price = 30
            });

            products.Add(new Product
            {
                Id = 1,
                Name = "C",
                Price = 20
            });

            products.Add(new Product
            {
                Id = 1,
                Name = "D",
                Price = 15
            });

            return products;
        }

        /// <summary>
        /// Gets collection of Qunatity Promotions.
        /// </summary>
        /// <returns>List of Quantity Promotions</returns>
        private List<QuantityPromotion> GetQuantityPromotions()
        {
            List<QuantityPromotion> quantityPromotions = new List<QuantityPromotion>();

            quantityPromotions.Add(new QuantityPromotion
            {
                ProductId = 1,
                PromotionQunatity = 3,
                PromotionPrice = 130,
                PromotionTypeId = (int)Constants.PromotionType.QuantityPromotion,
            });

            quantityPromotions.Add(new QuantityPromotion
            {
                ProductId = 2,
                PromotionQunatity = 2,
                PromotionPrice = 45,
                PromotionTypeId = (int)Constants.PromotionType.QuantityPromotion,
            });

            return quantityPromotions;
        }

        /// <summary>
        /// Gets collection of Percentage Promotions.
        /// </summary>
        /// <returns>List of Percentage Promotions</returns>
        private List<PercentagePromotion> GetPercentagePromotions()
        {
            List<PercentagePromotion> percentagePromotions = new List<PercentagePromotion>();

            return percentagePromotions;
        }

        /// <summary>
        /// Gets collection of Related Product Promotions.
        /// </summary>
        /// <returns>List of Related Product Promotions</returns>
        private List<RelatedProductPromotion> GetRelatedProductPromotions()
        {
            List<RelatedProductPromotion> relatedProductPromotions = new List<RelatedProductPromotion>();

            relatedProductPromotions.Add(new RelatedProductPromotion
            {
                ProductId = 3,
                RelatedProductId = 4,
                PromotionPrice = 30,
                PromotionTypeId = (int)Constants.PromotionType.RelatedProductPromotion,
            });

            return relatedProductPromotions;
        }

        #endregion Private Methods

        #region IDisposable Support

        /// <summary>
        /// Disposes the instance of UnitOfWork.
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!isDisposed)
            {
                if (disposing)
                {
                    //dispose managed state (managed objects).
                    //if (unitOfWork != null)
                    //    unitOfWork.Dispose();
                }

                // free unmanaged resources (unmanaged objects) and override a finalizer below.
                // set large fields to null.

                isDisposed = true;
            }
        }

        /// <summary>
        /// Disposes current instance of the service.
        /// </summary>
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            GC.SuppressFinalize(this);
        }

        #endregion IDisposable Support
    }
}
