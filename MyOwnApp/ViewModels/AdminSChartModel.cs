using MyOwnApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.ViewModels
{
    public class AdminSChartModel
    {
        public string AdminName { get; set; }
        public List<AdminYearChartType> ChartYearTypes { get; set; }
    }
}
