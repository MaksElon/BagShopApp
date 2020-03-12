using MyOwnApp.Data.Entities;
using MyOwnApp.Data.Interfaces;
using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Repositories
{
    public class ReviewRepository:IReviews
    {
        private readonly EFContext _context;
        public ReviewRepository(EFContext context)
        {
            _context = context;
        }
        public IEnumerable<Review> GetReviews
        {
            get
            {
                return _context.Reviews;
            }
            set
            {

            }
        }
        public bool AddReview(Review review)
        {
            try
            {
                _context.Reviews.Add(review);
                _context.SaveChanges();

            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool DeleteReview(int id)
        {
            try
            {
                _context.Reviews.Remove(_context.Reviews.FirstOrDefault(t => t.Id == id));
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
