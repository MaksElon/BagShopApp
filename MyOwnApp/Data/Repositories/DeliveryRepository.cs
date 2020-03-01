using MyOwnApp.Data.Entities;
using MyOwnApp.Data.Interfaces;
using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Repositories
{
    public class DeliveryRepository:IDeliveries
    {
        private readonly EFContext _context;
        public DeliveryRepository(EFContext context)
        {
            _context = context;
        }
        public IEnumerable<Delivery> GetDeliveries
        {
            get
            {
                return _context.Deliveries;
            }
            set
            {

            }
        }
        public bool AddDelivery(Delivery delivery)
        {
            try
            {
                _context.Deliveries.Add(delivery);
                _context.SaveChanges();

            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool DeleteDelivery(int id)
        {
            try
            {
                _context.Deliveries.Remove(_context.Deliveries.FirstOrDefault(t => t.Id == id));
                _context.SaveChanges();

            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
