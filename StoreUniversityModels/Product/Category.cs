using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreUniversityModels.Product
{
    public class Category
    {
        public Category()
        {
            
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsInsoon { get; set; }

        #region relations
        public virtual List<Product> Products { get; set; }
        #endregion
    }
}
