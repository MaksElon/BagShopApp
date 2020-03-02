using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.ViewModels
{
    public class ProductViewModel
    {
        public LayoutViewModel LayoutModel { get; set; }
        public Product GetProduct { get; set; }
        public List<ProductImage> GetProductImages { get; set; }
        public Dimension Dimension { get; set; }
        public Material Material { get; set; }
        public TypeOfProduct Type { get; set; }
        public ProductModel Model { get; set; }
        public bool AlreadyLiked { get; set; }
        public bool AlreadyDisliked { get; set; }
        public int LikesCount { get; set; }
        public int DislikesCount { get; set; }
    }
}
