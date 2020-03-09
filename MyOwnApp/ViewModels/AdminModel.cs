using MyOwnApp.Data.Models;
using MyOwnApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.ViewModels
{
    public class AdminModel
    {
        public LayoutViewModel LayoutModel { get; set; }
        public List<AdminProducersTable> TopProducers { get; set; }
        public List<AdminOrder> Orders { get; set; }
        public List<AdminProduct> Products { get; set; }
        public List<AdminChartType> ChartProductTypes { get; set; }
        public List<AdminYearChartType> ChartYearTypes { get; set; }
        public List<int> ChartValue { get; set; }
        public int AllTimeSold { get; set; }
        public int WeekSold { get; set; }
        public int WeekSoldCount { get; set; }
        public int OnlineUsers { get; set; }
        public string AdminName { get; set; }
        public AddDimensionModel AddDimensionModel { get; set; }
        public AddMaterialModel AddMaterialModel { get; set; }
        public AddModelModel AddModelModel { get; set; }
        public AddProducerModel AddProducerModel { get; set; }
        public AddProductModel AddProductModel { get; set; }
        public AddTypeModel AddTypeModel { get; set; }
    }
}
