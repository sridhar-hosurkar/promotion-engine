using PromotionCodeModels;
using System.Collections.Generic;

namespace PromotionCodeEngine
{

    /// <summary>
    /// Load Promotions from database
    /// It can be made as singleton
    /// </summary>
    public class PromotionHandler
    {
        public static List<Promotion> Promotions;

        public static void LoadPromotions(List<Promotion> promotions)
        {
            Promotions = promotions;
        }

        public static List<Promotion> GetPromotions()
        {
            return Promotions;
        }
    }
}
