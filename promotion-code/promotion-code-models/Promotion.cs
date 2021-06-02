using System.Collections.Generic;

namespace PromotionCodeModels
{
    public class Promotion
    {
        public string PromotionCode { get; set; }
        public List<Item> Items { get; set; }
        public double Price { get; set; }
    }
}
