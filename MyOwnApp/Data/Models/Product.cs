using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Models
{
    [Table("tbl_Product")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public double SalePercent { get; set; }
        [StringLength(25)]
        public string Article { get; set; }
        [StringLength(40)]
        public string Color { get; set; }
        public float Price { get; set; }
        public bool IsAdvertisingPaid { get; set; }
        public string Description { get; set; }
        public int AvailableCount { get; set; }
       
        [ForeignKey("MaterialOf")]
        public int MaterialId { get; set; }
        [ForeignKey("ProductModelOf")]
        public int ProductModelId { get; set; }
        [ForeignKey("TypeOfProductOf")]
        public int TypeId { get; set; }
        [ForeignKey("ProducerOf")]
        public int ProducerId { get; set; }

        public virtual Material MaterialOf { get; set; }
        public virtual ProductModel ProductModelOf { get; set; }
        public virtual TypeOfProduct TypeOfProductOf { get; set; }
        public virtual Producer ProducerOf { get; set; }
        public virtual Dimension DimensionOf { get; set; }

        public virtual ICollection<ProductOrder> ProductOrders { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
    }
}
