using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.ViewModels
{
    public class CartModel
    {
        public LayoutViewModel LayoutModel { get; set; }
        public List<Order> GetOrders { get; set; }
        public int OrdersCount { get; set; }
    }
}
