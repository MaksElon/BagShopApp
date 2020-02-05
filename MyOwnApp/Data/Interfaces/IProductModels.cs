using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Interfaces
{
    public interface IProductModels
    {
        IEnumerable<ProductModel> GetModels { get; set; }
        bool DeleteModel(int id);
        bool AddModel(ProductModel productModel);
    }
}
