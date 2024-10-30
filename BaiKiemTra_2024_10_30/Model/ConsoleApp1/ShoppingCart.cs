using System;
using System.Collections.Generic;
namespace ProductManagement{
    public class ShoppingCart{
        public List<Product> obj {  get; set; }
        public void addProduct(Product product)
        {
            this.obj.Add(product);
        }
        public void  removeProduct(Product product)
        {
            this.obj.Remove(product);
        }
        
    }
}