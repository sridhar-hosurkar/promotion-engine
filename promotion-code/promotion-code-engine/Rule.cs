using PromotionCodeModels;
using System;
using System.Collections.Generic;

namespace PromotionCodeEngine
{
    public class Rule : IRule
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

        public double CalculateDiscount(Cart cart)
        {
            throw new NotImplementedException();
        }

        public bool IsApplicable(Cart cart)
        {
            throw new NotImplementedException();
        }
    }
}
