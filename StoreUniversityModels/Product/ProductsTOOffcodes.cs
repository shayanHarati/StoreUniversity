using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreUniversityModels.Product
{
    public class ProductsTOOffcodes
    {
        public int ID { get; set; }
        public int ProductId { get; set; }
        public int OffCodeId { get; set; }

        public virtual Product  Product { get; set; }
        public virtual Offcode  Offcode { get; set; }
    }
}
