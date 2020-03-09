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
        public List<AdminProducersTable> TopProducers { get; set; }
        public List<AdminChartType> ChartProductTypes { get; set; }
        public int AllTimeSold { get; set; }
        public int WeekSold { get; set; }
        public int WeekSoldCount { get; set; }
        public int OnlineUsers { get; set; }
        public string AdminName { get; set; }
        
    }
}
