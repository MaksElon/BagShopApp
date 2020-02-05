using MyOwnApp.Data.Entities;
using MyOwnApp.Data.Interfaces;
using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Repositories
{
    public class MaterialRepository:IMaterials
    {
        private readonly EFContext _context;
        public MaterialRepository(EFContext context)
        {
            _context = context;
        }
        public IEnumerable<Material> GetMaterials
        {
            get
            {
                return _context.Materials;
            }
            set
            {

            }
        }
        public bool AddMaterial(Material material)
        {
            try
            {
                _context.Materials.Add(material);
                _context.SaveChanges();

            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool DeleteMaterial(int id)
        {
            try
            {
                _context.Materials.Remove(_context.Materials.FirstOrDefault(t => t.Id == id));
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
