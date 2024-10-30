using System;
namespace Shopping
{
    public interface OrderCalculator
    {
        Decimal Total(ShoppingCart obj);
    }
}