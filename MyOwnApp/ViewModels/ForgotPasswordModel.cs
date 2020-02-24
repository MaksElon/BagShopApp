using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.ViewModels
{
    public class ForgotPasswordModel
    {
        public string Email { get; set; }
        public List<Producer> GetProducers { get; set; }
        public int ProducersCount { get; set; }
    }
}
