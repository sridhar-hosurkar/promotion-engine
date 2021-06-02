using AutoFixture;
using PromotionCodeEngine;
using PromotionCodeModels;
using System.Collections.Generic;
using Xunit;

namespace PromotionCodeEngine.Tests
{
    public class RuleTests
    {
        IRule rule;
        List<Promotion> Promotions { get; set; }


        public RuleTests()
        {
            rule = new Rule();
        }

        [Fact()]
        public void IsApplicableTest()
        {
            rule.IsApplicable(new Cart());
        }

        [Fact()]
        public void CalculateDiscountTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void LoadPromotionsTest()
        {
            Rule.LoadPromotions(Data.GetSimplePromotions());
            Assert.Equal(3, Rule.GetPromotions().Count);

        }
    }
}