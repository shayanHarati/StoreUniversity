using StoreUniversityModels.Product;
using System.ComponentModel.DataAnnotations;

namespace StoreUniversity.DTOs.Store
{
    public class IndexProductsViewModel
    {
        public List<Product> Top { get; set; }
        public string CategoryName { get; set; }

    }
}
