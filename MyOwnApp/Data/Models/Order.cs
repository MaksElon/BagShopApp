using MyOwnApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Models
{
    [Table("tbl_Orders")]
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public bool Status { get; set; }
        public DateTime DateOfOrder { get; set; }
        [ForeignKey("UserOf")]
        public string UserId { get; set; }
        [ForeignKey("DeliveryOf")]
        public int DeliveryId { get; set; }
        public virtual User UserOf { get; set; }
        public virtual Delivery DeliveryOf { get; set; }

        public virtual ICollection<ProductOrder> ProductOrders{ get; set; }
    }
}
