using StoreUniversityModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreUniversityModels.Product
{
    public class Product
    {
        public Product()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int SellRate { get; set; }
        #region Relations
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<ProductImage> images { get; set; }
        public virtual List<ProductsTOOffcodes>  Offcodes { get; set; }
        public virtual List<User_Favorits>  UserFavorits { get; set; }
        #endregion
    }
}
