using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Models
{
    [Table("tbl_ProducerOfProduct")]
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        [StringLength(40)]
        public string Name { get; set; }
        [StringLength(70)]
        public string CapacityAddress { get; set; }
        public string ImageName { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
