using MyOwnApp.Data.Entities;
using MyOwnApp.Data.Interfaces;
using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Repositories
{
    public class ProducerRepository:IProducers
    {
        private readonly EFContext _context;
        public ProducerRepository(EFContext context)
        {
            _context = context;
        }
        public IEnumerable<Producer> GetProducers
        {
            get
            {
                return _context.Producers;
            }
            set
            {

            }
        }

        public bool AddProducer(Producer producer)
        {
            try
            {
                _context.Producers.Add(producer);
                _context.SaveChanges();

            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool DeleteProducer(int id)
        {
            try
            {
                _context.Producers.Remove(_context.Producers.FirstOrDefault(t => t.Id == id));
                _context.SaveChanges();

            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool EditProducer(int id, Producer producer)
        {
            try
            {
                var temp = _context.Producers.FirstOrDefault(t => t.Id == id);
                temp.CapacityAddress = producer.CapacityAddress;
                temp.Name = producer.Name;
                temp.ImageName = producer.ImageName;
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public Producer GetProducer(int id)
        {
            return _context.Producers.FirstOrDefault(t => t.Id == id);
        }
    }
}
