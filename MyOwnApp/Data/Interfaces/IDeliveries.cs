using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Interfaces
{
    public interface IDeliveries
    {
        IEnumerable<Delivery> GetDeliveries { get; set; }
        bool DeleteDelivery(int id);
        bool AddDelivery(Delivery delivery);
    }
}
