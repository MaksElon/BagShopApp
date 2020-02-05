using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Interfaces
{
    public interface IDimensions
    {
        IEnumerable<Dimension> GetDimensions { get; set; }
        bool DeleteDimension(int id);
        bool AddDimension(Dimension dimension);
    }
}
