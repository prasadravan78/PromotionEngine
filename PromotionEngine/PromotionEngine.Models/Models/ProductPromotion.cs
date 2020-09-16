namespace PromotionEngine.Models.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Holds the detail of Product Promotion entity.
    /// </summary>
    public class ProductPromotion
    {
        #region Properties

        /// <summary>
        /// Gets or Sets the ProductPromotionRelationId.
        /// </summary>
        public int ProductPromotionRelationId { get; set; }

        /// <summary>
        /// Gets or Sets the ApplyStartDate.
        /// </summary>
        public DateTime ApplyStartDate { get; set; }

        /// <summary>
        /// Gets or Sets the ApplyEndDate.
        /// </summary>
        public DateTime ApplyEndDate { get; set; }

        #endregion Properties
    }
}
