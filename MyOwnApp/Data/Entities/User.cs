using Microsoft.AspNetCore.Identity;
using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Entities
{
    [Table("tbl_Users")]
    public class User:IdentityUser<string>
    {
        public IEnumerable<UserRole> UserRoles { get; set; }
        public virtual UserProfile UserProfile { get; set; }
        
    }
}
