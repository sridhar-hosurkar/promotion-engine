using ExtensionMethods;
using PromotionCodeModels;
using System.Collections.Generic;
using System.Linq;

namespace PromotionCodeEngine
{
    public class Rule : IRule
    {

        public static List<Product> Products;


        public static void LoadProducts(List<Product> products)
        {
            Products = products;
        }

        

        public Cart UpdateCart(Cart cart)
        {
            cart.Items.ForEach(item => item.Price = Products.Single(p => p.SKUId == item.SKUId).Price);
            return cart;
        }


        private static double GetCartCost(Cart actualCart)
        {
            double price = 0;
            actualCart.Items.ForEach(x =>
            {
                price += x.Quantity * x.Price;
            });
            return price;
        }

        private double GetBestDeal(Cart actualCart, IEnumerable<Promotion> promotions)
        {
            var bestPrice = new List<double>();
            if (!promotions.Any())
                return GetCartCost(actualCart);

            foreach (var promotion in promotions)
            {
                var cart = actualCart.DeepClone();
                double price = 0;
                if (promotion.Items.All(x => cart.Items.Any(cartItem =>
                                                      x.Quantity <= cartItem.Quantity && cartItem.SKUId == x.SKUId)))
                {
                    var promoCount = promotion.Items.Select(x => cart.Items.Single(cart => cart.SKUId == x.SKUId).Quantity / x.Quantity).Min();
                    cart.Items.ForEach(item =>
                    {
                        var promoItem = promotion.Items.SingleOrDefault(x => x.SKUId == item.SKUId);
                        if (promoItem != null)
                            item.Quantity -= promoItem.Quantity * promoCount;
                    });
                    price += promotion.Price * promoCount;
                    price += GetBestDeal(cart, promotions.Except(new List<Promotion> { promotion }));
                    bestPrice.Add(price);
                }
                else
                {
                    price += GetCartCost(cart);
                    bestPrice.Add(price);
                    break;
                }

            }

            if (bestPrice.Where(x => x > 0).Count() > 0)
                return bestPrice.Where(x => x > 0).Min();
            return 0;
        }


        public double CalculateDiscount(Cart cart)
        {
            double price = 0;
            UpdateCart(cart);
            if (IsApplicable(cart))
            {
                var applicablePromotions = PromotionHandler.Promotions.Where(promotion =>
                                                promotion.Items.All(x => cart.Items.Any(cartItem =>
                                                     x.Quantity <= cartItem.Quantity && cartItem.SKUId == x.SKUId)));
                price = GetBestDeal(cart, applicablePromotions);
            }
            else
            {
                return GetCartCost(cart);
            }
            return price;
        }

        public bool IsApplicable(Cart cart)
        {
            return PromotionHandler.Promotions.Any(promotion =>
                                                promotion.Items.All(x => cart.Items.Any(cartItem =>
                                                    x.Quantity <= cartItem.Quantity && cartItem.SKUId == x.SKUId)));
        }
    }
}
