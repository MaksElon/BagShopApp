using Microsoft.AspNetCore.Mvc;
using MyOwnApp.ComponentModels;
using MyOwnApp.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Components
{
    public class Category : ViewComponent
    {
        private readonly IMaterials _material;
        private readonly ITypeOfProducts _types;
        private readonly IProductModels _models;
        private readonly IProducers _producers;
        private readonly IProducts _products;

        public Category(IProducts products,IProducers producers,IMaterials material, ITypeOfProducts types, IProductModels models)
        {
            _material = material;
            _types = types;
            _models = models;
            _producers = producers;
            _products = products;
        }
        public IViewComponentResult Invoke()
        {
            var category = new SideBarModel();
            category.Materials = _material.GetMaterials;
            category.ProductModels = _models.GetModels;
            category.TypeOfProducts = _types.GetTypeOfProducts;
            category.Producers = _producers.GetProducers;
            category.MaxPrice = Convert.ToInt32(_products.GetProducts.Max(p => p.Price));
            category.MinPrice= Convert.ToInt32(_products.GetProducts.Min(p => p.Price));
            return View(category);
        }
    }
}
