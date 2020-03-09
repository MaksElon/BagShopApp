using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyOwnApp.Data.Entities;
using MyOwnApp.Data.Interfaces;
using MyOwnApp.Data.Models;
using MyOwnApp.Models;
using MyOwnApp.ViewModels;
using Newtonsoft.Json;
using System.Drawing.Imaging;
using System.Drawing;

namespace MyOwnApp.Controllers
{
    public class AdminController : Controller
    {
        private readonly IProducts _products;
        private readonly IProducers _producers;
        private readonly ITypeOfProducts _type;
        private readonly ISubCategories _subCategories;
        private readonly IOrders _orders;
        private readonly IProductOrders _productOrders;
        private readonly IUsers _users;
        private readonly IUserProfiles _userProfiles;
        private readonly IMaterials _materials;
        private readonly IProductModels _productModels;
        private readonly IDimensions _dimensions;
        private readonly IHostingEnvironment _env;

        public AdminController(IHostingEnvironment env, IDimensions dimensions, IProductModels productModels, IMaterials materials, IUsers users, IUserProfiles userProfiles, IProductOrders productOrders, IOrders orders, IProducts products, IProducers producers, ITypeOfProducts type, ISubCategories subCategories)
        {
            _producers = producers;
            _products = products;
            _type = type;
            _subCategories = subCategories;
            _orders = orders;
            _productOrders = productOrders;
            _users = users;
            _userProfiles = userProfiles;
            _dimensions = dimensions;
            _productModels = productModels;
            _materials = materials;
            _env = env;
        }
        [HttpGet]
        public IActionResult AdminOrders()
        {
            var info = HttpContext.Session.GetString("SessionUser");
            if (info != null)
            {
                var result = JsonConvert.DeserializeObject<UserInfo>(info);

                AdminOrdersModel obj = new AdminOrdersModel();
                var tempU = _users.GetUsers.FirstOrDefault(t => t.Id == result.UserId);
                obj.AdminName = _userProfiles.GetUserProfiles.FirstOrDefault(t => t.User == tempU).FirstName;
                List<AdminOrder> listOrders = new List<AdminOrder>();
                foreach (var item in _orders.GetOrders)
                {
                    var productsOrders = _productOrders.GetProductOrders.Where(t => t.OrderId == item.Id);
                    if (productsOrders != null)
                    {
                        foreach (var prOr in productsOrders)
                        {
                            AdminOrder admOrder = new AdminOrder();
                            Product tempProd = _products.GetProducts.FirstOrDefault(t => t.Id == prOr.ProductId);
                            User tempUser = _users.GetUser(item.UserId);
                            UserProfile tempProfile = _userProfiles.GetUserProfiles.FirstOrDefault(t => t.User == tempUser);
                            admOrder.Description = tempProd.Name;
                            admOrder.Price = Convert.ToInt32(tempProd.Price - (tempProd.Price / 100 * tempProd.SalePercent));
                            if (item.Status)
                                admOrder.Status = "Processed";
                            else
                                admOrder.Status = "Denied";
                            admOrder.Email = tempUser.Email;
                            admOrder.Name = tempProfile.FirstName + " " + tempProfile.LastName;
                            admOrder.Date = item.DateOfOrder.ToShortDateString();
                            listOrders.Add(admOrder);
                        }
                    }
                }

                obj.Orders = listOrders;//todo order by date
                return View(obj);
            }
            return RedirectToAction("AccountAction", "Account");

        }
        [HttpGet]
        public IActionResult AdminProducts()
        {
            var info = HttpContext.Session.GetString("SessionUser");
            if (info != null)
            {
                var result = JsonConvert.DeserializeObject<UserInfo>(info);


                AdminProductsModel obj = new AdminProductsModel();
                obj.AddDimensionModel = new AddDimensionModel();
                obj.AddTypeModel = new AddTypeModel();
                obj.AddProductModel = new AddProductModel();
                obj.AddProducerModel = new AddProducerModel();
                obj.AddModelModel = new AddModelModel();
                obj.AddMaterialModel = new AddMaterialModel();
                var tempU = _users.GetUsers.FirstOrDefault(t => t.Id == result.UserId);
                obj.AdminName = _userProfiles.GetUserProfiles.FirstOrDefault(t => t.User == tempU).FirstName;
                List<AdminProduct> adminProducts = new List<AdminProduct>();
                foreach (var item in _products.GetProducts)
                {
                    AdminProduct admProd = new AdminProduct();
                    admProd.Id = item.Id;
                    admProd.Name = item.Name;
                    admProd.Price = Convert.ToInt32(item.Price);
                    string descr = item.Description;
                    if (descr.Length > 97)
                        descr = descr.Substring(0, 97) + "...";
                    admProd.Description = descr;
                    admProd.AvailableCount = item.AvailableCount;
                    string characters = "";
                    characters += _producers.GetProducers.FirstOrDefault(t => t.Id == item.ProducerId).Name + " ";
                    characters += _materials.GetMaterials.FirstOrDefault(t => t.Id == item.MaterialId).Name + " ";
                    characters += _type.GetTypeOfProducts.FirstOrDefault(t => t.Id == item.TypeId).Name + " ";
                    characters += _productModels.GetModels.FirstOrDefault(t => t.Id == item.ProductModelId).Name + " ";
                    var dim = _dimensions.GetDimensions.FirstOrDefault(t => t.ProductId == item.Id);
                    if (dim != null)
                        characters += dim.Width + " " + dim.Height + " " + dim.BottomWidth + " " + dim.HandleLength;
                    admProd.Characteristics = characters;
                    adminProducts.Add(admProd);
                }
                obj.Products = adminProducts;
                return View(obj);

            }
            return RedirectToAction("AccountAction", "Account");

        }
        [HttpGet]
        public IActionResult AdminFirstChart()
        {
            var info = HttpContext.Session.GetString("SessionUser");
            if (info != null)
            {
                var result = JsonConvert.DeserializeObject<UserInfo>(info);

                AdminFChartModel obj = new AdminFChartModel();
                var tempU = _users.GetUsers.FirstOrDefault(t => t.Id == result.UserId);
                obj.AdminName = _userProfiles.GetUserProfiles.FirstOrDefault(t => t.User == tempU).FirstName;
                List<int> monthProfits = new List<int>();
                for (int i = 0; i < 12; i++)
                {
                    var monthOrders = _orders.GetOrders.Where(t => t.DateOfOrder.Month == i + 1 && t.DateOfOrder.Year == DateTime.Today.Year);
                    monthProfits.Add(0);
                    foreach (var item in monthOrders)
                    {
                        var monthProductsOrders = _productOrders.GetProductOrders.Where(t => t.OrderId == item.Id);
                        if (monthProductsOrders != null)
                        {
                            var res = _products.GetProducts.Where(prod => monthProductsOrders.Select(o => o.ProductId).Any(t => t == prod.Id));
                            if (res != null)
                            {
                                monthProfits[i] = (Convert.ToInt32(res.Select(t => t.Price).Sum()));
                            }
                        }
                    }
                }
                obj.ChartValue = monthProfits;
                return View(obj);

            }
            return RedirectToAction("AccountAction", "Account");

        }
        [HttpGet]
        public IActionResult AdminSecondChart()
        {
            var info = HttpContext.Session.GetString("SessionUser");
            if (info != null)
            {
                var result = JsonConvert.DeserializeObject<UserInfo>(info);

                AdminSChartModel obj = new AdminSChartModel();
                var tempU = _users.GetUsers.FirstOrDefault(t => t.Id == result.UserId);
                obj.AdminName = _userProfiles.GetUserProfiles.FirstOrDefault(t => t.User == tempU).FirstName;
                List<AdminYearChartType> yearChartTypes = new List<AdminYearChartType>();
                int early = _orders.GetOrders.Max(t => t.DateOfOrder).Year;
                for (int y = DateTime.Today.Year; y >= early; y--)
                {
                    AdminYearChartType adminType = new AdminYearChartType();
                    adminType.Year = y.ToString();
                    List<int> tempProfits = new List<int>();
                    for (int i = 0; i < 12; i++)
                    {
                        var monthOrders = _orders.GetOrders.Where(t => t.DateOfOrder.Month == i + 1 && t.DateOfOrder.Year == y);
                        tempProfits.Add(0);
                        foreach (var item in monthOrders)
                        {
                            var monthProductsOrders = _productOrders.GetProductOrders.Where(t => t.OrderId == item.Id);
                            if (monthProductsOrders != null)
                            {
                                var res = _products.GetProducts.Where(prod => monthProductsOrders.Select(o => o.ProductId).Any(t => t == prod.Id));
                                if (res != null)
                                {
                                    tempProfits[i] = (Convert.ToInt32(res.Select(t => t.Price).Sum()));
                                }
                            }
                        }
                    }
                    adminType.ChartValue = tempProfits;
                    yearChartTypes.Add(adminType);
                }
                obj.ChartYearTypes = yearChartTypes;
                return View(obj);
            }
            return RedirectToAction("AccountAction", "Account");

        }
        [HttpGet]
        public IActionResult AdminPage()
        {
            var info = HttpContext.Session.GetString("SessionUser");
            if (info != null)
            {
                var result = JsonConvert.DeserializeObject<UserInfo>(info);


                AdminModel obj = new AdminModel();

                var tempU = _users.GetUsers.FirstOrDefault(t => t.Id == result.UserId);
                obj.AdminName = _userProfiles.GetUserProfiles.FirstOrDefault(t => t.User == tempU).FirstName;
                
                
                obj.OnlineUsers = 1;//todo
                List<AdminChartType> types = new List<AdminChartType>();
                foreach (var type in _type.GetTypeOfProducts)
                {
                    AdminChartType chartType = new AdminChartType();
                    chartType.NameOfType = type.Name;
                    int summ = 0;
                    foreach (var item in _products.GetProducts)
                    {
                        if (item.TypeOfProductOf.Id == type.Id)
                        {
                            int count = _productOrders.GetProductOrders.Where(t => t.ProductId == item.Id).Count();
                            if (count > 0)
                            {
                                summ += Convert.ToInt32(item.Price * count);
                            }
                        }
                    }
                    chartType.SoldSumm = summ;
                    types.Add(chartType);
                }
                types.OrderBy(t => t.SoldSumm);
                obj.ChartProductTypes = types;
                obj.AllTimeSold = Convert.ToInt32(_products.GetProducts.Where(t => t.ProductOrders != null).Select(p => p.Price).Sum());

                //week
                var currentWeek = CurrentWeek(DateTime.Today);
                List<Order> weekOrders = _orders.GetOrders.Where(t => currentWeek.Contains(t.DateOfOrder)).ToList();
                int weekSumm = 0, weekCount = 0;
                foreach (var item in weekOrders)
                {
                    var weekProductsOrders = _productOrders.GetProductOrders.Where(t => t.OrderId == item.Id);
                    if (weekProductsOrders != null)
                    {
                        var res = _products.GetProducts.Where(prod => weekProductsOrders.Select(o => o.ProductId).Any(i => i == prod.Id));
                        if (res != null)
                        {
                            weekCount += weekProductsOrders.Count();
                            weekSumm += Convert.ToInt32(res.Select(t => t.Price).Sum());
                        }
                    }
                }

                obj.WeekSold = weekCount;
                obj.WeekSold = weekSumm;

                
                
                List<AdminProducersTable> producersTable = new List<AdminProducersTable>();
                foreach (var producer in _producers.GetProducers)
                {
                    AdminProducersTable prods = new AdminProducersTable();
                    prods.NameOfProducer = producer.Name;
                    int summ = 0;
                    foreach (var item in _products.GetProducts)
                    {
                        if (item.ProducerOf.Id == producer.Id)
                        {
                            int count = _productOrders.GetProductOrders.Where(t => t.ProductId == item.Id).Count();
                            if (count > 0)
                            {
                                summ += Convert.ToInt32(item.Price * count);
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
            return RedirectToAction("AccountAction", "Account");

        }
        [HttpPost]
        public IActionResult AddMaterial(AddMaterialModel model)
        {
            if (!ModelState.IsValid)
            {
                AdminModel obj = new AdminModel();

                return View(obj);
            }
            _materials.AddMaterial(new Material { Name = model.Name });
            return RedirectToAction("AdminProducts", "Admin");
        }
        [HttpPost]
        public IActionResult AddType(AddTypeModel model)
        {
            if (!ModelState.IsValid)
            {
                AdminModel obj = new AdminModel();

                return View(obj);
            }
            _type.AddType(new TypeOfProduct { Name = model.Name });
            return RedirectToAction("AdminProducts", "Admin");
        }
        [HttpPost]
        public IActionResult AddModel(AddModelModel model)
        {
            if (!ModelState.IsValid)
            {
                AdminModel obj = new AdminModel();

                return View(obj);
            }
            _productModels.AddModel(new ProductModel { Name = model.Name });
            return RedirectToAction("AdminProducts", "Admin");
        }
        [HttpPost]
        public IActionResult AddDimension(AddDimensionModel model)
        {
            if (!ModelState.IsValid)
            {
                AdminModel obj = new AdminModel();

                return View(obj);
            }
            _dimensions.AddDimension(new Dimension
            {
                Width = model.Width,
                Height = model.Height,
                BottomWidth = model.BottomWidth,
                HandleLength = model.HandleLength,
                ProductId = model.ProductId
            });
            return RedirectToAction("AdminProducts", "Admin");
        }
        [HttpPost]
        public async Task<IActionResult> AddProducer(AddProducerModel model, IFormFile upploadedFile)
        {
            if (!ModelState.IsValid)
            {
                AdminModel obj = new AdminModel();

                return View(obj);
            }
            //if (!Directory.Exists(Path.Combine(_env.WebRootPath, "images")))
            //{
            //    Directory.CreateDirectory(Path.Combine(_env.WebRootPath, "images"));
            //}
            if (upploadedFile != null)
            {
                var file = upploadedFile;
                if (file.Length > 0)
                {
                    var folderServerPath = _env.ContentRootPath;
                    var folderName = "images";
                    var fileName = Guid.NewGuid().ToString() + ".jpg";
                    var saveFile = Path.Combine(folderServerPath, folderName, fileName);
                    using (var stream = System.IO.File.Create(saveFile))
                    {
                        await upploadedFile.CopyToAsync(stream);
                    }
                    _producers.AddProducer(new Producer
                    {
                        Name = model.Name,
                        CapacityAddress = model.CapacityAddress,
                        ImageName = fileName
                    });

                }
            }

            return RedirectToAction("AdminProducts", "Admin");
        }
        [HttpPost]
        public IActionResult AddProduct(AddProductModel model)
        {
            if (!ModelState.IsValid)
            {
                AdminModel obj = new AdminModel();

                return View(obj);
            }
            _products.AddProduct(new Product
            {
                Name = model.Name,
                Color = model.Color,
                Description = model.Description,
                Article = model.Article,
                AvailableCount = model.AvailableCount,
                IsAdvertisingPaid = model.IsAdvertisingPaid,
                Price = model.Price,
                SalePercent = model.SalePercent,
                MaterialId = model.MaterialId,
                ProductModelId = model.ProductModelId,
                TypeId = model.TypeId,
                ProducerId = model.ProducerId
            });
            return RedirectToAction("AdminProducts", "Admin");
        }



        public List<DateTime> CurrentWeek(DateTime date)
        {
            var startDate = date;
            var endDate = startDate.AddDays(7);
            //the number of days in our range of dates
            var numDays = (int)((endDate - startDate).TotalDays);
            List<DateTime> myDates = Enumerable
                       //creates an IEnumerable of ints from 0 to numDays
                       .Range(0, numDays)
                       //now for each of those numbers (0..numDays), 
                       //select startDate plus x number of days
                       .Select(x => startDate.AddDays(x))
                       //and make a list
                       .ToList();
            //List<string> myDaysOfWeek = myDates.Select(d => d.DayOfWeek.ToString()).ToList();
            //return myDaysOfWeek;
            return myDates;
        }
    }

}