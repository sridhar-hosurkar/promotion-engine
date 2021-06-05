using PromotionCodeModels;
using System.Collections.Generic;

namespace PromotionCodeEngine
{
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
