using MyOwnApp.Data.Entities;
using MyOwnApp.Data.Interfaces;
using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Repositories
{
    public class ProductRepository : IProducts
    {
        private readonly EFContext _context;
        public ProductRepository(EFContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetProducts
        {
            get
            {
                return _context.Products;
            }
            set
            {

            }
        }

        public bool AddProduct(Product product)
        {
            try
            {
                _context.Products.Add(product);
                _context.SaveChanges();

            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool DeleteProduct(int id)
        {
            try
            {
                _context.Products.Remove(_context.Products.FirstOrDefault(t=>t.Id==id));
                _context.SaveChanges();

            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool EditProduct(int id, Product product)
        {
            try
            {
                var temp = _context.Products.FirstOrDefault(t => t.Id == id);
                temp.Name = product.Name;
                temp.Price = product.Price;
                temp.SalePercent = product.SalePercent;
                temp.Article = product.Article;
                temp.Color = product.Color;
                temp.IsAdvertisingPaid = product.IsAdvertisingPaid;
                temp.Description = product.Description;
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public Product GetProduct(int id)
        {
            return _context.Products.FirstOrDefault(t => t.Id == id);
        }
    }
}
