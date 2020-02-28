using MyOwnApp.Data.Entities;
using MyOwnApp.Data.Interfaces;
using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Repositories
{
    public class SubCategoryRepository:ISubCategories
    {
        private readonly EFContext _context;

        public SubCategoryRepository(EFContext context)
        {
            _context = context;
        }
        public IEnumerable<SubCategory> GetSubCategories
        {
            get
            {
                return _context.SubCategories;
            }
            set
            {

            }
        }
        public bool AddSubCategory(SubCategory category)
        {
            try
            {
                _context.SubCategories.Add(category);
                _context.SaveChanges();

            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool DeleteSubCategory(int id)
        {
            try
            {
                _context.SubCategories.Remove(_context.SubCategories.FirstOrDefault(t => t.Id == id));
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
