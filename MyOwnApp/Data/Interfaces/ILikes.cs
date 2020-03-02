using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Interfaces
{
    public interface ILikes
    {
        IEnumerable<Likes> GetLikes { get; set; }
        bool DeleteLike(int id);
        bool AddLike(Likes likes);
    }
}
