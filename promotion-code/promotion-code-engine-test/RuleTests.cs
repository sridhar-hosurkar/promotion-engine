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
            PromotionHandler.LoadPromotions(Data.GetSimplePromotions());
            var isApplicable = rule.IsApplicable(Data.GetCartScenerioApplicableA());
            Assert.True(isApplicable);
        }

        [Fact()]
        public void IsApplicablePositiveScenerioBTest()
        {
            PromotionHandler.LoadPromotions(Data.GetSimplePromotions());
            var isApplicable = rule.IsApplicable(Data.GetCartScenerioApplicableB());
            Assert.True(isApplicable);
        }

        [Fact()]
        public void IsApplicablePositiveScenerioCTest()
        {
            PromotionHandler.LoadPromotions(Data.GetSimplePromotions());
            var isApplicable = rule.IsApplicable(Data.GetCartScenerioApplicableC());
            Assert.True(isApplicable);
        }

        [Fact()]
        public void IsApplicableNegativeATest()
        {
            PromotionHandler.LoadPromotions(Data.GetSimplePromotions());
            var isApplicable = rule.IsApplicable(Data.GetCartScenerioNotApplicableA());
            Assert.False(isApplicable);
        }

        [Fact()]
        public void IsApplicableNegativeBTest()
        {
            PromotionHandler.LoadPromotions(Data.GetSimplePromotions());
            var isApplicable = rule.IsApplicable(Data.GetCartScenerioNotApplicableB());
            Assert.False(isApplicable);
        }

        [Fact()]
        public void IsApplicableNegativeCTest()
        {
            PromotionHandler.LoadPromotions(Data.GetSimplePromotions());
            var isApplicable = rule.IsApplicable(Data.GetCartScenerioNotApplicableC());
            Assert.False(isApplicable);
        }

        [Fact()]
        public void LoadPromotionsTest()
        {
            PromotionHandler.LoadPromotions(Data.GetSimplePromotions());
            Assert.Equal(3, PromotionHandler.GetPromotions().Count);

        }

        [Fact()]
        public void CalculateDiscountPositiveScenerioATest()
        {
            PromotionHandler.LoadPromotions(Data.GetSimplePromotions());
            Rule.LoadProducts(Data.GetProducts());
            var CalculateDiscount = rule.CalculateDiscount(Data.GetCartScenerioApplicableA());
            Assert.Equal(205.0,CalculateDiscount);
        }

        [Fact()]
        public void CalculateDiscountPositiveScenerioBTest()
        {
            PromotionHandler.LoadPromotions(Data.GetSimplePromotions());
            Rule.LoadProducts(Data.GetProducts());
            var CalculateDiscount = rule.CalculateDiscount(Data.GetCartScenerioApplicableB());
            Assert.Equal(370.0,CalculateDiscount);
        }

        [Fact()]
        public void CalculateDiscountPositiveScenerioCTest()
        {
            PromotionHandler.LoadPromotions(Data.GetSimplePromotions());
            Rule.LoadProducts(Data.GetProducts());
            var CalculateDiscount = rule.CalculateDiscount(Data.GetCartScenerioApplicableC());
            Assert.Equal(280.0,CalculateDiscount);
        }

        [Fact()]
        public void CalculateDiscountNegativeATest()
        {
            PromotionHandler.LoadPromotions(Data.GetSimplePromotions());
            Rule.LoadProducts(Data.GetProducts());
            var CalculateDiscount = rule.CalculateDiscount(Data.GetCartScenerioNotApplicableA());
            Assert.Equal(130.0,CalculateDiscount);
        }

        [Fact()]
        public void CalculateDiscountNegativeBTest()
        {
            PromotionHandler.LoadPromotions(Data.GetSimplePromotions());
            Rule.LoadProducts(Data.GetProducts());
            var CalculateDiscount = rule.CalculateDiscount(Data.GetCartScenerioNotApplicableB());
            Assert.Equal(100.0,CalculateDiscount);
        }

        [Fact()]
        public void CalculateDiscountNegativeCTest()
        {
            PromotionHandler.LoadPromotions(Data.GetSimplePromotions());
            Rule.LoadProducts(Data.GetProducts());
            var CalculateDiscount = rule.CalculateDiscount(Data.GetCartScenerioNotApplicableC());
            Assert.Equal(115.0,CalculateDiscount);
        }

        /*Complex Promotions*/
        [Fact()]
        public void CalculateDiscountPositiveComplexScenerioATest()
        {
            PromotionHandler.LoadPromotions(Data.GetComplexPromotions());
            Rule.LoadProducts(Data.GetProducts());
            var CalculateDiscount = rule.CalculateDiscount(Data.GetCartScenerioApplicableA());
            Assert.Equal(205.0, CalculateDiscount);
        }

        [Fact()]
        public void CalculateDiscountPositiveComplexScenerioBTest()
        {
            PromotionHandler.LoadPromotions(Data.GetComplexPromotions());
            Rule.LoadProducts(Data.GetProducts());
            var CalculateDiscount = rule.CalculateDiscount(Data.GetCartScenerioComplexApplicableA());
            Assert.Equal(240.0, CalculateDiscount);
        }
    }
}