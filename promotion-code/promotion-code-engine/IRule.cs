using PromotionCodeModels;

namespace PromotionCodeEngine
{
    public interface IRule
    {
        bool IsApplicable(Cart cart);
        double CalculateDiscount(Cart cart);
    }
}
