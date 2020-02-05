using MyOwnApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Models
{
    [Table("tbl_UserProfiles")]
    public class UserProfile
    {
        [Key,ForeignKey("User")]
        public string Id { get; set; }
        [Required, StringLength(20)]
        public string FirstName { get; set; }
        [Required, StringLength(20)]
        public string LastName { get; set; }
        [Required]
        public int Age { get; set; }
        public int CountOfLogins { get; set; }
        public string AboutMe { get; set; }
        public string Image { get; set; }
        public string Address { get; set; }
        public DateTime RegisterDate { get; set; }
        public virtual User User { get; set; }
    }
}
