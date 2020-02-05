using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Interfaces
{
    public interface IProductImages
    {
        IEnumerable<ProductImage> GetProductImages { get; set; }
        bool DeleteProductImage(int id);
        bool AddProductImage(ProductImage productImage);
    }
}
