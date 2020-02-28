using MyOwnApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Models
{
    [Table("tbl_Dislikes")]
    public class Dislikes
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("ProductOf")]
        public int ProductId { get; set; }
        [ForeignKey("UserOf")]
        public string UserId { get; set; }
        public virtual Product ProductOf { get; set; }
        public virtual User UserOf { get; set; }
    }
}
