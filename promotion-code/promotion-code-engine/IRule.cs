using promotion_code_models;

namespace promotion_code_engine
{
    public interface IRule
    {
        bool IsApplicable(Cart cart);
        double CalculateDiscount(Cart cart);
    }
}
