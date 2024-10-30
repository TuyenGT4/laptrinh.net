using System;
namespace ProductManagement
{
    public class Order : OrderCalculator
    {
        public decimal Total(ShoppingCart obj)
        {
            decimal total = 0;
            foreach (var product in obj.obj)
            {
                total += product.Price * product.Quantity;
            }
            return total;
        }
    }
}