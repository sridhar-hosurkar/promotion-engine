using System;

namespace PromotionCodeModels
{
    [Serializable]
    public class Item
    {
        public string SKUId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
