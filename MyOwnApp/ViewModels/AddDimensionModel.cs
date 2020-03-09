using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.ViewModels
{
    public class AddDimensionModel
    {
        public float Height { get; set; }
        public float Width { get; set; }
        public float BottomWidth { get; set; }
        public float HandleLength { get; set; }
        public int ProductId { get; set; }
    }
}
