using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.ViewModels
{
    public class MainPageModel
    {
        public List<Producer> GetProducers { get; set; }
        public int ProducersCount { get; set; }
        public List<Product> GetRecommendedProducts { get; set; }
        public int RecommendedProductsCount { get; set; }
        public List<SubCategory> GetSubCategories { get; set; }
        public int SubCategoriesCount { get; set; }
        public List<TypeOfProduct> GetTypeOfProducts { get; set; }
        public int TypeCount { get; set; }
    }
}
