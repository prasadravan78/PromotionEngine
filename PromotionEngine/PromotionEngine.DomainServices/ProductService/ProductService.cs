namespace PromotionEngine.DomainServices.ProductService
{
    using PromotionEngine.Common;
    using PromotionEngine.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
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
            var quantityPromotions = GetQuantityPromotions();
            var percentagePromotions = GetPercentagePromotions();
            var relatedProductPromotions = GetRelatedProductPromotions();
            var productList = GetProducts();

            foreach (var product in products)
            {
                var originalProduct = productList.Where(k => k.Id == product.Id).FirstOrDefault();
                if (quantityPromotions.Select(k => k.ProductId).ToList().Contains(product.Id))
                {
                    // Gets price for quantity Promotion.
                    var quantityPromotion = quantityPromotions.Where(k => k.ProductId == product.Id).FirstOrDefault();

                    if (product.Quantity > 0)
                    {
                        totalPrice += product.Quantity / quantityPromotion.PromotionQunatity * quantityPromotion.PromotionPrice;
                        totalPrice += product.Quantity % quantityPromotion.PromotionQunatity * originalProduct.Price;
                    }                    
                }
                else if (percentagePromotions.Select(k => k.ProductId).ToList().Contains(product.Id))
                {
                    // Gets price for percentage promotion.
                    var percentagePromotion = percentagePromotions.Where(k => k.ProductId == product.Id).FirstOrDefault();

                    if (product.Quantity > 0)
                    {
                        totalPrice += (product.Quantity / percentagePromotion.PromotionQunatity) * (100 + percentagePromotion.Percentage) / 100;
                        totalPrice += (product.Quantity % percentagePromotion.PromotionQunatity) * originalProduct.Price;
                    }
                }
                else if (relatedProductPromotions.Select(k => k.ProductId).ToList().Contains(product.Id))
                {
                    // Gets price for product relation promotion.
                    var relatedProductPromotion = relatedProductPromotions.Where(k => k.ProductId == product.Id).FirstOrDefault();
                    var relatedOriginalProduct = productList.Where(k => k.Id == relatedProductPromotion.RelatedProductId).FirstOrDefault();

                    if (products.Select(k => k.Id).ToList().Contains(relatedProductPromotion.RelatedProductId))
                    {
                        var productQuantity = product.Quantity;
                        var relatedProduct = products.Where(k => k.Id == relatedProductPromotion.RelatedProductId).FirstOrDefault();

                        if (productQuantity > 0)
                        {
                            if (relatedProduct != null &&
                                relatedProduct.Quantity > 0)
                            {
                                if (productQuantity > relatedProduct.Quantity)
                                {
                                    totalPrice += relatedProduct.Quantity * relatedProductPromotion.PromotionPrice;
                                    totalPrice += (productQuantity - relatedProduct.Quantity) * originalProduct.Price;
                                }
                                else if (productQuantity < relatedProduct.Quantity)
                                {
                                    totalPrice += productQuantity * relatedProductPromotion.PromotionPrice;
                                    totalPrice += (relatedProduct.Quantity - productQuantity) * relatedOriginalProduct.Price;
                                }
                                else
                                {
                                    totalPrice += productQuantity * relatedProductPromotion.PromotionPrice;
                                }
                            }
                            else
                            {
                                totalPrice += productQuantity * originalProduct.Price;
                            }
                        }
                        else
                        {
                            if (relatedProduct != null &&
                                relatedProduct.Quantity > 0)
                            {
                                totalPrice += relatedProduct.Quantity * relatedOriginalProduct.Price;
                            }
                        }
                    }
                }
                else
                {
                    if (!relatedProductPromotions.Select(k => k.RelatedProductId ).ToList().Contains(product.Id) &&
                        product.Quantity > 0)
                    {
                        totalPrice += product.Quantity * originalProduct.Price;
                    }
                }
            }

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
                Id = 2,
                Name = "B",
                Price = 30
            });

            products.Add(new Product
            {
                Id = 3,
                Name = "C",
                Price = 20
            });

            products.Add(new Product
            {
                Id = 4,
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
