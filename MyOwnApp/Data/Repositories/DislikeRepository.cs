using MyOwnApp.Data.Entities;
using MyOwnApp.Data.Interfaces;
using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Repositories
{
    public class DislikeRepository:IDislikes
    {
        private readonly EFContext _context;
        public DislikeRepository(EFContext context)
        {
            _context = context;
        }
        public IEnumerable<Dislikes> GetDislikes
        {
            get
            {
                return _context.Dislikes;
            }
            set
            {

            }
        }
        public bool AddDislike(Dislikes dislike)
        {
            try
            {
                _context.Dislikes.Add(dislike);
                _context.SaveChanges();

            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool DeleteDislike(int id)
        {
            try
            {
                _context.Dislikes.Remove(_context.Dislikes.FirstOrDefault(t => t.Id == id));
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
