using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.ViewModels
{
    public class ProductModel
    {
        public LayoutViewModel LayoutModel { get; set; }
        public Product Product { get; set; }
    }
}
