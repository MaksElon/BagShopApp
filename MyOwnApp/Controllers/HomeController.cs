using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyOwnApp.Data.Interfaces;
using MyOwnApp.Models;
using MyOwnApp.ViewModels;

namespace MyOwnApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProducts _products;
        private readonly IUsers _users;
        private readonly IProducers _producers;
        private readonly IProductImages _productImages;
        private readonly ITypeOfProducts _type;
        private readonly IDimensions _dimensions;
        private readonly ISubCategories _subCategories;

        public HomeController(ISubCategories subCategories,ITypeOfProducts type, IProducts products, IUsers users, IProducers producers, IProductImages productImages)
        {
            _products = products;
            _users = users;
            _producers = producers;
            _productImages = productImages;
            _type = type;
            _subCategories = subCategories;
        }
        public IActionResult Index()
        {
            MainPageModel obj = new MainPageModel();
            obj.GetProducers = _producers.GetProducers.ToList();
            obj.ProducersCount = _producers.GetProducers.Count();
            obj.GetRecommendedProducts = _products.GetProducts.ToList();
            obj.RecommendedProductsCount = 9;
            obj.GetTypeOfProducts = _type.GetTypeOfProducts.ToList();
            obj.TypeCount = _type.GetTypeOfProducts.Count();
            obj.GetSubCategories = _subCategories.GetSubCategories.ToList();
            obj.SubCategoriesCount = _subCategories.GetSubCategories.Count();
            return View(obj);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
