using PromotionCodeModels;
using System;
using System.Collections.Generic;
using System.Linq;

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
            return Promotions.Select(x => x.Items).Any(promotion =>
                                                cart.Items.Any(cartItem => 
                                                    promotion.All(x => x.Quantity <= cartItem.Quantity && cartItem.SKUId == x.SKUId)));
        }
    }
}
