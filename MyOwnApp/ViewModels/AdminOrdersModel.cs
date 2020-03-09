using MyOwnApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.ViewModels
{
    public class AdminOrdersModel
    {
        public string AdminName { get; set; }
        public List<AdminOrder> Orders { get; set; }
    }
}
