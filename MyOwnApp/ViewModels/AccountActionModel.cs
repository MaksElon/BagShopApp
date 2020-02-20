using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.ViewModels
{
    public class AccountActionModel
    {
        public LoginViewModel LoginViewModel { get; set; }
        public RegisterViewModel RegisterViewModel { get; set; }
        public List<Producer> GetProducers { get; set; }
        public int ProducersCount { get; set; }
    }

}
