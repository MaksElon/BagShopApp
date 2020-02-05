using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Interfaces
{
    public interface IProducers
    {
        IEnumerable<Producer> GetProducers { get; set; }
        Producer GetProducer(int id);
        bool DeleteProducer(int id);
        bool AddProducer(Producer producer);
        bool EditProducer(int id, Producer producer);
    }
}
