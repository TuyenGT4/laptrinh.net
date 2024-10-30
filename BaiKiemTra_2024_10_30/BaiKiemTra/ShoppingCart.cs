using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiKiemTra
{
    public class ShoppingCart
    {
        public List<Product> Products { get; set; }
        public ShoppingCart()
        {
            Products = new List<Product>();
        }

        //phương thức thêm sản phẩm
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        //phương thức xóa sản phẩm khỏi list
        public void RemoveProduct(Product product)
        {
            Products.Remove(product);
        }

        public List<Product> GetProducts()
        {
            return Products;
        }
        // phương thức xóa all
        public void Clear()
        {
            Products.Clear();
        }
    }
}
