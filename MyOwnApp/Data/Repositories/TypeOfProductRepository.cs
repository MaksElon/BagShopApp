using MyOwnApp.Data.Entities;
using MyOwnApp.Data.Interfaces;
using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Repositories
{
    public class TypeOfProductRepository:ITypeOfProducts
    {
        private readonly EFContext _context;

        public TypeOfProductRepository(EFContext context)
        {
            _context = context;
        }
        public IEnumerable<TypeOfProduct> GetTypeOfProducts
        {
            get
            {
                return _context.TypeOfProducts;
            }
            set
            {

            }
        }
        public bool AddType(TypeOfProduct type)
        {
            try
            {
                _context.TypeOfProducts.Add(type);
                _context.SaveChanges();

            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool DeleteType(int id)
        {
            try
            {
                _context.TypeOfProducts.Remove(_context.TypeOfProducts.FirstOrDefault(t => t.Id == id));
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
