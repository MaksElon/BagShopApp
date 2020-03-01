using MyOwnApp.Data.Entities;
using MyOwnApp.Data.Interfaces;
using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Repositories
{
    public class ProductOrderRepository : IProductOrders
    {
        private readonly EFContext _context;
        public ProductOrderRepository(EFContext context)
        {
            _context = context;
        }
        public IEnumerable<ProductOrder> GetProductOrders
        {
            get
            {
                return _context.ProductOrders;
            }
            set
            {

            }
        }
        public bool AddProductOrder(ProductOrder productOrder)
        {
            try
            {
                _context.ProductOrders.Add(productOrder);
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
