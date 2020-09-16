namespace PromotionEngine.Models.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class PercentagePromotion : ProductPromotion
    {
        #region Properties

        /// <summary>
        /// Gets or Sets the PromotionQunatity.
        /// </summary>
        public int PromotionQunatity { get; set; }

        /// <summary>
        /// Gets or Sets the Percentage.
        /// </summary>
        public double Percentage { get; set; }

        #endregion Properties
    }
}
