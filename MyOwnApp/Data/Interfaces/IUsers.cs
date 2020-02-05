using MyOwnApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Interfaces
{
    public interface IUsers
    {
        IEnumerable<User> GetUsers { get; set; }
        User GetUser(string id);
        bool DeleteUser(string id);
        bool AddUser(User user);
       // bool EditUser(string id, User user);
    }
}
