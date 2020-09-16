namespace PromotionEngine.DomainServices.ProductService
{
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
