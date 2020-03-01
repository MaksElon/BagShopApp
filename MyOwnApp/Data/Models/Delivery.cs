using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Models
{
    [Table("tbl_Deliveries")]
    public class Delivery
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
