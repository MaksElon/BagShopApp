using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Interfaces
{
    public interface IProductOrders
    {
        IEnumerable<ProductOrder> GetProductOrders { get; set; }
        bool AddProductOrder(ProductOrder productOrder);
    }
}
