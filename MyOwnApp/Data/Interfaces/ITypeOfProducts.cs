using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Interfaces
{
    public interface ITypeOfProducts
    {
        IEnumerable<TypeOfProduct> GetTypeOfProducts { get; set; }
        bool DeleteType(int id);
        bool AddType(TypeOfProduct type);
    }
}
