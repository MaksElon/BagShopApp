using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Models
{
    [Table("tbl_ModelOfBags")]
    public class ProductModel
    {
        public int Id { get; set; }
        [StringLength(25)]
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
