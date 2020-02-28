using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Models
{
    [Table("tbl_SubCategory")]
    public class SubCategory
    {
        [Key]
        public int Id { get; set; }
        [StringLength(25)]
        public string Name { get; set; }
        [ForeignKey("ProductTypeOf")]
        public int ProductTypeId { get; set; }
        public virtual TypeOfProduct ProductTypeOf { get; set; }
    }
}
