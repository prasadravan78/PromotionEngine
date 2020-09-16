namespace PromotionEngine.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class RelatedProductPromotion : ProductPromotion
    {
        #region Properties

        /// <summary>
        /// Gets or Sets the RelatedProductId.
        /// </summary>
        public int RelatedProductId { get; set; }

        /// <summary>
        /// Gets or Sets the PromotionPrice.
        /// </summary>
        public double PromotionPrice { get; set; }

        #endregion Properties
    }
}
