using AutoFixture;
using PromotionCodeModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionCodeEngine.Tests
{
    public class Data
    {
        public static List<Promotion> GetSimplePromotions()
        {
            var promotions = new List<Promotion>();
            promotions.Add(new Promotion {PromotionCode = "P1", Item = new List<Item>() { new Item { Quantity = 3, SKUId = "A" } } });
            promotions.Add(new Promotion { PromotionCode = "P2", Item = new List<Item>() { new Item { Quantity = 2, SKUId = "B" } } });
            promotions.Add(new Promotion
            {
                PromotionCode = "P3",
                Item = new List<Item>() {
                    new Item { Quantity = 1, SKUId = "C" },
                    new Item { Quantity = 1, SKUId = "D" }
                }
            });
            return promotions;
        }

        public static List<Promotion> GetComplexPromotions()
        {
            var promotions = new List<Promotion>();
            promotions.Add(new Promotion { Item = new List<Item>() { new Item { Quantity = 3, SKUId = "A" } } });
            promotions.Add(new Promotion { Item = new List<Item>() { new Item { Quantity = 2, SKUId = "B" } } });
            promotions.Add(new Promotion
            {
                Item = new List<Item>() {
                    new Item { Quantity = 1, SKUId = "C" },
                    new Item { Quantity = 1, SKUId = "D" }
                }
            });
            return promotions;
        }
    }
}
