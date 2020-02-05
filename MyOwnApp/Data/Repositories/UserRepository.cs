using MyOwnApp.Data.Entities;
using MyOwnApp.Data.Interfaces;
using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Repositories
{
    public class UserRepository:IUsers
    {
        private readonly EFContext _context;
        public UserRepository(EFContext context)
        {
            _context = context;
        }

        public IEnumerable<User> GetUsers
        {
            get
            {
                return _context.Users;
            }
            set
            {

            }
        }

        public bool AddUser(User user)
        {
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();

            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool DeleteUser(string id)
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

        //public bool EditUser(string id, User user)
        //{
        //    try
        //    {
        //        var temp = _context.Users.FirstOrDefault(t => t.Id == id);
        //        temp.FirstName = user.FirstName;
        //        temp.LastName = user.LastName;
        //        temp.RegisterDate = user.RegisterDate;
        //        temp.Age = user.Age;
        //        temp.AboutMe = user.AboutMe;
        //        temp.Image = user.Image;
        //        _context.SaveChanges();
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //    return true;
        //}

        public User GetUser(string id)
        {
            return _context.Users.FirstOrDefault(t => t.Id == id);
        }
    }
}
