using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.ViewModels
{
    public class CartModel
    {
        public LayoutViewModel LayoutModel { get; set; }
        public Order GetOrder { get; set; }
        public List<ProductImage> GetProductImages { get; set; }
        public List<Product> GetProducts { get; set; }
    }
}
