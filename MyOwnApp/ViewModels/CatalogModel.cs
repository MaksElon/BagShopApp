using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.ViewModels
{
    public class CatalogModel
    {
        public List<Product> GetProducts { get; set; }
        public int ProductsCount { get; set; }
        public List<Producer> GetProducers { get; set; }
        public int ProducersCount { get; set; }
    }
}
