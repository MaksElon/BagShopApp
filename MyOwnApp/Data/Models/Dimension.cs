using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Models
{
    [Table("tbl_Dimentions")]
    public class Dimension
    {
        [Key]
        public int Id { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        public float BottomWidth { get; set; }
        public float HandleLength { get; set; }
        [ForeignKey("ProductOf")]
        public int ProductId { get; set; }
        public virtual Product ProductOf { get; set; }

    }
}
