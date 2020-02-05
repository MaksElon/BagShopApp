using Microsoft.AspNetCore.Identity;
using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Entities
{
    public class UserRole : IdentityUserRole<string>
    {
        public virtual User User{get;set;}
        public virtual Role Role { get; set; }
    }
}
