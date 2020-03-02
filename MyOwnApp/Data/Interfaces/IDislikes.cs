using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Interfaces
{
    public interface IDislikes
    {
        IEnumerable<Dislikes> GetDislikes { get; set; }
        bool DeleteDislike(int id);
        bool AddDislike(Dislikes dislikes);
    }
}
