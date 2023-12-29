using Cart_Exam.Models;
using StoreUniversityModels.User.UserRelations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
       
        public virtual List<User_Favorits>  Favorits { get; set; }
        #endregion
    }
}
