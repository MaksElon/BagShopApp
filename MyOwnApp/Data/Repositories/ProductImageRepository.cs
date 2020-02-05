using MyOwnApp.Data.Entities;
using MyOwnApp.Data.Interfaces;
using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Repositories
{
    public class ProductImageRepository: IProductImages
    {
        private readonly EFContext _context;
        public ProductImageRepository(EFContext context)
        {
            _context = context;
        }
        public IEnumerable<ProductImage> GetProductImages
        {
            get
            {
                return _context.ProductImages;
            }
            set
            {

            }
        }
        public bool AddProductImage(ProductImage productImage)
        {
            try
            {
                _context.ProductImages.Add(productImage);
                _context.SaveChanges();

            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool DeleteProductImage(int id)
        {
            try
            {
                _context.ProductImages.Remove(_context.ProductImages.FirstOrDefault(t => t.Id == id));
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
