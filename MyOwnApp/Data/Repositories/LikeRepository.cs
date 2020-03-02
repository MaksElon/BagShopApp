using MyOwnApp.Data.Entities;
using MyOwnApp.Data.Interfaces;
using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Repositories
{
    public class LikeRepository:ILikes
    {
        private readonly EFContext _context;
        public LikeRepository(EFContext context)
        {
            _context = context;
        }
        public IEnumerable<Likes> GetLikes
        {
            get
            {
                return _context.Likes;
            }
            set
            {

            }
        }
        public bool AddLike(Likes like)
        {
            try
            {
                _context.Likes.Add(like);
                _context.SaveChanges();

            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool DeleteLike(int id)
        {
            try
            {
                _context.Likes.Remove(_context.Likes.FirstOrDefault(t => t.Id == id));
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
