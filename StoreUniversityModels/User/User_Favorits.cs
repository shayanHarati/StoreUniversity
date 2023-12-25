using StoreUniversityModels.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreUniversityModels.User
{
    public class User_Favorits
    {
        public User_Favorits()
        {
            
        }
        public int UserFavoritId { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }

        #region Relations
        public virtual Product.Product  product { get; set; }
        public virtual User User { get; set; }
        #endregion
    }
}
