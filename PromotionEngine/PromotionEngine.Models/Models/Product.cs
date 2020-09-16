using System;

namespace PromotionEngine.Models
{
    /// <summary>
    /// Holds the detail of Product entity.
    /// </summary>
    public class Product
    {
        #region Properties

        /// <summary>
        /// Gets or Sets the Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets the Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets the Quantity.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or Sets the Quantity.
        /// </summary>
        public double Price { get; set; }

        #endregion Properties
    }
}
