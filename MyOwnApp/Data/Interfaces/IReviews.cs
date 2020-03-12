using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Interfaces
{
    public interface IReviews
    {
        IEnumerable<Review> GetReviews { get; set; }
        bool DeleteReview(int id);
        bool AddReview(Review review);
    }
}
