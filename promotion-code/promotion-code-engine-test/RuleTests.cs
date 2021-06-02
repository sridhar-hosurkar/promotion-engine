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
        public void IsApplicablePositiveScenerioATest()
        {
            Rule.LoadPromotions(Data.GetSimplePromotions());
            var isApplicable = rule.IsApplicable(Data.GetCartScenerioApplicableA());
            Assert.True(isApplicable);
        }

        [Fact()]
        public void IsApplicablePositiveScenerioBTest()
        {
            Rule.LoadPromotions(Data.GetSimplePromotions());
            var isApplicable = rule.IsApplicable(Data.GetCartScenerioApplicableB());
            Assert.True(isApplicable);
        }

        [Fact()]
        public void IsApplicablePositiveScenerioCTest()
        {
            Rule.LoadPromotions(Data.GetSimplePromotions());
            var isApplicable = rule.IsApplicable(Data.GetCartScenerioApplicableC());
            Assert.True(isApplicable);
        }

        [Fact()]
        public void IsApplicableNegativeATest()
        {
            Rule.LoadPromotions(Data.GetSimplePromotions());
            var isApplicable = rule.IsApplicable(Data.GetCartScenerioNotApplicableA());
            Assert.False(isApplicable);
        }

        [Fact()]
        public void IsApplicableNegativeBTest()
        {
            Rule.LoadPromotions(Data.GetSimplePromotions());
            var isApplicable = rule.IsApplicable(Data.GetCartScenerioNotApplicableB());
            Assert.False(isApplicable);
        }

        [Fact()]
        public void IsApplicableNegativeCTest()
        {
            Rule.LoadPromotions(Data.GetSimplePromotions());
            var isApplicable = rule.IsApplicable(Data.GetCartScenerioNotApplicableC());
            Assert.False(isApplicable);
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