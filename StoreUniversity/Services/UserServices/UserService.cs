using Microsoft.EntityFrameworkCore;
using StoreUniversity.Context.DataBase;
using StoreUniversity.DTOs.Account;
using StoreUniversityModels.User;
using StoreUniversityModels.User.UserRelations;

namespace StoreUniversity.Services.UserServices
{
    public class UserService : IUser
    {
        private DB context;
        public UserService(DB _context)
        {
            context = _context;
        }

        
        public User FindUser(string username)
        {

            return context.Users.Single(c=>c.UserName==username);
        }

        // we know this User is in database
        // username is unique
        public int GetId(string UserName)
        {
            return context.Users.Single(c=>c.UserName == UserName).Id;
        }

        // username is unique
        public bool IsExistsThisUser(string UserName)
        {
            return context.Users.Any(c => c.UserName==UserName);
        }

        public bool IsExistsThisUser(string Password, string UserName)
        {
            return context.Users.Any(c => c.Password == Password && c.UserName == UserName);
        }

        public bool IsExistsThisUserEmail(string Email)
        {
            return context.Users.Any(c=>c.Email==Email);
        }

        // user is valid
        public int RegisterUser(RegisterViewModel user)
        {
            User _user = new User()
            {
                UserName = user.UserName,
                Password = user.Password,
                Email = user.Email
            };

            context.Users.Add(_user);
            save();
            int id = GetId(user.UserName);
            User_Role ur = new User_Role()
            {
                RoleId = 101,
                UserId = id
            };
            context.UsersTORoles.Add(ur);
            save();
            return id;
            
        }

        public void save()
        {
            context.SaveChanges();
        }
    }
}
