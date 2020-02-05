using MyOwnApp.Data.Entities;
using MyOwnApp.Data.Interfaces;
using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Repositories
{
    public class ProductModelRepository: IProductModels
    {
        private readonly EFContext _context;
        public ProductModelRepository(EFContext context)
        {
            _context = context;
        }
        public IEnumerable<ProductModel> GetModels
        {
            get
            {
                return _context.ProductModels;
            }
            set
            {

            }
        }
        public bool AddModel(ProductModel productModel)
        {
            try
            {
                _context.ProductModels.Add(productModel);
                _context.SaveChanges();

            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool DeleteModel(int id)
        {
            try
            {
                _context.ProductModels.Remove(_context.ProductModels.FirstOrDefault(t => t.Id == id));
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
