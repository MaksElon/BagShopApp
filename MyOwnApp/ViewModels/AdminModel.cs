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
        public List<Order> Orders { get; set; }
        public List<AdminChartType> ProductTypes { get; set; }
        public List<int> ChartValue { get; set; }
        public int AllTimeSold { get; set; }
        public int WeekSold { get; set; }
        public int WeekProfit { get; set; }
        public int OnlineUsers { get; set; }
    }
}
