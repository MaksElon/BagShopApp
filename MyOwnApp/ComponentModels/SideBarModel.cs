using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.ComponentModels
{
    public class SideBarModel
    {
        public IEnumerable<TypeOfProduct> TypeOfProducts { get; set; }
        public IEnumerable<Material> Materials { get; set; }
        public IEnumerable<ProductModel> ProductModels { get; set; }
        public IEnumerable<Producer> Producers { get; set; }
        public int MaxPrice { get; set; }
        public int MinPrice { get; set; }
    }
}
