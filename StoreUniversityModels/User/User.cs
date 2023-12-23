using StoreUniversityModels.User.UserRelations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreUniversityModels.User
{
    public class User
    {
        public User()
        {
            
        }
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string  Image { get; set; }

        #region Relations
        public List<User_Role>  Roles { get; set; }
        #endregion
    }
}
