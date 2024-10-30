using System;
using System.Collections.Generic;
namespace ProductManagement{
    public class ShoppingCart{
        public List<Product> obj {  get; set; }
        private OrderCalculator orderCalculator;

        public ShoppingCart(OrderCalculator calculator)
        {
            obj = new List<Product>();
            orderCalculator = calculator;
        }
        public void addProduct(Product product)
        {
            this.obj.Add(product);
        }
        public void  removeProduct(Product product)
        {
            this.obj.Remove(product);
        }
        public decimal GetTotalOrderValue()
        {
            return orderCalculator.Total(this);
        }
    }
}