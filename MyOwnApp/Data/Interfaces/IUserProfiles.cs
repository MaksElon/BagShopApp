using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Interfaces
{
    public interface IUserProfiles
    {
        IEnumerable<UserProfile> GetUserProfiles { get; set; }
        UserProfile GetUserProfile(string id);
        bool DeleteUserProfile(string id);
        bool AddUserProfile(UserProfile userProfile);
        bool EditUserProfile(string id, UserProfile userProfile);
    }
}
