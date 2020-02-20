using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyOwnApp.Data.Interfaces;
using MyOwnApp.Models;
using MyOwnApp.ViewModels;
using Newtonsoft.Json;

namespace MyOwnApp.Controllers
{
    public class BagController : Controller
    {
        private readonly IUserProfiles _userProfiles;
        private readonly IProducts _products;
        private readonly IUsers _users;
        private readonly IProducers _producers;
        private readonly IProductModels _productModels;
        private readonly IProductImages _productImages;
        private readonly IMaterials _materials;
        private readonly IDimensions _dimensions;

        public BagController(IUserProfiles userProfiles,IDimensions dimensions,IProducts products, IUsers users, IProducers producers, IProductModels productModels, IProductImages productImages, IMaterials materials)
        {
            _products = products;
            _users = users;
            _producers = producers;
            _productModels = productModels;
            _productImages = productImages;
            _materials = materials;
            _dimensions = dimensions;
            _userProfiles = userProfiles;
        }
        public ViewResult GetMainPage()
        {
            
            MainPageModel obj = new MainPageModel();
            obj.GetProducers = _producers.GetProducers.ToList();
            obj.ProducersCount = _producers.GetProducers.Count();
            obj.GetRecommendedProducts = _products.GetProducts.ToList();
            obj.RecommendedProductsCount = 9;
            return View(obj);
        }
        [HttpGet]
        public ViewResult Catalog()
        {
            CatalogModel obj = new CatalogModel();
            obj.GetProducers = _producers.GetProducers.ToList();
            obj.ProducersCount = _producers.GetProducers.Count();
            obj.GetProducts = _products.GetProducts.ToList();
            obj.ProductsCount = _products.GetProducts.Count();
            return View(obj);
        }
    }
}