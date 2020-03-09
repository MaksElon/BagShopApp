using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.ViewModels
{
    public class AddProductModel
    {
        public string Name { get; set; }
        public double SalePercent { get; set; }
        public string Article { get; set; }
        public string Color { get; set; }
        public float Price { get; set; }
        public bool IsAdvertisingPaid { get; set; }
        public string Description { get; set; }
        public int AvailableCount { get; set; }

        public int MaterialId { get; set; }
        public int ProductModelId { get; set; }
        public int TypeId { get; set; }
        public int ProducerId { get; set; }
    }
}
