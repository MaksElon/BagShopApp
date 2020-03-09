using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Models
{
    public class AdminOrder
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string Status { get; set; }
        public int Price { get; set; }
    }
}
