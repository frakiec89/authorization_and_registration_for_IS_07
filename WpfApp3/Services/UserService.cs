using System;
using System.Collections.Generic;
using System.Linq;
using WpfApp3.DB;
// track

namespace WpfApp3.Services
{
    internal class UserService
    {
        private DB.Sqlite_Context _context ;

        public UserService() 
        {
            try
            {
                _context = new DB.Sqlite_Context();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool IsUser (string login  , string password)
        {
            try
            {
               return _context.Users.Any(u => u.UserEmail == login && u.Password == password);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string GetUserName (string login , string password)
        {
            try
            {
                return  _context.Users.SingleOrDefault(u => u.UserEmail == login && u.Password == password).UserName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AddUser (string name , string login , string password)
        {
            try
            {
                if (_context.Users.Any( u => u.UserEmail == login))
                    throw new Exception("такой  логин  уже  есть");

                User user = new User();
                user.UserName = name;
                user.Password = password;
                user.UserEmail = login;

                _context.Users.Add(user);
                _context.SaveChanges();


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
