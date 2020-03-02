using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyOwnApp.Data.Interfaces;
using MyOwnApp.ViewModels;

namespace MyOwnApp.Controllers
{
    public class AdminController : Controller
    {
        private readonly IProducts _products;
        private readonly IProducers _producers; 
        private readonly ITypeOfProducts _type;
        private readonly ISubCategories _subCategories;
        public AdminController(IProducts products, IProducers producers, ITypeOfProducts type, ISubCategories subCategories)
        {
            _producers = producers;
            _products = products;
            _type = type;
            _subCategories = subCategories;
        }
        [HttpGet]
        public IActionResult AdminPage()
        {
            AdminModel obj = new AdminModel();
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