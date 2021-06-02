﻿using AutoFixture;
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
            promotions.Add(new Promotion { PromotionCode = "P1", Items = new List<Item>() { new Item { Quantity = 3, SKUId = "A" } } });
            promotions.Add(new Promotion { PromotionCode = "P2", Items = new List<Item>() { new Item { Quantity = 2, SKUId = "B" } } });
            promotions.Add(new Promotion
            {
                PromotionCode = "P3",
                Items = new List<Item>() {
                    new Item { Quantity = 1, SKUId = "C" },
                    new Item { Quantity = 1, SKUId = "D" }
                }
            });
            return promotions;
        }

        public static List<Promotion> GetComplexPromotions()
        {
            var promotions = new List<Promotion>();
            promotions.Add(new Promotion { PromotionCode = "P1", Items = new List<Item>() { new Item { Quantity = 3, SKUId = "A" } } });
            promotions.Add(new Promotion { PromotionCode = "P2", Items = new List<Item>() { new Item { Quantity = 2, SKUId = "B" } } });
            promotions.Add(new Promotion
            {
                PromotionCode = "P3",
                Items = new List<Item>() {
                    new Item { Quantity = 1, SKUId = "C" },
                    new Item { Quantity = 1, SKUId = "D" }
                }
            });
            return promotions;
        }

        public static List<Product> GetProducts()
        {
            var products = new List<Product>();
            products.Add(new Product { Price = 50, SKUId = "A" });
            products.Add(new Product { Price = 30, SKUId = "B" });
            products.Add(new Product { Price = 20, SKUId = "C" });
            products.Add(new Product { Price = 15, SKUId = "D" });
            return products;
        }

        public static Cart GetCartScenerioApplicableA()
        {
            var cart = new Cart();
            cart.Items = new List<Item>();
            cart.Items.Add(new Item { Quantity = 3, SKUId = "A" });
            cart.Items.Add(new Item { Quantity = 2, SKUId = "B" });
            cart.Items.Add(new Item { Quantity = 1, SKUId = "C" });
            cart.Items.Add(new Item { Quantity = 1, SKUId = "D" });
            return cart;
        }

        public static Cart GetCartScenerioApplicableB()
        {
            var cart = new Cart();
            cart.Items = new List<Item>();
            cart.Items.Add(new Item { Quantity = 5, SKUId = "A" });
            cart.Items.Add(new Item { Quantity = 5, SKUId = "B" });
            cart.Items.Add(new Item { Quantity = 1, SKUId = "C" });
            return cart;
        }

        public static Cart GetCartScenerioApplicableC()
        {
            var cart = new Cart();
            cart.Items = new List<Item>();
            cart.Items.Add(new Item { Quantity = 3, SKUId = "A" });
            cart.Items.Add(new Item { Quantity = 5, SKUId = "B" });
            cart.Items.Add(new Item { Quantity = 1, SKUId = "C" });
            cart.Items.Add(new Item { Quantity = 1, SKUId = "D" });
            return cart;
        }

        public static Cart GetCartScenerioNotApplicableA()
        {
            var cart = new Cart();
            cart.Items = new List<Item>();
            cart.Items.Add(new Item { Quantity = 2, SKUId = "A" });
            cart.Items.Add(new Item { Quantity = 1, SKUId = "B" });
            return cart;
        }

        public static Cart GetCartScenerioNotApplicableB()
        {
            var cart = new Cart();
            cart.Items = new List<Item>();
            cart.Items.Add(new Item { Quantity = 1, SKUId = "A" });
            cart.Items.Add(new Item { Quantity = 1, SKUId = "B" });
            cart.Items.Add(new Item { Quantity = 1, SKUId = "C" });
            return cart;
        }

        public static Cart GetCartScenerioNotApplicableC()
        {
            var cart = new Cart();
            cart.Items = new List<Item>();
            cart.Items.Add(new Item { Quantity = 2, SKUId = "A" });
            cart.Items.Add(new Item { Quantity = 1, SKUId = "D" });
            return cart;
        }
    }
}
