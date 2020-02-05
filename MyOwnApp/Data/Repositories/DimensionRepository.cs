using MyOwnApp.Data.Entities;
using MyOwnApp.Data.Interfaces;
using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Repositories
{
    public class DimensionRepository:IDimensions
    {
        private readonly EFContext _context;
        public DimensionRepository(EFContext context)
        {
            _context = context;
        }
        public IEnumerable<Dimension> GetDimensions
        {
            get
            {
                return _context.Dimensions;
            }
            set
            {

            }
        }
        public bool AddDimension(Dimension dimension)
        {
            try
            {
                _context.Dimensions.Add(dimension);
                _context.SaveChanges();

            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool DeleteDimension(int id)
        {
            try
            {
                _context.Dimensions.Remove(_context.Dimensions.FirstOrDefault(t => t.Id == id));
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
