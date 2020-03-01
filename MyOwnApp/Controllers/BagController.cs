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
        private readonly IProductOrders _productOrders;

        public BagController(IProductOrders productOrders,ITypeOfProducts type, ISubCategories subCategories, IOrders orders, IUserProfiles userProfiles, IDimensions dimensions, IProducts products, IUsers users, IProducers producers, IProductModels productModels, IProductImages productImages, IMaterials materials)
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
            _productOrders = productOrders;
        }

        [HttpGet]
        public IActionResult Catalog()
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
            obj.GetProductImages = _productImages.GetProductImages.ToList();
            obj.ProductImagesCount = _productImages.GetProductImages.Count();
            return View(obj);
        }
        [HttpGet]
        public IActionResult Cart()
        {
            var info = HttpContext.Session.GetString("SessionUser");
            if (info != null)
            {
                var result = JsonConvert.DeserializeObject<UserInfo>(info);

                CartModel obj = new CartModel();
                LayoutViewModel layoutModel = new LayoutViewModel();
                layoutModel.GetProducers = _producers.GetProducers.ToList();
                layoutModel.ProducersCount = _producers.GetProducers.Count();
                layoutModel.GetTypeOfProducts = _type.GetTypeOfProducts.ToList();
                layoutModel.TypeCount = _type.GetTypeOfProducts.Count();
                layoutModel.GetSubCategories = _subCategories.GetSubCategories.ToList();
                layoutModel.SubCategoriesCount = _subCategories.GetSubCategories.Count();
                obj.LayoutModel = layoutModel;
                var order = _orders.GetOrders.FirstOrDefault(o => o.UserId == result.UserId);
                obj.GetOrder = order;
                var prOr = _productOrders.GetProductOrders.Where(t => t.OrderId == order.Id).ToList();
                obj.GetProducts = _products.GetProducts.Where(p => prOr.All(p2 => p2.ProductId == p.Id)).ToList();
                obj.GetProductImages = _productImages.GetProductImages.ToList();
                return View(obj);
            }
            return RedirectToAction("AccountAction", "Account");
        }
        [HttpGet]
        [Route("Bag/Product/{id}")]
        public IActionResult Product(int id)
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
            obj.GetProduct = _products.GetProducts.FirstOrDefault(p => p.Id == id);
            obj.GetProductImages = _productImages.GetProductImages.Where(t => t.ProductId == id).ToList();
            return View(obj);
        }
    }
}