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
        private readonly IUserProfiles _userProfiles;
        private readonly IProducts _products;
        private readonly IUsers _users;
        private readonly IProducers _producers;
        private readonly IProductModels _productModels;
        private readonly IProductImages _productImages;
        private readonly IMaterials _materials;
        private readonly IDimensions _dimensions;

        public HomeController(IUserProfiles userProfiles, IDimensions dimensions, IProducts products, IUsers users, IProducers producers, IProductModels productModels, IProductImages productImages, IMaterials materials)
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
        public IActionResult Index()
        {
            MainPageModel obj = new MainPageModel();
            obj.GetProducers = _producers.GetProducers.ToList();
            obj.ProducersCount = _producers.GetProducers.Count();
            obj.GetRecommendedProducts = _products.GetProducts.ToList();
            obj.RecommendedProductsCount = 9;
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
