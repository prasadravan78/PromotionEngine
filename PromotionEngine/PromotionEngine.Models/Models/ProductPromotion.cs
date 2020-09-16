namespace PromotionEngine.Models
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
        /// Gets or Sets the Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets the ProductId.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or Sets the PromotionTypeId.
        /// </summary>
        public int PromotionTypeId { get; set; }

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
