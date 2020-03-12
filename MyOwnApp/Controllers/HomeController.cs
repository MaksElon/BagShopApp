using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
        private readonly ISubCategories _subCategories;
        private readonly IDimensions _dimensions;

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
            obj.GetRecommendedProducts = _products.GetProducts.ToList();
            obj.RecommendedProductsCount = 9;
            LayoutViewModel layoutModel = new LayoutViewModel();
            var pr = _producers.GetProducers.ToList();
            foreach (var item in pr)
            {
                //item.ImageName = Path.Combine("/Telesyk", item.ImageName);
                item.ImageName = "/Telesyk/" + item.ImageName;
            }
            layoutModel.GetProducers = pr;
            layoutModel.ProducersCount = _producers.GetProducers.Count();
            layoutModel.GetTypeOfProducts = _type.GetTypeOfProducts.ToList();
            layoutModel.TypeCount = _type.GetTypeOfProducts.Count();
            layoutModel.GetSubCategories = _subCategories.GetSubCategories.ToList();
            layoutModel.SubCategoriesCount = _subCategories.GetSubCategories.Count();
            obj.LayoutModel = layoutModel;
            return View(obj);
        }
        [Route("Home/Error/{errorType}")]
        public IActionResult Error(int errorType)
        { 
            ErrorModel errorModel=new ErrorModel();
            if (errorType == 1)
                errorModel.ErrorName = "Not Found";
            else if(errorType==2)
                errorModel.ErrorName = "ModelState is empty";
            else if (errorType == 3)
                errorModel.ErrorName = "Za pusti post methodu ZASTRELU!!!!!!!";
            return View(errorModel);
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

        
        
    }
}
