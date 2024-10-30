using System;
namespace ProductManagement{
    public interface OrderCalculator
    {
        Decimal Total(ShoppingCart obj);
    }
}