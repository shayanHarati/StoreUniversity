using StoreUniversityModels.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StoreUniversityModels.User.UserRelations
{
    public class User_Role
    {
        public User_Role()
        {
            
        }
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }

        #region Relations
        public virtual User User { get; set; }
        public virtual Role Role { get; set; }
        #endregion

    }
}
