using StoreUniversityModels.User.UserRelations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreUniversityModels.User
{
    public class Role
    {
        public Role()
        {
            
        }
        public int Id { get; set; }
        public string Name { get; set; }
        #region Relations
        public virtual List<User_Role> Users { get; set; }
        #endregion
    }
}
