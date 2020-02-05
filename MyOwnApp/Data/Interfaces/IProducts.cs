using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Interfaces
{
    public interface IProducts
    {
        IEnumerable<Product> GetProducts { get; set; }
        Product GetProduct(int id);
        bool DeleteProduct(int id);
        bool AddProduct(Product product);
        bool EditProduct(int id,Product product);

    }
}
