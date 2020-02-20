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

        public Category(IMaterials material, ITypeOfProducts types, IProductModels models)
        {
            _material = material;
            _types = types;
            _models = models;
        }
        public IViewComponentResult Invoke()
        {
            var category = new SideBarModel();
            category.Materials = _material.GetMaterials;
            category.ProductModels = _models.GetModels;
            category.TypeOfProducts = _types.GetTypeOfProducts;
            return View(category);
        }
    }
}
