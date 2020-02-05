using MyOwnApp.Data.Entities;
using MyOwnApp.Data.Interfaces;
using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Repositories
{
    public class UserProfileRepository:IUserProfiles
    {
        private readonly EFContext _context;
        public UserProfileRepository(EFContext context)
        {
            _context = context;
        }

        public IEnumerable<UserProfile> GetUserProfiles
        {
            get
            {
                return _context.UserProfiles;
            }
            set
            {

            }
        }

        public bool AddUserProfile(UserProfile user)
        {
            try
            {
                _context.UserProfiles.Add(user);
                _context.SaveChanges();

            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool DeleteUserProfile(string id)
        {
            try
            {
                _context.Users.Remove(_context.Users.FirstOrDefault(t => t.Id == id));
                _context.SaveChanges();

            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool EditUserProfile(string id, UserProfile user)
        {
            try
            {
                var temp = _context.UserProfiles.FirstOrDefault(t => t.Id == id);
                temp.FirstName = user.FirstName;
                temp.LastName = user.LastName;
                temp.RegisterDate = user.RegisterDate;
                temp.Age = user.Age;
                temp.AboutMe = user.AboutMe;
                temp.Image = user.Image;
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public UserProfile GetUserProfile(string id)
        {
            return _context.UserProfiles.FirstOrDefault(t => t.Id == id);
        }
    }
}
