namespace PromotionEngine.Models.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;


    public class QuantityPromotion : ProductPromotion
    {
        #region Properties

        /// <summary>
        /// Gets or Sets the PromotionQunatity.
        /// </summary>
        public int PromotionQunatity { get; set; }

        /// <summary>
        /// Gets or Sets the PromotionPrice.
        /// </summary>
        public double PromotionPrice { get; set; }

        #endregion Properties
    }
}
