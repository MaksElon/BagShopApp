using MyOwnApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.ViewModels
{
    public class AdminProductsModel
    {
        public string AdminName { get; set; }
        public List<AdminProduct> Products { get; set; }
        public AddDimensionModel AddDimensionModel { get; set; }
        public AddMaterialModel AddMaterialModel { get; set; }
        public AddModelModel AddModelModel { get; set; }
        public AddProducerModel AddProducerModel { get; set; }
        public AddProductModel AddProductModel { get; set; }
        public AddTypeModel AddTypeModel { get; set; }
    }
}
