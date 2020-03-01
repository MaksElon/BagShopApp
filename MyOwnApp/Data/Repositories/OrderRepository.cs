using MyOwnApp.Data.Entities;
using MyOwnApp.Data.Interfaces;
using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Repositories
{
    public class OrderRepository:IOrders
    {
        private readonly EFContext _context;
        public OrderRepository(EFContext context)
        {
            _context = context;
        }

        public IEnumerable<Order> GetOrders
        {
            get
            {
                return _context.Orders;
            }
            set
            {

            }
        }

        public bool AddOrder(Order order)
        {
            try
            {
                _context.Orders.Add(order);
                _context.SaveChanges();

            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool DeleteOrder(int id)
        {
            try
            {
                _context.Orders.Remove(_context.Orders.FirstOrDefault(t => t.Id == id));
                _context.SaveChanges();

            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool EditOrder(int id, Order order)
        {
            try
            {
                var temp = _context.Orders.FirstOrDefault(t => t.Id == id);                
                temp.Status = order.Status;
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public Order GetOrder(int id)
        {
            return _context.Orders.FirstOrDefault(t => t.Id == id);
        }
    }
}
