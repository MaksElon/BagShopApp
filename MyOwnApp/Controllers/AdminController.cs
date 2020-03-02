using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyOwnApp.Data.Interfaces;
using MyOwnApp.Models;
using MyOwnApp.ViewModels;

namespace MyOwnApp.Controllers
{
    public class AdminController : Controller
    {
        private readonly IProducts _products;
        private readonly IProducers _producers; 
        private readonly ITypeOfProducts _type;
        private readonly ISubCategories _subCategories;
        private readonly IOrders _orders;
        public AdminController(IOrders orders,IProducts products, IProducers producers, ITypeOfProducts type, ISubCategories subCategories)
        {
            _producers = producers;
            _products = products;
            _type = type;
            _subCategories = subCategories;
            _orders = orders;
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
            obj.Orders = _orders.GetOrders.ToList();//todo order by date
            obj.OnlineUsers = 1;//todo
            List<AdminChartType> types = new List<AdminChartType>();
            foreach(var type in _type.GetTypeOfProducts)
            {
                AdminChartType chartType = new AdminChartType();
                chartType.NameOfType = type.Name;
                int summ = 0;
                foreach(var item in _products.GetProducts)
                {
                    if (item.TypeOfProductOf.Id == type.Id)
                    {
                        if(item.ProductOrders.Count()>0)
                        {
                            summ +=Convert.ToInt32(item.Price * item.ProductOrders.Count());
                        }
                    }
                }
                chartType.SoldSumm = summ;
                types.Add(chartType);
            }
            types.OrderBy(t => t.SoldSumm);
            obj.ProductTypes = types;
            obj.AllTimeSold = Convert.ToInt32(_products.GetProducts.Where(t => t.ProductOrders.Count() > 0).Select(p => p.Price).Sum());
            obj.ChartValue = null;//todo after date
            obj.WeekProfit = 0;//todo after date
            obj.WeekSold = 0;//todo after date

            List<AdminProducersTable> producersTable = new List<AdminProducersTable>();
            foreach (var producer in _producers.GetProducers)
            {
                AdminProducersTable prods = new AdminProducersTable();
                prods.NameOfType = producer.Name;
                int summ = 0;
                foreach (var item in _products.GetProducts)
                {
                    if (item.ProducerOf.Id == producer.Id)
                    {
                        if (item.ProductOrders.Count() > 0)
                        {
                            summ += Convert.ToInt32(item.Price * item.ProductOrders.Count());
                        }
                    }
                }
                prods.SoldSumm = summ;
                producersTable.Add(prods);
            }
            producersTable.OrderBy(t => t.SoldSumm);
            obj.TopProducers = producersTable;
            return View(obj);
        }
    }
}