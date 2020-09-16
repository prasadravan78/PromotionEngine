namespace PromotionEngine.Common
{
    using System;

    /// <summary>
    /// Defines constants being used across application.
    /// </summary>
    public class Constants
    {
        #region PromotionType

        /// <summary>
        /// Contains constants for Promotion Tyoe.
        /// </summary>
        public enum PromotionType
        { 
            QuantityPromotion,
            PercentagePromotion,
            RelatedProductPromotion
        }

        #endregion PromotionType  
    }
}
