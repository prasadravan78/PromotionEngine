namespace PromotionEngine.Models.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Holds the detail of Product Promotion Relation entity.
    /// </summary>
    public class ProductPromotionRelation
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

        #endregion Properties
    }
}
