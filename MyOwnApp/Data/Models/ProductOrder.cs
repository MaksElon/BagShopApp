using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Models
{
    [Table("tbl_ProductOrders")]
    public class ProductOrder
    {
        public int ProductId { get; set; }

        public int OrderId { get; set; }

        public virtual Product ProductOf { get; set; }
        public virtual Order OrderOf { get; set; }
    }
}
