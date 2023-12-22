using StoreUniversityModels.Product;

namespace StoreUniversity.DTOs.Store
{
    public class ShowViewModel
    {
        public List<Product> Products { get; set; }
        public string  SelectedCategory { get; set; }
        public List<Category> Categories { get; set; }
    }
}
