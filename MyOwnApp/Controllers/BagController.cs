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
        private readonly IOrders _orders;
        private readonly ITypeOfProducts _type;
        private readonly ISubCategories _subCategories;
        public BagController(ITypeOfProducts type, ISubCategories subCategories, IOrders orders,IUserProfiles userProfiles,IDimensions dimensions,IProducts products, IUsers users, IProducers producers, IProductModels productModels, IProductImages productImages, IMaterials materials)
        {
            _products = products;
            _users = users;
            _producers = producers;
            _productModels = productModels;
            _productImages = productImages;
            _materials = materials;
            _dimensions = dimensions;
            _userProfiles = userProfiles;
            _orders = orders;
            _type = type;
            _subCategories = subCategories;
        }
        public ViewResult GetMainPage()
        {
            
            MainPageModel obj = new MainPageModel();
            LayoutViewModel layoutModel = new LayoutViewModel();
            layoutModel.GetProducers = _producers.GetProducers.ToList();
            layoutModel.ProducersCount = _producers.GetProducers.Count();
            layoutModel.GetTypeOfProducts = _type.GetTypeOfProducts.ToList();
            layoutModel.TypeCount = _type.GetTypeOfProducts.Count();
            layoutModel.GetSubCategories = _subCategories.GetSubCategories.ToList();
            layoutModel.SubCategoriesCount = _subCategories.GetSubCategories.Count();
            obj.LayoutModel = layoutModel;
            obj.GetRecommendedProducts = _products.GetProducts.ToList();
            obj.RecommendedProductsCount = 9;
            return View(obj);
        }
        [HttpGet]
        public ViewResult Catalog()
        {
            CatalogModel obj = new CatalogModel();
            LayoutViewModel layoutModel = new LayoutViewModel();
            layoutModel.GetProducers = _producers.GetProducers.ToList();
            layoutModel.ProducersCount = _producers.GetProducers.Count();
            layoutModel.GetTypeOfProducts = _type.GetTypeOfProducts.ToList();
            layoutModel.TypeCount = _type.GetTypeOfProducts.Count();
            layoutModel.GetSubCategories = _subCategories.GetSubCategories.ToList();
            layoutModel.SubCategoriesCount = _subCategories.GetSubCategories.Count();
            obj.LayoutModel = layoutModel;
            obj.GetProducts = _products.GetProducts.ToList();
            obj.ProductsCount = _products.GetProducts.Count();
            return View(obj);
        }
        [HttpGet]
        public ViewResult Cart()
        {
            CartModel obj = new CartModel();
            LayoutViewModel layoutModel = new LayoutViewModel();
            layoutModel.GetProducers = _producers.GetProducers.ToList();
            layoutModel.ProducersCount = _producers.GetProducers.Count();
            layoutModel.GetTypeOfProducts = _type.GetTypeOfProducts.ToList();
            layoutModel.TypeCount = _type.GetTypeOfProducts.Count();
            layoutModel.GetSubCategories = _subCategories.GetSubCategories.ToList();
            layoutModel.SubCategoriesCount = _subCategories.GetSubCategories.Count();
            obj.LayoutModel = layoutModel;
            obj.GetOrders = _orders.GetOrders.ToList();
            obj.OrdersCount = _orders.GetOrders.Count();
            return View(obj);
        }
        [HttpGet]
        public ViewResult Product()
        {
            ProductModel obj = new ProductModel();
            LayoutViewModel layoutModel = new LayoutViewModel();
            layoutModel.GetProducers = _producers.GetProducers.ToList();
            layoutModel.ProducersCount = _producers.GetProducers.Count();
            layoutModel.GetTypeOfProducts = _type.GetTypeOfProducts.ToList();
            layoutModel.TypeCount = _type.GetTypeOfProducts.Count();
            layoutModel.GetSubCategories = _subCategories.GetSubCategories.ToList();
            layoutModel.SubCategoriesCount = _subCategories.GetSubCategories.Count();
            obj.LayoutModel = layoutModel;

            return View(obj);
        }
    }
}