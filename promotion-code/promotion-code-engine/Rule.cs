using promotion_code_models;
using System;
using System.Collections.Generic;

namespace promotion_code_engine
{
    public class Rule : IRule
    {
        List<Promotion> Promotions;

        public Rule(List<Promotion> promotions)
        {
            Promotions = promotions;
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
