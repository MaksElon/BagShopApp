using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Interfaces
{
    public interface ISubCategories
    {
        IEnumerable<SubCategory> GetSubCategories { get; set; }
        bool DeleteSubCategory(int id);
        bool AddSubCategory(SubCategory category);
    }
}
