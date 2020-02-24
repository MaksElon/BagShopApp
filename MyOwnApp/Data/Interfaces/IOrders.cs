using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Interfaces
{
    public interface IOrders
    {
        IEnumerable<Order> GetOrders { get; set; }
        Order GetOrder(int id);
        bool DeleteOrder(int id);
        bool AddOrder(Order order);
        bool EditOrder(int id, Order order);
    }
}
