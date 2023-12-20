using StoreUniversity.Context.DataBase;
using StoreUniversityModels.User.UserRelations;

namespace StoreUniversity.Services
{
    public class User_RoleService : IUser_Role
    {
        private DB context;
        public User_RoleService(DB _context)
        {
            context = _context;
        }
        public void Add(int UserId, int RoleId)
        {
            User_Role ur = new User_Role()
            {
                RoleId = RoleId,
                UserId = UserId
            };
            context.UsersTORoles.Add(ur);
            save();
        }

        public void save()
        {
            context.SaveChanges();
        }
    }
}
